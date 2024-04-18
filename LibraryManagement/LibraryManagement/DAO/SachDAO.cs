using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return instance; }
            private set { instance = value; }
        }

        private SachDAO() 
        {
        
        }
        public DataTable LoadBookList()
        {
            string query = "SELECT * FROM VW_Book_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadTacGia()
        {
            string query = "Select * from VW_TacGia_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadNhaXuatBan()
        {
            string query = "Select * from VW_NhaXuatBan_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadTheLoai()
        {
            string query = "Select * from VW_TheLoai_List";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void AddBook(Sach s)
        {
            string query = "SP_Add_New_Book @MaTacGia , @MaTheLoai , @MaNhaXuatBan , @TenSach , @LoaiTaiLieu , @NamXuatBan , @GiaSach , @SoLuong ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { s.MaTacGia, s.MaTheLoai, s.MaNhaXuatBan, s.TenSach, s.LoaiTaiLieu, s.NamXuatBan, s.GiaSach, s.SoLuong });
        }
        public bool UpdateBook(Sach s)
        {
            string query = "SP_Update_Book @MaTacGia , @MaTheLoai , @MaNhaXuatBan , @TenSach , @LoaiTaiLieu , @NamXuatBan , @GiaSach , @SoLuong ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { s.MaTacGia, s.MaTheLoai, s.MaNhaXuatBan, s.TenSach, s.LoaiTaiLieu, s.NamXuatBan, s.GiaSach, s.SoLuong });
            return result > 0;
        }

        public DataTable FindBookByAdvanced(Sach s)
        {
            object tacGia = s.TenTacGia;
            object maTheLoai = s.TenTheLoai;
            object maNhaXuatBan = s.TenNhaXuatBan;
            object tenSach = s.TenSach;
            object loaiTaiLieu = s.LoaiTaiLieu;
            object namXuatBan = s.NamXuatBan;
            if (s.TenTacGia == null)
            {
                tacGia = DBNull.Value;
            }
            if (s.TenTheLoai == null)
            {
                maTheLoai = DBNull.Value;
            }
            if (s.TenNhaXuatBan == null)
            {
                maNhaXuatBan = DBNull.Value;
            }
            if (s.TenSach == "")
            {
                tenSach = DBNull.Value;
            }
            if (s.LoaiTaiLieu == "")
            {
                loaiTaiLieu = DBNull.Value;
            }
            if (s.NamXuatBan == 0)
            {
                namXuatBan = DBNull.Value;
            }
            string query = "SP_Find_Book_By_Advanced @TenTacGia , @TenTheLoai , @TenNhaXuatBan , @TenSach , @LoaiTaiLieu , @NamXuatBan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tacGia, maTheLoai, maNhaXuatBan, tenSach, loaiTaiLieu, namXuatBan });
            return data;
        }
        public void DeleteBook(int maSach)
        {
            string query = "SP_Delete_Book @MaSach ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { maSach });
        }
        public int TotalAvailableBooks()
        {
            string query = "SELECT * FROM FN_Total_Available_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
        public int TotalBorrowedBooks()
        {
            string query = "SELECT * FROM FN_Total_Borrowed_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
        public int TotalDamagedOrLostBooks()
        {
            string query = "SELECT * FROM FN_Total_Damaged_Or_Lost_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
        public int TotalBooks()
        {
            string query = "SELECT * FROM FN_Total_Books()";
            object total = DataProvider.Instance.ExecuteScalar(query);
            return (int)total;
        }
    }
}
