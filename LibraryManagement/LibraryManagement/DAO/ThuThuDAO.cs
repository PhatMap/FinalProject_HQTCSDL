using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class ThuThuDAO
    {
        private static ThuThuDAO instance;
        public static ThuThuDAO Instance
        {
            get { if (instance == null) instance = new ThuThuDAO(); return instance; }
            private set { instance = value; }
        }

        private ThuThuDAO() { }

        public List<ThuThu> LoadThuThuList()
        {
            List<ThuThu> ThuThuList = new List<ThuThu>();

            string query = "SELECT * FROM VW_Librarian_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThuThuList.Add(new ThuThu(item));
            }
            return ThuThuList;
        }
    }
}
