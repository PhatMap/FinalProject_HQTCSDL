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
