using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fReader : Form
    {
        private int maTaiKhoan = Session.loginAccount.MaTaiKhoan;
        private int firstCellValue;
        private enum type
        {
            All = 0,
            NotPaid = 1,
            Paid = 2,
            NotReturned = 1,
            Returned = 2,
            Empty = 0,
            AuthorMode = 0,
            NXBMode = 1,
            GerneMode = 2
        }

        public fReader()
        {
            InitializeComponent();

            LoadAccountProfile();
            LoadBookList();

            rbtnMuon.Checked = true;
            rbtnTatCa.Checked = true;

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

        private void LoadAccountProfile()
        {
            TaiKhoan tk = Session.loginAccount;

            lbMaTaiKhoan.Text = tk.MaTaiKhoan.ToString();
            lbHoTen.Text = tk.HoTen;
            lbNgaySinh.Text = tk.NgaySinh.ToShortDateString();
            lbGioiTinh.Text = tk.GioiTinh.ToString();
            lbEmail.Text = tk.Email;
            lbDiaChi.Text = tk.DiaChi;
            lbVaiTro.Text = tk.VaiTro;
            lbSoDienThoai.Text = tk.SoDienThoai;
        }
        public void LoadReaderPenalty(int type)
        {
            dgvPhieu.DataSource = PhieuPhatDAO.Instance.LoadReaderPenalty(maTaiKhoan, type);

        }

        public void LoadReaderBorrowed(int type)
        {
            dgvPhieu.DataSource = PhieuMuonSachDAO.Instance.LoadReaderBorrowed(maTaiKhoan, type);

        }

        public void LoadBookList()
        {
            dgvSach.DataSource = SachDAO.Instance.LoadBookList();
        }

        private void rbtnMuon_CheckedChanged(object sender, EventArgs e)
        {
            LoadReaderBorrowed((int)type.All);
            rbtnTatCa.Checked = true;
        }

        private void rbtnPhat_CheckedChanged(object sender, EventArgs e)
        {
            LoadReaderPenalty((int)type.All);
            rbtnTatCa.Checked = true;
        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMuon.Checked)
            {
                LoadReaderBorrowed((int)type.All);
            }
            else
            {
                LoadReaderPenalty((int)type.All);
            }
        }

        private void rbDangMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMuon.Checked)
            {
                LoadReaderBorrowed((int)type.NotPaid);
            }
            else
            {
                LoadReaderPenalty((int)type.NotReturned);
            }
        }

        private void rbDaTra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMuon.Checked)
            {
                LoadReaderBorrowed((int)type.Paid);
            }
            else
            {
                LoadReaderPenalty((int)type.Returned);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            fProfileUpdate f = new fProfileUpdate();
            f.FormClosed += (s, args) => LoadAccountProfile();
            f.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            fPassword f = new fPassword();
            f.ShowDialog();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            txbTenSach.Clear();
            cbTacGia.SelectedItem = null;
            cbNhaXuatBan.SelectedItem = null;
            cbTheLoai.SelectedItem = null;
            nudNamXuatBan.Value = 0;
            cbLoaiTaiLieu.SelectedItem = null;
            LoadBookList();

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

            dgvSach.DataSource = SachDAO.Instance.FindBookByAdvanced(s);
        }

        private void dgvPhieu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvPhieu.Rows[e.RowIndex];

                firstCellValue = (int)selectedRow.Cells[0].Value;

                if (rbtnMuon.Checked)
                {
                    dgvPhieu.DataSource = SachDAO.Instance.LoadBookListByBorrowedOrPenaltyID(firstCellValue, (int)type.Empty);
                }
                else
                {
                    dgvPhieu.DataSource = SachDAO.Instance.LoadBookListByBorrowedOrPenaltyID((int)type.Empty, firstCellValue);
                }
            }
            catch
            {
                if (rbtnMuon.Checked)
                {
                    LoadReaderBorrowed((int)type.All);
                    rbtnTatCa.Checked = true;
                }
                else
                {
                    LoadReaderPenalty((int)type.All);
                    rbtnTatCa.Checked = true;
                }
            }  
        }

        private void btnResetPhieu_Click(object sender, EventArgs e)
        {
            LoadReaderBorrowed((int)type.All);
            rbtnTatCa.Checked = true;
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
    }
}
