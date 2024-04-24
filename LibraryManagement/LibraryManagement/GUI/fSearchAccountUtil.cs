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
using System.Windows.Controls;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fSearchAccountUtil : Form
    {
        private DataTable clone;
        public fSearchAccountUtil()
        {
            InitializeComponent();

            dgvSearch.DataSource = TaiKhoanDAO.Instance.LoadAccountList();
            clone = TaiKhoanDAO.Instance.LoadAccountList();
        }

        private void inpAccName_TextChanged(object sender, EventArgs e)
        {
            string keyword = inpAccName.Text.Trim();

            DataTable filtered = clone.Clone();

            foreach (DataRow row in clone.Rows)
            {
                if (row["HoTen"].ToString().ToLower().Contains(keyword.ToLower()))
                {
                    filtered.ImportRow(row);
                }
            }

            dgvSearch.DataSource = filtered;
        }

        private void inpAccEmail_TextChanged(object sender, EventArgs e)
        {
            string keyword = inpAccEmail.Text.Trim();

            DataTable filtered = clone.Clone();

            foreach (DataRow row in clone.Rows)
            {
                if (row["Email"].ToString().ToLower().Contains(keyword.ToLower()))
                {
                    filtered.ImportRow(row);
                }
            }

            dgvSearch.DataSource = filtered;
        }

        private void dgvSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvSearch.Rows[e.RowIndex];

            Session.temp = (int)selectedRow.Cells[0].Value;

            this.Close();
        }
    }
}
