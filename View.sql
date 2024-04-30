/***	Get account list (Phat)		***/
CREATE VIEW VW_Account_List AS
SELECT 	
	*
FROM dbo.TaiKhoan 

GO
/***	Get shift list (Phat)		***/
CREATE VIEW VW_Schedule_List AS
SELECT 
	MaLichLamViec, NgayLam, Ca, Tk.MaTaiKhoan, TK.HoTen, TK.SoDienThoai, TK.GioiTinh
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
/***	Get Sách list (Văn)		***/
CREATE VIEW VW_Book_List AS
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
/***	Get Nhà Xuất Bản list (Văn)		***/
CREATE VIEW VW_NhaXuatBan_List AS
SELECT *
FROM dbo.NhaXuatBan

GO
/***	Get Thể Loại list (Hoàn)		***/
CREATE VIEW VW_TheLoai_List AS
SELECT *
FROM dbo.TheLoai

GO
/***	Get Tác Giả list (Văn)		***/
CREATE VIEW VW_TacGia_List AS
SELECT *
FROM dbo.TacGia

GO
/***	Get PhieuPhat list (Hoan)		***/
CREATE VIEW VW_PhieuPhat_List AS
SELECT PP.MaPhieuPhat, PP.MaPhieuMuon,PP.TienPhat,PP.NgayTra,PMS.MaTaiKhoan,PMS.NgayTra AS NgayTraSach
FROM dbo.PhieuPhat PP
JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon= PP.MaPhieuMuon

GO
/***	Get Book Loan Coupon list (Trung)		***/
Create VIEW VW_Book_Loan_Coupon_List AS
SELECT 
	*
FROM dbo.PhieuMuonSach 







