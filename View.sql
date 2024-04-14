/***	Get account list (Phat)		***/
CREATE VIEW VW_Account_List AS
SELECT 	
	*
FROM dbo.TaiKhoan 

GO
/***	Get shift list (Phat)		***/
CREATE VIEW VW_Shift_List AS
SELECT 
	MaLichLamViec, NgayLam, Ca, TK.HoTen, TK.SoDienThoai, TK.GioiTinh
FROM dbo.LichLamViec LLV
JOIN dbo.TaiKhoan TK ON TK.MaTaiKhoan = LLV.MaTaiKhoan

GO
/***	Get Librarian list (Phat)		***/
CREATE VIEW VW_Librarian_List AS
SELECT 
	MaTaiKhoan, 
	HoTen 
FROM dbo.TaiKhoan
WHERE VaiTro = N'Thủ thư'

GO
/***	Get Book Loan Coupon list (Trung)		***/
Create VIEW VW_BookLoanCoupon_List AS
SELECT 
	PM.MaPhieuMuon,
	S.MaSach,
	MaTaiKhoan,
	S.TinhTrang,
	NgayMuon,
	NgayTra
FROM dbo.PhieuMuonSach PM
Join dbo.CuonSach S ON PM.MaPhieuMuon = S.MaPhieuMuon

GO
/***	Get Genre list (Trung)		***/
Create VIEW VW_Genre_List AS
SELECT 
	MaTheLoai,
	TenTheLoai
FROM dbo.TheLoai

GO
