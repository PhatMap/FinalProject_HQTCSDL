using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.DAO
{
    public class PhieuMuonSachDAO
    {
        private static PhieuMuonSachDAO instance;
        public static PhieuMuonSachDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuonSachDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuMuonSachDAO() { }
        public DataTable LoadBookLoanCouponList()
        {
            string query = "SELECT * FROM VW_Book_Loan_Coupon_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable LoadReaderBorrowed(int maTaiKhoan, int type)
        {
            string query = "SELECT * FROM FN_Reader_Borrowed_List( @MaTaiKhoan , @type )";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan, type });

            return data;
        }
        public DataTable LoadBook_Status(int type)
        {
            string query = "SP_Find_Book_Loan_Coupon_By_Status @type ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { type });

            return result;
        }
        public int AddBookLoanCoupon(PhieuMuonSach pm)
        {
            string query = "SP_Add_New_Book_Loan_Coupon @MaTaiKhoan , @NgayMuon , @NgayTra ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { pm.MaTaiKhoan, pm.NgayMuon, DBNull.Value } );
            if (data.Rows.Count > 0)
            {
                int insertedId = (int)data.Rows[0]["InsertedID"];
                return insertedId;
            }
            else
            {
                return -1;
            }
        }

        public void DeleteCoupon(int id)
        {
            string query = "SP_Delete_Coupon @MaPhieuMuon ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
        public bool UpdateCoupon(PhieuMuonSach pm)
        {
            string query = "SP_Update_Coupon @MaPhieuMuon , @MaTaiKhoan , @MaSach , @NgayMuon , @NgayTra ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { pm.MaPhieuMuon, pm.MaTaiKhoan, pm.NgayMuon, pm.NgayTra });

            return result > 0;
        }
        public void UpdateCoupon_Returned(int id)
        {
            string query = "SP_Update_Coupon_Returned @MaPhieuMuon ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public DataTable FindBookLoanCoupon(int id)
        {
            string query = "SP_Find_Account_Book_Loan_Coupon @MaTaiKhoan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return data;
        }
        public int TotalLoanCouponsByMonth(int month, int year)
        {
            string query = "SELECT * FROM dbo.FN_Total_Loan_Coupons_By_Month( @month , @year )";
            object total = DataProvider.Instance.ExecuteScalar(query, new object[] { month, year });
            return (int)total;
        }
    }
}
