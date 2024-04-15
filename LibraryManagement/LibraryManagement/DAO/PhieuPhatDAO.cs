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

        public void AddPhieuPhat(PhieuPhat pp)
        {
            string query = "SP_Add_New_PhieuPhat @MaPhieuMuon , @TienPhat , @NgayTra ";

            DataProvider.Instance.ExecuteQuery(query, new object[] {pp.MaPhieuMuon, pp.TienPhat, pp.NgayTra});
        }

        public void DeletePhieuPhat(int maPhieuPhat)
        {
            string query = "SP_Delete_PhieuPhat @MaPhieuPhat ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieuPhat });
        }

        public bool UpdatePhieuPhat(PhieuPhat pp)
        {
            string query = "SP_Update_PhieuPhat @MaPhieuPhat , @MaPhieuMuon , @TienPhat , @NgayTra ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { pp.MaPhieuPhat, pp.MaPhieuMuon, pp.TienPhat, pp.NgayTra});

            return result > 0;
        }

        public DataTable FindPhieuPhatByAdvanced(PhieuPhat pp)
        {
            object maPhieuMuon = pp.MaPhieuMuon;
            object tienPhat = pp.TienPhat;
            object ngayTra = pp.NgayTra;

            if (pp.MaPhieuMuon == 0)
            {
                maPhieuMuon = DBNull.Value;
            }
            if (pp.TienPhat == 0)
            {
                tienPhat = DBNull.Value;
            }
            if (pp.NgayTra == null)
            {
                ngayTra = DBNull.Value;
            }

            string query = "SP_Find_PhieuPhat_By_Advanced @MaPhieuMuon , @TienPhat , @NgayTra ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieuMuon, tienPhat, ngayTra });
            return data;
        }
    }
}
