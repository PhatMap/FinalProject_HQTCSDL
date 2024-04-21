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
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.MatKhau = inpAccPass.Text;
                tk.Email = inpAccEmail.Text;
                tk.NgaySinh = dtpAccNgaySinh.Value;
                tk.VaiTro = cbAccRole.SelectedItem.ToString();
                tk.DiaChi = inpAccPhone.Text;
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
                MessageBox.Show("Đã đăng ký thành công", "Add account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Thất bại", "Add account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
