using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fCoupon : Form
    {
        BindingSource PhieuPhatList = new BindingSource();

        public fCoupon()
        {
            InitializeComponent();

            dgvPhieuPhat.DataSource = PhieuPhatList;

            LoadPhieuPhatList();

            dgvPhieuPhat.SelectionChanged += dgvPhieuPhat_SelectionChanged;
        }

        private void LoadPhieuPhatList()
        {
            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.LoadPhieuPhatList();
        }

        private void ShowDataFromSelectedRow()
        {
            if (dgvPhieuPhat.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhieuPhat.SelectedRows[0];

                numPhieuMuonID.Value = Convert.ToInt32(selectedRow.Cells["MaPhieuMuon"].Value);
                numTienPhatID.Value = Convert.ToDecimal(selectedRow.Cells["TienPhat"].Value);
                dtpNgayTra.Value = Convert.ToDateTime(selectedRow.Cells["NgayTra"].Value);
            }
        }

        private void dgvPhieuPhat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.SelectedRows.Count > 0 && !dgvPhieuPhat.SelectedRows[0].IsNewRow)
            {
                ShowDataFromSelectedRow();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();

            pp.MaPhieuMuon = (int)numPhieuMuonID.Value;
            pp.TienPhat = (decimal)numTienPhatID.Value;
            pp.NgayTra = dtpNgayTra.Value;

            PhieuPhatDAO.Instance.AddPhieuPhat(pp);

            LoadPhieuPhatList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.SelectedRows.Count > 0)
            {
                int maPhieuPhat = Convert.ToInt32(dgvPhieuPhat.SelectedRows[0].Cells["MaPhieuPhat"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu phạt này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PhieuPhatDAO.Instance.DeletePhieuPhat(maPhieuPhat);

                    LoadPhieuPhatList();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu phạt cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.SelectedRows.Count > 0)
            {
                int maPhieuPhat = Convert.ToInt32(dgvPhieuPhat.SelectedRows[0].Cells["MaPhieuPhat"].Value);
                int maPhieuMuon = (int)numPhieuMuonID.Value;
                decimal tienPhat = (decimal)numTienPhatID.Value;
                DateTime ngayTra = dtpNgayTra.Value;

                PhieuPhat pp = new PhieuPhat();
                pp.MaPhieuPhat = maPhieuPhat;
                pp.MaPhieuMuon = maPhieuMuon;
                pp.TienPhat = tienPhat;
                pp.NgayTra = ngayTra;

                bool result = PhieuPhatDAO.Instance.UpdatePhieuPhat(pp);

                if (result)
                {
                    MessageBox.Show("Cập nhật  thông tin phiếu phạt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuPhatList();
                }
                else
                {
                    MessageBox.Show("Cập    nhật thông tin phiếu phạt thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu phạt cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int maPhieuMuon = (int)numPhieuMuonID.Value;
            decimal tienPhat = (decimal)numTienPhatID.Value;
            DateTime ngayTra = dtpNgayTra.Value;

            DataTable searchResult = PhieuPhatDAO.Instance.FindPhieuPhatByAdvanced(new PhieuPhat()
            {
                MaPhieuMuon = maPhieuMuon,
                TienPhat = tienPhat,
                NgayTra = ngayTra
            });

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                PhieuPhatList.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadPhieuPhatList();
        }
    }
}
