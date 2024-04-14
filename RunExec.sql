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






SELECT * FROM TaiKhoan

EXEC SP_Get_Schedule 
	@NgayDauTuan  = NULL,
	@NgayCuoiTuan  = NULL,
	@MaTaiKhoan = 5

EXEC SP_Add_New_Account
	@MaTaiKhoan = 20110535,
    @HoTen = N'Trần Trung A',
	@MatKhau = 'aaaaaaaa',
    @DiaChi = N'Hồ Chí Minh',
    @NgaySinh = '2001-12-29',
	@Email = 'user1n@gmail.com',
	@SoDienThoai = '1234567890',
	@VaiTro = N'Độc giả',
    @GioiTinh = 'Nam';

DROP
<<<<<<< HEAD
select * from VW_PhieuPhat_List
=======
select * from TaiKhoan
EXEC SP_Delete_Account @MaTaiKhoan = 20110535






EXEC SP_Get_Schedule 
@NgayDauTuan = '2024-04-10',
@NgayCuoiTuan = '2024-04-12'

EXEC SP_Get_Schedule 
@NgayDauTuan = NULL,
@NgayCuoiTuan = NULL,
@HoTen = N'Phạm Văn E'
>>>>>>> main
