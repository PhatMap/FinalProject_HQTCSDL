-- Show all triggers
SELECT 
    name AS TriggerName,
    type_desc AS ObjectType,
    create_date AS CreateDate
FROM sys.triggers;

-- Show all views
SELECT 
    name AS ViewName,
    type_desc AS ObjectType,
    create_date AS CreateDate
FROM sys.views;

-- Show all procedures
SELECT 
    name AS ProcedureName,
    type_desc AS ObjectType,
    create_date AS CreateDate
FROM sys.procedures;

-- Show all functions
SELECT 
    name AS FunctionName,
    type_desc AS ObjectType,
    create_date AS CreateDate
FROM sys.objects
WHERE type IN ('FN', 'IF', 'TF', 'FS', 'FT');



--DROP ALL TABLES AT ONCE
DECLARE @TableName NVARCHAR(128)
DECLARE cur CURSOR FOR
SELECT name
FROM sys.tables
OPEN cur
FETCH NEXT FROM cur INTO @TableName
WHILE @@FETCH_STATUS = 0
BEGIN
    EXEC ('DROP TABLE ' + @TableName)
    FETCH NEXT FROM cur INTO @TableName
END
CLOSE cur
DEALLOCATE cur






---------------------------------------------------------------------Tables
CREATE TABLE TacGia (
    MaTacGia INT PRIMARY KEY IDENTITY(1,1),
    TenTacGia NVARCHAR(255) NOT NULL
);

CREATE TABLE NhaXuatBan (
    MaNhaXuatBan INT PRIMARY KEY IDENTITY(1,1),
    TenNhaXuatBan NVARCHAR(255) NOT NULL
);


CREATE TABLE LoaiTinhTrangSach (
    MaLoaiTinhTrang INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiTinhTrang NVARCHAR(255) NOT NULL
);

CREATE TABLE Ca(
    MaCa INT PRIMARY KEY IDENTITY(1,1),
    Thu NVARCHAR(255) NOT NULL,
    Buoi NVARCHAR(255) NOT NULL,
);

CREATE TABLE ChucNang(
	MaChucNang INT PRIMARY KEY IDENTITY(1,1),
	TenChucNang NVARCHAR(255) NOT NULL,
);
CREATE TABLE ChucVu(
	MaChucVu INT PRIMARY KEY IDENTITY(1,1),
	TenChucVu NVARCHAR(255) NOT NULL,
);
CREATE TABLE PhanQuyen(
	MaChucVu INT,
	MaChucNang INT,
	PRIMARY KEY (MaChucVu, MaChucNang),
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu) ON DELETE CASCADE,
	FOREIGN KEY (MaChucNang) REFERENCES ChucNang(MaChucNang) ON DELETE CASCADE,
);

CREATE TABLE LoaiTaiLieu (
    MaLoaiTaiLieu INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiTaiLieu NVARCHAR(255) NOT NULL
);

CREATE TABLE Sach (
    MaSach INT PRIMARY KEY IDENTITY(1,1),
    MaTacGia INT,
    MaLoaiTaiLieu INT,
    MaNhaXuatBan INT,
    TenSach NVARCHAR(255) NOT NULL,
    TheLoai NVARCHAR(100) NOT NULL,
    NamXuatBan INT NOT NULL,
    GiaSach DECIMAL(18,2) NOT NULL,
    SoLuong INT CHECK (SoLuong >= 0),
    FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia),
    FOREIGN KEY (MaLoaiTaiLieu) REFERENCES LoaiTaiLieu(MaLoaiTaiLieu),
    FOREIGN KEY (MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan)
);

CREATE TABLE TaiKhoan(
	MaTaiKhoan INT PRIMARY KEY IDENTITY(1,1),
	TenTaiKhoan NVARCHAR(255) NOT NULL,
	MatKhau NVARCHAR(255) NOT NULL CHECK(LEN(MatKhau) >= 8),
	DiaChi NVARCHAR(255) NOT NULL,
	Email NVARCHAR(255) UNIQUE NOT NULL, 
	NgaySinh DATE NOT NULL CHECK(NgaySinh <= DATEADD(year, -18, GETDATE())),
	MaChucVu INT DEFAULT 1, 
    GioiTinh BIT NOT NULL,
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);

