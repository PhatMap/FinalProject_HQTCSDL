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

