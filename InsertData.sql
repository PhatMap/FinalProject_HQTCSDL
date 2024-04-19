DECLARE @today DATE
SET @today = GETDATE()

-- Thêm tác giả
INSERT INTO TacGia (TenTacGia)
VALUES (N'Kim Dung'),
       (N'Tran Van Tuan'),
       (N'Haruki Murakami'),
       (N'J.K. Rowling'),
       (N'Dan Brown'),
       (N'Paulo Coelho');

-- Thêm thể loại
INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Trinh thám'),
       (N'Kỹ năng sống'),
       (N'Chính trị'),
       (N'Văn học nước ngoài'),
       (N'Kinh doanh'),
       (N'Thơ ca');

-- Thêm nhà xuất bản
INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES (N'NXB Phụ Nữ'),
       (N'NXB Giáo Dục'),
       (N'NXB Thế Giới'),
       (N'NXB Hội Nhà Văn'),
       (N'NXB Tổng Hợp'),
       (N'NXB Đại Học Quốc Gia');

-- Thêm sách
INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES 
		-- 1
		(4, 4, 4, N'Tiểu thuyết Thần Tượng', N'Sách tham khảo', 2010, 75000, 4),
		(5, 5, 5, N'Đường Mây Trên Đất Hoa', N'Sách tham khảo', 1930, 48000, 5),
		(6, 6, 6, N'The Alchemist', N'Sách tham khảo', 1988, 92000, 3),
		-- 2
		(1, 1, 2, N'Vượt Sóng', N'Sách tham khảo', 2012, 68000, 3),
		(2, 2, 3, N'Đoản Khúc Thu Hà Nội', N'Sách tham khảo', 1940, 51000, 3),
		(3, 3, 1, N'Angels & Demons', N'Sách tham khảo', 2000, 86000, 3),
		-- 3
		(4, 4, 4, N'Điều Kỳ Diệu Của Thần Chết', N'Sách tham khảo', 2015, 72000, 4),
		(5, 5, 5, N'Nhà Giả Kim', N'Sách tham khảo', 1988, 89000, 4),
		(6, 6, 6, N'1Q84', N'Sách tham khảo', 2009, 95000, 5),
		-- 4
		(1, 1, 2, N'Bên Rặng Tuyết Sơn', N'Sách tham khảo', 2010, 69000, 5),
		(2, 2, 3, N'Bài Thơ Cuối Cùng', N'Sách tham khảo', 1950, 53000, 5),
		(3, 3, 1, N'The Lost Symbol', N'Sách tham khảo', 2009, 87000, 5),
		-- 5
		(4, 4, 4, N'Tiếng Chim Hót Trong Bão Tuyết', N'Giáo trình', 2018, 71000, 5),
		(5, 5, 5, N'Wuthering Heights', N'Giáo trình', 1847, 48000, 5),
		(6, 6, 6, N'Norwegian Wood', N'Giáo trình', 1987, 91000, 5),
		-- 6
		(1, 1, 2, N'Lời Nói Đầu Xuân', N'Giáo trình', 2013, 70000, 5),
		(2, 2, 3, N'Nhớ Một Người', N'Giáo trình', 1965, 54000, 5),
		(3, 3, 1, N'Inferno', N'Giáo trình', 2013, 88000, 5),
		-- 7
		(4, 4, 4, N'Sóng', N'Giáo trình', 2014, 74000, 5),
		(5, 5, 5, N'Anna Karenina', N'Giáo trình', 1877, 49000, 5),
		(6, 6, 6, N'Kafka on the Shore', N'Giáo trình', 2002, 94000, 5);


INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	(20110536,'admin@gmail.com', 'aaaaaaaa', N'Quản trị viên', N'Trần Trung Phát', '0123456789', '2000-01-01', N'Hà Nội', N'Nam'),
		(1,'example2@gmail.com', 'password2', N'Thủ thư', N'Trần Thị B', '0987654321', '1995-05-10', N'Hồ Chí Minh', N'Nữ'),
		(2,'example3@gmail.com', 'password3', N'Người dùng', N'Phạm Văn C', '0369852147', '1988-11-20', N'Đà Nẵng', N'Nam'),
		(3, 'example4@gmail.com', 'password4', N'Sinh viên CLC', N'Nguyễn Văn A', '0123456789', '2001-02-15', N'Hà Nội', N'Nam'),
		(4, 'example5@gmail.com', 'password5', N'Sinh viên đại trà', N'Lê Thị B', '0987654321', '2000-03-20', N'Hồ Chí Minh', N'Nữ'),
		(5, 'example6@gmail.com', 'password6', N'Học viên cao học', N'Trần Văn C', '0369852147', '1998-04-25', N'Đà Nẵng', N'Nam'),
		(6, 'example7@gmail.com', 'password7', N'Giảng viên', N'Lý Thị D', '0369852147', '1990-05-30', N'Hải Phòng', N'Nữ'),
		(7, 'example8@gmail.com', 'password8', N'Thủ thư', N'Phạm Văn E', '0369852147', '1985-06-05', N'Vũng Tàu', N'Nam'),
		(8, 'example9@gmail.com', 'password9', N'Quản trị viên', N'Nguyễn Thị F', '0369852147', '1982-07-10', N'Bình Dương', N'Nữ');

SET IDENTITY_INSERT PhieuMuonSach ON;

INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES  (1, 20110536, @today, NULL),
		(2, 20110536, @today, DATEADD(DAY, 7, @today)),
		(3, 20110536, @today, NULL),
		(4, 20110536, @today, NULL),
		(5, 20110536, @today, DATEADD(DAY, 7, @today)),
		(6, 20110536, @today, NULL),
		(7, 20110536, @today, DATEADD(DAY, 8, @today)),
		(8, 20110536, @today, NULL);

SET IDENTITY_INSERT PhieuMuonSach OFF;

INSERT INTO PhieuPhat (MaPhieuMuon, TienPhat, NgayTra)
VALUES  (2, 5000, DATEADD(DAY, 7, NULL)),
		(1, 3000, DATEADD(DAY, 7, @today)),
		(3, 7000, DATEADD(DAY, 10, @today)),
		(4, 4500, DATEADD(DAY, 5, NULL)),
		(5, 6000, DATEADD(DAY, 8, @today)),
		(6, 3500, DATEADD(DAY, 6, NULL));

INSERT INTO LichLamViec (NgayLam, Ca, MaTaiKhoan)
VALUES (DATEADD(DAY, 3, @today), N'Sáng', 20110536),
       (DATEADD(DAY, 4, @today), N'Chiều', 20110536),
       (DATEADD(DAY, 5, @today), N'Sáng', 20110536),
       (DATEADD(DAY, 6, @today), N'Chiều', 20110536);

INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
VALUES	(1, 1, N'Đang mượn'),
		(5, 1, N'Đang mượn'),
		(6, 1, N'Đang mượn'),
		(2, 2, N'Đã trả'),
		(3, 3, N'Đang mượn'),
		(7, 3, N'Đang mượn'),
		(8, 3, N'Đang mượn'),
		(6, 2, N'Hư'),
		(5, 2, N'Mất');
		
		
