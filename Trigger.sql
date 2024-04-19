CREATE TRIGGER trg_CheckSach
ON Sach
FOR INSERT, UPDATE
AS
BEGIN

	-- Kiểm tra MaTacGia
	IF EXISTS (SELECT * FROM inserted WHERE MaTacGia IS NULL)
	BEGIN
		RAISERROR('Mã tác giả không được để trống', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra MaTheLoai
	IF EXISTS (SELECT * FROM inserted WHERE MaTheLoai IS NULL)
	BEGIN
		RAISERROR('Mã thể loại không được để trống', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra MaNhaXuatBan
	IF EXISTS (SELECT * FROM inserted WHERE MaNhaXuatBan IS NULL)
	BEGIN
		RAISERROR('Mã nhà xuất bản không được để trống', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra TenSach
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(TenSach) = '')
	BEGIN
		RAISERROR('Tên sách không được để trống', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra LoaiTaiLieu
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(LoaiTaiLieu) = '')
	BEGIN
		RAISERROR('Loại tài liệu không được để trống', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra NamXuatBan
	IF EXISTS (SELECT * FROM inserted WHERE NamXuatBan <10 )
	BEGIN
		RAISERROR('Năm xuất bản quá cũ', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra GiaSach
	IF EXISTS (SELECT * FROM inserted WHERE GiaSach <= 0)
	BEGIN
		RAISERROR('Giá sách phải lớn hơn 0', 16, 1)
		ROLLBACK TRANSACTION
	END

	-- Kiểm tra SoLuong
	IF EXISTS (SELECT * FROM inserted WHERE SoLuong <= 0)
	BEGIN
		RAISERROR('Số lượng sách không được nhỏ hơn 0', 16, 1)
		--THROW 5000, 'Số lượng sách không được nhỏ hơn 0', 1
		ROLLBACK TRANSACTION
	END
END

CREATE TRIGGER trg_CheckTacGia
ON TacGia
FOR INSERT, UPDATE
AS
BEGIN
	-- Kiểm tra TenTacGia
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(TenTacGia) = '')
	BEGIN
		RAISERROR('Tên tác giả không được để trống', 16, 1)
		ROLLBACK TRANSACTION
	END
END