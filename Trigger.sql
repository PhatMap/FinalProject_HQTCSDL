/***	Not duplicate phone number (Phat)		***/
CREATE TRIGGER TR_Not_Duplicate_Phone_Number
ON dbo.TaiKhoan
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS
	(
		SELECT * FROM inserted i
		WHERE EXISTS(	SELECT * FROM dbo.TaiKhoan TK 
						WHERE	(TK.SoDienThoai = i.SoDienThoai) 
						AND		(TK.MaTaiKhoan <> i.MaTaiKhoan)
					)
	) 
    BEGIN
		RAISERROR ('Duplicate phone number is not allowed', 16, 1);
        ROLLBACK TRANSACTION;
	END
END;

GO
/***	Librarian not working over 48h/week (Phat)		***/
CREATE TRIGGER TR_Limit_Working_Hours
ON dbo.LichLamViec
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaTaiKhoan INT;
	DECLARE @NgayLam Date;
    DECLARE @TotalHours INT;
    --Một Ca tính là 4 giờ
    SELECT @MaTaiKhoan = MaTaiKhoan, 
			@NgayLam = NgayLam
	FROM inserted;
    
    SELECT @TotalHours = dbo.FN_Total_Working_Hours(@MaTaiKhoan, @NgayLam)

    IF @TotalHours > 40
    BEGIN
        RAISERROR ('The total working hours exceed the limit of 40 hours per week for a Librarian.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

GO
/***	An Librarian can not duplicate Working day(Phat)		***/
CREATE TRIGGER TR_Not_Duplicate_Working_Days
ON dbo.LichLamViec
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaTaiKhoan INT;
	DECLARE @MaLichLamViec INT;
	DECLARE @NgayLam Date;
	DECLARE @Ca NVARCHAR(255);

    SELECT @MaTaiKhoan = MaTaiKhoan, @NgayLam = NgayLam, @Ca = Ca, @MaLichLamViec=MaLichLamViec FROM inserted;
    
    IF EXISTS (SELECT * FROM dbo.LichLamViec WHERE(MaTaiKhoan = @MaTaiKhoan AND NgayLam = @NgayLam AND Ca = @Ca AND @MaLichLamViec<>MaLichLamViec))
    BEGIN
        RAISERROR ('A working day can not be duplicate.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

GO
/***	Update book quantity if borrowed (Phat)		***/
CREATE TRIGGER TR_Not_Update_Books_Quantity_After_Borrowed
ON dbo.CuonSach
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaPhieuMuon INT;

    SELECT @MaPhieuMuon = MaPhieuMuon FROM inserted;

    UPDATE S
    SET S.SoLuong = S.SoLuong - 1
    FROM dbo.CuonSach CS
    JOIN dbo.Sach S ON CS.MaSach = S.MaSach
    WHERE CS.MaPhieuMuon = @MaPhieuMuon;
END;

GO
/* Trigger không cho tạo, cập nhật thể loại trùng*/
CREATE TRIGGER TR_Prevent_duplicate_category 
ON TheLoai
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM TheLoai t
        JOIN INSERTED i ON t.TenTheLoai = i.TenTheLoai WHERE t.MaTheLoai<>i.MaTheLoai
    )
    BEGIN
        RAISERROR('Không thể thêm hoặc cập nhật vì đã tồn tại thể loại có cùng tên.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END; 

GO 
/* Trigger không cho tạo, cập nhật ngày trả nợ < ngày trả sách*/
CREATE TRIGGER TR_Prevent_return_date_update
ON dbo.PhieuPhat
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        JOIN PhieuMuonSach pms ON i.MaPhieuMuon = pms.MaPhieuMuon
        WHERE i.NgayTra < pms.NgayTra
		)
    BEGIN
        RAISERROR('Ngày trả không được lớn hơn ngày trả thực tế.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;

GO
/* Trigger không cho tạo, cập nhật sách trùng*/
CREATE TRIGGER TR_Prevent_duplicate_Book
ON dbo.Sach
AFTER INSERT, UPDATE
AS
BEGIN
	IF EXISTS (
	SELECT 1 
	FROM Sach S 
	JOIN inserted i 
	ON S.MaTacGia = i.MaTacGia 
	WHERE	S.TenSach = i.TenSach AND
			S.MaTacGia = i.MaTacGia AND
			S.MaTheLoai = i.MaTheLoai AND
			S.MaNhaXuatBan = i.MaNhaXuatBan AND
			S.LoaiTaiLieu = i.LoaiTaiLieu AND
			S.NamXuatBan = i.NamXuatBan AND
			S.GiaSach = i.GiaSach AND
			S.MaSach<>i.MaSach)
	BEGIN
		RAISERROR('Không tạo trùng tựa sách', 16, 1);
		ROLLBACK TRANSACTION;
	END;
END;

GO
/* Trigger không cho tạo, cập nhật tác giả trùng (Phat)*/
CREATE TRIGGER TR_Prevent_duplicate_Author
ON TacGia
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT 1 FROM TacGia TG JOIN inserted i ON TG.MaTacGia = i.MaTacGia 
	WHERE TG.TenTacGia = i.TenTacGia AND TG.MaTacGia<>i.MaTacGia)
	BEGIN
		RAISERROR('Không trùng tên tác giả', 16, 1)
		ROLLBACK TRANSACTION
	END
END

GO
--Trigger Check Duplicates_NXB(Trung)--
CREATE or Alter TRIGGER TR_Prevent_Publisher_Duplicate
ON dbo.NhaXuatBan
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.NhaXuatBan NXB JOIN inserted i ON NXB.MaNhaXuatBan = i.MaNhaXuatBan
	WHERE NXB.TenNhaXuatBan = i.TenNhaXuatBan AND NXB.MaNhaXuatBan<>i.MaNhaXuatBan)
    BEGIN
        RAISERROR('Không trùng tên nhà xuất bản', 16, 1)
		ROLLBACK TRANSACTION
    END;
