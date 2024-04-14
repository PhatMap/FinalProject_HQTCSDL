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






select * from VW_Shift_List
SELECT * FROM FN_Get_Account_Profile('user1n@gmail.com')

EXEC SP_Find_Account_By_Email @Email = 'admin@gmail.com'

EXEC SP_Find_Account_By_Name @HoTen = N'Phạm Văn C'
EXEC SP_Change_Account_Password     
	@Email = 'admin@gmail.com',
    @MatKhauMoi = 'zzzzzzzz',
	@XacNhan = 'zzzzzzzz',
	@MatKhauCu = 'aaaaaaaa';

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
select * from VW_Librarian_List
EXEC SP_Delete_Account @MaTaiKhoan = 20110535
EXEC SP_Find_Account_By_Advanced 
    @MaTaiKhoan = NULL,
    @HoTen = NULL,
    @DiaChi = NULL,
    @Email = NULL,
    @SoDienThoai = NULL,
    @VaiTro = N'Thủ thư',
    @GioiTinh = NULL;

Select * from FN_Get_Account_Profile ('admin@gmail.com')
SELECT * FROM VW_BookLoanCoupon_List
EXEC SP_Find_BookLoanCoupon_By_Status @Status = "Đang mượn"
EXEC SP_Add_New_BookLoanCoupon
	@MaPhieuMuon = 4,
	@MaTaiKhoan = 20110535,
	@NgayMuon = '2024-03-03',
	@NgayTra = NULL;