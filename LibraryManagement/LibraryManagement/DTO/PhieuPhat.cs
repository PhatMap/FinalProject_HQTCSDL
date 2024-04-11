using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class PhieuPhat
    {
        public PhieuPhat(int maPhieuPhat, int maPhieuMuon, int maTaiKhoan, int maLoaiTinhTrang, int tienPhat)
        {
            this.MaPhieuPhat = maPhieuPhat;
            this.MaPhieuMuon = maPhieuMuon;
            this.MaTaiKhoan = maTaiKhoan;
            this.MaLoaiTinhTrang = maLoaiTinhTrang;
            this.TienPhat = tienPhat;
        }

        public PhieuPhat(DataRow row)
        {
            this.MaPhieuPhat = (int)row["MaPhieuPhat"];
            this.MaPhieuMuon = (int)row["MaPhieuMuon"];
            this.MaTaiKhoan = (int)row["MaTaiKhoan"];
            this.MaLoaiTinhTrang = (int)row["MaLoaiTinhTrang"];
            this.TienPhat = (int)row["TienPhat"];
        }

        private int maPhieuPhat;
        public int MaPhieuPhat
        {
            get { return maPhieuPhat; }
            set { maPhieuPhat = value; }
        }

        private int maPhieuMuon;
        public int MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        private int maTaiKhoan;
        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }

        private int maLoaiTinhTrang;
        public int MaLoaiTinhTrang
        {
            get { return maLoaiTinhTrang; }
            set { maLoaiTinhTrang = value; }
        }

        private int tienPhat;
        public int TienPhat
        {
            get { return TienPhat; }
            set { TienPhat = value; }
        }
    }
}