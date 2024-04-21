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
    public partial class fChooseBooks : Form
    {
        private DataTable clone;

        public fChooseBooks()
        {
            InitializeComponent();


            dgvSearch.DataSource = SachDAO.Instance.LoadBookList();
            clone = SachDAO.Instance.LoadBookList();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txbSearch.Text.Trim();

            DataTable filtered = clone.Clone();

            foreach (DataRow row in clone.Rows)
            {
                if (row["TenSach"].ToString().ToLower().Contains(keyword.ToLower()) ||
                    row["TenTacGia"].ToString().ToLower().Contains(keyword.ToLower()) ||
                    row["TenTheLoai"].ToString().ToLower().Contains(keyword.ToLower()) ||
                    row["TenNhaXuatBan"].ToString().ToLower().Contains(keyword.ToLower()) ||
                    row["NamXuatBan"].ToString().ToLower().Contains(keyword.ToLower()) ||
                    row["LoaiTaiLieu"].ToString().ToLower().Contains(keyword.ToLower()))
                {
                    filtered.ImportRow(row);
                }
            }

            dgvSearch.DataSource = filtered;
        }

        private void dgvSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvSearch.Rows[e.RowIndex];

            Session.booksID.Add((int)selectedRow.Cells[0].Value);

            Session.booksName.Add(selectedRow.Cells[4].Value.ToString());

            lbMaSach.Text = "";

            foreach (string s in Session.booksName)
            {
                lbMaSach.Text += s + "\n";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