END;

GO
/***	Trigger Prevent Borrow Book by Situations (Phat)	***/
CREATE OR ALTER TRIGGER TR_Prevent_Borrowed_Situations
ON dbo.PhieuMuonSach
AFTER INSERT
AS
BEGIN
    DECLARE @ThamKhao INT, @GiaoTrinh INT, @MaTaiKhoan INT, @RollBack BIT = 0;

    SELECT @MaTaiKhoan = MaTaiKhoan FROM inserted;

    IF EXISTS (
        SELECT 1 
        FROM PhieuPhat pp
        JOIN PhieuMuonSach pms ON pp.MaPhieuMuon = pms.MaPhieuMuon
        WHERE pms.MaTaiKhoan = @MaTaiKhoan AND pp.NgayTra IS NULL
    )
    BEGIN
        RAISERROR (N'Tài khoản vẫn còn phiếu phạt chưa trả.', 16, 1);
        SET @RollBack = 1;
    END;

    IF EXISTS (
        SELECT * 
        FROM dbo.PhieuMuonSach PMS
		JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
        WHERE PMS.MaTaiKhoan = @MaTaiKhoan 
		AND PMS.NgayTra IS NULL
		AND CS.TinhTrang = N'Trả trễ'
    )
    BEGIN
        RAISERROR (N'Tài khoản có sách đang trễ hẹn trả.', 16, 1);
        SET @RollBack = 1;
    END;
	
    SELECT 
        @ThamKhao = SUM(CASE WHEN S.LoaiTaiLieu = N'Sách tham khảo' THEN 1 ELSE 0 END),
        @GiaoTrinh = SUM(CASE WHEN S.LoaiTaiLieu = N'Giáo trình' THEN 1 ELSE 0 END)
	FROM dbo.PhieuMuonSach PMS 
	JOIN inserted i ON i.MaTaiKhoan = PMS.MaTaiKhoan
    JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
    JOIN dbo.Sach S ON S.MaSach = CS.MaSach

    IF EXISTS (
        SELECT 1 
        FROM dbo.TaiKhoan TK
        JOIN inserted i ON i.MaTaiKhoan = TK.MaTaiKhoan
        WHERE 
            (TK.VaiTro = N'Sinh viên CLC' AND ((@ThamKhao > 10) OR (@GiaoTrinh > 20)))
            OR (TK.VaiTro = N'Sinh viên đại trà' AND ((@ThamKhao > 10) OR (@GiaoTrinh > 15)))
            OR (TK.VaiTro = N'Học viên cao học' AND ((@ThamKhao > 5) OR (@GiaoTrinh > 5)))
            OR (TK.VaiTro = N'Giảng viên' AND ((@ThamKhao > 10) OR (@GiaoTrinh > 5)))
    )
    BEGIN
        RAISERROR (N'Vượt quá số lượng sách được mượn.', 16, 1);
        SET @RollBack = 1;
    END;

	IF(@RollBack = 1)
	BEGIN
		ROLLBACK TRANSACTION;
	END;
END;

