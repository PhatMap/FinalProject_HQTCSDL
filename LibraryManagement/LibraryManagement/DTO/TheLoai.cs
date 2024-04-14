using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class TheLoai
    {
        private int matheloai;
        private string tentheloai;
        public int MaTheLoai
        {
            get { return matheloai; }
            set { matheloai = value; }
        }
        public string TenTheLoai
        {
            get { return tentheloai; }
            set { tentheloai = value; }
        }
        public TheLoai() { }
        public TheLoai(int matheloai, string tentheloai)
        {
            this.MaTheLoai = matheloai;
            this.TenTheLoai = tentheloai;
        }
        public TheLoai(DataRow row)
        {
            this.MaTheLoai = (int)row["MaTheLoai"];
            this.TenTheLoai = row["TenTheLoai"].ToString();
        }
    }
}
