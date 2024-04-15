using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fCoupon : Form
    {
        BindingSource PhieuPhatList = new BindingSource();
        BindingSource phieumuonList = new BindingSource();

        public fCoupon()
        {
            InitializeComponent();

            dgvPhieuPhat.DataSource = PhieuPhatList;

            AddPhieuPhatBinding();

            LoadPhieuPhatList();

            dgvPhieuMuon.DataSource = phieumuonList;


            DetachCouponBinding();

            LoadCouponList();
        }

        private void LoadPhieuPhatList()
        {
            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.LoadPhieuPhatList();
        }

        private void AddPhieuPhatBinding()
        {
            numPhieuPhatID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "MaPhieuPhat"));
            numPhieuMuonID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "MaPhieuMuon"));
            numTienPhatID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "TienPhat"));
            dtpNgayTra.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "NgayTra"));
        }

        private void DetachPhieuPhatBinding()
        {
            numPhieuPhatID.DataBindings.Clear();
            numPhieuPhatID.DataBindings.Clear();
            numTienPhatID.DataBindings.Clear();
            dtpNgayTra.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();

            pp.MaPhieuMuon = (int)numPhieuPhatID.Value;
            pp.TienPhat = (decimal)numTienPhatID.Value;
            pp.NgayTra = dtpNgayTra.Value;

            PhieuPhatDAO.Instance.AddPhieuPhat(pp);

            LoadPhieuPhatList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuPhatDAO.Instance.DeletePhieuPhat((int)numPhieuPhatID.Value);
            LoadPhieuPhatList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maPhieuPhat = (int)numPhieuPhatID.Value;
            int maPhieuMuon = (int)numPhieuPhatID.Value;
            decimal tienPhat = (decimal)numTienPhatID.Value;
            DateTime ngayTra = dtpNgayTra.Value;

            PhieuPhat pp = new PhieuPhat();
            pp.MaPhieuPhat = maPhieuPhat;
            pp.MaPhieuMuon = maPhieuMuon;
            pp.TienPhat = tienPhat;
            pp.NgayTra = ngayTra;

            bool result = PhieuPhatDAO.Instance.UpdatePhieuPhat(pp);
            LoadPhieuPhatList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();
            pp.MaPhieuMuon = (int)numPhieuPhatID.Value;
            pp.TienPhat = (decimal)numTienPhatID.Value;
            pp.NgayTra = dtpNgayTra.Value;

            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.FindPhieuPhatByAdvanced(pp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadPhieuPhatList();
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

        private void CouponBinding()
        {
            txtBoxMaPhieuMuon.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaPhieuMuon"));
            txtBoxMaSach.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaSach"));
            txtBoxMaTaiKhoan.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaTaiKhoan"));
            dateNgayMuon.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "NgayMuon"));
            dateNgayTra.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "NgayTra"));
        }

        private void btnTimPM_Click(object sender, EventArgs e)
        {
            PhieuMuonSach pm = new PhieuMuonSach
            {
                MaTaiKhoan = string.IsNullOrEmpty(txtBoxMaTaiKhoan.Text) ? 0 : int.Parse(txtBoxMaTaiKhoan.Text),
                MaPhieuMuon = string.IsNullOrEmpty(txtBoxMaPhieuMuon.Text) ? 0 : int.Parse(txtBoxMaPhieuMuon.Text),
                MaSach = string.IsNullOrEmpty(txtBoxMaSach.Text) ? 0 : int.Parse(txtBoxMaSach.Text)
            };

            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.FindBookLoanCoupon(pm);
        }

        private void btnThemPM_Click(object sender, EventArgs e)
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

        private void btnSuaPM_Click(object sender, EventArgs e)
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

        private void btnXoaPM_Click(object sender, EventArgs e)
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
    }
}