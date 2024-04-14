using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fCoupon : Form
    {
        BindingSource phieumuonList = new BindingSource();
        public fCoupon()
        {
            InitializeComponent();
            dgvPhieuMuon.DataSource = phieumuonList;


            DetachCouponBinding();

            LoadCouponList();
        }
        private void LoadCouponList()
        {
            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.LoadBookLoanCouponList();
        }
        private void LoadBook_Status(string status)
        {
            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.LoadBook_Status(status);
        }
        private void DetachCouponBinding()
        {
            txtBoxMaPhieuMuon.DataBindings.Clear();
            txtBoxMaSach.DataBindings.Clear();
            txtBoxMaTaiKhoan.DataBindings.Clear();
            dateNgayMuon.DataBindings.Clear();
            dateNgayTra.DataBindings.Clear();
            comboBoxTinhTrang.DataBindings.Clear();
        }

        private void rbDangMuon_CheckedChanged(object sender, EventArgs e)
        {
            LoadBook_Status("Đang mượn");
        }

        private void rbDaTra_CheckedChanged(object sender, EventArgs e)
        {
            LoadBook_Status("Đã Trả");
        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadCouponList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuMuonSach pm = new PhieuMuonSach();
            if (string.IsNullOrEmpty(txtBoxMaTaiKhoan.Text))
            {
                MessageBox.Show("Dien Ma Tai Khoan");
            }
            else if (string.IsNullOrEmpty(txtBoxMaSach.Text)) { MessageBox.Show("Dien Ma Sach"); }
            else
            {

                pm.MaTaiKhoan = int.Parse(txtBoxMaTaiKhoan.Text);
                pm.MaSach = int.Parse(txtBoxMaSach.Text);
                pm.NgayMuon = dateNgayMuon.Value;
                pm.NgayTra = dateNgayTra.Value;

                PhieuMuonSachDAO.Instance.AddBookLoanCoupon(pm);

                LoadCouponList();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DetachCouponBinding();
            CouponBinding();
            PhieuMuonSach pm = new PhieuMuonSach();
            pm.MaTaiKhoan = int.Parse(txtBoxMaTaiKhoan.Text);
            pm.MaSach = int.Parse(txtBoxMaSach.Text);
            pm.NgayMuon = dateNgayMuon.Value;
            pm.NgayTra = dateNgayTra.Value;
            PhieuMuonSachDAO.Instance.DeleteCoupon(pm);
            LoadCouponList();
            DetachCouponBinding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuMuonSach pm = new PhieuMuonSach();
            pm.MaPhieuMuon = int.Parse(txtBoxMaPhieuMuon.Text);
            pm.MaTaiKhoan = int.Parse(txtBoxMaTaiKhoan.Text);
            pm.MaSach = int.Parse(txtBoxMaSach.Text);
            pm.NgayMuon = dateNgayMuon.Value;
            pm.NgayTra = dateNgayTra.Value;
            PhieuMuonSachDAO.Instance.UpdateCoupon(pm);
            LoadCouponList();
        }
        private void CouponBinding()
        {
            txtBoxMaPhieuMuon.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaPhieuMuon"));
            txtBoxMaSach.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaSach"));
            txtBoxMaTaiKhoan.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaTaiKhoan"));
            dateNgayMuon.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "NgayMuon"));
            dateNgayTra.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "NgayTra"));
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetachCouponBinding();
            CouponBinding();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            PhieuMuonSach pm = new PhieuMuonSach();
            pm.MaPhieuMuon = int.Parse(txtBoxMaPhieuMuon.Text);
            PhieuMuonSachDAO.Instance.UpdateCoupon_Returned(pm);
            LoadCouponList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            PhieuMuonSach pm = new PhieuMuonSach
            {
                MaTaiKhoan = string.IsNullOrEmpty(txtBoxMaTaiKhoan.Text) ? 0 : int.Parse(txtBoxMaTaiKhoan.Text),
                MaPhieuMuon = string.IsNullOrEmpty(txtBoxMaPhieuMuon.Text) ? 0 : int.Parse(txtBoxMaPhieuMuon.Text),
                MaSach = string.IsNullOrEmpty(txtBoxMaSach.Text) ? 0 : int.Parse(txtBoxMaSach.Text)
            };

            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.FindBookLoanCoupon(pm);
        }
    }
}
