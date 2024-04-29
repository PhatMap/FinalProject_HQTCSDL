-- Thêm tác giả
INSERT INTO TacGia (TenTacGia)
VALUES (N'Lê Chí Cương'),
       (N'Viên Thế Giang'),
       (N'Nguyễn Công Khanh'),
       (N'Nguyễn Viết Trung');

-- Thêm thể loại
INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Khoa học'),
       (N'Pháp luật'),
       (N'Sức khỏe'),
       (N'Công nghệ thông tin');

-- Thêm nhà xuất bản
INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES (N'Đại học quốc gia TP.Hồ Chí Minh'),
       (N'Đại học quốc gia Hà Nội'),
       (N'Xây Dựng');

-- Thêm sách
INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES 
		(1, 1, 1, N'Luyện kim - Cơ khí', N'Giáo Trình', 2013, 75000, 7),
		(2, 2, 1, N'Luật chứng khoán', N'Giáo Trình', 2023, 48000, 8),
		(3, 3, 2, N'Trị liệu tâm lý', N'Sách tham khảo', 2023, 92000, 9),
		(4, 4, 3, N'Tính toán cầu đúc hẫng trên phần mềm Midas', N'Sách tham khảo', 2018, 68000, 8);


INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110536,'20110536@hcmute.edu.vn.com', 'zzzzzzzz', N'Quản trị viên', N'Trần Trung Phát', '0183476789', '2002-01-01', N'Hồ Chí Minh', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(21110862,'21110862@hcmute.edu.vn.com', 'xxxxxxxx', N'Thủ thư', N'Lê Quốc Văn', '0183456799', '2003-05-01', N'Quy Nhơn', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(21110827,'21110827@hcmute.edu.vn.com', 'cccccccc', N'Thủ thư', N'Trần Khải Hoàn', '0188456789', '2003-01-06', N'Đắc Lắc', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(21110333,'21110333@hcmute.edu.vn.com', 'vvvvvvvv', N'Sinh viên CLC', N'Đoàn Nguyễn Nam Trung', '0183356789', '2003-04-03', N'vũng Tàu', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110535,'20110535@hcmute.edu.vn.com', 'bbbbbbbb', N'Sinh viên đại trà', N'Trần Trung Kiên', '0183455789', '2002-01-12', N'Hà Nội', N'Nữ');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20113536,'20113536@hcmute.edu.vn.com', 'nnnnnnnn', N'Học viên cao học', N'Nguyễn Quốc Quân', '0183456289', '2002-11-01', N'Nha Trang', N'Nam');

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110556,'20110556@hcmute.edu.vn.com', 'mmmmmmmm', N'Giảng viên', N'Lê Thị Bùi', '0113456789', '2002-10-01', N'Hồ Chí Minh', N'Nữ');


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

		
		
