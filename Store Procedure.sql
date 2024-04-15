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
go
/***	Find Book Loan Coupon by status (Trung)		***/
CREATE PROC SP_Find_BookLoanCoupon_By_Status
(
	@Status nvarchar(255) = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_BookLoanCoupon_List
	WHERE 
		(@Status IS NULL OR TinhTrang = @Status)
END;
go
/***	Add New Book Loan Coupon(Trung)		***/
CREATE OR ALTER PROC SP_Add_New_BookLoanCoupon
	@MaTaiKhoan int = NULL,
	@MaSach int = null,
	@NgayMuon date = NULL,
	@NgayTra date = NULL
AS
BEGIN
    -- Declare a table variable to hold the new ID
    DECLARE @NewIDTable TABLE (NewID INT);

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insert into the PhieuMuonSach table
        INSERT INTO PhieuMuonSach (MaTaiKhoan, NgayMuon, NgayTra)
        OUTPUT Inserted.MaPhieuMuon INTO @NewIDTable
        VALUES (@MaTaiKhoan, @NgayMuon, @NgayTra);

        -- Get the new ID
        DECLARE @NewID INT = (SELECT NewID FROM @NewIDTable);

        -- Check if MaSach exists in CuonSach
        IF NOT EXISTS (SELECT 1 FROM CuonSach WHERE MaSach = @MaSach)
        BEGIN
            -- Insert new record into CuonSach
            INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
            VALUES (@MaSach, @NewID, N'Đang mượn');
        END
        ELSE
        BEGIN
            -- Update the CuonSach table
            UPDATE CuonSach
            SET MaPhieuMuon = @NewID
            WHERE MaSach = @MaSach;
        END

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Delete coupon(Trung)		***/
CREATE or Alter PROC SP_Delete_Coupon
    @MaTaiKhoan int,
	@MaSach int
AS
BEGIN
	DECLARE @DeletedIDTable TABLE (DeletedID INT);

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Delete from CuonSach and output the deleted ID
        DELETE FROM dbo.CuonSach
        OUTPUT DELETED.MaPhieuMuon INTO @DeletedIDTable
        WHERE MaSach = @MaSach;

        -- Get the deleted ID
        DECLARE @DeletedID INT = (SELECT DeletedID FROM @DeletedIDTable);

        -- Delete from PhieuMuonSach using the deleted ID
        DELETE FROM dbo.PhieuMuonSach
        WHERE MaPhieuMuon = @DeletedID AND MaTaiKhoan = @MaTaiKhoan;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
GO
/***	Update coupon(Trung)		***/
CREATE PROC SP_Update_Coupon
	@MaPhieuMuon int,
	@MaTaiKhoan int,
    @MaSach int,
	@NgayMuon date,
	@NgayTra date
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
			UPDATE dbo.CuonSach
				Set	MaSach = @MaSach
				Where MaPhieuMuon = @MaPhieuMuon;
            UPDATE dbo.PhieuMuonSach
				SET MaTaiKhoan = @MaTaiKhoan,
					NgayMuon = @NgayMuon,
					NgayTra = @NgayTra
				WHERE MaPhieuMuon = @MaPhieuMuon;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
GO
/***	Update coupon _ Returned(Trung)		***/
CREATE PROC SP_Update_Coupon_Returned
	@MaPhieuMuon int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
			UPDATE dbo.CuonSach
				Set	TinhTrang = N'Đã Trả'
				Where MaPhieuMuon = @MaPhieuMuon;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
GO
/***	Find Book Loan Coupon by advanced (Trung)		***/
CREATE PROC SP_Find_BookLoan_Coupon_By_Advanced
(
	@MaSach int,
	@MaTaiKhoan int,
	@MaPhieuMuon int
)
AS
BEGIN
	SELECT 
		*
	FROM VW_BookLoanCoupon_List 
	WHERE 
		(@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan) AND
		(@MaSach IS NULL OR MaSach = @MaSach) AND
		(@MaPhieuMuon IS NULL OR MaPhieuMuon = @MaPhieuMuon) 
END;
GO
/***	Add NXB (Trung)		***/

CREATE PROC SP_Add_New_NXB
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.NhaXuatBan(TenNhaXuatBan)
        VALUES (@TenNhaXuatBan);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
go
/***	Update NXB (Trung)		***/
CREATE or Alter PROC SP_Update_NXB
	@MaNhaXuatBan INT,
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
			UPDATE dbo.NhaXuatBan
				Set	TenNhaXuatBan = @TenNhaXuatBan
				Where MaNhaXuatBan = @MaNhaXuatBan;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
GO
/***	Find NXB (Trung)		***/
CREATE PROC SP_Find_NXB
(
	@MaNhaXuatBan int,
	@TenNhaXuatBan NVARCHAR(255)
)
AS
BEGIN
	SELECT 
		*
	FROM VW_NXB_List
	WHERE 
		(@MaNhaXuatBan IS NULL OR MaNhaXuatBan = @MaNhaXuatBan) AND
		(@TenNhaXuatBan IS NULL OR TenNhaXuatBan = @TenNhaXuatBan)
END;
GO
/***	Delete NXB (Trung)		***/
CREATE or Alter PROC SP_Delete_NXB
	@MaNhaXuatBan INT,
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
			Delete From dbo.NhaXuatBan
			Where MaNhaXuatBan = @MaNhaXuatBan And TenNhaXuatBan = @TenNhaXuatBan;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
GO