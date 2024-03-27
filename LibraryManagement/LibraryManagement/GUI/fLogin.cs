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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string email = inpEmail.Text;
            string passWord = inpPassWord.Text;

            if (Login(email = "admin@gmail.com", passWord = "aaaaaaaa"))
            {
                TaiKhoan loginAccount = TaiKhoanDAO.Instance.GetAccountProfile(email);
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
        bool Login(string email, string passWord)
        {
            return TaiKhoanDAO.Instance.Login(email, passWord);
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
