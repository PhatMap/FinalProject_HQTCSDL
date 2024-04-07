/*** Bỏ tất cả bảng cùng lúc -> Nhớ bấm liên tục cho hết đỏ thì thôi ***/
CREATE PROCEDURE SP_Drop_All_Tables
(
@mode BIT
)
AS
BEGIN
    IF @mode = 0
		BEGIN
			---*** Do not drop ***
			DECLARE @TableName NVARCHAR(128)
			DECLARE @DatabaseName NVARCHAR(128)
    
			SET @DatabaseName = DB_NAME() -- Get the current database name
    
			DECLARE cur CURSOR FOR
			SELECT t.name
			FROM sys.tables t
			WHERE SCHEMA_NAME(t.schema_id) + '.' + t.name NOT IN (
				SELECT SCHEMA_NAME(o.schema_id) + '.' + o.name
				FROM sys.objects o
				INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
				WHERE o.type IN ('P', 'FN', 'IF', 'TF', 'TR')
			) -- Exclude tables that are also stored procedures, functions, or triggers
			AND SCHEMA_NAME(t.schema_id) + '.' + t.name NOT IN ('sysdiagrams') -- Exclude sysdiagrams table if exists
			AND OBJECTPROPERTY(t.object_id, 'IsMsShipped') = 0 -- Exclude system tables

			OPEN cur
			FETCH NEXT FROM cur INTO @TableName
			WHILE @@FETCH_STATUS = 0
			BEGIN
				EXEC ('DROP TABLE ' + @TableName)
				FETCH NEXT FROM cur INTO @TableName
			END
			CLOSE cur
			DEALLOCATE cur
		END;
    IF @mode = 1
		BEGIN
			DROP TABLE LichLamViec
			DROP TABLE PhieuPhat
			DROP TABLE CuonSach
			DROP TABLE Sach
			DROP TABLE TacGia
			DROP TABLE TheLoai
			DROP TABLE NhaXuatBan
			DROP TABLE PhieuMuonSach
			DROP TABLE TaiKhoan
		END;
END

GO
/*** Xem tất cả các bảng cùng lúc ***/
CREATE PROCEDURE SP_Select_All_Records_From_All_Tables
AS
BEGIN
	---*** Do not drop ***
    DECLARE @TableName NVARCHAR(MAX)
    DECLARE @SQL NVARCHAR(MAX)

    DECLARE table_cursor CURSOR FOR
    SELECT TABLE_NAME
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE'

    OPEN table_cursor
    FETCH NEXT FROM table_cursor INTO @TableName

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @SQL = 'SELECT * FROM ' + @TableName
        EXEC sp_executesql @SQL
        
        FETCH NEXT FROM table_cursor INTO @TableName
    END

    CLOSE table_cursor
    DEALLOCATE table_cursor
END

