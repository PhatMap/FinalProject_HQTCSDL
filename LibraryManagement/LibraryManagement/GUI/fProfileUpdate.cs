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
    public partial class fProfileUpdate : Form
    {
        public fProfileUpdate()
        {
            InitializeComponent();
            LoadUpdate();
        }
        private void LoadUpdate()
        {
            TaiKhoan tk = Session.loginAccount;

            inpTenTaiKhoan.Text = tk.TenTaiKhoan;
            inpDiaChi.Text = tk.DiaChi;
            dtpNgaySinh.Value = tk.NgaySinh;
            inpEmail.Text = tk.Email;
            if (tk.GioiTinh)
            {
                rbtnNu.Checked = true;
            }
            else
            {
                rbtnNam.Checked = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TaiKhoan newTK = new TaiKhoan();

            newTK.TenTaiKhoan = inpTenTaiKhoan.Text;
            newTK.DiaChi = inpDiaChi.Text;
            newTK.NgaySinh = dtpNgaySinh.Value;
            newTK.Email = inpEmail.Text;
            if (rbtnNam.Checked) { newTK.GioiTinh = false; }
            if (rbtnNu.Checked) { newTK.GioiTinh = true; }
            newTK.MaChucVu = Session.loginAccount.MaChucVu;
            newTK.MaTaiKhoan = Session.loginAccount.MaTaiKhoan;

            bool result = TaiKhoanDAO.Instance.UpdateProfile(newTK);

            if (!result) 
            {
                MessageBox.Show("Cập nhật không thành công");
                return;
            }
            else 
            {
                MessageBox.Show("Cập nhật thành công");
                Session.loginAccount = newTK;
                this.Close();
            }
        }
    }
}
