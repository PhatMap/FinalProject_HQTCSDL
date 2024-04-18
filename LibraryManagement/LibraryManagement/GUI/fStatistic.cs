using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LibraryManagement.DAO;

namespace LibraryManagement.GUI
{

    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();

            LoadSachChart();

            LoadTaiKhoanChart();

            LoadPhieuMuonPhatChart();
        }

        private void LoadSachChart()
        {
            dgvTacGia.DataSource = TacGiaDAO.Instance.TotalAuthors();
            dgvtheLoai.DataSource = TheLoaiDAO.Instance.TotalCategories();
            dgvNXB.DataSource = NhaXuatBanDAO.Instance.TotalPublishers();

            int all = SachDAO.Instance.TotalBooks();
            int availabe = SachDAO.Instance.TotalAvailableBooks();
            int borrowed = SachDAO.Instance.TotalBorrowedBooks();
            int lostDamaged = SachDAO.Instance.TotalDamagedOrLostBooks();

            chartSach.Titles.Add("Tổng số sách: " + all);
            chartSach.Series["SachSeries"].Points.AddXY($"Hiện hữu  {availabe} ", availabe);
            chartSach.Series["SachSeries"].Points.AddXY($"Đang mượn  {borrowed} ", borrowed);
            chartSach.Series["SachSeries"].Points.AddXY($"Hư hoặc mất  {lostDamaged} ", lostDamaged);

            double total = chartSach.Series["SachSeries"].Points.Sum(p => p.YValues[0]);

            foreach (var point in chartSach.Series["SachSeries"].Points)
            {
                double percentage = (point.YValues[0] / total) * 100;
                point.Label = $"{percentage:F2}%";
                point.LegendText = point.AxisLabel;
            }
        }
        private void LoadTaiKhoanChart()
        {
            int all = TaiKhoanDAO.Instance.TotalAccounts();
            int clc = TaiKhoanDAO.Instance.TotalHighQualityStudentAccounts();
            int daiTra = TaiKhoanDAO.Instance.TotalMassStudentAccounts();
            int caoHoc = TaiKhoanDAO.Instance.TotalGraduateStudentAccounts();
            int giangVien = TaiKhoanDAO.Instance.TotalLecturerAccounts();
            int thuThu = TaiKhoanDAO.Instance.TotalLibrarianAccounts();
            int quanTriVien = TaiKhoanDAO.Instance.TotalAdministratorAccounts();

            chartTaiKhoan.Titles.Add("Tổng số tài khoản: " + all);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"CLC {clc}", clc);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Đại trà {daiTra}", daiTra);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Cao học {caoHoc}", caoHoc);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Giảng viên {giangVien}", giangVien);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Thủ thư {thuThu}", thuThu);
            chartTaiKhoan.Series["TaiKhoanSeries"].Points.AddXY($"Quản trị viên {quanTriVien}", quanTriVien);

            double total = chartTaiKhoan.Series["TaiKhoanSeries"].Points.Sum(p => p.YValues[0]);

            foreach (var point in chartTaiKhoan.Series["TaiKhoanSeries"].Points)
            {
                double percentage = (point.YValues[0] / total) * 100;
                point.Label = $"{percentage:F2}%";
                point.LegendText = point.AxisLabel;
            }
        }

        private void LoadPhieuMuonPhatChart()
        {
            int year = DateTime.Now.Year;

            for (int month = 1; month <= 12; month++)
            {
                int muon = PhieuMuonSachDAO.Instance.TotalLoanCouponsByMonth(month, year);
                int phat = PhieuPhatDAO.Instance.TotalPenaltyCouponsByMonth(month, year);

                muon = muon == null ? 0 : muon;
                phat = phat == null ? 0 : phat;

                chartMuonPhat.Series["MuonSeries"].Points.AddXY(month, muon);
                chartMuonPhat.Series["PhatSeries"].Points.AddXY(month, phat);

                chartMuonPhat.Series["MuonSeries"].Points[month - 1].Label = muon.ToString();
                chartMuonPhat.Series["PhatSeries"].Points[month - 1].Label = phat.ToString();

                chartMuonPhat.Series["MuonSeries"].Points[month - 1].LegendText = $"Muon {month}";
                chartMuonPhat.Series["PhatSeries"].Points[month - 1].LegendText = $"Phat {month}";
            }

            for (int i = 0; i < 12; i++)
            {
                chartMuonPhat.ChartAreas[0].AxisX.CustomLabels.Add(i + 1 - 0.5, i + 1 + 0.5, (i + 1).ToString());
            }

            chartMuonPhat.Series["MuonSeries"].LegendText = "Phiếu mượn";
            chartMuonPhat.Series["PhatSeries"].LegendText = "Phiếu phạt";

            chartMuonPhat.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartMuonPhat.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
        }
    }
}
