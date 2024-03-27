using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement.DAO
{
    internal class PhanQuyenDAO
    {
        private static PhanQuyenDAO instance;
        public static PhanQuyenDAO Instance
        {
            get { if (instance == null) instance = new PhanQuyenDAO(); return instance; }
            private set { instance = value; }
        }

        private PhanQuyenDAO() { }

        public (string, List<string>) GetAccountAuthorization(int maChucVu)
        {
            string query = "SP_Get_Account_Position_Functions @MaChucVu ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maChucVu });

            string chucVu = null;
            List<string> chucNangs = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                if (chucVu == null)
                {
                    chucVu = row["TenChucVu"].ToString();
                }

                string chucNang = row["TenChucNang"].ToString();
                chucNangs.Add(chucNang);
            }

            return (chucVu, chucNangs);
        }
    }
}
