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
/***	Get Tác Giả list (Văn)		***/
CREATE VIEW VW_TacGia_List AS
SELECT *
FROM dbo.TacGia

GO
/***	Get Nhà Xuất Bản list (Văn)		***/
CREATE VIEW VW_NhaXuatBan_List AS
SELECT *
FROM dbo.NhaXuatBan

/***	Get Thể Loại list (Văn)		***/
CREATE VIEW VW_TheLoai_List AS
SELECT *
FROM dbo.TheLoai

/***	Get Tác Giả list (Văn)		***/
CREATE VIEW VW_TacGia_List AS
SELECT *
FROM dbo.TacGia
