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
    public partial class fBook : Form
    {
        BindingSource TheLoaiList = new BindingSource();

        public fBook()
        {
            InitializeComponent();

            dgvTheLoai.DataSource = TheLoaiList;

            LoadTheLoaiList();

            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
        }

        private void LoadTheLoaiList()
        {
            TheLoaiList.DataSource = TheLoaiDAO.Instance.LoadTheLoaiList();
        }

        private void ShowDataFromSelectedRow()
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTheLoai.SelectedRows[0];

                txtTenTheLoai.Text = Convert.ToString(selectedRow.Cells["TenTheLoai"].Value);
            }
        }

        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0 && !dgvTheLoai.SelectedRows[0].IsNewRow)
            {
                ShowDataFromSelectedRow();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();

            tl.TenTheLoai = txtTenTheLoai.Text;

            TheLoaiDAO.Instance.AddTheLoai(tl);

            LoadTheLoaiList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                int maTheLoai = Convert.ToInt32(dgvTheLoai.SelectedRows[0].Cells["MaTheLoai"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    TheLoaiDAO.Instance.DeleteTheLoai(maTheLoai);

                    LoadTheLoaiList();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                int maTheLoai = Convert.ToInt32(dgvTheLoai.SelectedRows[0].Cells["MaTheLoai"].Value);
                string tenTheLoai = txtTenTheLoai.Text;

                TheLoai tl = new TheLoai();
                tl.MaTheLoai = maTheLoai;
                tl.TenTheLoai = tenTheLoai;

                bool result = TheLoaiDAO.Instance.UpdateTheLoai(tl);

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTheLoaiList();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text;

            DataTable searchResult = TheLoaiDAO.Instance.FindTheLoaiByAdvanced(new TheLoai()
            {
                TenTheLoai = tenTheLoai
            });

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                TheLoaiList.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadTheLoaiList();
        }
    }
}
