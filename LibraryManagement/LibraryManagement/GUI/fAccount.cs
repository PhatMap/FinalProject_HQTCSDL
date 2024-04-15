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
    public partial class fAccount : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource ScheduleList = new BindingSource();

        public fAccount()
        {
            InitializeComponent();
            this.dgvAccount.CellDoubleClick += dgvAccount_CellDoubleClick;

            dgvAccount.DataSource = accountList;
            dgvSchedule.DataSource = ScheduleList;

            cbLibName.DataSource = TaiKhoanDAO.Instance.LoadLibrarian();
            cbLibName.DisplayMember = "HoTen";
            cbLibName.ValueMember = "MaTaiKhoan";

            DetachAccountBinding();
            DetachScheduleBinding();

            LoadAccountProfile();
            LoadAccountList();
            LoadScheduleList();
        }


        private void AddAccountBinding()
        {
            inpAccName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "HoTen"));
            inpAccEmail.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Email"));
            numAccID.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MaTaiKhoan"));
            dtpAccNgaySinh.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "NgaySinh"));
            inpAccPass.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MatKhau"));
            var maleBinding = new Binding("Checked", dgvAccount.DataSource, "GioiTinh");
            maleBinding.Format += (s, args) =>
            {
                if (args.Value != DBNull.Value && (string)args.Value == "Nam")
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNam.DataBindings.Add(maleBinding);

            var femaleBinding = new Binding("Checked", dgvAccount.DataSource, "GioiTinh");
            femaleBinding.Format += (s, args) =>
            {
                if (args.Value != DBNull.Value && (string)args.Value != "Nam")
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNu.DataBindings.Add(femaleBinding);
            inpAccPhone.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "SoDienThoai"));
            cbAccRole.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "VaiTro"));
            inpAccAddress.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DiaChi"));
        }

        private void DetachAccountBinding()
        {
            inpAccName.DataBindings.Clear();
            inpAccEmail.DataBindings.Clear();
            numAccID.DataBindings.Clear();
            dtpAccNgaySinh.DataBindings.Clear();
            inpAccPass.DataBindings.Clear();
            rbtnNam.DataBindings.Clear();
            rbtnNu.DataBindings.Clear();
            inpAccPhone.DataBindings.Clear();
            cbAccRole.DataBindings.Clear();
            inpAccAddress.DataBindings.Clear();
        }

        private void AddScheduleBinding()
        {
            dtpLibDay.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "NgayLam"));
            cbLibName.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "HoTen"));
            cbLibCa.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "Ca"));
            numLibID.DataBindings.Add(new Binding("Text", dgvSchedule.DataSource, "MaLichLamViec"));
        }

        private void DetachScheduleBinding()
        {
            dtpLibDay.DataBindings.Clear();
            cbLibName.DataBindings.Clear();
            cbLibCa.DataBindings.Clear();
            numLibID.DataBindings.Clear();
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

        private void LoadAccountList()
        {
            accountList.DataSource = TaiKhoanDAO.Instance.LoadAccountList();
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

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.MaTaiKhoan = (int)numAccID.Value;
            tk.HoTen = inpAccName.Text;
            tk.MatKhau = inpAccPass.Text;
            tk.Email = inpAccEmail.Text;
            tk.NgaySinh = dtpAccNgaySinh.Value;
            tk.VaiTro = cbAccRole.SelectedItem.ToString();
            tk.DiaChi = inpAccAddress.Text;
            if (rbtnNam.Checked)
            {
                tk.GioiTinh = "Nam";
            }
            else
            {
                tk.GioiTinh = "Nữ";
            }

            tk.SoDienThoai = inpAccPhone.Text;

            TaiKhoanDAO.Instance.AddAccount(tk);

            LoadAccountList();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            DetachAccountBinding();
            AddAccountBinding();

            int accID = (int)numAccID.Value;

            TaiKhoanDAO.Instance.DeleteAccount(accID);

            LoadAccountList();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            DetachAccountBinding();
            AddAccountBinding();

            TaiKhoan tk = new TaiKhoan();

            tk.MaTaiKhoan = (int)numAccID.Value;
            tk.HoTen = inpAccName.Text;
            tk.MatKhau = inpAccPass.Text;
            tk.Email = inpAccEmail.Text;
            tk.NgaySinh = dtpAccNgaySinh.Value;
            tk.VaiTro = cbAccRole.SelectedItem.ToString();
            tk.DiaChi = inpAccAddress.Text;
            tk.SoDienThoai = inpAccPhone.Text;
            if (rbtnNam.Checked)
            {
                tk.GioiTinh = "Nam";
            }
            else
            {
                tk.GioiTinh = "Nữ";
            }

            TaiKhoanDAO.Instance.UpdateAccount(tk);

            LoadAccountList();
        }

        private void btnFindAcc_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.MaTaiKhoan = (int)numAccID.Value;
            tk.HoTen = inpAccName.Text;
            tk.Email = inpAccEmail.Text;
            if (cbAccRole.SelectedItem != null)
            {
                tk.VaiTro = cbAccRole.SelectedItem.ToString();
            }
            tk.DiaChi = inpAccAddress.Text;
            if (rbtnNam.Checked)
            {
                tk.GioiTinh = "Nam";
            }
            if (rbtnNu.Checked)
            {
                tk.GioiTinh = "Nữ";
            }

            tk.SoDienThoai = inpAccPhone.Text;


            accountList.DataSource = TaiKhoanDAO.Instance.FindAccountByAdvanced(tk);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DetachAccountBinding();

            LoadAccountList();

            numAccID.Value = 0;
            inpAccName.Clear();
            inpAccPass.Clear();
            inpAccEmail.Clear();
            dtpAccNgaySinh.Value = DateTime.Now;
            cbAccRole.SelectedItem = null;
            inpAccAddress.Clear();
            inpAccPhone.Clear();
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        //tab3 lich lam viec

        private void LoadScheduleList()
        {
            ScheduleList.DataSource = LichLamViecDAO.Instance.LoadLichLamViecList();
        }

        private void btnLibCreate_Click(object sender, EventArgs e)
        {
            LichLamViec newLLV = new LichLamViec();

            newLLV.NgayLam = dtpLibDay.Value;
            newLLV.Ca = cbLibCa.SelectedItem.ToString();
            newLLV.MaTaiKhoan = (int)cbLibName.SelectedValue;

            LichLamViecDAO.Instance.AddNewSchedule(newLLV);
            LoadScheduleList();
        }

        private void btnLibUpdate_Click(object sender, EventArgs e)
        {
            DetachScheduleBinding();
            AddScheduleBinding();

            LichLamViec newLLV = new LichLamViec();
            newLLV.MaLichLamViec = (int)numLibID.Value;
            newLLV.NgayLam = dtpLibDay.Value;
            newLLV.Ca = cbLibCa.SelectedItem.ToString();
            newLLV.MaTaiKhoan = (int)cbLibName.SelectedValue;

            LichLamViecDAO.Instance.UpdateSchedule(newLLV);

            LoadScheduleList();
        }

        private void btnLibDelete_Click(object sender, EventArgs e)
        {
            DetachScheduleBinding();
            AddScheduleBinding();

            int id = (int)numLibID.Value;
            LichLamViecDAO.Instance.DeleteSchedule(id);

            LoadScheduleList();
        }
        public void SelectTab(int tabIndex)
        {
            tabControl1.SelectedIndex = tabIndex;
        }
        public string SelectedValue
        {
            get
            {
                if (dgvAccount.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvAccount.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAccount.Rows[selectedRowIndex];
                    return Convert.ToString(selectedRow.Cells["MaTaiKhoan"].Value);
                }
                return null;
            }
        }

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
