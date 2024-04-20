/* Trigger không cho tạo, cập nhật thể loại trùng*/
CREATE TRIGGER Prevent_duplicate_category 
ON TheLoai
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM TheLoai t
        JOIN INSERTED i ON t.TenTheLoai = i.TenTheLoai
    )
    BEGIN
        RAISERROR('Không thể thêm hoặc cập nhật vì đã tồn tại thể loại có cùng tên.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END;
END; 

GO 
/* Trigger không cho tạo, cập nhật ngày trả phiếu phạt >= ngày trả thực tế*/
CREATE TRIGGER Prevent_return_date_update
ON PhieuPhat
INSTEAD OF UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        JOIN PhieuMuonSach pms ON i.MaPhieuMuon = pms.MaPhieuMuon
        WHERE i.NgayTra > pms.NgayTra
    )
    BEGIN
        RAISERROR('Ngày trả không được lớn hơn ngày trả thực tế.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END;

    UPDATE PhieuPhat
    SET MaPhieuMuon = i.MaPhieuMuon,
        TienPhat = i.TienPhat,
        NgayTra = i.NgayTra
    FROM INSERTED i
    WHERE PhieuPhat.MaPhieuPhat = i.MaPhieuPhat;
END;

GO
--Trigger Check Duplicates_NXB(Trung)--
CREATE or Alter TRIGGER trg_CheckDuplicate_NXB
ON dbo.NhaXuatBan
INSTEAD OF INSERT
AS
BEGIN
    IF NOT EXISTS (SELECT 1
                   FROM dbo.NhaXuatBan
                   JOIN inserted
                   ON dbo.NhaXuatBan.TenNhaXuatBan = inserted.TenNhaXuatBan)
    BEGIN
        INSERT INTO dbo.NhaXuatBan(TenNhaXuatBan)
        SELECT TenNhaXuatBan
        FROM inserted;
    END;
END;

GO
--Trigger Check Unpaid Fine(Trung)--
CREATE OR ALTER TRIGGER trg_CheckUnpaid
ON PhieuMuonSach
FOR INSERT
AS
BEGIN
    DECLARE @MaTaiKhoan INT;
    SELECT @MaTaiKhoan = MaTaiKhoan FROM inserted;

    IF EXISTS (
        SELECT 1 
        FROM PhieuPhat pp
        JOIN PhieuMuonSach pms ON pp.MaPhieuMuon = pms.MaPhieuMuon
        WHERE pms.MaTaiKhoan = @MaTaiKhoan AND pp.NgayTra IS NULL
    )
    BEGIN
        RAISERROR (N'Tài khoản vẫn còn phiếu phạt chưa trả.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO


