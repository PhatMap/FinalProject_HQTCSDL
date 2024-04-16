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
		(4, 4, 4, N'Tiểu thuyết Thần Tượng', N'Tiểu thuyết', 2010, 75000, 90),
		(5, 5, 5, N'Đường Mây Trên Đất Hoa', N'Kinh điển', 1930, 48000, 60),
		(6, 6, 6, N'The Alchemist', N'Văn học nước ngoài', 1988, 92000, 110),
		-- 2
		(1, 1, 2, N'Vượt Sóng', N'Tiểu thuyết', 2012, 68000, 85),
		(2, 2, 3, N'Đoản Khúc Thu Hà Nội', N'Kinh điển', 1940, 51000, 65),
		(3, 3, 1, N'Angels & Demons', N'Văn học nước ngoài', 2000, 86000, 105),
		-- 3
		(4, 4, 4, N'Điều Kỳ Diệu Của Thần Chết', N'Trinh thám', 2015, 72000, 95),
		(5, 5, 5, N'Nhà Giả Kim', N'Kỹ năng sống', 1988, 89000, 115),
		(6, 6, 6, N'1Q84', N'Văn học nước ngoài', 2009, 95000, 125),
		-- 4
		(1, 1, 2, N'Bên Rặng Tuyết Sơn', N'Tiểu thuyết', 2010, 69000, 88),
		(2, 2, 3, N'Bài Thơ Cuối Cùng', N'Kinh điển', 1950, 53000, 70),
		(3, 3, 1, N'The Lost Symbol', N'Văn học nước ngoài', 2009, 87000, 108),
		-- 5
		(4, 4, 4, N'Tiếng Chim Hót Trong Bão Tuyết', N'Trinh thám', 2018, 71000, 92),
		(5, 5, 5, N'Wuthering Heights', N'Văn học nước ngoài', 1847, 48000, 62),
		(6, 6, 6, N'Norwegian Wood', N'Văn học nước ngoài', 1987, 91000, 112),
		-- 6
		(1, 1, 2, N'Lời Nói Đầu Xuân', N'Tiểu thuyết', 2013, 70000, 86),
		(2, 2, 3, N'Nhớ Một Người', N'Kinh điển', 1965, 54000, 68),
		(3, 3, 1, N'Inferno', N'Văn học nước ngoài', 2013, 88000, 110),
		-- 7
		(4, 4, 4, N'Sóng', N'Trinh thám', 2014, 74000, 97),
		(5, 5, 5, N'Anna Karenina', N'Văn học nước ngoài', 1877, 49000, 63),
		(6, 6, 6, N'Kafka on the Shore', N'Văn học nước ngoài', 2002, 94000, 120),
		-- 8
		(1, 1, 2, N'Nhật Ký Trong Tù', N'Tiểu thuyết', 2016, 71000, 89),
		(2, 2, 3, N'Tiểu Sử Cuộc Đời', N'Kinh điển', 1970, 55000, 71),
		(3, 3, 1, N'Origin', N'Văn học nước ngoài', 2017, 90000, 115),
		-- 9
		(4, 4, 4, N'Đường Về Phương Đông', N'Trinh thám', 2017, 73000, 94),
		(5, 5, 5, N'The Catcher in the Rye', N'Văn học nước ngoài', 1951, 50000, 66),
		(6, 6, 6, N'Colorless Tsukuru Tazaki and His Years of Pilgrimage', N'Văn học nước ngoài', 2013, 93000, 118),
		-- 10
		(1, 1, 2, N'Cô Gái Đến Từ Hôm Qua', N'Tiểu thuyết', 2018, 68000, 87),
		(2, 2, 3, N'The Great Gatsby', N'Văn học nước ngoài', 1925, 52000, 67),
		(3, 3, 1, N'The Da Vinci Code', N'Văn học nước ngoài', 2003, 85000, 107),
		-- 11
		(4, 4, 4, N'Bóng Ma Trên Gác Nhà', N'Trinh thám', 2019, 75000, 96),
		(5, 5, 5, N'Moby Dick', N'Văn học nước ngoài', 1851, 47000, 61),
		(6, 6, 6, N'After Dark', N'Văn học nước ngoài', 2004, 96000, 123),
		-- 12
		(1, 1, 2, N'Quê Nội', N'Tiểu thuyết', 2014, 67000, 84),
		(2, 2, 3, N'Nhật Ký Trong Tù', N'Kinh điển', 1968, 56000, 72),
		(3, 3, 1, N'The Alchemist', N'Văn học nước ngoài', 1988, 94000, 116),
		-- 13
		(4, 4, 4, N'The Silence of the Lambs', N'Trinh thám', 1988, 76000, 98),
		(5, 5, 5, N'The Picture of Dorian Gray', N'Văn học nước ngoài', 1890, 46000, 59),
		(6, 6, 6, N'Sputnik Sweetheart', N'Văn học nước ngoài', 1999, 95000, 122),
		-- 14
		(1, 1, 2, N'Cánh Đồng Bất Tận', N'Tiểu thuyết', 2015, 66000, 83),
		(2, 2, 3, N'Nhật Ký của Anne Frank', N'Kinh điển', 1947, 57000, 73),
		(3, 3, 1, N'1Q84', N'Văn học nước ngoài', 2009, 96000, 124),
		-- 15
		(4, 4, 4, N'Cuốn Theo Chiều Gió', N'Trinh thám', 2016, 74000, 93),
		(5, 5, 5, N'1984', N'Văn học nước ngoài', 1949, 45000, 58),
		(6, 6, 6, N'Blind Willow, Sleeping Woman', N'Văn học nước ngoài', 2006, 97000, 125),
		-- 16
		(1, 1, 2, N'Dưới Bóng Cây', N'Tiểu thuyết', 2017, 65000, 82),
		(2, 2, 3, N'The Sun Also Rises', N'Văn học nước ngoài', 1926, 58000, 74),
		(3, 3, 1, N'Colorless Tsukuru Tazaki and His Years of Pilgrimage', N'Văn học nước ngoài', 2013, 98000, 126),
		-- 17
		(4, 4, 4, N'Gone Girl', N'Trinh thám', 2012, 77000, 99),
		(5, 5, 5, N'Pride and Prejudice', N'Văn học nước ngoài', 1813, 44000, 57),
		(6, 6, 6, N'Kafka on the Shore', N'Văn học nước ngoài', 2002, 99000, 127),
		-- 18
		(1, 1, 2, N'Đảo Giấu Vàng', N'Tiểu thuyết', 2018, 64000, 81),
		(2, 2, 3, N'The Count of Monte Cristo', N'Văn học nước ngoài', 1844, 59000, 75),
		(3, 3, 1, N'The Da Vinci Code', N'Văn học nước ngoài', 2003, 97000, 125),
		-- 19
		(4, 4, 4, N'The Girl with the Dragon Tattoo', N'Trinh thám', 2005, 78000, 100),
		(5, 5, 5, N'To Kill a Mockingbird', N'Văn học nước ngoài', 1960, 43000, 56),
		(6, 6, 6, N'Norwegian Wood', N'Văn học nước ngoài', 1987, 100000, 128),
		-- 20
		(1, 1, 2, N'The Secret Garden', N'Tiểu thuyết', 2019, 63000, 80),
		(2, 2, 3, N'Crime and Punishment', N'Văn học nước ngoài', 1866, 60000, 76),
		(3, 3, 1, N'Origin', N'Văn học nước ngoài', 2017, 96000, 124);


INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES (20110536,'admin@gmail.com', 'aaaaaaaa', N'Quản trị viên', N'Trần Trung Phát', '0123456789', '2000-01-01', N'Hà Nội', N'Nam'),
       (1,'example2@gmail.com', 'password2', N'Thủ thư', N'Trần Thị B', '0987654321', '1995-05-10', N'Hồ Chí Minh', N'Nữ'),
       (2,'example3@gmail.com', 'password3', N'Người dùng', N'Phạm Văn C', '0369852147', '1988-11-20', N'Đà Nẵng', N'Nam');

SET IDENTITY_INSERT PhieuMuonSach ON;

INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES  (1, 20110536, @today, NULL),
		(2, 20110536, @today, DATEADD(DAY, 7, @today)),
		(3, 20110536, @today, NULL);
		(4, 20110536, @today, NULL),
		(5, 20110536, @today, DATEADD(DAY, 7, @today)),
		(6, 20110536, @today, NULL),
		(7, 20110536, @today, DATEADD(DAY, 8, @today)),
		(8, 20110536, @today, NULL);

SET IDENTITY_INSERT PhieuMuonSach OFF;

INSERT INTO PhieuPhat (MaPhieuMuon, TienPhat, NgayTra)
VALUES  (2, 5000, DATEADD(DAY, 7, @today)),
		(1, 3000, DATEADD(DAY, 7, @today)),
		(3, 7000, DATEADD(DAY, 10, @today)),
		(4, 4500, DATEADD(DAY, 5, @today)),
		(5, 6000, DATEADD(DAY, 8, @today)),
		(6, 3500, DATEADD(DAY, 6, @today));

INSERT INTO LichLamViec (NgayLam, Ca, MaTaiKhoan)
VALUES (DATEADD(DAY, 3, @today), N'Sáng', 20110536),
       (DATEADD(DAY, 4, @today), N'Chiều', 20110536),
       (DATEADD(DAY, 5, @today), N'Sáng', 20110536),
       (DATEADD(DAY, 6, @today), N'Chiều', 20110536);

INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
VALUES (1, 1, N'Đang mượn'),
       (2, 2, N'Đang mượn'),
       (3, 3, N'Đang mượn');
