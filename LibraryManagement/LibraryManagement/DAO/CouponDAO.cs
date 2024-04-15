using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    internal class CouponDAO
    {
        private static CouponDAO instance;
        public static CouponDAO Instance
        {
            get { if (instance == null) instance = new CouponDAO(); return instance; }
            private set { instance = value; }
        }
        private CouponDAO() { }
        public List<PhieuMuon> LoadPhieuMuonList()
        {
            List<PhieuMuon> PhieuMuonList = new List<PhieuMuon>();

            string query = "SELECT * FROM PhieuMuonSach";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuonList.Add(new PhieuMuon(item));
            }
            return PhieuMuonList;
        }
    }
}
