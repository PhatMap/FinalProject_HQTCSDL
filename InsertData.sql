-- Thêm tác giả
INSERT INTO TacGia (TenTacGia)
VALUES (N'Lê Chí Cương'),
       (N'Viên Thế Giang'),
       (N'Nguyễn Công Khanh'),
       (N'Nguyễn Viết Trung');

INSERT INTO TacGia (TenTacGia)
VALUES (N'Viktor Mayer'),
	   (N'Jeff Atwood'),
	   (N'Nam cao'),
	   (N'Nguyễn Du'),
	   (N'Ngô Tất Tố'),
	   (N'Vũ Trọng Phụng'),
	   (N'Nguyễn Hồng'),
	   (N'Kim Lân'),
	   (N'Thạch Lam'),
	   (N'Nguyễn Tuân'),
	   (N'Tô Hoài'),
	   (N'Lưu Trọng Lư'),
	   (N'Nguyễn Bính'),
	   (N'Nguyễn Đình Lập'),
	   (N'Thế Lữ'),
	   (N'Vũ Bằng'),
	   (N'Bích Khê'),
	   (N'Hồ Chí Minh');

-- Thêm thể loại
INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Khoa học'),
       (N'Pháp luật'),
       (N'Sức khỏe'),
       (N'Công nghệ thông tin');

INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Văn học');
-- Thêm nhà xuất bản
INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES (N'Đại học quốc gia TP.Hồ Chí Minh'),
       (N'Đại học quốc gia Hà Nội'),
       (N'Xây Dựng');
INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES
	   (N'Giáo dục'),
	   (N'Kim Đồng'),
	   (N'Trẻ'),
	   (N'Hội Nhà Văn');

-- Thêm sách
INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES 
		(1, 1, 1, N'Luyện kim - Cơ khí', N'Giáo Trình', 2013, 75000, 7),
		(2, 2, 1, N'Luật chứng khoán', N'Giáo Trình', 2023, 48000, 8),
		(3, 3, 2, N'Trị liệu tâm lý', N'Sách tham khảo', 2023, 92000, 9),
		(4, 4, 3, N'Tính toán cầu đúc hẫng trên phần mềm Midas', N'Sách tham khảo', 2018, 68000, 8);

INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES 
		(6, 4, 1, N'Lập Trình và Cuộc Sống', N'Sách tham khảo', 2023, 100000, 10),
		(5, 4, 1, N'Trí Tuệ Nhân Tạo', N'Sách tham khảo', 2023, 90000, 10),
		(5, 4, 1, N'LIFE', N'Sách tham khảo', 2023, 70000, 10),
		(7, 4, 4, N'Chí Phèo', N'Sách tham khảo', 2015, 50000, 12),
		(8, 4, 5, N'Truyện Kiều', N'Sách tham khảo', 2003, 20000, 9),
		(9, 4, 5, N'Tắt Đèn', N'Sách tham khảo', 2000, 10000, 7),
		(10, 4, 7, N'Số Đỏ', N'Sách tham khảo', 2001, 15000, 4),
		(11, 4, 7, N'Bỉ Vỏ', N'Sách tham khảo', 2000, 12000, 8),
		(12, 4, 7, N'Vợ Nhặt', N'Sách tham khảo', 1999, 11000, 6),
		(13, 4, 4, N'Hà Nội 36 Phố Phường', N'Sách tham khảo', 2002, 20000, 9),
		(14, 4, 5, N'Chùa Đàn', N'Sách tham khảo', 2001, 22000, 10),
		(15, 4, 7, N'Trúng Số Độc Đắc', N'Sách tham khảo', 1989, 9000, 4),
		(16, 4, 7, N'Những Ngày Thơ Ấu', N'Sách tham khảo', 2005, 20000, 5),
		(17, 4, 4, N'Thiêng Thu', N'Sách tham khảo', 1988, 10000, 3),
		(18, 4, 5, N'Mười Hai Bến Nước', N'Sách tham khảo', 1880, 9000, 3),
		(19, 4, 5, N'Ngoại Ô', N'Sách tham khảo', 1989, 10000, 9),
		(20, 4, 7, N'Lê Phong', N'Sách tham khảo', 2000, 10000, 5),
		(21, 4, 4, N'Phù Dung Ơi, Vĩnh Biệt!', N'Sách tham khảo', 2003, 20000, 10),
		(22, 4, 4, N'Nhật Ký Trong Tù', N'Sách tham khảo', 2005, 20000, 10);


INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110536,'20110536@hcmute.edu.vn', 'zzzzzzzz', N'Quản trị viên', N'Trần Trung Phát', '0183476789', '2002-01-01', N'Hồ Chí Minh', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(21110862,'21110862@hcmute.edu.vn', 'xxxxxxxx', N'Thủ thư', N'Lê Quốc Văn', '0183456799', '2003-05-01', N'Quy Nhơn', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(21110827,'21110827@hcmute.edu.vn', 'cccccccc', N'Thủ thư', N'Trần Khải Hoàn', '0188456789', '2003-01-06', N'Đắc Lắc', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(21110333,'21110333@hcmute.edu.vn', 'vvvvvvvv', N'Sinh viên CLC', N'Đoàn Nguyễn Nam Trung', '0183356789', '2003-04-03', N'vũng Tàu', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110535,'20110535@hcmute.edu.vn', 'bbbbbbbb', N'Sinh viên đại trà', N'Trần Trung Kiên', '0183455789', '2002-01-12', N'Hà Nội', N'Nữ');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20113536,'20113536@hcmute.edu.vn', 'nnnnnnnn', N'Học viên cao học', N'Nguyễn Quốc Quân', '0183456289', '2002-11-01', N'Nha Trang', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110556,'20110556@hcmute.edu.vn', 'mmmmmmmm', N'Giảng viên', N'Lê Thị Bùi', '0113456789', '2002-10-01', N'Hồ Chí Minh', N'Nữ');


DISABLE TRIGGER ALL ON PhieuMuonSach;
SET IDENTITY_INSERT PhieuMuonSach ON;
ALTER TABLE PhieuMuonSach NOCHECK CONSTRAINT ALL;


INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES  (1, 20113536 , '2024-04-03', NULL),
		(2, 20110535, '2023-08-04', NULL),
		(3, 21110333, '2023-08-05', NULL),
		(4, 20110556, '2024-04-02', NULL);

INSERT INTO LichLamViec (NgayLam, Ca, MaTaiKhoan)
VALUES ('2024-05-06', N'Sáng', 21110862),
		('2024-05-07', N'Sáng', 21110862),
		('2024-05-08', N'Sáng', 21110862),
		('2024-05-09', N'Sáng', 21110862),
		('2024-05-10', N'Sáng', 21110862),
	   ('2024-05-06', N'Chiều', 21110827),
	   ('2024-05-07', N'Chiều', 21110827),
	   ('2024-05-08', N'Chiều', 21110827),
	   ('2024-05-09', N'Chiều', 21110827),
	   ('2024-05-10', N'Chiều', 21110827);

ENABLE TRIGGER ALL ON PhieuMuonSach;
SET IDENTITY_INSERT PhieuMuonSach OFF;
ALTER TABLE PhieuMuonSach CHECK CONSTRAINT ALL;

INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
VALUES	(1, 1, N'Đang mượn'),
		(2, 1, N'Đang mượn'),
		(2, 2, N'Đang mượn'),
		(1, 2, N'Đang mượn'),
		(3, 3, N'Đang mượn'),
		(4, 3, N'Đang mượn'),
		(4, 4, N'Đang mượn'),
		(1, 4, N'Đang mượn');

		
		
