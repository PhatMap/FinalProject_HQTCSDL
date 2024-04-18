/*** Hàm lấy số lượng sách đang hiện hữu (Phat)***/
CREATE FUNCTION FN_Total_Available_Books()
RETURNS TABLE
AS
RETURN (
	SELECT SUM(DISTINCT SoLuong) AS Total_Available 
	FROM dbo.Sach
);

GO
/*** Hàm lấy số lượng sách đang mượn (Phat)***/
CREATE FUNCTION FN_Total_Borrowed_Books()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Borrowed 
	FROM dbo.CuonSach
	WHERE TinhTrang = N'Đang mượn'
);

GO
/*** Hàm lấy số lượng sách bị hư hoặc mất (Phat)***/
CREATE FUNCTION FN_Total_Damaged_Or_Lost_Books()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Damaged_Or_Lost 
	FROM dbo.CuonSach
	WHERE TinhTrang = N'Hư' OR TinhTrang = N'Mất'
);

GO
/*** Hàm lấy số lượng tất cả sách (Phat)***/
CREATE FUNCTION FN_Total_Books()
RETURNS TABLE
AS
RETURN (
	SELECT 
    (SELECT SUM(Total_Available) FROM FN_Total_Available_Books()) +
    (SELECT SUM(Total_Borrowed) FROM FN_Total_Borrowed_Books()) +
    (SELECT SUM(Total_Damaged_Or_Lost) FROM FN_Total_Damaged_Or_Lost_Books()) AS Total_All
);

GO
/*** Hàm lấy số lượng tất cả tác giả (Phat)***/
CREATE FUNCTION FN_Total_Authors()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Authors
	FROM dbo.TacGia
);

GO
/*** Hàm lấy số lượng tất cả nhà xuất bản (Phat)***/
CREATE FUNCTION FN_Total_Publishers()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Publishers
	FROM dbo.NhaXuatBan
);

GO
/*** Hàm lấy số lượng tất cả thể loại (Phat)***/
CREATE FUNCTION FN_Total_Categories()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Categories
	FROM dbo.TheLoai
);

GO
/*** Hàm lấy số lượng tất cả phiếu mượn (Phat)***/
CREATE FUNCTION FN_Total_Loan_Coupons_By_Month
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


GO
/*** Hàm lấy số lượng tất cả phiếu phạt (Phat)***/
CREATE FUNCTION FN_Total_Penalty_Coupons_By_Month
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

GO
/*** Hàm lấy số lượng tất cả tài khoản (Phat)***/
CREATE FUNCTION FN_Total_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Accounts
	FROM dbo.TaiKhoan
);

GO
/*** Hàm lấy số lượng tất cả tài khoản sinh viên CLC(Phat)***/
CREATE FUNCTION FN_Total_High_Quality_Student_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_High_Quality_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Sinh viên CLC'
);

GO
/*** Hàm lấy số lượng tất cả tài khoản sinh viên đại trà(Phat)***/
CREATE FUNCTION FN_Total_Mass_Student_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Mass_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Sinh viên đại trà'
);

GO
/*** Hàm lấy số lượng tất cả Học viên cao học (Phat)***/
CREATE FUNCTION FN_Total_Graduate_Student_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Graduate_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Học viên cao học'
);

GO
/*** Hàm lấy số lượng tất cả tài khoản Giảng viên (Phat)***/
CREATE FUNCTION FN_Total_Lecturer_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Lecturer_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Giảng viên'
);

GO
/*** Hàm lấy số lượng tất cả tài khoản Thủ thư (Phat)***/
CREATE FUNCTION FN_Total_Librarian_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Librarian_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Thủ thư'
);

GO
/*** Hàm lấy số lượng tất cả tài khoản Quản trị viên (Phat)***/
CREATE FUNCTION FN_Total_Administrator_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Administrator_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Quản trị viên'
);

GO
/***	Get reader borrowed coupon list detail (Phat)		***/
CREATE FUNCTION FN_Reader_Borrowed_Detail
(
    @MaPhieuMuon int = NULL,
    @MaPhieuPhat int = NULL
)
RETURNS TABLE
AS
RETURN (
    SELECT 
		TenSach AS N'Tên sách',
		TenTacGia AS N'Tác giả',
		TenTheLoai AS N'Thể loại',
		TenNhaXuatBan AS N'Nhà xuất bản',
		LoaiTaiLieu AS N'Loại tài liệu',
		NamXuatBan AS N'Năm xuất bản',
		CS.TinhTrang AS N'Tình trạng'
    FROM dbo.CuonSach CS
    JOIN dbo.VW_Book_List S ON S.MaSach = CS.MaSach
    WHERE 
        (@MaPhieuMuon IS NOT NULL AND CS.MaPhieuMuon = @MaPhieuMuon) OR 
        (@MaPhieuPhat IS NOT NULL AND CS.MaPhieuMuon = 
		(SELECT MaPhieuMuon FROM dbo.PhieuPhat WHERE MaPhieuPhat = @MaPhieuPhat))
);

GO
/*** Get reader penalty coupon list ***/
CREATE FUNCTION FN_Reader_Penalty_List
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
/*** Get reader borrowed coupon list ***/
CREATE FUNCTION FN_Reader_Borrowed_List
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
