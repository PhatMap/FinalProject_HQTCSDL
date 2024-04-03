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
            phieumuonList.DataSource = CouponDAO.Instance.LoadPhieuMuonList();
        }
        private void DetachCouponBinding()
        {
            txtBoxMaSach.DataBindings.Clear();
            txtBoxMaTaiKhoan.DataBindings.Clear();
            dateNgayMuon.DataBindings.Clear();
            dateNgayTraDK.DataBindings.Clear();
            dateNgayTraTT.DataBindings.Clear();
            comboBoxTinhTrang.DataBindings.Clear();
        }
    }
}