GO
/*** Tạo tất cả các bảng ***/
CREATE PROCEDURE SP_Create_All_Tables
AS
BEGIN
	---*** Do not drop ***
	CREATE TABLE TaiKhoan (
		MaTaiKhoan INT PRIMARY KEY,
		Email NVARCHAR(255) UNIQUE NOT NULL,
		MatKhau NVARCHAR(255) CHECK (LEN(MatKhau) >= 8),
		VaiTro NVARCHAR(50) NOT NULL,
		HoTen NVARCHAR(255) NOT NULL,
		SoDienThoai NVARCHAR(10) CHECK (LEN(SoDienThoai) = 10),
		NgaySinh DATE CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 18),
		DiaChi NVARCHAR(255) NOT NULL,
		GioiTinh NVARCHAR(10) NOT NULL
	);

	CREATE TABLE NhaXuatBan (
		MaNhaXuatBan INT IDENTITY(1,1) PRIMARY KEY,
		TenNhaXuatBan NVARCHAR(255) NOT NULL
	);

	CREATE TABLE TacGia (
		MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
		TenTacGia NVARCHAR(255) NOT NULL
	);

	CREATE TABLE TheLoai(
		MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
		TenTheLoai NVARCHAR(255) NOT NULL
	);

	CREATE TABLE Sach (
		MaSach INT IDENTITY(1,1) PRIMARY KEY,
		MaTacGia INT,
		MaTheLoai INT,
		MaNhaXuatBan INT,
		TenSach NVARCHAR(255) NOT NULL,
		LoaiTaiLieu NVARCHAR(50) NOT NULL,
		NamXuatBan INT CHECK (NamXuatBan >= 0 AND NamXuatBan <= YEAR(GETDATE())),
		GiaSach DECIMAL(18,0) CHECK (GiaSach >= 0),
		SoLuong INT CHECK (SoLuong >= 0),
		FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia),
		FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai),
		FOREIGN KEY (MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan)
	);

	CREATE TABLE PhieuMuonSach (
		MaPhieuMuon INT IDENTITY(1,1) PRIMARY KEY,
		MaTaiKhoan INT,
		NgayMuon DATE DEFAULT GETDATE(),
		CHECK (CONVERT(DATE, NgayMuon) = CONVERT(DATE, GETDATE())),
		NgayTra DATE NULL,
		FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
	);

	CREATE TABLE PhieuPhat (
		MaPhieuPhat INT IDENTITY(1,1) PRIMARY KEY,
		MaPhieuMuon INT,
		TienPhat DECIMAL(18,0) CHECK (TienPhat >= 0),
		NgayTra DATE NULL, 
		FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuonSach(MaPhieuMuon),
	);

	CREATE TABLE LichLamViec (
		MaLichLamViec INT IDENTITY(1,1) PRIMARY KEY,
		NgayLam DATE CHECK (NgayLam >= CAST(GETDATE() AS DATE)),
		Ca NVARCHAR(255) NOT NULL,
		MaTaiKhoan INT,
		FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
	);

	CREATE TABLE CuonSach (
		MaSach INT,
		MaPhieuMuon INT,
		TinhTrang NVARCHAR(255) NOT NULL,
		PRIMARY KEY (MaSach, MaPhieuMuon),
		FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
		FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuonSach(MaPhieuMuon)
	);
END;

GO
/*** Nhập dữ liệu tất cả các bảng	***/
CREATE PROCEDURE SP_Insert_All_Tables_Data
AS 
BEGIN
	---*** Do not drop ***
	DECLARE @today DATE
	SET @today = GETDATE()

	INSERT INTO TacGia (TenTacGia)
	VALUES (N'Nguyễn Nhật Ánh'),
		   (N'Nguyễn Du'),
		   (N'Trích Đoàn');

	INSERT INTO TheLoai (TenTheLoai)
	VALUES (N'Tiểu thuyết'),
		   (N'Kinh điển'),
		   (N'Phiêu lưu'),
		   (N'Khoa học viễn tưởng');

	INSERT INTO NhaXuatBan (TenNhaXuatBan)
	VALUES (N'Nhà Xuất Bản Trẻ'),
		   (N'NXB Kim Đồng'),
		   (N'NXB Văn Học'),
		   (N'NXB Lao Động Xã Hội');

	INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
	VALUES (1, 1, 1, N'Tôi thấy hoa vàng trên cỏ xanh', N'Sách tham khảo', 2005, 65000, 100),
		   (2, 2, 2, N'Thần đồng đất Việt', N'Giáo trình', 1960, 55000, 80),
		   (3, 3, 3, N'Harry Potter và Hòn Đá Phù Thủy', N'Sách tham khảo', 1997, 89000, 120);

	INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
	VALUES (20110536,'admin@gmail.com', 'aaaaaaaa', N'Quản trị viên', N'Trần Trung Phát', '0123456789', '2000-01-01', N'Hà Nội', N'Nam'),
		   (1,'example2@gmail.com', 'password2', N'Thủ thư', N'Trần Thị B', '0987654321', '1995-05-10', N'Hồ Chí Minh', N'Nữ'),
		   (2,'example3@gmail.com', 'password3', N'Độc giả', N'Phạm Văn C', '0369852147', '1988-11-20', N'Đà Nẵng', N'Nam');

	SET IDENTITY_INSERT PhieuMuonSach ON;

	INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
	VALUES (1, 20110536, @today, NULL),
		   (2, 20110536, @today, DATEADD(DAY, 7, @today)),
		   (3, 20110536, @today, NULL);

	SET IDENTITY_INSERT PhieuMuonSach OFF;

	INSERT INTO PhieuPhat (MaPhieuMuon, TienPhat, NgayTra)
	VALUES (2, 5000, DATEADD(DAY, 7, @today));

	INSERT INTO LichLamViec (NgayLam, Ca, MaTaiKhoan)
	VALUES (DATEADD(DAY, 3, @today), N'Sáng', 20110536),
		   (DATEADD(DAY, 4, @today), N'Chiều', 20110536),
		   (DATEADD(DAY, 5, @today), N'Sáng', 20110536),
		   (DATEADD(DAY, 6, @today), N'Chiều', 20110536);

	INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
	VALUES (1, 1, N'Đang mượn'),
		   (2, 2, N'Đang mượn'),
		   (3, 3, N'Đang mượn');
