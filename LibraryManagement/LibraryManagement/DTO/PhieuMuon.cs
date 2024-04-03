using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    internal class PhieuMuon
    {
        private int maPhieuMuon;
        private int maSach;
        private int maTinhTrang;
        private int maTaiKhoan;
        private DateTime ngayMuon;
        private DateTime ngayTraDuKien;
        private DateTime ngayTraThucTe;

        public int MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }
        public int MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public int MaTinhTrang
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }
        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public DateTime NgayTraDuKien
        {
            get { return ngayTraDuKien; }
            set { ngayTraDuKien = value; }
        }
        public DateTime NgayTraThucTe
        {
            get { return ngayTraThucTe; }
            set { ngayTraThucTe = value; }
        }
        public PhieuMuon(int maphieumuon, int masach, int matinhtrang, int mataikhoan, DateTime ngaymuon, DateTime ngaytradukien, DateTime ngaytrathucte)
        {
            this.MaPhieuMuon = maphieumuon;
            this.MaSach = masach;
            this.MaTinhTrang = matinhtrang;
            this.MaTaiKhoan = mataikhoan;
            this.NgayMuon = ngaymuon;
            this.NgayTraDuKien = ngaytradukien;
            this.NgayTraThucTe = ngaytrathucte;
        }

        public PhieuMuon(DataRow row)
        {
            this.MaPhieuMuon = (int)row["MaPhieuMuon"];
            this.MaSach = (int)row["MaSach"];
            this.MaTinhTrang = (int)row["MaTinhTrang"];
            this.MaTaiKhoan = (int)row["MaTaiKhoan"];
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayTraDuKien = (DateTime)row["NgayTraDuKien"];
            this.NgayTraThucTe = (DateTime)row["NgayTraThucTe"];
        }
    }
}
