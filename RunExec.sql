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

DROP USER [20110536@hcmute.edu.vn.com];
DROP LOGIN [20110536@hcmute.edu.vn.com];

DROP USER [21110862@hcmute.edu.vn.com];
DROP LOGIN [21110862@hcmute.edu.vn.com];

DROP USER [21110827@hcmute.edu.vn.com];
DROP LOGIN [21110827@hcmute.edu.vn.com];

DROP USER [21110333@hcmute.edu.vn.com];
DROP LOGIN [21110333@hcmute.edu.vn.com];

DROP USER [20110535@hcmute.edu.vn.com];
DROP LOGIN [20110535@hcmute.edu.vn.com];

DROP USER [20113536@hcmute.edu.vn.com];
DROP LOGIN [20113536@hcmute.edu.vn.com];

DROP USER [20110556@hcmute.edu.vn.com];
DROP LOGIN [20110556@hcmute.edu.vn.com];

SELECT * FROM VW_Book_Loan_Coupon_List
SELECT * FROM CuonSach

SELECT * FROM VW_PhieuPhat_List
SELECT * FROM PhieuPhat

DECLARE @LateBooks int = 0;
DECLARE @Penalty DECIMAL(18, 0) = 0;
	DECLARE @TotalDays INT = 0;
	DECLARE @TotalDamagedOrLost DECIMAL(18, 0) = 0;

	SELECT @TotalDamagedOrLost = ISNULL(SUM(S.GiaSach), 0)
	FROM dbo.PhieuMuonSach PMS
	JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
	JOIN dbo.Sach S ON S.MaSach = CS.MaSach
	WHERE CS.MaPhieuMuon = 12 AND (CS.TinhTrang = N'Đã hư' OR CS.TinhTrang = N'Đã mất');



	SET @TotalDamagedOrLost = @TotalDamagedOrLost * 2;

	IF EXISTS (SELECT 1 FROM dbo.PhieuMuonSach PMS
				JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
				WHERE CS.MaPhieuMuon = 12 AND CS.TinhTrang = N'Trả trễ')
	BEGIN 
	SELECT @LateBooks = COUNT(*)
	FROM dbo.PhieuMuonSach PMS
	JOIN dbo.CuonSach CS ON CS.MaPhieuMuon = PMS.MaPhieuMuon
	WHERE CS.MaPhieuMuon = 12;
	END;

	SELECT @TotalDays = DATEDIFF(DAY, PMS.NgayMuon, GETDATE())
	FROM dbo.PhieuMuonSach PMS
	WHERE PMS.MaPhieuMuon = 12;

	SET @Penalty = CAST(ISNULL(@TotalDays, 0) AS DECIMAL(18, 0)) * ISNULL(@LateBooks, 0) * 1000 + ISNULL(@TotalDamagedOrLost, 0);
PRINT @LateBooks
PRINT @Penalty
PRINT @TotalDays




DISABLE TRIGGER ALL ON PhieuMuonSach;
SET IDENTITY_INSERT PhieuMuonSach ON;
ALTER TABLE PhieuMuonSach NOCHECK CONSTRAINT ALL;

INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES  (1, 20113536 , '2024-04-03', NULL),
		(2, 20110535, '2023-08-04', NULL),
		(3, 21110333, '2023-08-05', NULL),
		(4, 20110556, '2024-04-02', NULL);

INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
VALUES	(1, 1, N'Đang mượn'),
		(2, 1, N'Đang mượn'),
		(2, 2, N'Đang mượn'),
		(1, 2, N'Đang mượn'),
		(3, 3, N'Đang mượn'),
		(4, 3, N'Đang mượn'),
		(4, 4, N'Đang mượn'),
		(1, 4, N'Đang mượn');

ENABLE TRIGGER ALL ON PhieuMuonSach;
SET IDENTITY_INSERT PhieuMuonSach OFF;
ALTER TABLE PhieuMuonSach CHECK CONSTRAINT ALL;

exec SP_Update_Coupon_Returned @MaPhieuMuon = 12

exec SP_Add_New_PhieuPhat @MaPhieuMuon = 12

DELETE dbo.PhieuMuonSach where MaPhieuMuon = 4