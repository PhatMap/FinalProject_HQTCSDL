using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;
        public static TheLoaiDAO Instance
        {
            get { if (instance == null) instance = new TheLoaiDAO(); return instance; }
            private set { instance = value; }
        }
        private TheLoaiDAO() { }
        public DataTable LoadGenreList()
        {
            string query = "SELECT * FROM VW_Genre_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public void AddGenre(TheLoai tl)
        {
            string query = "SP_Add_New_Genre @TenTheLoai ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tl.TenTheLoai });
        }
        public bool UpdateGenre(TheLoai tl)
        {
            string query = "SP_Update_Genre @MaTheLoai , @TenTheLoai ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tl.MaTheLoai, tl.TenTheLoai });

            return result > 0;
        }
        public DataTable FindGenre(TheLoai tl)
        {
            object matheloai = tl.MaTheLoai;
            object tentheloai = tl.TenTheLoai;

            if (tl.MaTheLoai == 0)
            {
                matheloai = DBNull.Value;
            }
            if (tl.TenTheLoai == "")
            {
                tentheloai = DBNull.Value;
            }

            string query = "SP_Find_Genre @MaTheLoai , @TenTheLoai ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { matheloai, tentheloai });
            return data;
        }
        public void DeleteGenre(TheLoai tl)
        {
            string query = "SP_Delete_Genre @MaTheLoai , @TenTheLoai ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tl.MaTheLoai , tl.TenTheLoai });
        }
    }
}
