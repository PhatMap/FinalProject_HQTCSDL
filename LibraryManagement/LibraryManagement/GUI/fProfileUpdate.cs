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

            inpHoTen.Text = tk.HoTen;
            inpDiaChi.Text = tk.DiaChi;
            dtpNgaySinh.Value = tk.NgaySinh;
            inpEmail.Text = tk.Email;
            inpSoDienThoai.Text = tk.SoDienThoai;
            if(tk.GioiTinh == "Nam")
            {
                rbtnNam.Checked = true;
            }
            rbtnNu.Checked = !rbtnNam.Checked;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TaiKhoan newTK = Session.loginAccount;

            newTK.HoTen = inpHoTen.Text;
            newTK.DiaChi = inpDiaChi.Text;
            newTK.NgaySinh = dtpNgaySinh.Value;
            newTK.SoDienThoai = inpSoDienThoai.Text;
            if(rbtnNam.Checked == true)
            {
                newTK.GioiTinh = "Nam";
            }
            else
            {
                newTK.GioiTinh = "Nữ";
            }
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
