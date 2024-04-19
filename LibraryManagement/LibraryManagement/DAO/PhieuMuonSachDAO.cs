using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string query = "SELECT * FROM VW_BookLoanCoupon_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable LoadReaderBorrowed(int maTaiKhoan, int type)
        {
            string query = "SELECT * FROM FN_Reader_Borrowed_List( @MaTaiKhoan , @type )";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan, type });

            return data;
        }
        public DataTable LoadBook_Status(string status)
        {
            string query = "SP_Find_BookLoanCoupon_By_Status @Status ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { status });

            return result;
        }
        public void AddBookLoanCoupon(PhieuMuonSach pm)
        {
            object ngaytra = pm.NgayTra;

            DateTime today = DateTime.Now;

            if (pm.NgayTra > today)
            {
                ngaytra = pm.NgayTra;
            }
            else ngaytra = DBNull.Value;

            string query = "SP_Add_New_BookLoanCoupon @MaTaiKhoan , @MaSach , @NgayMuon , @NgayTra ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { pm.MaTaiKhoan, pm.MaSach, pm.NgayMuon, ngaytra });
        }
        public void DeleteCoupon(PhieuMuonSach pm)
        {
            string query = "SP_Delete_Coupon @MaTaiKhoan , @MaSach ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { pm.MaTaiKhoan, pm.MaSach });
        }
        public bool UpdateCoupon(PhieuMuonSach pm)
        {
            string query = "SP_Update_Coupon @MaPhieuMuon , @MaTaiKhoan , @MaSach , @NgayMuon , @NgayTra ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { pm.MaPhieuMuon, pm.MaTaiKhoan, pm.MaSach, pm.NgayMuon, pm.NgayTra });

            return result > 0;
        }
        public bool UpdateCoupon_Returned(PhieuMuonSach pm)
        {
            string query = "SP_Update_Coupon_Returned @MaPhieuMuon ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { pm.MaPhieuMuon });

            return result > 0;
        }
        public DataTable FindBookLoanCoupon(PhieuMuonSach pm)
        {
            object maphieumuon = pm.MaPhieuMuon;
            object mataikhoan = pm.MaTaiKhoan;
            object masach = pm.MaSach;

            if (pm.MaPhieuMuon == 0)
            {
                maphieumuon = DBNull.Value;
            }
            if (pm.MaTaiKhoan == 0)
            {
                mataikhoan = DBNull.Value;
            }
            if (pm.MaSach == 0)
            {
                masach = DBNull.Value;
            }

            string query = "SP_Find_BookLoan_Coupon_By_Advanced @MaSach , @MaTaiKhoan , @MaPhieuMuon ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { masach, mataikhoan, maphieumuon });
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
