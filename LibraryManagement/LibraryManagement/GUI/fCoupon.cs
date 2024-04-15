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

        public fCoupon()
        {
            InitializeComponent();

            dgvPhieuPhat.DataSource = PhieuPhatList;

            AddPhieuPhatBinding();

            LoadPhieuPhatList();

        }

        private void LoadPhieuPhatList()
        {
            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.LoadPhieuPhatList();
        }

        private void AddPhieuPhatBinding()
        {
            numPhieuPhatID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "MaPhieuPhat"));
            numPhieuPhatID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "MaPhieuMuon"));
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
    }
}