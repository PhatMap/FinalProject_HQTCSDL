using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class CuonSachDAO
    {
        private static CuonSachDAO instance;
        public static CuonSachDAO Instance
        {
            get { if (instance == null) instance = new CuonSachDAO(); return instance; }
            private set { instance = value; }
        }

        private CuonSachDAO()
        {

        }

        public void AddCuonSachToPhieuMuon(int maPhieuMuon)
        {
            string query = "SP_Add_Books_To_Coupon @MaSach , @MaPhieuMuon ";
            foreach (int maSach in Session.booksID)
            {
                DataProvider.Instance.ExecuteQuery(query, new object[] { maSach, maPhieuMuon });
            }
        }

        public void UpdateStatus(int maPhieuMuon, int maSach, string tinhTrang)
        {
            string query = "SP_Update_Book_In_Coupon @MaPhieuMuon , @MaSach , @TinhTrang ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maPhieuMuon, maSach, tinhTrang });
        }
    }
}
