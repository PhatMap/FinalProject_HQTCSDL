/*** Tạo tất cả các bảng ***/
EXEC SP_Create_All_Tables

/*** Nhập dữ liệu tất cả các bảng	***/
EXEC SP_Insert_All_Tables_Data 

/*** Xóa bảng cùng lúc -> Nhớ bấm liên tục cho hết đỏ thì thôi ***/
EXEC SP_Drop_All_Tables  @mode = 1

/*** Xem dữ liệu đã nhập tất cả các bảng cùng lúc ***/
EXEC SP_Select_All_Records_From_All_Tables

/***	Hiện hết Store Procedure, Function, Trigger, View	***/
EXEC SP_Select_All_SP_FN_TR_VW

/***	Gỡ hết Store Procedure	***/
EXEC SP_Drop_All_SP

/***	Không gỡ Store Procedure đánh dấu	***/
EXEC SP_Drop_SP_Marked

/***	Gỡ hết Function	***/
EXEC SP_Drop_All_FN

/***	Gỡ hết Trigger	***/
EXEC SP_Drop_All_TR

/***	Gỡ hết View	***/
EXEC SP_Drop_All_VW

DROP ROLE ThuThu
DROP ROLE DocGia

INSERT INTO TacGia (TenTacGia)
VALUES (N'Kim Dung')


DELETE dbo.TaiKhoan WHERE MaTaiKhoan=20110536
DROP USER [admin@gmail.com];
DROP LOGIN [admin@gmail.com];








PRINT dbo.FN_Total_Working_Hours(20110536, '2024-04-26')

select * from dbo.TaiKhoan
select * from dbo.PhieuMuonSach
select * from dbo.Sach where MaSach = 5

select * from dbo.PhieuPhat
Update dbo.Sach 
SET SoLuong = 5
where MaSach = 6

UPDATE dbo.CuonSach
SET TinhTrang = N'Đã mất'
WHERE MaPhieuMuon = 36 AND MaSach = 8


UPDATE dbo.PhieuMuonSach
SET NgayTra = '2024-04-25'
WHERE MaPhieuMuon = 100

DECLARE @a DECIMAL(18, 2)
SET @a = dbo.FN_Calculate_Penalty_Value(100)
PRINT @a

DECLARE @today DATE
SET @today = GETDATE()

SET IDENTITY_INSERT PhieuMuonSach ON;
INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES  (100, 20110536, @today, NULL)
SET IDENTITY_INSERT PhieuMuonSach OFF;

select * from dbo.NhaXuatBan
INSERT INTO dbo.NhaXuatBan(TenNhaXuatBan)
VALUES	( N'Test')

UPDATE dbo.NhaXuatBan
SET TenNhaXuatBan = N'Test'
WHERE MaNhaXuatBan = 1

EXEC SP_Add_New_PhieuPhat
@MaPhieuMuon = 100

DELete from dbo.PhieuPhat where MaPhieuMuon = 100
EXEC SP_Delete_Coupon @MaPhieuMuon = 100
EXEC SP_Update_Coupon_Returned @MaPhieuMuon = 100

SELECT * FROM PhieuMuonSach WHERE MaPhieuMuon = 100;
SELECT * FROM CuonSach WHERE MaPhieuMuon = 100;

DECLARE @a DECIMAL(18, 0);
SET @a = dbo.FN_Calculate_Penalty_Value(100);
PRINT @a;

SELECT PP.MaPhieuPhat, PP.MaPhieuMuon,PP.NgayTra,PMS.MaTaiKhoan,PMS.NgayTra AS NgayTraSach
FROM dbo.PhieuPhat PP
JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon= PP.MaPhieuMuon
