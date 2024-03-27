using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int maTaiKhoan, string tenTaiKhoan, string matKhau, string diaChi, string email, DateTime ngaySinh, int maChucVu, bool gioiTinh)
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.DiaChi = diaChi;
            this.Email = email;
            this.NgaySinh = ngaySinh;
            this.MaChucVu = maChucVu;
            this.GioiTinh = gioiTinh;
        }

        public TaiKhoan(DataRow row)
        {
            this.MaTaiKhoan = (int)row["MaTaiKhoan"];
            this.TenTaiKhoan = row["TenTaiKhoan"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Email = row["Email"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.MaChucVu = (int)row["MaChucVu"];
            this.GioiTinh = (bool)row["GioiTinh"];
        }

        public TaiKhoan()
        {
        }

        private int maTaiKhoan;
        public int MaTaiKhoan 
        {  
            get { return maTaiKhoan; } 
            set { maTaiKhoan = value; } 
        }

        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private int maChucVu;
        public int MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }

        private bool gioiTinh;
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

    }
}
