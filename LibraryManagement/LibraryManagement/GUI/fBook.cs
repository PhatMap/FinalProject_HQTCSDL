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

        public fBook()
        {
            InitializeComponent();

            dgvSach.DataSource = sachList;
            dgvTacGia.DataSource = tacGiaList;

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

            dgvTheLoai.DataSource = TheLoaiList;

            LoadTheLoaiList();

            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
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

        private void ShowDataFromSelectedRow()
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTheLoai.SelectedRows[0];

                txtTenTheLoai.Text = Convert.ToString(selectedRow.Cells["TenTheLoai"].Value);
            }
        }

        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0 && !dgvTheLoai.SelectedRows[0].IsNewRow)
            {
                ShowDataFromSelectedRow();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                int maTheLoai = Convert.ToInt32(dgvTheLoai.SelectedRows[0].Cells["MaTheLoai"].Value);
                string tenTheLoai = txtTenTheLoai.Text;

                TheLoai tl = new TheLoai();
                tl.MaTheLoai = maTheLoai;
                tl.TenTheLoai = tenTheLoai;

                bool result = TheLoaiDAO.Instance.UpdateTheLoai(tl);

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTheLoaiList();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text;

            DataTable searchResult = TheLoaiDAO.Instance.FindTheLoaiByAdvanced(new TheLoai()
            {
                TenTheLoai = tenTheLoai
            });

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                TheLoaiList.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadTheLoaiList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                int maTheLoai = Convert.ToInt32(dgvTheLoai.SelectedRows[0].Cells["MaTheLoai"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    TheLoaiDAO.Instance.DeleteTheLoai(maTheLoai);

                    LoadTheLoaiList();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();

            tl.TenTheLoai = txtTenTheLoai.Text;

            TheLoaiDAO.Instance.AddTheLoai(tl);

            LoadTheLoaiList();
        }
    }
}
