USE [master]
GO
/****** Object:  Database [Library]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Library.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Library_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY FULL 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Library', N'ON'
GO
ALTER DATABASE [Library] SET QUERY_STORE = ON
GO
ALTER DATABASE [Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Library]
GO
/****** Object:  User [21110862@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [21110862@hcmute.edu.vn.com] FOR LOGIN [21110862@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [21110827@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [21110827@hcmute.edu.vn.com] FOR LOGIN [21110827@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [21110333@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [21110333@hcmute.edu.vn.com] FOR LOGIN [21110333@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [20113536@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [20113536@hcmute.edu.vn.com] FOR LOGIN [20113536@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [20110556@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [20110556@hcmute.edu.vn.com] FOR LOGIN [20110556@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [20110536@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [20110536@hcmute.edu.vn.com] FOR LOGIN [20110536@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [20110535@hcmute.edu.vn.com]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE USER [20110535@hcmute.edu.vn.com] FOR LOGIN [20110535@hcmute.edu.vn.com] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [ThuThu]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE ROLE [ThuThu]
GO
/****** Object:  DatabaseRole [DocGia]    Script Date: 29/04/2024 11:58:24 PM ******/
CREATE ROLE [DocGia]
GO
ALTER ROLE [ThuThu] ADD MEMBER [21110862@hcmute.edu.vn.com]
GO
ALTER ROLE [ThuThu] ADD MEMBER [21110827@hcmute.edu.vn.com]
GO
ALTER ROLE [DocGia] ADD MEMBER [21110333@hcmute.edu.vn.com]
GO
ALTER ROLE [DocGia] ADD MEMBER [20113536@hcmute.edu.vn.com]
GO
ALTER ROLE [DocGia] ADD MEMBER [20110556@hcmute.edu.vn.com]
GO
ALTER ROLE [DocGia] ADD MEMBER [20110535@hcmute.edu.vn.com]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Calculate_Penalty_Value]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Calculate Penalty Value (Phat)***/
CREATE   FUNCTION [dbo].[FN_Calculate_Penalty_Value]
(
	@MaPhieuMuon INT
)
RETURNS DECIMAL(18, 0)
AS
BEGIN
    DECLARE @Penalty DECIMAL(18, 0) = 0;
	DECLARE @LateBooks INT = 0;
	DECLARE @TotalDays INT = 0;
	DECLARE @TotalDamagedOrLost DECIMAL(18, 0) = 0;

	SELECT @TotalDamagedOrLost = ISNULL(SUM(S.GiaSach), 0)
	FROM dbo.PhieuMuonSach PMS
	JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
	JOIN dbo.Sach S ON S.MaSach = CS.MaSach
	WHERE CS.MaPhieuMuon = @MaPhieuMuon AND (CS.TinhTrang = N'Đã hư' OR CS.TinhTrang = N'Đã mất');

	SET @TotalDamagedOrLost = @TotalDamagedOrLost * 2;

	SELECT @LateBooks = COUNT(*)
	FROM dbo.PhieuMuonSach PMS
	JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
	WHERE CS.MaPhieuMuon = @MaPhieuMuon AND CS.TinhTrang = N'Trả trễ';

	SELECT @TotalDays = DATEDIFF(DAY, PMS.NgayTra, GETDATE())
	FROM dbo.PhieuMuonSach PMS
	WHERE PMS.MaPhieuMuon = @MaPhieuMuon;

	SET @Penalty = CAST(ISNULL(@TotalDays, 0) AS DECIMAL(18, 0)) * ISNULL(@LateBooks, 0) * 1000 + ISNULL(@TotalDamagedOrLost, 0);

	RETURN @Penalty;
END;

	
	
	

	

		


GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Working_Hours]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Get Librarian Total Working hours in week (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Working_Hours]
(
	@MaTaiKhoan INT,
    @NgayLam DATE
)
RETURNS INT
AS
BEGIN
	DECLARE @WeekStart DATE;
    DECLARE @WeekEnd DATE;
    DECLARE @TotalShifts INT;

    SET @WeekStart = DATEADD(DAY, 2 - DATEPART(WEEKDAY, @NgayLam), @NgayLam);
    SET @WeekEnd = DATEADD(DAY, 8 - DATEPART(WEEKDAY, @NgayLam), @NgayLam);

	SELECT @TotalShifts = COUNT(*)
    FROM dbo.LichLamViec
    WHERE NgayLam BETWEEN @WeekStart AND @WeekEnd
      AND MaTaiKhoan = @MaTaiKhoan;

	RETURN @TotalShifts*4
END;

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[MaTacGia] [int] NULL,
	[MaTheLoai] [int] NULL,
	[MaNhaXuatBan] [int] NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[LoaiTaiLieu] [nvarchar](50) NOT NULL,
	[NamXuatBan] [int] NULL,
	[GiaSach] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Available_Books]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng sách đang hiện hữu (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Available_Books]()
RETURNS TABLE
AS
RETURN (
	SELECT SUM(DISTINCT SoLuong) AS Total_Available 
	FROM dbo.Sach
);

GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuonSach](
	[MaSach] [int] NOT NULL,
	[MaPhieuMuon] [int] NOT NULL,
	[TinhTrang] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Borrowed_Books]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng sách Borrowing (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Borrowed_Books]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Borrowed 
	FROM dbo.CuonSach
	WHERE TinhTrang = N'Đang mượn'
);

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Damaged_Or_Lost_Books]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng sách bị hư hoặc mất (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Damaged_Or_Lost_Books]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Damaged_Or_Lost 
	FROM dbo.CuonSach
	WHERE TinhTrang = N'Đã hư' OR TinhTrang = N'Đã mất'
);

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Books]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả sách (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Books]()
RETURNS TABLE
AS
RETURN (
	SELECT 
    (SELECT SUM(Total_Available) FROM FN_Total_Available_Books()) +
    (SELECT SUM(Total_Borrowed) FROM FN_Total_Borrowed_Books()) +
    (SELECT SUM(Total_Damaged_Or_Lost) FROM FN_Total_Damaged_Or_Lost_Books()) AS Total_All
);

GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [int] IDENTITY(1,1) NOT NULL,
	[TenTacGia] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Authors]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tác giả (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Authors]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Authors
	FROM dbo.TacGia
);

GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNhaXuatBan] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaXuatBan] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Publishers]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả nhà xuất bản (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Publishers]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Publishers
	FROM dbo.NhaXuatBan
);

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Categories]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả thể loại (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Categories]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Categories
	FROM dbo.TheLoai
);

GO
/****** Object:  Table [dbo].[PhieuMuonSach]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonSach](
	[MaPhieuMuon] [int] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [int] NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Loan_Coupons_By_Month]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả phiếu mượn (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Loan_Coupons_By_Month]
(
    @month int,
    @year int
)
RETURNS TABLE
AS
RETURN (
    SELECT 
        COUNT(*) AS Total_Loan_Coupons
    FROM 
        dbo.PhieuMuonSach
    WHERE 
        MONTH(NgayMuon) = @month AND YEAR(NgayMuon) = @year
);
GO
/****** Object:  Table [dbo].[PhieuPhat]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuPhat](
	[MaPhieuPhat] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuMuon] [int] NULL,
	[TienPhat] [decimal](18, 0) NULL,
	[NgayTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuPhat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Penalty_Coupons_By_Month]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả phiếu phạt (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Penalty_Coupons_By_Month]
(
    @month int,
    @year int
)
RETURNS TABLE
AS
RETURN (
    SELECT 
        COUNT(*) AS Total_Penalty_Coupons
    FROM 
        dbo.PhieuPhat
    WHERE 
        MONTH(NgayTra) = @month AND YEAR(NgayTra) = @year
);
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [int] NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](255) NULL,
	[VaiTro] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[SoDienThoai] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tài khoản (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Accounts
	FROM dbo.TaiKhoan
);

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_High_Quality_Student_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tài khoản sinh viên CLC(Phat)***/
CREATE FUNCTION [dbo].[FN_Total_High_Quality_Student_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_High_Quality_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Sinh viên CLC'
);

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Mass_Student_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tài khoản sinh viên đại trà(Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Mass_Student_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Mass_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Sinh viên đại trà'
);

GO
/****** Object:  View [dbo].[VW_Account_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get account list (Phat)		***/
CREATE VIEW [dbo].[VW_Account_List] AS
SELECT 	
	*
FROM dbo.TaiKhoan 

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Graduate_Student_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả Học viên cao học (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Graduate_Student_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Graduate_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Học viên cao học'
);

GO
/****** Object:  Table [dbo].[LichLamViec]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichLamViec](
	[MaLichLamViec] [int] IDENTITY(1,1) NOT NULL,
	[NgayLam] [date] NULL,
	[Ca] [nvarchar](255) NOT NULL,
	[MaTaiKhoan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLichLamViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Schedule_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get shift list (Phat)		***/
CREATE VIEW [dbo].[VW_Schedule_List] AS
SELECT 
	MaLichLamViec, NgayLam, Ca, Tk.MaTaiKhoan, TK.HoTen, TK.SoDienThoai, TK.GioiTinh
FROM dbo.LichLamViec LLV
JOIN dbo.TaiKhoan TK ON TK.MaTaiKhoan = LLV.MaTaiKhoan

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Lecturer_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tài khoản Giảng viên (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Lecturer_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Lecturer_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Giảng viên'
);

GO
/****** Object:  View [dbo].[VW_Librarian_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Librarian list (Phat)		***/
CREATE VIEW [dbo].[VW_Librarian_List] AS
SELECT 
	MaTaiKhoan, 
	HoTen 
FROM dbo.TaiKhoan
WHERE VaiTro = N'Thủ thư'


GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Librarian_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tài khoản Thủ thư (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Librarian_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Librarian_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Thủ thư'
);

GO
/****** Object:  View [dbo].[VW_Book_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Sách list (Văn)		***/
CREATE VIEW [dbo].[VW_Book_List] AS
SELECT 
    S.MaSach, 
    TG.TenTacGia, 
    TL.TenTheLoai, 
    NXB.TenNhaXuatBan, 
    S.TenSach, 
    S.LoaiTaiLieu, 
    S.NamXuatBan, 
    S.GiaSach, 
    S.SoLuong
FROM 
    Sach S
INNER JOIN 
    TacGia TG ON S.MaTacGia = TG.MaTacGia
INNER JOIN 
    TheLoai TL ON S.MaTheLoai = TL.MaTheLoai
INNER JOIN 
    NhaXuatBan NXB ON S.MaNhaXuatBan = NXB.MaNhaXuatBan;

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Total_Administrator_Accounts]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Hàm lấy số lượng tất cả tài khoản Quản trị viên (Phat)***/
CREATE FUNCTION [dbo].[FN_Total_Administrator_Accounts]()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Administrator_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Quản trị viên'
);