CREATE TABLE PhieuMuonSach (
    MaPhieuMuon INT PRIMARY KEY IDENTITY(1,1),
    MaSach INT FOREIGN KEY REFERENCES Sach(MaSach),
    MaTinhTrang INT FOREIGN KEY REFERENCES LoaiTinhTrangSach(MaLoaiTinhTrang),
    MaTaiKhoan INT FOREIGN KEY REFERENCES TaiKhoan(MaTaiKhoan),
    NgayMuon DATE NOT NULL CHECK (DATEDIFF(DAY, GETDATE(), NgayMuon) >= 0),
    NgayTraDuKien DATE NOT NULL CHECK (DATEDIFF(DAY, GETDATE(), NgayTraDuKien) >= 0),
    NgayTraThucTe DATE CHECK (DATEDIFF(DAY, GETDATE(), NgayTraThucTe) >= 0)
);
CREATE TABLE PhieuPhat (
    MaPhieuPhat INT PRIMARY KEY IDENTITY(1,1),
    MaPhieuMuon INT,
    MaLoaiTinhTrang INT,
    MaTaiKhoan INT,
    TienPhat INT  NOT NULL CHECK (TienPhat >= 0),
    FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuonSach(MaPhieuMuon),
    FOREIGN KEY (MaLoaiTinhTrang) REFERENCES LoaiTinhTrangSach(MaLoaiTinhTrang),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);

CREATE TABLE DocGia(
	MaDocGia INT PRIMARY KEY IDENTITY(1,1),
	MaTaiKhoan INT,
	FOREIGN KEY (MaTaiKhoan )REFERENCES TaiKhoan(MaTaiKhoan )
);

CREATE TABLE ThuThu(
	MaThuThu INT PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan INT,
	FOREIGN KEY (MaTaiKhoan )REFERENCES TaiKhoan(MaTaiKhoan )
);

CREATE TABLE QuanTriVien(
	MaQuanTriVien INT PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan INT,
	FOREIGN KEY (MaTaiKhoan )REFERENCES TaiKhoan(MaTaiKhoan )
);


CREATE TABLE ThamSo(
    MaThamSo INT PRIMARY KEY IDENTITY(1,1),
    TenThamSo NVARCHAR(255) NOT NULL,
    GiaTri INT NOT NULL
);

CREATE TABLE PhanCong (
    MaCa INT NOT NULL,
    MaThuThu INT NOT NULL,
    NgayDauTuan DATE NOT NULL,
    NgayCuoiTuan DATE NOT NULL,
    FOREIGN KEY (MaThuThu) REFERENCES ThuThu(MaThuThu),
    FOREIGN KEY (MaCa) REFERENCES Ca(MaCa)
);


---------------------------------------------------------------------Insert Data
-- Insert data into TacGia table
INSERT INTO TacGia (TenTacGia) VALUES 
('Nguyen Hien Le'),
('Jane Austen'),
('George Orwell');

-- Insert data into NhaXuatBan table
INSERT INTO NhaXuatBan (TenNhaXuatBan) VALUES 
(N'NXB Trẻ'),
('Penguin Books'),
('Houghton Mifflin Harcourt');

-- Insert data into LoaiTinhTrangSach table
INSERT INTO LoaiTinhTrangSach (TenLoaiTinhTrang) VALUES 
(N'Mới'),
(N'Cũ'),
(N'Hỏng');

-- Insert data into Ca table
INSERT INTO Ca (Thu, Buoi) VALUES 
(N'Thứ Hai', N'Sáng'),
(N'Thứ Hai', N'Chiều'),
(N'Thứ Ba', N'Sáng');

-- Insert data into ChucNang table
INSERT INTO ChucNang (TenChucNang) VALUES 
(N'Quản lý sách'),
(N'Quản lý độc giả'),
(N'Quản lý phiếu mượn sách');

