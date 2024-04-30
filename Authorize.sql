-- Create roles
-- Quản trị viên dùng sysadmin

CREATE ROLE ThuThu;
-- Grant permissions on tables
GRANT SELECT, REFERENCES  ON [TaiKhoan] TO ThuThu;
GRANT SELECT ON [LichLamViec] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [NhaXuatBan] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [TacGia] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [TheLoai] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [Sach] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES ON [PhieuMuonSach] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE ON [PhieuPhat] TO ThuThu;
GRANT SELECT, INSERT, UPDATE, DELETE ON [CuonSach] TO ThuThu;
--Views + Functions
GRANT SELECT TO ThuThu

--Procedures 
GRANT EXECUTE TO ThuThu
DENY EXECUTE ON [SP_Add_New_Account] TO ThuThu
DENY EXECUTE ON [SP_Delete_Account] TO ThuThu
DENY EXECUTE ON [SP_Update_Account] TO ThuThu
DENY EXECUTE ON [SP_Add_New_Schedule] TO ThuThu
DENY EXECUTE ON [SP_Update_Schedule] TO ThuThu
DENY EXECUTE ON [SP_Delete_Schedule] TO ThuThu



CREATE ROLE DocGia;
-- Grant permissions on tables
GRANT SELECT, REFERENCES  ON [TaiKhoan] TO DocGia;
GRANT SELECT, REFERENCES ON [NhaXuatBan] TO DocGia;
GRANT SELECT, REFERENCES ON [TacGia] TO DocGia;
GRANT SELECT, REFERENCES ON [TheLoai] TO DocGia;
GRANT SELECT, REFERENCES ON [Sach] TO DocGia;
GRANT SELECT, REFERENCES ON [PhieuMuonSach] TO DocGia;
GRANT SELECT ON [PhieuPhat] TO DocGia;
GRANT SELECT ON [CuonSach] TO DocGia;
--Views 
GRANT SELECT ON [VW_Book_List] TO DocGia
GRANT SELECT ON [VW_NhaXuatBan_List] TO DocGia
GRANT SELECT ON [VW_TheLoai_List] TO DocGia
GRANT SELECT ON [VW_TacGia_List] TO DocGia
GRANT SELECT ON [VW_NhaXuatBan_List] TO DocGia
--Procedures + Functions
GRANT EXECUTE ON [SP_Login] TO DocGia
GRANT EXECUTE ON [SP_Change_Account_Password] TO DocGia
GRANT EXECUTE ON [SP_Account_Profile] TO DocGia
GRANT EXECUTE ON [SP_Find_Book_By_Advanced] TO DocGia
GRANT EXECUTE ON [SP_Find_TacGia] TO DocGia
GRANT EXECUTE ON [SP_Find_NXB] TO DocGia
GRANT EXECUTE ON [SP_Find_TheLoai] TO DocGia
GRANT SELECT ON [FN_Reader_Borrowed_Detail] TO DocGia
GRANT SELECT ON [FN_Reader_Penalty_List] TO DocGia
GRANT SELECT ON [FN_Reader_Borrowed_List] TO DocGia