GO
/****** Object:  View [dbo].[VW_NhaXuatBan_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Nhà Xuất Bản list (Văn)		***/
CREATE VIEW [dbo].[VW_NhaXuatBan_List] AS
SELECT *
FROM dbo.NhaXuatBan

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Reader_Borrowed_Detail]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get reader borrowed coupon list detail (Phat)		***/
CREATE   FUNCTION [dbo].[FN_Reader_Borrowed_Detail]
(
    @MaPhieuMuon int = NULL,
    @MaPhieuPhat int = NULL
)
RETURNS TABLE
AS
RETURN (
    SELECT 
		CS.MaSach AS N'ID',
		TenSach AS N'Tên sách',
		TenTacGia AS N'Tác giả',
		TenTheLoai AS N'Thể loại',
		TenNhaXuatBan AS N'Nhà xuất bản',
		LoaiTaiLieu AS N'Loại tài liệu',
		NamXuatBan AS N'Năm xuất bản',
		S.GiaSach AS N'Giá',
		CS.TinhTrang AS N'Tình trạng'
    FROM dbo.CuonSach CS
    JOIN dbo.VW_Book_List S ON S.MaSach = CS.MaSach
    WHERE 
        (@MaPhieuMuon IS NOT NULL AND CS.MaPhieuMuon = @MaPhieuMuon) OR 
        (@MaPhieuPhat IS NOT NULL AND CS.MaPhieuMuon = 
		(SELECT MaPhieuMuon FROM dbo.PhieuPhat WHERE MaPhieuPhat = @MaPhieuPhat))
);

GO
/****** Object:  View [dbo].[VW_TheLoai_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Thể Loại list (Hoàn)		***/
CREATE VIEW [dbo].[VW_TheLoai_List] AS
SELECT *
FROM dbo.TheLoai

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Reader_Penalty_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Get reader penalty coupon list (Phat)***/
CREATE FUNCTION [dbo].[FN_Reader_Penalty_List]
(
    @MaTaiKhoan int,
    @Type int -- 0: All, 1: Not Paid, 2: Paid
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        PP.MaPhieuPhat AS N'Mã phiếu phạt',
        PP.TienPhat AS N'Tiền phạt',
        PP.NgayTra AS N'Ngày đóng phạt'
    FROM dbo.PhieuPhat PP
    JOIN dbo.PhieuMuonSach PMS ON PP.MaPhieuMuon = PMS.MaPhieuMuon
    WHERE 
        PMS.MaTaiKhoan = @MaTaiKhoan AND
        ((@Type = 0) OR
         (@Type = 1 AND PP.NgayTra IS NULL) OR
         (@Type = 2 AND PP.NgayTra IS NOT NULL))
);

GO
/****** Object:  View [dbo].[VW_TacGia_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Tác Giả list (Văn)		***/
CREATE VIEW [dbo].[VW_TacGia_List] AS
SELECT *
FROM dbo.TacGia

GO
/****** Object:  UserDefinedFunction [dbo].[FN_Reader_Borrowed_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*** Get reader borrowed coupon list (Phat)***/
CREATE FUNCTION [dbo].[FN_Reader_Borrowed_List]
(
    @MaTaiKhoan int,
    @Type int -- 0: All, 1: Not Returned, 2: Returned
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        MaPhieuMuon AS N'Mã phiếu mượn',
        NgayMuon AS N'Ngày mượn',
        NgayTra AS N'Ngày trả sách'
    FROM dbo.PhieuMuonSach
    WHERE 
        MaTaiKhoan = @MaTaiKhoan AND
        ((@Type = 0) OR
         (@Type = 1 AND NgayTra IS NULL) OR
         (@Type = 2 AND NgayTra IS NOT NULL))
);

GO
/****** Object:  View [dbo].[VW_PhieuPhat_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get PhieuPhat list (Hoan)		***/
CREATE VIEW [dbo].[VW_PhieuPhat_List] AS
SELECT PP.MaPhieuPhat, PP.MaPhieuMuon,PP.NgayTra,PMS.MaTaiKhoan,PMS.NgayTra AS NgayTraSach
FROM dbo.PhieuPhat PP
JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon= PP.MaPhieuMuon

GO
/****** Object:  View [dbo].[VW_Book_Loan_Coupon_List]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Book Loan Coupon list (Trung)		***/
Create VIEW [dbo].[VW_Book_Loan_Coupon_List] AS
SELECT 
	*
FROM dbo.PhieuMuonSach 







