using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class ThuThu
    {
        public ThuThu(int maThuThu, string tenTaiKhoan)
        {
            this.MaThuThu = maThuThu;
            this.TenTaiKhoan = tenTaiKhoan;
        }

        public ThuThu(DataRow row)
        {
            this.MaThuThu = (int)row["MaThuThu"];
            this.TenTaiKhoan = row["TenTaiKhoan"].ToString();
        }

        private int maThuThu;
        public int MaThuThu
        {
            get { return maThuThu; }
            set { maThuThu = value; }
        }

        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
    }
}
