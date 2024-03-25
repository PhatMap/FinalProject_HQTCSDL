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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void loadForm(object Form)
        {
            if (this.pnlMain.Controls.Count>0)
                this.pnlMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            loadForm(new fAccount());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            loadForm(new fBook());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void fHome_Load(object sender, EventArgs e)
        {

        }
    }
}
