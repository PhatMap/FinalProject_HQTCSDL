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
        public fAccount()
        {
            InitializeComponent();
            LoadAccountProfile();
            LoadAccountList();
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
            DataTable taiKhoanList = TaiKhoanDAO.Instance.LoadAccountList();
            dgvAccount.DataSource = taiKhoanList;

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

            TaiKhoanDAO.Instance.AddAccount(tk);

            LoadAccountList();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            int accID = (int)numID.Value;

            TaiKhoanDAO.Instance.DeleteAccount(accID);

            LoadAccountList();
        }

    }
}
