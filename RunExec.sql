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





SELECT * FROM dbo.CuonSach
SELECT * FROM dbo.VW_Reader_Not_Returned_Borrowed

SELECT * FROM dbo.FN_Reader_All_Penalty(20110536)

EXEC SP_Find_Book_By_Advanced
	@TenTacGia  = NULL,
	@TenTheLoai= NULL,
    @TenNhaXuatBan  = NULL,
    @TenSach  = NULL,
	@LoaiTaiLieu  = NULL,
	@NamXuatBan  = NULL