GO
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (1, 1, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (1, 2, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (1, 4, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (2, 1, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (2, 2, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (3, 3, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (4, 3, N'Đang mượn')
INSERT [dbo].[CuonSach] ([MaSach], [MaPhieuMuon], [TinhTrang]) VALUES (4, 4, N'Đang mượn')
GO
SET IDENTITY_INSERT [dbo].[LichLamViec] ON 

INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (1, CAST(N'2024-05-06' AS Date), N'Sáng', 21110862)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (2, CAST(N'2024-05-07' AS Date), N'Sáng', 21110862)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (3, CAST(N'2024-05-08' AS Date), N'Sáng', 21110862)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (4, CAST(N'2024-05-09' AS Date), N'Sáng', 21110862)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (5, CAST(N'2024-05-10' AS Date), N'Sáng', 21110862)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (6, CAST(N'2024-05-06' AS Date), N'Chiều', 21110827)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (7, CAST(N'2024-05-07' AS Date), N'Chiều', 21110827)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (8, CAST(N'2024-05-08' AS Date), N'Chiều', 21110827)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (9, CAST(N'2024-05-09' AS Date), N'Chiều', 21110827)
INSERT [dbo].[LichLamViec] ([MaLichLamViec], [NgayLam], [Ca], [MaTaiKhoan]) VALUES (10, CAST(N'2024-05-10' AS Date), N'Chiều', 21110827)
SET IDENTITY_INSERT [dbo].[LichLamViec] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaXuatBan] ON 

INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (1, N'Đại học quốc gia TP.Hồ Chí Minh')
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (2, N'Đại học quốc gia Hà Nội')
INSERT [dbo].[NhaXuatBan] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (3, N'Xây Dựng')
SET IDENTITY_INSERT [dbo].[NhaXuatBan] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuMuonSach] ON 

INSERT [dbo].[PhieuMuonSach] ([MaPhieuMuon], [MaTaiKhoan], [NgayMuon], [NgayTra]) VALUES (1, 20113536, CAST(N'2024-04-03' AS Date), NULL)
INSERT [dbo].[PhieuMuonSach] ([MaPhieuMuon], [MaTaiKhoan], [NgayMuon], [NgayTra]) VALUES (2, 20110535, CAST(N'2023-08-04' AS Date), NULL)
INSERT [dbo].[PhieuMuonSach] ([MaPhieuMuon], [MaTaiKhoan], [NgayMuon], [NgayTra]) VALUES (3, 21110333, CAST(N'2023-08-05' AS Date), NULL)
INSERT [dbo].[PhieuMuonSach] ([MaPhieuMuon], [MaTaiKhoan], [NgayMuon], [NgayTra]) VALUES (4, 20110556, CAST(N'2024-04-02' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[PhieuMuonSach] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([MaSach], [MaTacGia], [MaTheLoai], [MaNhaXuatBan], [TenSach], [LoaiTaiLieu], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (1, 1, 1, 1, N'Luyện kim - Cơ khí', N'Giáo Trình', 2013, CAST(75000 AS Decimal(18, 0)), 6)
INSERT [dbo].[Sach] ([MaSach], [MaTacGia], [MaTheLoai], [MaNhaXuatBan], [TenSach], [LoaiTaiLieu], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (2, 2, 2, 1, N'Luật chứng khoán', N'Giáo Trình', 2023, CAST(48000 AS Decimal(18, 0)), 7)
INSERT [dbo].[Sach] ([MaSach], [MaTacGia], [MaTheLoai], [MaNhaXuatBan], [TenSach], [LoaiTaiLieu], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (3, 3, 3, 2, N'Trị liệu tâm lý', N'Sách tham khảo', 2023, CAST(92000 AS Decimal(18, 0)), 9)
INSERT [dbo].[Sach] ([MaSach], [MaTacGia], [MaTheLoai], [MaNhaXuatBan], [TenSach], [LoaiTaiLieu], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (4, 4, 4, 3, N'Tính toán cầu đúc hẫng trên phần mềm Midas', N'Sách tham khảo', 2018, CAST(68000 AS Decimal(18, 0)), 8)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (1, N'Lê Chí Cương')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (2, N'Viên Thế Giang')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (3, N'Nguyễn Công Khanh')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (4, N'Nguyễn Viết Trung')
SET IDENTITY_INSERT [dbo].[TacGia] OFF
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (20110535, N'20110535@hcmute.edu.vn.com', N'bbbbbbbb', N'Sinh viên đại trà', N'Trần Trung Kiên', N'0183455789', CAST(N'2002-01-12' AS Date), N'Hà Nội', N'Nữ')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (20110536, N'20110536@hcmute.edu.vn.com', N'zzzzzzzz', N'Quản trị viên', N'Trần Trung Phát', N'0183476789', CAST(N'2002-01-01' AS Date), N'Hồ Chí Minh', N'Nam')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (20110556, N'20110556@hcmute.edu.vn.com', N'mmmmmmmm', N'Giảng viên', N'Lê Thị Bùi', N'0113456789', CAST(N'2002-10-01' AS Date), N'Hồ Chí Minh', N'Nữ')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (20113536, N'20113536@hcmute.edu.vn.com', N'nnnnnnnn', N'Học viên cao học', N'Nguyễn Quốc Quân', N'0183456289', CAST(N'2002-11-01' AS Date), N'Nha Trang', N'Nam')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (21110333, N'21110333@hcmute.edu.vn.com', N'vvvvvvvv', N'Sinh viên CLC', N'Đoàn Nguyễn Nam Trung', N'0183356789', CAST(N'2003-04-03' AS Date), N'vũng Tàu', N'Nam')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (21110827, N'21110827@hcmute.edu.vn.com', N'cccccccc', N'Thủ thư', N'Trần Khải Hoàn', N'0188456789', CAST(N'2003-01-06' AS Date), N'Đắc Lắc', N'Nam')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [Email], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [NgaySinh], [DiaChi], [GioiTinh]) VALUES (21110862, N'21110862@hcmute.edu.vn.com', N'xxxxxxxx', N'Thủ thư', N'Lê Quốc Văn', N'0183456799', CAST(N'2003-05-01' AS Date), N'Quy Nhơn', N'Nam')
GO
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Khoa học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Pháp luật')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'Sức khỏe')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (4, N'Công nghệ thông tin')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__A9D10534DDDE5A29]    Script Date: 29/04/2024 11:58:24 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PhieuMuonSach] ADD  DEFAULT (getdate()) FOR [NgayMuon]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuonSach] ([MaPhieuMuon])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH NOCHECK ADD FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuPhat]  WITH CHECK ADD FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuonSach] ([MaPhieuMuon])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaNhaXuatBan])
REFERENCES [dbo].[NhaXuatBan] ([MaNhaXuatBan])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD CHECK  (([NgayLam]>=CONVERT([date],getdate())))
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH NOCHECK ADD CHECK  ((CONVERT([date],[NgayMuon])=CONVERT([date],getdate())))
GO
ALTER TABLE [dbo].[PhieuPhat]  WITH CHECK ADD CHECK  (([TienPhat]>=(0)))
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD CHECK  (([GiaSach]>=(0)))
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD CHECK  (([NamXuatBan]>=(0) AND [NamXuatBan]<=datepart(year,getdate())))
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD CHECK  (([SoLuong]>=(0)))
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD CHECK  ((len([MatKhau])>=(8)))
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD CHECK  ((datediff(year,[NgaySinh],getdate())>=(18)))
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD CHECK  ((len([SoDienThoai])=(10)))
GO
/****** Object:  StoredProcedure [dbo].[SP_Account_Profile]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update profile(Phat)		***/
CREATE PROCEDURE [dbo].[SP_Account_Profile]
	@MaTaiKhoan int,
    @HoTen nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh date,
	@SoDienThoai nvarchar(10),
    @GioiTinh nvarchar(10)
AS
BEGIN
    BEGIN TRY
            UPDATE dbo.TaiKhoan
				SET HoTen = @HoTen,
					DiaChi = @DiaChi,
					NgaySinh = @NgaySinh,
					GioiTinh = @GioiTinh,
					SoDienThoai = @SoDienThoai
			 WHERE MaTaiKhoan = @MaTaiKhoan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_Books_To_Coupon]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add Books To Coupon (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Add_Books_To_Coupon]
(
	@MaSach int,
	@MaPhieuMuon int
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.CuonSach(MaSach, MaPhieuMuon, TinhTrang)
		VALUES (@MaSach, @MaPhieuMuon, N'Đang mượn')
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_Account]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add New Account(Phat)		***/
CREATE PROCEDURE [dbo].[SP_Add_New_Account]
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
    BEGIN TRY
        INSERT INTO dbo.TaiKhoan (MaTaiKhoan, HoTen, MatKhau, DiaChi, Email, NgaySinh, SoDienThoai, VaiTro, GioiTinh)
        VALUES (@MaTaiKhoan, @HoTen, @MatKhau, @DiaChi, @Email, @NgaySinh,@SoDienThoai, @VaiTro, @GioiTinh);       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_Book]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add New Book(Van)		***/
CREATE   PROCEDURE [dbo].[SP_Add_New_Book]
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
    BEGIN TRY
        INSERT INTO dbo.Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
        VALUES (@MaTacGia, @MaTheLoai, @MaNhaXuatBan, @TenSach, @LoaiTaiLieu, @NamXuatBan, @GiaSach, @SoLuong);
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_Book_Loan_Coupon]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add New Book Loan Coupon(Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Add_New_Book_Loan_Coupon]
    @MaTaiKhoan int = NULL,
    @NgayMuon date = NULL,
    @NgayTra date = NULL
AS
BEGIN
    BEGIN TRY
		DECLARE @InsertedID INT;

        INSERT INTO dbo.PhieuMuonSach (MaTaiKhoan, NgayMuon, NgayTra)
        VALUES (@MaTaiKhoan, @NgayMuon, @NgayTra);

        SET @InsertedID = SCOPE_IDENTITY();
		SELECT @InsertedID AS InsertedID;
 
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_NXB]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add NXB (Trung)		***/

CREATE   PROCEDURE [dbo].[SP_Add_New_NXB]
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.NhaXuatBan(TenNhaXuatBan)
        VALUES (@TenNhaXuatBan);
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_PhieuPhat]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Thêm phiếu phạt (Hoàn) */
CREATE   PROCEDURE [dbo].[SP_Add_New_PhieuPhat]
    @MaPhieuMuon int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		UPDATE dbo.PhieuMuonSach
		SET NgayTra = GETDATE()
		WHERE MaPhieuMuon = @MaPhieuMuon

		UPDATE dbo.CuonSach
		SET TinhTrang = N'Đã trả'
		WHERE MaPhieuMuon = @MaPhieuMuon AND TinhTrang = N'Đang mượn'

		DECLARE @TienPhat DECIMAL(18, 0) = dbo.FN_Calculate_Penalty_Value(@MaPhieuMuon);        
		INSERT INTO dbo.PhieuPhat (MaPhieuMuon, TienPhat)
        VALUES (@MaPhieuMuon, @TienPhat);
		
        COMMIT;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_Schedule]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add new schedule (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Add_New_Schedule]
(
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.LichLamViec(NgayLam, Ca, MaTaiKhoan)
        VALUES (@NgayLam , @Ca , @MaTaiKhoan );       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_New_TheLoai]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Thêm thể loại (Hoàn) */
CREATE   PROCEDURE [dbo].[SP_Add_New_TheLoai]
    @TenTheLoai nvarchar(50)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.TheLoai (TenTheLoai)
        VALUES (@TenTheLoai);
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Add_Tac_Gia]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Add Tác Giả(Van)		***/
CREATE   PROCEDURE [dbo].[SP_Add_Tac_Gia]
    @TenTacGia NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.TacGia (TenTacGia)
        VALUES (@TenTacGia);
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Change_Account_Password]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Change password(Phat)		***/
CREATE PROCEDURE [dbo].[SP_Change_Account_Password]
(
    @Email NVARCHAR(255),
    @MatKhauMoi NVARCHAR(255),
	@XacNhan NVARCHAR(255),
	@MatKhauCu NVARCHAR(255)
)
AS 
BEGIN
	IF NOT EXISTS (SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhauCu)
    BEGIN
        RAISERROR('Email hoặc mật khẩu cũ không đúng', 16, 1);
		RETURN;
    END

	IF @MatKhauMoi <> @XacNhan
    BEGIN
        RAISERROR('Mật khẩu mới và xác nhận không khớp', 16, 1);
		RETURN;
    END

    BEGIN TRY
            UPDATE dbo.TaiKhoan
			SET MatKhau = @MatKhauMoi
			WHERE Email = @Email;      
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Account]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete account(Phat)		  ***/
CREATE PROCEDURE [dbo].[SP_Delete_Account]
    @MaTaiKhoan int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan;       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Book]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete account(Van)		***/