END;

GO
/***	Hiện hết Store Procedure, Function, Trigger, View	***/
CREATE PROCEDURE SP_Select_All_SP_FN_TR_VW
AS
BEGIN
	---*** Do not drop ***
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
END;

GO
/***	Gỡ hết Store Procedure	***/
CREATE PROCEDURE SP_Drop_All_SP
AS
BEGIN
	---*** Do not drop ***
	-- Gỡ bỏ tất cả các stored procedure
	DECLARE @procedureName NVARCHAR(MAX)
	DECLARE curProcedures CURSOR FOR
	SELECT name FROM sys.objects WHERE type = 'P'
	OPEN curProcedures
	FETCH NEXT FROM curProcedures INTO @procedureName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC('DROP PROCEDURE ' + @procedureName)
		FETCH NEXT FROM curProcedures INTO @procedureName
	END
	CLOSE curProcedures
	DEALLOCATE curProcedures
END;

GO
/***	Không gỡ Store Procedure đánh dấu	***/
CREATE PROCEDURE SP_Drop_SP_Marked
AS
BEGIN
	---*** Do not drop ***
	    -- Drop all stored procedures except those marked with a specific comment
    DECLARE @procedureName NVARCHAR(MAX)
    
    -- Declare cursor to fetch procedure names
    DECLARE curProcedures CURSOR FOR
    SELECT name 
    FROM sys.objects 
    WHERE type = 'P'
    AND OBJECT_DEFINITION(OBJECT_ID) NOT LIKE '%---*** Do not drop ***%'
    
    OPEN curProcedures
    FETCH NEXT FROM curProcedures INTO @procedureName
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Drop the stored procedure
        EXEC('DROP PROCEDURE ' + @procedureName)
        FETCH NEXT FROM curProcedures INTO @procedureName
    END
    
    CLOSE curProcedures
    DEALLOCATE curProcedures
END;

GO
/***	Gỡ hết Store Procedure, Function, Trigger, View	***/
CREATE PROCEDURE SP_Drop_All_FN
AS
BEGIN
	---*** Do not drop ***
	-- Gỡ bỏ tất cả các function
	DECLARE @functionName NVARCHAR(MAX)
	DECLARE curFunctions CURSOR FOR
	SELECT name FROM sys.objects WHERE type IN ('FN', 'IF', 'TF')
	OPEN curFunctions
	FETCH NEXT FROM curFunctions INTO @functionName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC('DROP FUNCTION ' + @functionName)
		FETCH NEXT FROM curFunctions INTO @functionName
	END
	CLOSE curFunctions
	DEALLOCATE curFunctions
END;

GO
/***	Gỡ hết Trigger, View	***/
CREATE PROCEDURE SP_Drop_All_TR
AS
BEGIN
	---*** Do not drop ***
	-- Gỡ bỏ tất cả các trigger
	DECLARE @triggerName NVARCHAR(MAX)
	DECLARE curTriggers CURSOR FOR
	SELECT name FROM sys.triggers
	OPEN curTriggers
	FETCH NEXT FROM curTriggers INTO @triggerName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC('DROP TRIGGER ' + @triggerName)
		FETCH NEXT FROM curTriggers INTO @triggerName
	END
	CLOSE curTriggers
	DEALLOCATE curTriggers
END;

GO
/***	Gỡ hết View	***/
CREATE PROCEDURE SP_Drop_All_VW
AS
BEGIN
	---*** Do not drop ***
	-- Gỡ bỏ tất cả các view
	DECLARE @viewName NVARCHAR(MAX)
	DECLARE curViews CURSOR FOR
	SELECT name FROM sys.views
	OPEN curViews
	FETCH NEXT FROM curViews INTO @viewName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC('DROP VIEW ' + @viewName)
		FETCH NEXT FROM curViews INTO @viewName
	END
	CLOSE curViews
	DEALLOCATE curViews
END;