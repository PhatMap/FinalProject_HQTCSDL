﻿using System;
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

        private void LoadForm(object Form)
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
            LoadForm(new fAccount());
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            LoadForm(new fBook());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadForm(new fStatistic());
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            LoadForm(new fAuthorize());
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            LoadForm(new fCoupon());
        }
    }
}