-- Insert data into ChucVu table
INSERT INTO ChucVu (TenChucVu) VALUES 
(N'Độc giả'),
(N'Thủ thư'),
(N'Quản trị viên');

-- Insert data into LoaiTaiLieu table
INSERT INTO LoaiTaiLieu (TenLoaiTaiLieu) VALUES 
(N'Sách'),
(N'Tạp chí'),
(N'Báo');

-- Insert data into Sach table
INSERT INTO Sach (MaTacGia, MaLoaiTaiLieu, MaNhaXuatBan, TenSach, TheLoai, NamXuatBan, GiaSach, SoLuong) VALUES 
(1, 1, 1, N'Những Người Khốn Khổ', N'Tiểu thuyết', 1949, 15.99, 50),
(2, 1, 2, N'Pride and Prejudice', N'Tiểu thuyết', 1813, 12.50, 30),
(3, 1, 3, '1984', 'Tiểu thuyết', 1949, 10.99, 25);

-- Insert data into TaiKhoan table
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, DiaChi, Email, NgaySinh, MaChucVu, GioiTinh) VALUES 
('user1', 'password1', '123 Street, City', 'user1@example.com', '1990-05-15', 1, 1),
('admin', 'aaaaaaaa', '456 Avenue, Town', 'admin@gmail.com', '1985-10-20', 3, 0);

-- Insert data into PhanQuyen table
INSERT INTO PhanQuyen (MaChucVu, MaChucNang) VALUES 
(1, 1),
(2, 1),
(2, 2),
(3, 1),
(3, 2),
(3, 3);



-- Insert data into PhieuMuonSach table
INSERT INTO PhieuMuonSach (MaSach, MaTinhTrang, MaTaiKhoan, NgayMuon, NgayTraDuKien, NgayTraThucTe) VALUES 
(1, 1, 1, '2024-03-25', '2024-04-25', NULL),
(2, 1, 1, '2024-03-25', '2024-04-25', NULL);

-- Insert data into PhieuPhat table
INSERT INTO PhieuPhat (MaPhieuMuon, MaLoaiTinhTrang, MaTaiKhoan, TienPhat) VALUES 
(1, 3, 1, 50),
(2, 3, 1, 30);

-- Insert data into DocGia table
INSERT INTO DocGia (MaTaiKhoan) VALUES 
(1);

-- Insert data into ThuThu table
INSERT INTO ThuThu (MaTaiKhoan) VALUES 
(2);

-- Insert data into QuanTriVien table
INSERT INTO QuanTriVien (MaTaiKhoan) VALUES 
(2);

-- Insert data into ThamSo table
INSERT INTO ThamSo (TenThamSo, GiaTri) VALUES 
('SoLuongMuonToiDa', 5),
('SoNgayMuonToiDa', 30);

-- Insert data into PhanCong table
INSERT INTO PhanCong (MaCa, MaThuThu, NgayDauTuan, NgayCuoiTuan) VALUES 
(1, 1, '2024-03-25', '2024-03-31'),
(2, 1, '2024-03-25', '2024-03-31');





GO
-------------------------------------------------------------------View(VW_)---------------------------------------------------------------------------------
GO
-------------------------------------Get account list (Phat)
CREATE VIEW VW_Account_List AS
SELECT 	
	MaTaiKhoan, 
	TenTaiKhoan, 
	MatKhau, 
	DiaChi, 
	Email, 
	NgaySinh, 
	CV.TenChucVu,     
	CASE GioiTinh
		WHEN 0 THEN N'Nam'
		WHEN 1 THEN N'Nữ'
	END AS GioiTinh
FROM TaiKhoan TK
JOIN ChucVu CV ON TK.MaChucVu = CV.MaChucVu;
GO

--Chạy thử
SELECT * FROM VW_Account_List

