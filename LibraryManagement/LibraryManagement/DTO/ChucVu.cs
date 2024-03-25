using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class ChucVu
    {
        public ChucVu(int maChucVu, string tenChucVu) 
        {
            this.MaChucVu = maChucVu;
            this.TenChucVu = tenChucVu;
        }

        public ChucVu(DataRow row) 
        {
            this.MaChucVu = (int)row["MaChucVu"];
            this.TenChucVu = row["TenChucVu"].ToString();
        }

        private int maChucVu;
        public int MaChucVu 
        {  
            get { return maChucVu; } 
            set { maChucVu = value; } 
        }

        private string tenChucVu;
        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }
    }
}