CREATE   PROCEDURE [dbo].[SP_Delete_Book]
    @MaSach int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.Sach WHERE MaSach = @MaSach;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Coupon]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete coupon(Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Delete_Coupon]
    @MaPhieuMuon int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		UPDATE S
		SET S.SoLuong = S.SoLuong + 1
		FROM dbo.CuonSach CS
		JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon = CS.MaPhieuMuon
		JOIN dbo.Sach S ON CS.MaSach = S.MaSach
		WHERE CS.MaPhieuMuon = @MaPhieuMuon AND NgayTra IS NULL;

        DELETE FROM dbo.PhieuMuonSach
        WHERE MaPhieuMuon = @MaPhieuMuon
        
        COMMIT;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_NXB]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete NXB (Trung)		***/
CREATE   PROCEDURE [dbo].[SP_Delete_NXB]
	@MaNhaXuatBan INT,
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
			Delete From dbo.NhaXuatBan
			Where MaNhaXuatBan = @MaNhaXuatBan And TenNhaXuatBan = @TenNhaXuatBan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_PhieuPhat]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Xoá phiếu phạt (Hoàn) */
CREATE   PROCEDURE [dbo].[SP_Delete_PhieuPhat]
    @MaPhieuPhat int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.PhieuPhat WHERE MaPhieuPhat = @MaPhieuPhat;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Schedule]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete schedule (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Delete_Schedule]
