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

select * from VW_Book_List

select * from VW_TheLoai_List

select * from dbo.Sach


EXEC SP_Add_New_Book 
    @MaSach = 4, 
    @MaTacGia = 4, 
    @MaTheLoai = 4, 
    @MaNhaXuatBan = 4, 
    @TenSach = N'Tây Du Ký', 
    @LoaiTaiLieu = N'Sách tham khảo', 
    @NamXuatBan = 1999, 
    @GiaSach = 50000, 
    @SoLuong = 50;

/***	Find account by advanced (Phat)		***/
CREATE PROC SP_Find_Account_By_Advanced
(
	@MaTaiKhoan int = NULL,
    @HoTen nvarchar(255) = NULL,
    @DiaChi nvarchar(255) = NULL,
	@Email NVARCHAR(255) = NULL,
	@SoDienThoai NVARCHAR(10) = NULL,
	@VaiTro nvarchar(50) = NULL,
    @GioiTinh nvarchar(10) = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Account_List 
	WHERE 
		(@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan) AND
		(@HoTen IS NULL OR HoTen = @HoTen) AND
		(@DiaChi IS NULL OR DiaChi = @DiaChi) AND
		(@Email IS NULL OR Email = @Email) AND
		(@SoDienThoai IS NULL OR SoDienThoai = @SoDienThoai) AND
		(@VaiTro IS NULL OR VaiTro = @VaiTro) AND
		(@GioiTinh IS NULL OR GioiTinh = @GioiTinh) 
END;

select * from VW_Book_List

exec SP_Find_Book_By_Advanced
@TenTacGia  = N'Nguyễn Du',
	@TenTheLoai  = NULL,
    @TenNhaXuatBan  = NULL,
    @TenSach  = NULL,
	@LoaiTaiLieu = NULL,
	@NamXuatBan = NULL

Select * from VW_TacGia_List

EXEC SP_Add_New_Book 
    @MaTacGia = 3, 
    @MaTheLoai = 4, 
    @MaNhaXuatBan = 4, 
    @TenSach = N'Tây Du Ký', 
    @LoaiTaiLieu = N'Sách tham khảo', 
    @NamXuatBan = 1999, 
    @GiaSach = 50000, 
    @SoLuong = 50;

EXEC SP_Update_Book 
    @MaTacGia = 2, 
    @MaTheLoai = 2, 
    @MaNhaXuatBan = 2, 
    @TenSach = N'Tây Du Ký', 
    @LoaiTaiLieu = N'Sách tham khảo', 
    @NamXuatBan = 1888, 
    @GiaSach = 500000, 
    @SoLuong = 50;
