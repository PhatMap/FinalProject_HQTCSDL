using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class PhanCong
    {
        public PhanCong(DateTime ngayDauTuan, DateTime ngayCuoiTuan, string tenTaiKhoan, string thu, string buoi)
        {
            this.NgayDauTuan = ngayDauTuan;
            this.NgayCuoiTuan = ngayCuoiTuan;
            this.TenTaiKhoan = tenTaiKhoan;
            this.Thu = thu;
            this.Buoi = buoi;   
        }

        public PhanCong(DataRow row)
        {
            this.NgayDauTuan = (DateTime)row["NgayDauTuan"];
            this.NgayCuoiTuan = (DateTime)row["NgayCuoiTuan"]; 
            this.TenTaiKhoan = row["TenTaiKhoan"].ToString();
            this.Thu = row["Thu"].ToString();
            this.Buoi = row["Buoi"].ToString();
        }


        private DateTime ngayDauTuan;
        public DateTime NgayDauTuan
        {
            get { return ngayDauTuan; }
            set { ngayDauTuan = value; }
        }

        private DateTime ngayCuoiTuan;
        public DateTime NgayCuoiTuan
        {
            get { return ngayCuoiTuan; }
            set { ngayCuoiTuan = value; }
        }

        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private string thu;
        public string Thu
        {
            get { return thu; }
            set { thu = value; }
        }

        private string buoi;
        public string Buoi
        {
            get { return buoi; }
            set { buoi = value; }
        }
    }
}
