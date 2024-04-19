DECLARE @today DATE
SET @today = GETDATE()

INSERT INTO TacGia (TenTacGia)
VALUES (N'Nguyễn Nhật Ánh'),
       (N'Nguyễn Du'),
       (N'Trích Đoàn');

INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Tiểu thuyết'),
       (N'Kinh điển'),
       (N'Phiêu lưu'),
       (N'Khoa học viễn tưởng');

INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES (N'Nhà Xuất Bản Trẻ'),
       (N'NXB Kim Đồng'),
       (N'NXB Văn Học'),
       (N'NXB Lao Động Xã Hội');

INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES (1, 1, 1, N'Tôi thấy hoa vàng trên cỏ xanh', N'Sách tham khảo', 2005, 65000, 100),
       (2, 2, 2, N'Thần đồng đất Việt', N'Giáo trình', 1960, 55000, 80),
       (3, 3, 3, N'Harry Potter và Hòn Đá Phù Thủy', N'Sách tham khảo', 1997, 89000, 120);

INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES (20110536,'admin@gmail.com', 'aaaaaaaa', N'Quản trị viên', N'Trần Trung Phát', '0123456789', '2000-01-01', N'Hà Nội', N'Nam'),
       (1,'example2@gmail.com', 'password2', N'Thủ thư', N'Trần Thị B', '0987654321', '1995-05-10', N'Hồ Chí Minh', N'Nữ'),
       (2,'example3@gmail.com', 'password3', N'Người dùng', N'Phạm Văn C', '0369852147', '1988-11-20', N'Đà Nẵng', N'Nam');

SET IDENTITY_INSERT PhieuMuonSach ON;

INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES (1, 20110536, @today, NULL),
       (2, 20110536, @today, DATEADD(DAY, 7, @today)),
       (3, 20110536, @today, NULL);

SET IDENTITY_INSERT PhieuMuonSach OFF;

INSERT INTO PhieuPhat (MaPhieuMuon, TienPhat, NgayTra)
VALUES (2, 5000, DATEADD(DAY, 7, @today));

INSERT INTO LichLamViec (NgayLam, Ca, MaTaiKhoan)
VALUES (DATEADD(DAY, 3, @today), N'Sáng', 20110536),
       (DATEADD(DAY, 4, @today), N'Chiều', 20110536),
       (DATEADD(DAY, 5, @today), N'Sáng', 20110536),
       (DATEADD(DAY, 6, @today), N'Chiều', 20110536);

INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
VALUES (1, 1, N'Đang mượn'),
       (2, 2, N'Đang mượn'),
       (3, 3, N'Đang mượn');
