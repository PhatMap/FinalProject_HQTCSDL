using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class CaDAO
    {
        private static CaDAO instance;
        public static CaDAO Instance
        {
            get { if (instance == null) instance = new CaDAO(); return instance; }
            private set { instance = value; }
        }

        private CaDAO() { }

        public List<Ca> LoadCaList()
        {
            List<Ca> CaList = new List<Ca>();

            string query = "SELECT * FROM VW_Shift_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CaList.Add(new Ca(item));
            }
            return CaList;
        }
    }
}
