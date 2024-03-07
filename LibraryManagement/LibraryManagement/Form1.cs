using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        formDashboard dashboard;
        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType < MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237); 
        }

            bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height > 160)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 120)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 40)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }
    }
}
