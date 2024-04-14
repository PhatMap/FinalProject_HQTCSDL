using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class PhieuMuonSach
    {
        private int maPhieuMuon;
        private int maSach;
        private int maTaiKhoan;
        private string tinhTrang;
        private DateTime ngayMuon;
        private DateTime ngayTra;

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
        public int MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public DateTime NgayTra

        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        public PhieuMuonSach(int maphieumuon, int masach, int mataikhoan, string tinhtrang, DateTime ngaymuon, DateTime ngaytra)
        {
            this.MaPhieuMuon = maphieumuon;
            this.MaSach = masach;
            this.MaTaiKhoan = mataikhoan;
            this.TinhTrang = tinhtrang;
            this.NgayMuon = ngaymuon;
            this.NgayTra = ngaytra;
        }
        public PhieuMuonSach(DataRow row)
        {
            this.MaPhieuMuon = (int)row["MaPhieuMuon"];
            this.MaSach = (int)row["MaSach"];
            this.MaTaiKhoan = (int)row["MaTaiKhoan"];
            this.TinhTrang = row["TinhTrang"].ToString();
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayTra = (DateTime)row["NgayTra"];
        }

        public PhieuMuonSach()
        {
        }
    }
}
