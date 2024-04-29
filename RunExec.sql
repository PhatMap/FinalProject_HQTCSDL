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

Select * from TaiKhoan



