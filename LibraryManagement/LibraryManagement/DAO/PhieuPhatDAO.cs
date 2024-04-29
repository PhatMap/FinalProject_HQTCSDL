using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class PhieuPhatDAO
    {
        private static PhieuPhatDAO instance;
        public static PhieuPhatDAO Instance
        {
            get { if (instance == null) instance = new PhieuPhatDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuPhatDAO() { }

        public DataTable LoadPhieuPhatList()
        {
            string query = "SELECT * FROM VW_PhieuPhat_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable LoadPhieuPhatListByStatus(int type)
        {
            string query = "SP_Get_Penalty_Coupon_By_Status @type ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { type });

            return data;
        }

        public DataTable LoadReaderPenalty(int maTaiKhoan, int type)
        {
            string query = "SELECT * FROM FN_Reader_Penalty_List( @MaTaiKhoan , @type )";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan, type });

            return data;
        }

        public void AddPhieuPhat(PhieuPhat pp)
        {
            string query = "SP_Add_New_PhieuPhat @MaPhieuMuon ";

            DataProvider.Instance.ExecuteQuery(query, new object[] { pp.MaPhieuMuon });
        }

        public void DeletePhieuPhat(int maPhieuPhat)
        {
            string query = "SP_Delete_PhieuPhat @MaPhieuPhat ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieuPhat });
        }

        public DataTable FindPhieuPhat(int id)
        {
            string query = "SP_Find_PhieuPhat @MaTaiKhoan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return data;
        }
        public int TotalPenaltyCouponsByMonth(int month, int year)
        {
            string query = "SELECT * FROM dbo.FN_Total_Penalty_Coupons_By_Month( @month , @year )";
            object total = DataProvider.Instance.ExecuteScalar(query, new object[] { month, year });
            return (int)total;
        }

        public void PayDebt(int maPhieuPhat)
        {
            string query = "SP_Pay_Penalty_Coupon_Debt @MaPhieuPhat ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhieuPhat });
        }
    }
}