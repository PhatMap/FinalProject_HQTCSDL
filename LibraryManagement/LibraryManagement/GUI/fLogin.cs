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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = inpUserName.Text;
            string passWord = inpPassWord.Text;

            if (Login(userName = "admin", passWord = "aaaaaaaa"))
            {
                TaiKhoan loginAccount = TaiKhoanDAO.Instance.GetAccountProfile(userName);
                Session.loginAccount = loginAccount;
                fHome f = new fHome();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        bool Login(string userName, string passWord)
        {
            return TaiKhoanDAO.Instance.Login(userName, passWord);
        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
            fSignup f = new fSignup();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
