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
            DataTable list = TaiKhoanDAO.Instance.LoadAccountList();
            dgvAccount.DataSource = list;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
