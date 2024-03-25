using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class ChucNang
    {
        public ChucNang(int maChucNang, string tenChucNang)
        {
            this.MaChucNang = maChucNang;
            this.TenChucNang = tenChucNang;
        }

        public ChucNang(DataRow row)
        {
            this.MaChucNang = (int)row["MaChucNang"];
            this.TenChucNang = row["TenChucNang"].ToString();
        }

        private int maChucNang;
        public int MaChucNang
        {
            get { return maChucNang; }
            set { maChucNang = value; }
        }

        private string tenChucNang;
        public string TenChucNang
        {
            get { return tenChucNang; }
            set { tenChucNang = value; }
        }
    }
}