(
	@MaLichLamViec int
)
AS
BEGIN
    BEGIN TRY
        DELETE dbo.LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_TacGia]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete account(Van)		***/
CREATE   PROCEDURE [dbo].[SP_Delete_TacGia]
    @MaTacGia int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.TacGia WHERE MaTacGia = @MaTacGia;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_TheLoai]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Xoá thể loại (Hoàn) */
CREATE   PROCEDURE [dbo].[SP_Delete_TheLoai]
    @MaTheLoai int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.TheLoai WHERE MaTheLoai = @MaTheLoai;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_Account_Book_Loan_Coupon]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Find Book Loan Coupon (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Find_Account_Book_Loan_Coupon]
(
	@MaTaiKhoan int
)
AS
BEGIN
	SELECT 
		*
	FROM dbo.PhieuMuonSach 
	WHERE MaTaiKhoan = @MaTaiKhoan
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_Account_By_Advanced]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Find account by advanced (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Find_Account_By_Advanced]
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
/****** Object:  StoredProcedure [dbo].[SP_Find_Book_By_Advanced]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Find account by advanced (Van)		***/
CREATE   PROCEDURE [dbo].[SP_Find_Book_By_Advanced]
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
		(@TenSach IS NULL OR TenSach LIKE '%' + @TenSach + '%') AND
		(@LoaiTaiLieu IS NULL OR @LoaiTaiLieu = LoaiTaiLieu) AND
		(@NamXuatBan IS NULL OR @NamXuatBan = NamXuatBan)
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_Book_Loan_Coupon_By_Status]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Find Book Loan Coupon by status (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Find_Book_Loan_Coupon_By_Status]
(
	@type int
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Book_Loan_Coupon_List
	WHERE 
		(@type = 0 AND NgayTra IS NULL) OR
		(@type = 1 AND NgayTra IS NOT NULL)
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_NXB]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Find NXB (Trung)		***/
CREATE   PROCEDURE [dbo].[SP_Find_NXB]
(
	@TenNhaXuatBan NVARCHAR(255)
)
AS
BEGIN
	SELECT 
		*
	FROM VW_NXB_List
	WHERE TenNhaXuatBan LIKE '%' + @TenNhaXuatBan + '%'
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_PhieuPhat]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Tìm kiếm phiếu phạt (Hoàn)*/
CREATE   PROCEDURE [dbo].[SP_Find_PhieuPhat]
(
    @MaTaiKhoan int 
)
AS
BEGIN
	SELECT 
		PP.MaPhieuPhat, PP.MaPhieuMuon, PP.TienPhat, PP.NgayTra
	FROM dbo.PhieuPhat PP 
	JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon = PP.MaPhieuMuon
	WHERE PMS.MaTaiKhoan = @MaTaiKhoan
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_TacGia]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Find TacGia by advanced (Van)		***/
CREATE   PROCEDURE [dbo].[SP_Find_TacGia]
(
	@TenTacGia NVARCHAR(255) = NULL
)
AS
BEGIN
	SELECT * FROM VW_TacGia_List WHERE @TenTacGia LIKE '%' + TenTacGia + '%'
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Find_TheLoai]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Tìm kiếm thể loại (Hoàn)*/
CREATE   PROCEDURE [dbo].[SP_Find_TheLoai]
(
    @TenTheLoai nvarchar(50) = NULL
)
AS
BEGIN
	SELECT * FROM VW_TheLoai_List WHERE TenTheLoai LIKE '%' + @TenTheLoai + '%' 
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Account_Profile]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get login account profile(Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Get_Account_Profile]
(@Email nvarchar(255))
AS
BEGIN
    SELECT *
    FROM TaiKhoan
    WHERE Email = @Email
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Penalty_Coupon_By_Status]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get Book Penalty Coupon by status (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Get_Penalty_Coupon_By_Status]
(
	@type int
)
AS
BEGIN
	SELECT 
		*
	FROM VW_PhieuPhat_List
	WHERE 
		(@type = 0 AND NgayTra IS NULL) OR
		(@type = 1 AND NgayTra IS NOT NULL)
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Schedule]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Get schedule (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Get_Schedule]
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
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Login Account (Phat)		***/
CREATE PROCEDURE [dbo].[SP_Login]
    @Email NVARCHAR(255),
    @MatKhau NVARCHAR(255)
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau
END;


