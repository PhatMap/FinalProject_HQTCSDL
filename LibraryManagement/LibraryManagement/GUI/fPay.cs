using LibraryManagement.DAO;
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
    public partial class fPay : Form
    {
        private int id;
        public fPay(int maPhieuPhat, decimal debt)
        {
            InitializeComponent();

            id = maPhieuPhat;

            numTienTra.Value = debt;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal du = (decimal)numTienNhan.Value - (decimal)numTienTra.Value;
            if (du >= 0 )
            {
                MessageBox.Show("Số dư phải trả là:" + du + " VNĐ");
                PhieuPhatDAO.Instance.PayDebt(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không cho trả thiếu");
            }
        }
    }
}
