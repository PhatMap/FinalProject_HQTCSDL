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
