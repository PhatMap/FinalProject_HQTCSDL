﻿/***	Login Account (Phat)		***/
CREATE PROC SP_Login
@Email nvarchar(255), @MatKhau nvarchar(255)
AS 
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau
END

GO
/***	Change password(Phat)		***/
CREATE PROC SP_Change_Account_Password
(
    @Email NVARCHAR(255),
    @MatKhauMoi NVARCHAR(255),
	@XacNhan NVARCHAR(255),
	@MatKhauCu NVARCHAR(255)
)
AS 
BEGIN
    BEGIN TRANSACTION;

	IF NOT EXISTS (SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhauCu)
    BEGIN
        ROLLBACK; 
    END

	IF @MatKhauMoi <> @XacNhan
    BEGIN
        ROLLBACK; 
    END

    BEGIN TRY
            UPDATE dbo.TaiKhoan
			SET MatKhau = @MatKhauMoi
			WHERE Email = @Email;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END

GO
/***	Update account(Phat)		***/
CREATE PROC SP_Update_Account
	@MaTaiKhoan int,
    @HoTen nvarchar(255),
	@MatKhau nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh date,
	@Email nvarchar(255),
	@SoDienThoai nvarchar(10),
	@VaiTro nvarchar(50),
    @GioiTinh nvarchar(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            UPDATE dbo.TaiKhoan
				SET HoTen = @HoTen,
					MatKhau = @MatKhau,
					DiaChi = @DiaChi,
					NgaySinh = @NgaySinh,
					GioiTinh = @GioiTinh,
					Email = @Email,
					SoDienThoai = @SoDienThoai,
					VaiTro = @VaiTro
			 WHERE MaTaiKhoan = @MaTaiKhoan;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Add New Account(Phat)		***/
CREATE PROC SP_Add_New_Account
	@MaTaiKhoan int,
    @HoTen nvarchar(255),
	@MatKhau nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh date,
	@Email NVARCHAR(255),
	@SoDienThoai NVARCHAR(10),
	@VaiTro nvarchar(50),
    @GioiTinh nvarchar(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.TaiKhoan (MaTaiKhoan, HoTen, MatKhau, DiaChi, Email, NgaySinh, SoDienThoai, VaiTro, GioiTinh)
        VALUES (@MaTaiKhoan, @HoTen, @MatKhau, @DiaChi, @Email, @NgaySinh,@SoDienThoai, @VaiTro, @GioiTinh);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Delete account(Phat)		***/
CREATE PROC SP_Delete_Account
    @MaTaiKhoan int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            DELETE dbo.TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Find account by email(Phat)		***/
CREATE PROC SP_Find_Account_By_Email
(
	@Email nvarchar(255)
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Account_List 
	WHERE 
		(Email = @Email) 
END;


GO
/***	Find account by name (Phat)		***/
CREATE PROC SP_Find_Account_By_Name
(
	@HoTen nvarchar(255)
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Account_List 
	WHERE 
		(HoTen = @HoTen) 
END;

GO
/***	Add new schedule (Phat)		***/
CREATE PROC SP_Add_New_Schedule
(
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
	BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.LichLamViec(NgayLam, Ca, MaTaiKhoan)
        VALUES (@NgayLam , @Ca , @MaTaiKhoan );
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Update schedule (Phat)		***/
CREATE PROC SP_Update_Schedule
(
	@MaLichLamViec int,
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
	BEGIN TRANSACTION;

    BEGIN TRY
        Update dbo.LichLamViec
        SET NgayLam = @NgayLam,
			Ca = @Ca , 
			MaTaiKhoan = @MaTaiKhoan 
		WHERE MaLichLamViec = @MaLichLamViec
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Delete schedule (Phat)		***/
CREATE PROC SP_Delete_Schedule
(
	@MaLichLamViec int
)
AS
BEGIN
	BEGIN TRANSACTION;

    BEGIN TRY
        DELETE dbo.LichLamViec
			WHERE MaLichLamViec = @MaLichLamViec
      
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;