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
        private bool canAddBinding = true;

        public fAccount()
        {
            InitializeComponent();

            dgvAccount.DataSource = accountList;
            LoadAccountProfile();
            LoadAccountList();
        }

        private void AddAccountBinding()
        {
            inpAccName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "TenTaiKhoan"));
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
            //Tại sao không để == "Nữ" mà để != "Nam", là để tránh xài tiếng việt sợ lỗi :)
                if (args.Value != DBNull.Value && (string)args.Value != "Nam") 
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNu.DataBindings.Add(femaleBinding);


            cbAccPosition.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "TenChucVu"));
            inpAccAddress.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DiaChi"));
        }

        private void LoadAccountProfile()
        {
            TaiKhoan tk = Session.loginAccount;

            lbMaTaiKhoan.Text = tk.MaTaiKhoan.ToString();
            lbTenTaiKhoan.Text = tk.TenTaiKhoan;
            lbNgaySinh.Text = tk.NgaySinh.ToShortDateString();
            switch (tk.GioiTinh)
            {
                case false: lbGioiTinh.Text = "Nam";
                    break;
                case true: lbGioiTinh.Text = "Nữ";
                    break;
            }
            lbEmail.Text = tk.Email;
            lbDiaChi.Text = tk.DiaChi;

            string chucVu = null;
            List<string> chucNangs = new List<string>();
            (chucVu, chucNangs) = PhanQuyenDAO.Instance.GetAccountAuthorization(tk.MaChucVu);
            lbTenChucVu.Text = chucVu;

            int labelY = 0; 
            foreach (string chucNang in chucNangs)
            {
                Label label = new Label();
                labelY += label.Height + 20;
                label.Text = chucNang;
                label.AutoSize = true;
                label.Location = new Point(30, labelY);
                pnlChucNangs.Controls.Add(label);
            }
        }

        private void LoadAccountList()
        {
            accountList.DataSource = TaiKhoanDAO.Instance.LoadAccountList();

            List<ChucVu> chucVuList = ChucVuDAO.Instance.LoadChucVuList();
            cbAccPosition.DataSource = chucVuList;
            cbAccPosition.DisplayMember = "TenChucVu";
            cbAccPosition.ValueMember = "MaChucVu";
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

            tk.TenTaiKhoan = inpAccName.Text;
            tk.MatKhau = inpAccPass.Text;
            tk.Email = inpAccEmail.Text;
            tk.NgaySinh = dtpAccNgaySinh.Value;
            tk.MaChucVu = (int)cbAccPosition.SelectedValue;
            tk.DiaChi = inpAccAddress.Text;
            if (rbtnNam.Checked) { tk.GioiTinh = false; }
            if (rbtnNu.Checked) { tk.GioiTinh = true; }

            TaiKhoanDAO.Instance.AddAccount(tk);

            LoadAccountList();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            int accID = (int)numAccID.Value;

            TaiKhoanDAO.Instance.DeleteAccount(accID);

            LoadAccountList();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            DetachBindings();
            AddAccountBinding();

            TaiKhoan tk = new TaiKhoan();

            tk.MaTaiKhoan = (int)numAccID.Value;
            tk.TenTaiKhoan = inpAccName.Text;
            tk.MatKhau = inpAccPass.Text;
            tk.Email = inpAccEmail.Text;
            tk.NgaySinh = dtpAccNgaySinh.Value;
            tk.MaChucVu = (int)cbAccPosition.SelectedValue;
            tk.DiaChi = inpAccAddress.Text;
            if (rbtnNam.Checked) { tk.GioiTinh = false; }
            if (rbtnNu.Checked) { tk.GioiTinh = true; }

            TaiKhoanDAO.Instance.UpdateAccount(tk);

            LoadAccountList();
        }

        private void btnFindAcc_Click(object sender, EventArgs e)
        {
            DetachBindings();
            AddAccountBinding();
            string email = inpAccEmail.Text;
            string name = inpAccName.Text;

            if(!string.IsNullOrEmpty(email))
            {
                accountList.DataSource = TaiKhoanDAO.Instance.FindAccountByEmail(email);
            }
            else
            {
                accountList.DataSource = TaiKhoanDAO.Instance.FindAccountByName(name);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DetachBindings();

            LoadAccountList();

            numAccID.Value = 0;
            inpAccName.Clear();
            inpAccPass.Clear();
            inpAccEmail.Clear();
            dtpAccNgaySinh.Value = DateTime.Now;
            cbAccPosition.SelectedIndex = 0;
            inpAccAddress.Clear();
            rbtnNam.Checked = false; 
            rbtnNu.Checked = false;


        }

        private void DetachBindings()
        {
            inpAccName.DataBindings.Clear();
            inpAccEmail.DataBindings.Clear();
            numAccID.DataBindings.Clear();
            dtpAccNgaySinh.DataBindings.Clear();
            inpAccPass.DataBindings.Clear();
            rbtnNam.DataBindings.Clear();
            rbtnNu.DataBindings.Clear();
            cbAccPosition.DataBindings.Clear();
            inpAccAddress.DataBindings.Clear();
        }
    }
}
