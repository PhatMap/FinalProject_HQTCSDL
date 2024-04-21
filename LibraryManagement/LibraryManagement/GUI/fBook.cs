using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fBook : Form
    {
        BindingSource sachList = new BindingSource();
        BindingSource tacGiaList = new BindingSource();
        BindingSource TheLoaiList = new BindingSource();
        BindingSource nhaxuatbanlist = new BindingSource();
        private DataGridViewCell previousCell;
        private enum type
        {
            AuthorMode = 0,
            NXBMode = 1,
            GerneMode = 2
        }
        public fBook()
        {
            InitializeComponent();

            dgvSach.DataSource = sachList;
            dgvTacGia.DataSource = tacGiaList;
            dgvTheLoai.DataSource = TheLoaiList;
            dgvNhaXuatBan.DataSource = nhaxuatbanlist;

            LoadTacGiaList();
            LoadSachList();
            LoadTheLoaiList();
            LoadNXBList();

            DetachBookBinding();
            DetachTacGiaBinding();
            DetachNXBBinding();
            DetachTheLoaiBinding();

            cbTacGia.DataSource = SachDAO.Instance.LoadTacGia();
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";
            cbTacGia.SelectedItem = null;

            cbNhaXuatBan.DataSource = SachDAO.Instance.LoadNhaXuatBan();
            cbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbNhaXuatBan.ValueMember = "MaNhaXuatBan";
            cbNhaXuatBan.SelectedItem = null;

            cbTheLoai.DataSource = SachDAO.Instance.LoadTheLoai();
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.SelectedItem = null;
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
            nudMaSach.DataBindings.Clear();
        }

        private void AddBookBinding()
        {
            txbTenSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenSach"));
            cbTacGia.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenTacGia"));
            nudMaSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "MaSach"));
            cbNhaXuatBan.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenNhaXuatBan"));
            cbTheLoai.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "TenTheLoai"));
            nudSoLuong.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "SoLuong"));
            nudNamXuatBan.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "NamXuatBan"));
            cbLoaiTaiLieu.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "LoaiTaiLieu"));
            nudGiaSach.DataBindings.Add(new Binding("Text", dgvSach.DataSource, "GiaSach"));
        }

        private void AddTheLoaiBinding()
        {
            txbTenTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "TenTheLoai"));
            numTheLoaiID.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "MaTheLoai"));
        }

        private void DetachTheLoaiBinding()
        {
            txbTenTheLoai.DataBindings.Clear();
            numTheLoaiID.DataBindings.Clear();
        }

        private void DetachTacGiaBinding()
        {
            txbTenTacGia.DataBindings.Clear();
            numTacGiaID.DataBindings.Clear();
        }
        private void AddTacGiaBinding()
        {
            txbTenTacGia.DataBindings.Add(new Binding("Text", dgvTacGia.DataSource, "TenTacGia"));
            numTacGiaID.DataBindings.Add(new Binding("Text", dgvTacGia.DataSource, "MaTacGia"));
        }

        private void DetachNXBBinding()
        {
            txbNXB.DataBindings.Clear();
            numNXBid.DataBindings.Clear();
        }
        private void AddNXBBinding()
        {
            txbNXB.DataBindings.Add(new Binding("Text", dgvNhaXuatBan.DataSource, "TenNhaXuatBan"));
            numNXBid.DataBindings.Add(new Binding("Text", dgvNhaXuatBan.DataSource, "MaNhaXuatBan"));
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

        private void btnUpdateBook_Click(object sender, EventArgs e)
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

            SachDAO.Instance.UpdateBook(s);

            LoadSachList();
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();

            s.TenSach = txbTenSach.Text;

            if (cbTacGia.SelectedItem == null)
            {
                s.TenTacGia = "";
            }
            else
            {
                s.TenTacGia = ((DataRowView)cbTacGia.SelectedItem)["TenTacGia"].ToString();
            }

            if (cbNhaXuatBan.SelectedItem == null)
            {
                s.TenNhaXuatBan = "";
            }
            else
            {
                s.TenNhaXuatBan = ((DataRowView)cbNhaXuatBan.SelectedItem)["TenNhaXuatBan"].ToString();
            }

            if (cbTheLoai.SelectedItem == null)
            {
                s.TenTheLoai = "";
            }
            else
            {
                s.TenTheLoai = ((DataRowView)cbTheLoai.SelectedItem)["TenTheLoai"].ToString();
            }

            s.NamXuatBan = (int)nudNamXuatBan.Value;

            if (cbLoaiTaiLieu.SelectedItem == null)
            {
                s.LoaiTaiLieu = "";
            }
            else
            {
                s.LoaiTaiLieu = cbLoaiTaiLieu.SelectedItem.ToString();
            }

            sachList.DataSource = SachDAO.Instance.FindBookByAdvanced(s);

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int maSach = (int)nudMaSach.Value;

            SachDAO.Instance.DeleteBook(maSach);

            LoadSachList();
        }

        private void btnResertBook_Click(object sender, EventArgs e)
        {
            DetachBookBinding();

            nudMaSach.Value = 0;
            txbTenSach.Clear();
            cbTacGia.SelectedItem = null;
            cbNhaXuatBan.SelectedItem = null;
            cbTheLoai.SelectedItem = null;
            nudSoLuong.Value = 0;
            nudNamXuatBan.Value = 0;
            cbLoaiTaiLieu.SelectedItem = null;
            nudGiaSach.Value = 0;

            LoadSachList();
        }

        private void btnAddTacGia_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();

            tg.TenTacGia = txbTenTacGia.Text;

            TacGiaDAO.Instance.AddTacGia(tg);

            LoadTacGiaList();
        }

        private void btnUpdateTacGia_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.MaTacGia = int.Parse(dgvTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString());
            tg.TenTacGia = txbTenTacGia.Text;

            TacGiaDAO.Instance.UpdateTacGia(tg);

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

            numTacGiaID.Value = 0;
            txbTenTacGia.Clear();
        }

        private void btnDeleteTacGia_Click(object sender, EventArgs e)
        {
            int maTacGia = (int)numTacGiaID.Value;

            TacGiaDAO.Instance.DeleteTacGia(maTacGia);

            LoadTacGiaList();
        }

        private void LoadTheLoaiList()
        {
            TheLoaiList.DataSource = TheLoaiDAO.Instance.LoadTheLoaiList();
        }

        private void LoadNXBList()
        {
            nhaxuatbanlist.DataSource = NhaXuatBanDAO.Instance.LoadNXBList();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();

            tl.TenTheLoai = txbTenTheLoai.Text;

            TheLoaiDAO.Instance.AddTheLoai(tl);

            LoadTheLoaiList();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            int maTheLoai = (int)numTheLoaiID.Value;
            string tenTheLoai = txbTenTheLoai.Text;

            TheLoai tl = new TheLoai();
            tl.MaTheLoai = maTheLoai;
            tl.TenTheLoai = tenTheLoai;

            bool result = TheLoaiDAO.Instance.UpdateTheLoai(tl);
            LoadTheLoaiList();
        }

        private void btnResetTheLoai_Click(object sender, EventArgs e)
        {
            LoadTheLoaiList();
            txbTenTheLoai.Clear();
            numTheLoaiID.Value = 0;
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            TheLoaiDAO.Instance.DeleteTheLoai((int)numTheLoaiID.Value);
            LoadTheLoaiList();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.TenNhaXuatBan = txbNXB.Text;
            NhaXuatBanDAO.Instance.AddNXB(nxb);
            LoadNXBList();
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan tl = new NhaXuatBan();
            tl.TenNhaXuatBan = txbNXB.Text;
            tl.MaNhaXuatBan = (int)numNXBid.Value;
            NhaXuatBanDAO.Instance.UpdateNXB(tl);
            LoadNXBList();
        }

        private void btnResetNXB_Click(object sender, EventArgs e)
        {
            LoadNXBList();
            numNXBid.Value = 0;
            txbNXB.Clear();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            NhaXuatBan tl = new NhaXuatBan();
            tl.MaNhaXuatBan = (int)numNXBid.Value;
            tl.TenNhaXuatBan = txbNXB.Text;
            NhaXuatBanDAO.Instance.DeleteNXB(tl);
            LoadNXBList();
        }
        private void dgvTacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachTacGiaBinding();
                txbTenTacGia.Clear();
            }
            else
            {
                DetachTacGiaBinding();
                AddTacGiaBinding();
                DetachTacGiaBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvTacGia.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dgvNhaXuatBan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachNXBBinding();
                txbNXB.Clear();
            }
            else
            {
                DetachNXBBinding();
                AddNXBBinding();
                DetachNXBBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvNhaXuatBan.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dgvTheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachTheLoaiBinding();
                txbTenTacGia.Clear();
            }
            else
            {
                DetachTheLoaiBinding();
                AddTheLoaiBinding();
                DetachTheLoaiBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvTheLoai.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            fReaderSearchUttil f = new fReaderSearchUttil((int)type.AuthorMode);
            f.ShowDialog();
            cbTacGia.SelectedValue = Session.temp;
        }

        private void btnNXBSearch_Click(object sender, EventArgs e)
        {
            fReaderSearchUttil f = new fReaderSearchUttil((int)type.NXBMode);
            f.ShowDialog();
            cbNhaXuatBan.SelectedValue = Session.temp;
        }

        private void btnGerneSearch_Click(object sender, EventArgs e)
        {
            fReaderSearchUttil f = new fReaderSearchUttil((int)type.GerneMode);
            f.ShowDialog();
            cbTheLoai.SelectedValue = Session.temp;
        }

        private void dgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachBookBinding();

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
            else
            {
                DetachBookBinding();
                AddBookBinding();
                DetachBookBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvSach.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }

}