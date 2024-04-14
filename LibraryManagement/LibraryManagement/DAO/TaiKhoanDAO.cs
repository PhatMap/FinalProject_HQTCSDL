using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public bool Login(string email, string matKhau)
        {
            string query = "SP_Login @Email , @MatKhau ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email, matKhau });

            return result.Rows.Count > 0;
        }

        public DataTable LoadAccountList()
        {
            string query = "SELECT * FROM VW_Account_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public TaiKhoan GetAccountProfile(string email)
        {
            string query = "SP_Get_Account_Profile @Email ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email });

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }

        public bool ChangeAccountPassword(string email, string newPass, string confirm, string oldPass)
        {
            string query = "SP_Change_Account_Password @Email , @MatKhauMoi , @XacNhan , @MatKhauCu ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { email, newPass, confirm, oldPass });

            return result > 0;
        }

        public bool UpdateAccount(TaiKhoan tk)
        {
            string query = "SP_Update_Account @MaTaiKhoan , @HoTen , @MatKhau , @DiaChi , @NgaySinh , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.MatKhau, tk.DiaChi, tk.NgaySinh, tk.Email, tk.SoDienThoai, tk.VaiTro, tk.GioiTinh });

            return result > 0;
        }

        public void AddAccount(TaiKhoan tk)
        {
            string query = "SP_Add_New_Account @MaTaiKhoan , @HoTen , @MatKhau , @DiaChi , @NgaySinh , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.MatKhau, tk.DiaChi, tk.NgaySinh, tk.Email, tk.SoDienThoai, tk.VaiTro, tk.GioiTinh });
        }

        public void DeleteAccount(int maTaiKhoan)
        {
            string query = "SP_Delete_Account @MaTaiKhoan ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan });
        }

        public DataTable FindAccountByAdvanced(TaiKhoan tk)
        {
            object maTaiKhoan = tk.MaTaiKhoan;
            object hoTen = tk.HoTen;
            object email = tk.Email;
            object vaiTro = tk.VaiTro;
            object gioiTinh = tk.GioiTinh;
            object diaChi = tk.DiaChi;
            object soDienThoai = tk.SoDienThoai;
            if (tk.MaTaiKhoan == 0)
            {
                maTaiKhoan = DBNull.Value;
            }
            if (tk.HoTen == "")
            {
                hoTen = DBNull.Value;
            }
            if (tk.Email == "")
            {
                email = DBNull.Value;
            }
            if (tk.VaiTro == null)
            {
                vaiTro = DBNull.Value;
            }
            if (tk.GioiTinh == null)
            {
                gioiTinh = DBNull.Value;
            }
            if (tk.DiaChi == "")
            {
                diaChi = DBNull.Value;
            }
            if (tk.SoDienThoai == "")
            {
                soDienThoai = DBNull.Value;
            }

            string query = "SP_Find_Account_By_Advanced @MaTaiKhoan , @HoTen , @DiaChi , @Email , @SoDienThoai , @VaiTro , @GioiTinh ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan, hoTen, diaChi, email, soDienThoai, vaiTro, gioiTinh });
            return data;
        }

        public DataTable LoadLibrarian()
        {
            string query = "Select * from VW_Librarian_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
// acascnojad