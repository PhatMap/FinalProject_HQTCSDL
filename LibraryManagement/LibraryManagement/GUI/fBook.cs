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
        BindingSource sachList = new BindingSource();
        BindingSource tacGiaList = new BindingSource();
        BindingSource TheLoaiList = new BindingSource();
 BindingSource nhaxuatbanlist = new BindingSource();

        public fBook()
        {
            InitializeComponent();

            dgvSach.DataSource = sachList;
            dgvTacGia.DataSource = tacGiaList;

            dgvTheLoai.DataSource = TheLoaiList;

            cbTacGia.DataSource = SachDAO.Instance.LoadTacGia();
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";

            cbNhaXuatBan.DataSource = SachDAO.Instance.LoadNhaXuatBan();
            cbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbNhaXuatBan.ValueMember = "MaNhaXuatBan";

            cbTheLoai.DataSource = SachDAO.Instance.LoadTheLoai();
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";

            LoadTacGiaList();
            LoadSachList();

            DetachBookBinding();
            DetachTacGiaBinding();

            AddBookBinding();
            AddTacGiaBinding();

            AddTheLoaiBinding();

            LoadTheLoaiList();

            dgvNhaXuatBan.DataSource = nhaxuatbanlist;

            DetachNXBBinding();

            LoadNXBList();
        }
        public void LoadTacGiaList()
        {
            tacGiaList.DataSource = TacGiaDAO.Instance.LoadTacGiaList();
        }
        public void LoadSachList()
        {
            sachList.DataSource = SachDAO.Instance.LoadBookList();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;
            s.MaTacGia = (int)cbTacGia.SelectedValue;
            s.MaNhaXuatBan = (int)cbNhaXuatBan.SelectedValue;
            s.MaTheLoai = (int)cbTheLoai.SelectedValue;
            s.SoLuong = (int)nudSoLuong.Value;
            s.NamXuatBan = (int)nudNamXuatBan.Value;
            s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            s.GiaSach = (decimal)nudGiaSach.Value;

            SachDAO.Instance.AddBook(s);

            LoadSachList();

        }
        private void DetachBookBinding()
        {
            txbTenSach.DataBindings.Clear();
            cbTacGia.DataBindings.Clear();
            cbNhaXuatBan.DataBindings.Clear();
            cbTheLoai.DataBindings.Clear();
            nudSoLuong.DataBindings.Clear();
            nudNamXuatBan.DataBindings.Clear();
            cbLoaiTaiLieu.DataBindings.Clear();
            nudGiaSach.DataBindings.Clear();
        }

        private void AddBookBinding()
        {
            txbTenSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenSach"));
            cbTacGia.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenTacGia"));
            cbNhaXuatBan.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenNhaXuatBan"));
            cbTheLoai.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenTheLoai"));
            nudSoLuong.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "SoLuong"));
            nudNamXuatBan.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "NamXuatBan"));
            cbLoaiTaiLieu.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "LoaiTaiLieu"));
            nudGiaSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "GiaSach"));
        }

        private void AddTheLoaiBinding()
        {
            txtTenTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "TenTheLoai"));
            numTheLoaiID.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "MaTheLoai"));
        }

        private void DetachTheLoaiBinding()
        {
            txtTenTheLoai.DataBindings.Clear();
            numTheLoaiID.DataBindings.Clear();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            DetachBookBinding();
            AddBookBinding();

            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;
            s.MaTacGia = (int)cbTacGia.SelectedValue;
            s.MaNhaXuatBan = (int)cbNhaXuatBan.SelectedValue;
            s.MaTheLoai = (int)cbTheLoai.SelectedValue;
            s.SoLuong = (int)nudSoLuong.Value;
            s.NamXuatBan = (int)nudNamXuatBan.Value;
            s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            s.GiaSach = (decimal)nudGiaSach.Value;

            SachDAO.Instance.UpdateBook(s);

            LoadSachList();
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {


            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;
            s.TenTacGia = ((DataRowView)cbTacGia.SelectedItem)["TenTacGia"].ToString();
            s.TenNhaXuatBan = ((DataRowView)cbNhaXuatBan.SelectedItem)["TenNhaXuatBan"].ToString();
            s.TenTheLoai = ((DataRowView)cbTheLoai.SelectedItem)["TenTheLoai"].ToString();
            s.NamXuatBan = (int)nudNamXuatBan.Value;
            s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            sachList.DataSource = SachDAO.Instance.FindBookByAdvanced(s);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DetachBookBinding();
            AddBookBinding();

            int maSach = (int)nudMaSach.Value;

            SachDAO.Instance.DeleteBook(maSach);

            LoadSachList();

        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            DetachBookBinding();

            LoadSachList();

            nudMaSach.Value = 0;
            txbTenSach.Clear();
            cbTacGia.SelectedItem = null;
            cbNhaXuatBan.SelectedItem = null;
            cbTheLoai.SelectedItem = null;
            nudSoLuong.Value = 0;
            nudNamXuatBan.Value = 0;
            cbLoaiTaiLieu.SelectedItem = null;
            nudGiaSach.Value = 0;
        }
        //-------------------------Tác Giả--------------------------
        private void btnAddTacGia_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();

            tg.TenTacGia = txbTenTacGia.Text;

            TacGiaDAO.Instance.AddTacGia(tg);

            LoadTacGiaList();
        }

        private void DetachTacGiaBinding()
        {
            txbTenTacGia.DataBindings.Clear();
        }
        private void AddTacGiaBinding()
        {
            txbTenTacGia.DataBindings.Add(new Binding("Text", dgvTacGia.DataSource, "TenTacGia"));
        }

        private void btnUpdateTacGia_Click(object sender, EventArgs e)
        {
            // Lấy thông tin về tác giả từ DataGridView
            TacGia tg = new TacGia();
            tg.MaTacGia = int.Parse(dgvTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString());
            tg.TenTacGia = txbTenTacGia.Text;

            // Gọi phương thức cập nhật tác giả từ lớp DAO
            TacGiaDAO.Instance.UpdateTacGia(tg);

            // Load lại danh sách tác giả sau khi cập nhật
            LoadTacGiaList();
        }

        private void btnFindTacGia_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();

            tg.TenTacGia = txbTenTacGia.Text;

            tacGiaList.DataSource = TacGiaDAO.Instance.FindTacGiaByAdvanced(tg);
        }

        private void btnResertTacGia_Click(object sender, EventArgs e)
        {
            DetachTacGiaBinding();

            LoadTacGiaList();

            nudMaTacGia.Value = 0;
            txbTenTacGia.Clear();
        }

        private void btnDeleteTacGia_Click(object sender, EventArgs e)
        {
            DetachTacGiaBinding();
            AddTacGiaBinding();

            int maTacGia = (int)nudMaTacGia.Value;

            TacGiaDAO.Instance.DeleteTacGia(maTacGia);

            LoadTacGiaList();
        }

        private void LoadTheLoaiList()
        {
            TheLoaiList.DataSource = TheLoaiDAO.Instance.LoadTheLoaiList();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();

            tl.TenTheLoai = txtTenTheLoai.Text;

            TheLoaiDAO.Instance.AddTheLoai(tl);

            LoadTheLoaiList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TheLoaiDAO.Instance.DeleteTheLoai((int)numTheLoaiID.Value);
            LoadTheLoaiList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int maTheLoai = (int)numTheLoaiID.Value;
            string tenTheLoai = txtTenTheLoai.Text;

            TheLoai tl = new TheLoai();
            tl.MaTheLoai = maTheLoai;
            tl.TenTheLoai = tenTheLoai;

            bool result = TheLoaiDAO.Instance.UpdateTheLoai(tl);
            LoadTheLoaiList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text;

            TheLoaiList.DataSource = TheLoaiDAO.Instance.FindTheLoaiByAdvanced(tenTheLoai);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadTheLoaiList();
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