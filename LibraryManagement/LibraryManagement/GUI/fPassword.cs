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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.GUI
{
    public partial class fPassword : Form
    {
        public fPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string oldPass = inpOldPass.Text;
            string newPass = inpNewPass.Text;
            string confirm = inpConfirm.Text;
            string email = Session.loginAccount.Email;
            
            bool result = TaiKhoanDAO.Instance.ChangeAccountPassword(email, newPass, confirm, oldPass);
            if (!result)
            {
                MessageBox.Show("Mật khẩu cũ sai hoặc mật khẩu mới và mật khẩu xác nhật không trùng nhau");
                return;
            }
            else
            {
                MessageBox.Show("Đã đổi mật khẩu");
                this.Close();
            }
        }
    }
}
