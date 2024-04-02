using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class PhanQuyen
    {
        public PhanQuyen(int maChucVu, int maChucNang)
        {
            this.MaChucVu = maChucVu;
            this.MaChucNang = maChucNang;
        }

        public PhanQuyen(DataRow row)
        {
            this.MaChucVu = (int)row["MaChucVu"];
            this.MaChucNang = (int)row["MaChucNang"];
        }

        private int maChucVu;
        public int MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }

        private int maChucNang;
        public int MaChucNang
        {
            get { return maChucNang; }
            set { maChucNang = value; }
        }
    }
}