GO
/****** Object:  StoredProcedure [dbo].[SP_Pay_Penalty_Coupon_Debt]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Trả nợ phiếu phạt (Phát) */
CREATE   PROCEDURE [dbo].[SP_Pay_Penalty_Coupon_Debt]
    @MaPhieuPhat int
AS
BEGIN
    BEGIN TRY
		UPDATE dbo.PhieuPhat
		SET NgayTra = GETDATE()
		WHERE MaPhieuPhat = @MaPhieuPhat
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;


GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Account]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update account(Phat)		***/
CREATE PROCEDURE [dbo].[SP_Update_Account]
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
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Book]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update Book(Van)		***/
CREATE   PROCEDURE [dbo].[SP_Update_Book]
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
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Book_In_Coupon]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update Book In Coupon (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Update_Book_In_Coupon]
(
	@MaPhieuMuon int,
	@MaSach int,
	@TinhTrang nvarchar(255)
)
AS
BEGIN
    BEGIN TRY
        UPDATE dbo.CuonSach
		SET TinhTrang = @TinhTrang
		WHERE MaSach = @MaSach AND MaPhieuMuon = @MaPhieuMuon
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Coupon]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update coupon(Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Update_Coupon]
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
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Coupon_Returned]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update coupon _ Returned(Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Update_Coupon_Returned]
    @MaPhieuMuon INT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM dbo.CuonSach CS
		JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon = CS.MaPhieuMuon
        JOIN dbo.Sach S ON CS.MaSach = S.MaSach
        JOIN dbo.TaiKhoan TK ON TK.MaTaiKhoan = PMS.MaTaiKhoan
        WHERE CS.MaPhieuMuon = @MaPhieuMuon 
            AND (CS.TinhTrang = N'Đang mượn')
            AND (
                (TK.VaiTro = N'Sinh viên CLC' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 21) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 105)
                ))
                OR 
                (TK.VaiTro = N'Sinh viên đại trà' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 21) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 105)
                ))
                OR 
                (TK.VaiTro = N'Học viên cao học' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 32) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 56)
                ))
                OR 
                (TK.VaiTro = N'Giảng viên' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 365) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 365)
                ))
            )
    )
    BEGIN
		RAISERROR(N'Người này đang giữ sách quá hạn trả.', 16, 1)
        RETURN;
    END

    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE S
        SET S.SoLuong = S.SoLuong + 1
        FROM dbo.CuonSach CS
        JOIN dbo.Sach S ON CS.MaSach = S.MaSach
        WHERE CS.MaPhieuMuon = @MaPhieuMuon AND (CS.TinhTrang = N'Đã trả' OR CS.TinhTrang = N'Trả trễ');

        UPDATE dbo.PhieuMuonSach
        SET NgayTra = GETDATE()
        WHERE MaPhieuMuon = @MaPhieuMuon;

        COMMIT;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;


GO
/****** Object:  StoredProcedure [dbo].[SP_Update_NXB]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update NXB (Trung)		***/
CREATE   PROCEDURE [dbo].[SP_Update_NXB]
	@MaNhaXuatBan INT,
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
		UPDATE dbo.NhaXuatBan
			Set	TenNhaXuatBan = @TenNhaXuatBan
			Where MaNhaXuatBan = @MaNhaXuatBan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_PhieuPhat]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Sửa phiếu phạt (Hoàn)*/
CREATE   PROCEDURE [dbo].[SP_Update_PhieuPhat]
	@MaPhieuPhat int,
    @MaPhieuMuon int,
	@TienPhat decimal,
    @NgayTra date = NULL
AS
BEGIN
    BEGIN TRY
            UPDATE	dbo.PhieuPhat
				SET MaPhieuMuon = @MaPhieuMuon,
					TienPhat = @TienPhat,
					NgayTra = @NgayTra
			 WHERE	MaPhieuPhat = @MaPhieuPhat;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Schedule]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update schedule (Phat)		***/
CREATE   PROCEDURE [dbo].[SP_Update_Schedule]
(
	@MaLichLamViec int,
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
    BEGIN TRY
        Update dbo.LichLamViec
        SET NgayLam = @NgayLam,
			Ca = @Ca , 
			MaTaiKhoan = @MaTaiKhoan 
		WHERE MaLichLamViec = @MaLichLamViec
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Tac_Gia]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update Tác Giả(Van)		***/
CREATE   PROCEDURE [dbo].[SP_Update_Tac_Gia]
    @MaTacGia INT,
    @TenTacGia NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
		UPDATE dbo.TacGia SET TenTacGia = @TenTacGia WHERE MaTacGia = @MaTacGia;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_TheLoai]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Sửa thể loại (Hoàn)*/
CREATE   PROCEDURE [dbo].[SP_Update_TheLoai]
	@MaTheLoai int,
    @TenTheLoai nvarchar(50)
