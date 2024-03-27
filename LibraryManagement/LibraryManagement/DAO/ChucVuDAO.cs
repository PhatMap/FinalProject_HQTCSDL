using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return instance; }
            private set { instance = value; }
        }

        private ChucVuDAO() { }

        public List<ChucVu> LoadChucVuList()
        {
            List<ChucVu> chucVuList = new List<ChucVu>();

            string query = "SELECT * FROM VW_Position_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                chucVuList.Add(new ChucVu(item));
            }
            return chucVuList;  
        }
    }
}
