using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class PhanCongDAO
    {
        private static PhanCongDAO instance;
        public static PhanCongDAO Instance
        {
            get { if (instance == null) instance = new PhanCongDAO(); return instance; }
            private set { instance = value; }
        }

        private PhanCongDAO() { }

        public List<PhanCong> LoadPhanCongList()
        {
            List<PhanCong> phanCongList = new List<PhanCong>();

            string query = "SELECT * FROM VW_Assignment_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                phanCongList.Add(new PhanCong(item));
            }
            return phanCongList;
        }
    }
}
