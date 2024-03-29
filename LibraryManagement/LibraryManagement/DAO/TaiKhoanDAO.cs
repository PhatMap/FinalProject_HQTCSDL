﻿using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public bool Login(string email, string passWord) 
        {
            string query = "SP_Login @Email , @MatKhau ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ email, passWord});

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
            string query = "SELECT * FROM FN_Get_Account_Profile( @Email )";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ email });

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

        public bool UpdateProfile(TaiKhoan newTK)
        {
            string query = "SP_Update_Account_Profile @TenTaiKhoan , @DiaChi , @NgaySinh , @Email , @GioiTinh ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newTK.TenTaiKhoan, newTK.DiaChi, newTK.NgaySinh, newTK.Email, newTK.GioiTinh });

            return result > 0;
        }

        public void AddAccount(TaiKhoan tk)
        {
            string query = "SP_Add_New_Account @TenTaiKhoan , @MatKhau , @DiaChi , @NgaySinh , @Email , @MaChucVu , @GioiTinh ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tk.TenTaiKhoan, tk.MatKhau, tk.DiaChi, tk.NgaySinh.ToString("yyyy-MM-dd"), tk.Email, tk.MaChucVu, tk.GioiTinh });
        }
    }
}