GO
/***	Create SQL Server account (Phat)		***/
CREATE TRIGGER TR_Create_SQL_Server_Account
ON dbo.TaiKhoan
AFTER INSERT
AS
BEGIN
    DECLARE @Email NVARCHAR(255), 
            @MatKhau NVARCHAR(255), 
            @VaiTro NVARCHAR(255), 
            @MaTaiKhoan NVARCHAR(255),
            @Query NVARCHAR(MAX);

    SELECT @Email = Email, 
           @MatKhau = MatKhau, 
           @VaiTro = VaiTro, 
           @MaTaiKhoan = MaTaiKhoan 
    FROM inserted;

    SET @Query = 'CREATE LOGIN [' + @Email + '] WITH PASSWORD = N''' + @MatKhau + ''', DEFAULT_DATABASE=[Library], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;';
    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error creating LOGIN: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

    SET @Query = 'CREATE USER [' + @Email + '] FOR LOGIN [' + @Email + '];';
    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error creating USER: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

    IF (@VaiTro = N'Quản trị viên')
    BEGIN
        SET @Query = 'ALTER SERVER ROLE sysadmin ADD MEMBER [' + @Email + '];';
    END
    ELSE IF (@VaiTro = N'Thủ thư')
    BEGIN
        SET @Query = 'ALTER ROLE ThuThu ADD MEMBER [' + @Email + '];';
    END
    ELSE
    BEGIN
        SET @Query = 'ALTER ROLE DocGia ADD MEMBER [' + @Email + '];';
    END

    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error assigning role: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

END;

GO
/***	Update SQL Server account (Phat)		***/
CREATE TRIGGER TR_Update_SQL_Server_Account
ON dbo.TaiKhoan
AFTER UPDATE
AS
BEGIN
    DECLARE @Email NVARCHAR(255), 
            @MatKhau NVARCHAR(255), 
            @VaiTro NVARCHAR(255), 
            @MaTaiKhoan NVARCHAR(255),
            @OldEmail NVARCHAR(255),
            @OldMatKhau NVARCHAR(255),
            @Query NVARCHAR(MAX);

    SELECT @Email = Email, 
           @MatKhau = MatKhau, 
           @VaiTro = VaiTro, 
           @MaTaiKhoan = MaTaiKhoan 
    FROM inserted;

    SELECT @OldEmail = Email, 
           @OldMatKhau = MatKhau
    FROM deleted;

    IF (@Email <> @OldEmail OR @MatKhau <> @OldMatKhau)
    BEGIN
        SET @Query = 'ALTER LOGIN [' + @OldEmail + '] WITH PASSWORD = N''' + @MatKhau + ''', NAME = [' + @Email + '];';
        BEGIN TRY
            EXEC sp_executesql @Query;
        END TRY
        BEGIN CATCH
            PRINT 'Error updating LOGIN: ' + ERROR_MESSAGE();
            ROLLBACK TRANSACTION;
        END CATCH;

        SET @Query = 'ALTER USER [' + @OldEmail + '] WITH NAME = [' + @Email + '];';
        BEGIN TRY
            EXEC sp_executesql @Query;
        END TRY
        BEGIN CATCH
            PRINT 'Error updating USER: ' + ERROR_MESSAGE();
            ROLLBACK TRANSACTION;
        END CATCH;
    END

    IF (@VaiTro = N'Quản trị viên')
    BEGIN
        SET @Query = 'ALTER SERVER ROLE sysadmin ADD MEMBER [' + @Email + '];';
    END
    ELSE IF (@VaiTro = N'Thủ thư')
    BEGIN
        SET @Query = 'ALTER ROLE ThuThu ADD MEMBER [' + @Email + '];';
    END
    ELSE
    BEGIN
        SET @Query = 'ALTER ROLE DocGia ADD MEMBER [' + @Email + '];';
    END

    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error assigning role: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

END;

GO
/***	Delete SQL Server account (Phat)		***/
CREATE TRIGGER TR_Delete_SQL_Server_Account
ON dbo.TaiKhoan
AFTER DELETE
AS
BEGIN
    DECLARE @Email NVARCHAR(255),
            @Query NVARCHAR(MAX),
            @SessionID INT;

    SELECT @Email = Email 
    FROM deleted;

    SELECT @SessionID = session_id 
    FROM sys.dm_exec_sessions
    WHERE login_name = @Email;

    IF @SessionID IS NOT NULL
    BEGIN
        SET @Query = 'KILL ' + CONVERT(nvarchar(20), @SessionID);
        EXEC (@Query);
    END

    SET @Query = 'DROP USER [' + @Email + '];';
    EXEC (@Query);

    SET @Query = 'DROP LOGIN [' + @Email + '];';
    EXEC (@Query);
END;


