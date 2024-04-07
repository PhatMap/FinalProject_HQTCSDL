using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class LichLamViecDAO
    {
        private static LichLamViecDAO instance;
        public static LichLamViecDAO Instance
        {
            get { if (instance == null) instance = new LichLamViecDAO(); return instance; }
            private set { instance = value; }
        }

        private LichLamViecDAO() { }

        public DataTable LoadLichLamViecList()
        {
            string query = "SELECT * FROM VW_Shift_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void AddNewSchedule(LichLamViec lich)
        {
            string query = "SP_Add_New_Schedule @NgayLam , @Ca , @MaTaiKhoan ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { lich.NgayLam, lich.Ca, lich.MaTaiKhoan});
        }
        public void UpdateSchedule(LichLamViec lich)
        {
            string query = "SP_Update_Schedule @MaLichLamViec , @NgayLam , @Ca , @MaTaiKhoan ";

            DataProvider.Instance.ExecuteQuery(query, new object[] { lich.MaLichLamViec, lich.NgayLam, lich.Ca, lich.MaTaiKhoan });
        }
        public void DeleteSchedule(int id)
        {
            string query = "SP_Delete_Schedule @MaLichLamViec ";

            DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
    }
}
