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
    public partial class fBook : Form
    {
        BindingSource nhaxuatbanlist = new BindingSource();

        public fBook()
        {
            InitializeComponent();
            dgvNhaXuatBan.DataSource = nhaxuatbanlist;

            DetachNXBBinding();

            LoadNXBList();
        }
        private void DetachNXBBinding()
        {
            txtBoxMaNhaXuatBan.DataBindings.Clear();
            txtBoxTenNhaXuatBan.DataBindings.Clear();
        }
        private void LoadNXBList()
        {
            nhaxuatbanlist.DataSource = NhaXuatBanDAO.Instance.LoadNXBList();
        }
        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.TenNhaXuatBan = txtBoxTenNhaXuatBan.Text;
            NhaXuatBanDAO.Instance.AddNXB(nxb);
            LoadNXBList();
        }
        private void NXBBinding()
        {
            txtBoxTenNhaXuatBan.DataBindings.Add(new Binding("Text", dgvNhaXuatBan.DataSource, "TenNhaXuatBan"));
            txtBoxMaNhaXuatBan.DataBindings.Add(new Binding("Text", dgvNhaXuatBan.DataSource, "MaNhaXuatBan"));
        }
        private void btnEditNXB_Click_1(object sender, EventArgs e)
        {
            NhaXuatBan tl = new NhaXuatBan();
            tl.TenNhaXuatBan = txtBoxTenNhaXuatBan.Text;
            tl.MaNhaXuatBan = int.Parse(txtBoxMaNhaXuatBan.Text);
            NhaXuatBanDAO.Instance.UpdateNXB(tl);
            LoadNXBList();
        }

        private void btnFindNXB_Click_1(object sender, EventArgs e)
        {
            NhaXuatBan tl = new NhaXuatBan
            {
                MaNhaXuatBan = string.IsNullOrEmpty(txtBoxMaNhaXuatBan.Text) ? 0 : int.Parse(txtBoxMaNhaXuatBan.Text),
                TenNhaXuatBan = string.IsNullOrEmpty(txtBoxTenNhaXuatBan.Text) ? "" : txtBoxTenNhaXuatBan.Text,
            };

            nhaxuatbanlist.DataSource = NhaXuatBanDAO.Instance.FindNhaXuatBan(tl);
        }

        private void btnDeleteNXB_Click_1(object sender, EventArgs e)
        {
            DetachNXBBinding();
            NXBBinding();
            NhaXuatBan tl = new NhaXuatBan();
            tl.MaNhaXuatBan = int.Parse(txtBoxMaNhaXuatBan.Text);
            tl.TenNhaXuatBan = txtBoxTenNhaXuatBan.Text;
            NhaXuatBanDAO.Instance.DeleteNXB(tl);
            LoadNXBList();
            DetachNXBBinding();
        }

        private void dgvNhaXuatBan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DetachNXBBinding();
            NXBBinding();
        }
    }
}
