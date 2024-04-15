/***	Login Account (Phat)		***/
CREATE PROC SP_Login
@Email nvarchar(255), @MatKhau nvarchar(255)
AS 
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau
END

GO
/***	Get login account profile(Phat)		***/
CREATE PROC SP_Get_Account_Profile
(@Email nvarchar(255))
AS
BEGIN
    SELECT *
    FROM TaiKhoan
    WHERE Email = @Email
END;

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
		(@HoTen IS NULL OR HoTen LIKE '%' + @HoTen + '%') AND
		(@DiaChi IS NULL OR DiaChi LIKE '%' + @DiaChi + '%') AND
		(@Email IS NULL OR Email LIKE '%' + @Email + '%') AND
		(@SoDienThoai IS NULL OR CAST(SoDienThoai AS VARCHAR) LIKE '%' + CAST(@SoDienThoai AS VARCHAR) + '%') AND
		(@VaiTro IS NULL OR VaiTro = @VaiTro) AND
		(@GioiTinh IS NULL OR GioiTinh = @GioiTinh) 
END;

GO
/***	Get schedule (Phat)		***/
CREATE PROC SP_Get_Schedule
(
	@NgayDauTuan date = NULL,
	@NgayCuoiTuan date = NULL,
	@MaTaiKhoan int = NULL
)
AS
BEGIN
	SELECT * FROM VW_Schedule_List
	WHERE
		(@NgayDauTuan IS NULL OR NgayLam >= @NgayDauTuan) AND
		(@NgayCuoiTuan IS NULL OR NgayLam <= @NgayCuoiTuan)	AND
		(@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan)
END;

GO
/***	Load danh sách Sách (Văn)		***/
CREATE PROC SP_Load_List_Sach
AS
BEGIN
	SELECT 
		*
	FROM VW_Book_List 
	WHERE 
END;

GO
/***	Add New Book(Van)		***/
CREATE PROC SP_Add_New_Book
    @MaTacGia INT,
	@MaTheLoai INT,
    @MaNhaXuatBan INT,
    @TenSach NVARCHAR(255),
	@LoaiTaiLieu NVARCHAR(255),
	@NamXuatBan INT,
	@GiaSach DECIMAL,
    @SoLuong INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
        VALUES (@MaTacGia, @MaTheLoai, @MaNhaXuatBan, @TenSach, @LoaiTaiLieu, @NamXuatBan, @GiaSach, @SoLuong);
        
        COMMIT;
    END TRY
    BEGIN CATCH
		PRINT ERROR_MESSAGE();
        ROLLBACK;
    END CATCH;
END;

DROP PROCEDURE IF EXISTS SP_Add_New_Book;

GO
/***	Update Book(Van)		***/
CREATE PROC SP_Update_Book
	@MaTacGia INT,
	@MaTheLoai INT,
    @MaNhaXuatBan INT,
    @TenSach NVARCHAR(255),
	@LoaiTaiLieu NVARCHAR(255),
	@NamXuatBan INT,
	@GiaSach DECIMAL,
    @SoLuong INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            UPDATE dbo.Sach
				SET MaTacGia = @MaTacGia,
					MaTheLoai = @MaTheLoai,
					MaNhaXuatBan = @MaNhaXuatBan,
					TenSach = @TenSach,
					LoaiTaiLieu = @LoaiTaiLieu,
					NamXuatBan = @NamXuatBan,
					GiaSach = @GiaSach,
					SoLuong = @SoLuong
			 WHERE TenSach = @TenSach;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Find account by advanced (Van)		***/
CREATE PROC SP_Find_Book_By_Advanced
(
	@TenTacGia NVARCHAR(255) = NULL,
	@TenTheLoai NVARCHAR(255) = NULL,
    @TenNhaXuatBan NVARCHAR(255) = NULL,
    @TenSach NVARCHAR(255) = NULL,
	@LoaiTaiLieu NVARCHAR(255) = NULL,
	@NamXuatBan INT = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Book_List 
	WHERE 
		(@TenTacGia IS NULL OR @TenTacGia = TenTacGia) AND
		(@TenTheLoai IS NULL OR @TenTheLoai = TenTheLoai) AND
		(@TenNhaXuatBan IS NULL OR @TenNhaXuatBan = TenNhaXuatBan) AND
		(@TenSach IS NULL OR @TenSach = TenSach) AND
		(@LoaiTaiLieu IS NULL OR @LoaiTaiLieu = LoaiTaiLieu) AND
		(@NamXuatBan IS NULL OR @NamXuatBan = NamXuatBan)
END;

GO
/***	Delete account(Van)		***/
CREATE PROC SP_Delete_Book
    @MaSach int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            DELETE dbo.Sach WHERE MaSach = @MaSach;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Add Tác Giả(Van)		***/
CREATE PROC SP_Add_Tac_Gia
    @TenTacGia NVARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO dbo.TacGia (TenTacGia)
        VALUES (@TenTacGia);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Update Tác Giả(Van)		***/
CREATE PROC SP_Update_Tac_Gia
    @MaTacGia INT,
    @TenTacGia NVARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            UPDATE dbo.TacGia
				SET TenTacGia = @TenTacGia
			 WHERE MaTacGia = @MaTacGia;
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

GO
/***	Find TacGia by advanced (Van)		***/
CREATE PROC SP_Find_TacGia_By_Advanced
(
	@TenTacGia NVARCHAR(255) = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_TacGia_List 
	WHERE 
		(@TenTacGia IS NULL OR @TenTacGia = TenTacGia)
		
END;

GO
/***	Delete account(Van)		***/
CREATE PROC SP_Delete_TacGia
    @MaTacGia int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            DELETE dbo.TacGia WHERE MaTacGia = @MaTacGia;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
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