GO
--------------------------------------------Get authorization list (Phat)
CREATE VIEW VW_Authorization_List AS
SELECT 	
	PQ.MaChucVu, 
	PQ.MaChucNang, 
	CV.TenChucVu, 
	CN.TenChucNang 
FROM PhanQuyen PQ
JOIN ChucVu CV ON PQ.MaChucVu = CV.MaChucVu
JOIN ChucNang CN ON PQ.MaChucNang = CN.MaChucNang;

--Chạy thử
SELECT * FROM VW_Authorization_List
GO

--------------------------------------------Get postion list (Phat)
CREATE VIEW VW_Position_List AS
SELECT 	
	MaChucVu, TenChucVu 
FROM ChucVu
	
--Chạy thử
SELECT * FROM VW_Position_List
GO

-------------------------------------------------------------------Store Procedure (SP_)---------------------------------------------------------------------------------
------------------------------------------------------------Login Account (Phat)
GO
CREATE PROC SP_Login
@Email nvarchar(255), @MatKhau nvarchar(255)
AS 
BEGIN
	SELECT * FROM TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau
END
GO

--Chạy thử
EXEC SP_Login @Email = 'admin@gmail.com', @MatKhau = 'aaaaaaaa'

------------------------------------------------------------Get Account Position functions (Phat)
GO
CREATE PROC SP_Get_Account_Position_Functions
@MaChucVu int
AS 
BEGIN
	SELECT * FROM VW_Authorization_List WHERE MaChucVu = @MaChucVu
END
GO

--Chạy thử
EXEC SP_Get_Account_Position_Functions @position = 1

---------------------------------------------------Change password(Phat)
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

	IF NOT EXISTS (SELECT * FROM TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhauCu)
    BEGIN
        ROLLBACK; 
    END

	IF @MatKhauMoi <> @XacNhan
    BEGIN
        ROLLBACK; 
    END

    BEGIN TRY
            UPDATE TaiKhoan
			SET MatKhau = @MatKhauMoi
			WHERE Email = @Email;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END

--Chạy thử
SELECT * FROM SP_Change_Account_Password()

---------------------------------------------------Update account profile(Phat)

CREATE PROC SP_Update_Account_Profile
    @TenTaiKhoan nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh datetime,
    @Email nvarchar(255),
    @GioiTinh bit
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            UPDATE TaiKhoan
				SET TenTaiKhoan = @TenTaiKhoan,
					DiaChi = @DiaChi,
					NgaySinh = @NgaySinh,
					GioiTinh = @GioiTinh
			 WHERE Email = @Email;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

---------------------------------------------------Add New Account(Phat)
GO

CREATE PROC SP_Add_New_Account
    @TenTaiKhoan nvarchar(255),
	@MatKhau nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh datetime,
    @Email nvarchar(255),
	@MaChucVu int,
    @GioiTinh bit
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, DiaChi, Email, NgaySinh, MaChucVu, GioiTinh)
        VALUES (@TenTaiKhoan, @MatKhau, @DiaChi, @Email, @NgaySinh, @MaChucVu, @GioiTinh);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

--Chạy thử
EXEC SP_Add_New_Account 
    @TenTaiKhoan = 'John Doe',
    @MatKhau = 'password123',
    @DiaChi = '123 Main St',
    @NgaySinh = '1999-03-31',
    @Email = 'john@example.com',
    @MaChucVu = 1,
    @GioiTinh = 0;

GO

---------------------------------------------------Delete account(Phat)

CREATE PROC SP_Delete_Account
    @MaTaiKhoan int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
            DELETE TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;

Select * from TaiKhoan

EXEC SP_Delete_Account '3'

-------------------------------------------------------------------Function(FN_)---------------------------------------------------------------------------------
---------------------------------------------------Get login account profile(Phat)
CREATE FUNCTION FN_Get_Account_Profile(@Email nvarchar(255))
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM TaiKhoan
    WHERE Email = @Email
)

SELECT * FROM FN_Get_Account_Profile('admin@gmail.com')




-------------------------------------------------------------------Trigger(TR_)---------------------------------------------------------------------------------