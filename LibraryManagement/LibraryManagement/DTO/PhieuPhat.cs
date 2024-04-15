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
        public PhieuPhat(int maPhieuPhat, int maPhieuMuon, decimal tienPhat, DateTime ngayTra)
        {
            this.MaPhieuPhat = maPhieuPhat;
            this.MaPhieuMuon = maPhieuMuon;
            this.TienPhat = tienPhat;
            this.NgayTra = ngayTra;
        }

        public PhieuPhat(DataRow row)
        {
            this.MaPhieuPhat = (int)row["MaPhieuPhat"];
            this.MaPhieuMuon = (int)row["MaPhieuMuon"];
            this.TienPhat = (decimal)row["TienPhat"];
            this.NgayTra = (DateTime)row["NgayTra"];
        }

        public PhieuPhat()
        {
        }

        private int maPhieuPhat;
        private int maPhieuMuon;
        private decimal tienPhat;
        private DateTime ngayTra;

        public int MaPhieuPhat
        {
            get
            {
                return maPhieuPhat;
            }

            set
            {
                maPhieuPhat = value;
            }
        }

        public int MaPhieuMuon
        {
            get
            {
                return maPhieuMuon;
            }

            set
            {
                maPhieuMuon = value;
            }
        }

        public decimal TienPhat
        {
            get
            {
                return tienPhat;
            }

            set
            {
                tienPhat = value;
            }
        }

        public DateTime NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }
    }
}