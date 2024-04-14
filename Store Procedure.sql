/***	Login Account (Phat)		***/
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

GO
/***	Find account by advanced (Phat)		***/
CREATE PROC SP_Find_Account_By_Advanced
(
	@MaTaiKhoan int = NULL,
    @HoTen nvarchar(255) = NULL,
    @DiaChi nvarchar(255) = NULL,
	@Email NVARCHAR(255) = NULL,
	@SoDienThoai NVARCHAR(10) = NULL,
	@VaiTro nvarchar(50) = NULL,
    @GioiTinh nvarchar(10) = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Account_List 
	WHERE 
		(@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan) AND
		(@HoTen IS NULL OR HoTen = @HoTen) AND
		(@DiaChi IS NULL OR DiaChi = @DiaChi) AND
		(@Email IS NULL OR Email = @Email) AND
		(@SoDienThoai IS NULL OR SoDienThoai = @SoDienThoai) AND
		(@VaiTro IS NULL OR VaiTro = @VaiTro) AND
		(@GioiTinh IS NULL OR GioiTinh = @GioiTinh) 
END;

GO
/* Thêm phiếu phạt (Hoàn) */
CREATE PROC SP_Add_New_PhieuPhat
    @MaPhieuMuon int,
	@TienPhat decimal,
    @NgayTra date
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.PhieuPhat (MaPhieuMuon, TienPhat, NgayTra)
        VALUES (@MaPhieuMuon, @TienPhat, @NgayTra);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/* Xoá phiếu phạt (Hoàn) */
CREATE PROC SP_Delete_PhieuPhat
    @MaPhieuPhat int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            DELETE dbo.PhieuPhat WHERE MaPhieuPhat = @MaPhieuPhat;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/* Sửa phiếu phạt (Hoàn)*/
CREATE PROC SP_Update_PhieuPhat
	@MaPhieuPhat int,
    @MaPhieuMuon int,
	@TienPhat decimal,
    @NgayTra date
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            UPDATE dbo.PhieuPhat
				SET MaPhieuMuon = @MaPhieuMuon,
					TienPhat = @TienPhat,
					NgayTra = @NgayTra
			 WHERE MaPhieuPhat = @MaPhieuPhat;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/* Tìm kiếm phiếu phạt (Hoàn)*/
CREATE PROC SP_Find_PhieuPhat_By_Advanced
(
    @MaPhieuMuon int = NULL,
    @TienPhat decimal = NULL,
    @NgayTra date = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_PhieuPhat_List 
	WHERE 
		(@MaPhieuMuon IS NULL OR MaPhieuMuon = @MaPhieuMuon) AND
		(@TienPhat IS NULL OR TienPhat = @TienPhat) AND
		(@NgayTra IS NULL OR CONVERT(DATE, NgayTra) = CONVERT(DATE, @NgayTra)) 
END;

GO
/* Thêm thể loại (Hoàn) */
CREATE PROC SP_Add_New_TheLoai
    @TenTheLoai nvarchar(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.TheLoai (TenTheLoai)
        VALUES (@TenTheLoai);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/* Xoá thể loại (Hoàn) */
CREATE PROC SP_Delete_TheLoai
    @MaTheLoai int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            DELETE dbo.TheLoai WHERE MaTheLoai = @MaTheLoai;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/* Sửa thể loại (Hoàn)*/
CREATE PROC SP_Update_TheLoai
	@MaTheLoai int,
    @TenTheLoai nvarchar(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            UPDATE dbo.TheLoai
				SET TenTheLoai = @TenTheLoai
			 WHERE MaTheLoai = @MaTheLoai;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/* Tìm kiếm thể loại (Hoàn)*/
CREATE PROC SP_Find_TheLoai_By_Advanced
(
    @TenTheLoai nvarchar(50) = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_TheLoai_List 
	WHERE 
		(@TenTheLoai IS NULL OR TenTheLoai = @TenTheLoai) 
END;