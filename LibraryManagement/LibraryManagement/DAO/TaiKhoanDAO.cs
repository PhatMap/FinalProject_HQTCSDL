using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Login(string userName, string passWord) 
        {
            string query = "SP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, passWord});

            return result.Rows.Count > 0;
        }

        public DataTable LoadAccountList()
        {
            string query = "SELECT * FROM VW_Account_List";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public TaiKhoan GetAccountProfile(string userName)
        {
            string query = "SP_Get_Account_Profile @userName";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ userName});

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }
    }
}