AS
BEGIN
    BEGIN TRY
            UPDATE dbo.TheLoai
				SET TenTheLoai = @TenTheLoai
			 WHERE MaTheLoai = @MaTheLoai;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/****** Object:  Trigger [dbo].[TR_Not_Update_Books_Quantity_After_Borrowed]    Script Date: 29/04/2024 11:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update book quantity if borrowed (Phat)		***/
CREATE TRIGGER [dbo].[TR_Not_Update_Books_Quantity_After_Borrowed]
ON [dbo].[CuonSach]
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
ALTER TABLE [dbo].[CuonSach] ENABLE TRIGGER [TR_Not_Update_Books_Quantity_After_Borrowed]
GO
/****** Object:  Trigger [dbo].[TR_Limit_Working_Hours]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Librarian not working over 48h/week (Phat)		***/
CREATE TRIGGER [dbo].[TR_Limit_Working_Hours]
ON [dbo].[LichLamViec]
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
ALTER TABLE [dbo].[LichLamViec] ENABLE TRIGGER [TR_Limit_Working_Hours]
GO
/****** Object:  Trigger [dbo].[TR_Not_Duplicate_Working_Days]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	An Librarian can not duplicate Working day(Phat)		***/
CREATE TRIGGER [dbo].[TR_Not_Duplicate_Working_Days]
ON [dbo].[LichLamViec]
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
ALTER TABLE [dbo].[LichLamViec] ENABLE TRIGGER [TR_Not_Duplicate_Working_Days]
GO
/****** Object:  Trigger [dbo].[TR_Prevent_Publisher_Duplicate]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Trigger Check Duplicates_NXB(Trung)--
CREATE   TRIGGER [dbo].[TR_Prevent_Publisher_Duplicate]
ON [dbo].[NhaXuatBan]
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
ALTER TABLE [dbo].[NhaXuatBan] ENABLE TRIGGER [TR_Prevent_Publisher_Duplicate]
GO
/****** Object:  Trigger [dbo].[TR_Prevent_Borrowed_Situations]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Trigger Prevent Borrow Book by Situations (Phat)	***/
CREATE   TRIGGER [dbo].[TR_Prevent_Borrowed_Situations]
ON [dbo].[PhieuMuonSach]
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
ALTER TABLE [dbo].[PhieuMuonSach] ENABLE TRIGGER [TR_Prevent_Borrowed_Situations]
GO
/****** Object:  Trigger [dbo].[TR_Prevent_return_date_update]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Trigger không cho tạo, cập nhật ngày trả nợ < ngày trả sách*/
CREATE TRIGGER [dbo].[TR_Prevent_return_date_update]
ON [dbo].[PhieuPhat]
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
ALTER TABLE [dbo].[PhieuPhat] ENABLE TRIGGER [TR_Prevent_return_date_update]
GO
/****** Object:  Trigger [dbo].[TR_Prevent_duplicate_Book]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Trigger không cho tạo, cập nhật sách trùng*/
CREATE TRIGGER [dbo].[TR_Prevent_duplicate_Book]
ON [dbo].[Sach]
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
ALTER TABLE [dbo].[Sach] ENABLE TRIGGER [TR_Prevent_duplicate_Book]
GO
/****** Object:  Trigger [dbo].[TR_Prevent_duplicate_Author]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Trigger không cho tạo, cập nhật tác giả trùng (Phat)*/
CREATE TRIGGER [dbo].[TR_Prevent_duplicate_Author]
ON [dbo].[TacGia]
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
ALTER TABLE [dbo].[TacGia] ENABLE TRIGGER [TR_Prevent_duplicate_Author]
GO
/****** Object:  Trigger [dbo].[TR_Create_SQL_Server_Account]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Create SQL Server account (Phat)		***/
CREATE TRIGGER [dbo].[TR_Create_SQL_Server_Account]
ON [dbo].[TaiKhoan]
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
ALTER TABLE [dbo].[TaiKhoan] ENABLE TRIGGER [TR_Create_SQL_Server_Account]
GO
/****** Object:  Trigger [dbo].[TR_Delete_SQL_Server_Account]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Delete SQL Server account (Phat)		***/
CREATE TRIGGER [dbo].[TR_Delete_SQL_Server_Account]
ON [dbo].[TaiKhoan]
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


GO
ALTER TABLE [dbo].[TaiKhoan] ENABLE TRIGGER [TR_Delete_SQL_Server_Account]
GO
/****** Object:  Trigger [dbo].[TR_Not_Duplicate_Phone_Number]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Not duplicate phone number (Phat)		***/
CREATE TRIGGER [dbo].[TR_Not_Duplicate_Phone_Number]
ON [dbo].[TaiKhoan]
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
ALTER TABLE [dbo].[TaiKhoan] ENABLE TRIGGER [TR_Not_Duplicate_Phone_Number]
GO
/****** Object:  Trigger [dbo].[TR_Update_SQL_Server_Account]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***	Update SQL Server account (Phat)		***/
CREATE TRIGGER [dbo].[TR_Update_SQL_Server_Account]
ON [dbo].[TaiKhoan]
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
ALTER TABLE [dbo].[TaiKhoan] ENABLE TRIGGER [TR_Update_SQL_Server_Account]
GO
/****** Object:  Trigger [dbo].[TR_Prevent_duplicate_category]    Script Date: 29/04/2024 11:58:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Trigger không cho tạo, cập nhật thể loại trùng*/
CREATE TRIGGER [dbo].[TR_Prevent_duplicate_category] 
ON [dbo].[TheLoai]
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
ALTER TABLE [dbo].[TheLoai] ENABLE TRIGGER [TR_Prevent_duplicate_category]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
