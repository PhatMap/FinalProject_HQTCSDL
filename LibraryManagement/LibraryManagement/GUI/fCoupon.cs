using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Text;
using System.Windows.Automation.Peers;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class fCoupon : Form
    {
        BindingSource PhieuPhatList = new BindingSource();
        BindingSource phieumuonList = new BindingSource();
        private DataGridViewCell previousCell;
        private int firstCellValue;

        private enum type
        {
            ChuaTra = 0,
            DaTra = 1,
            Empty = 0,
        }
        public fCoupon()
        {
            InitializeComponent();

            dgvPhieuPhat.DataSource = PhieuPhatList;
            dgvPhieuMuon.DataSource = phieumuonList;

            rbDangMuon.Checked = true;
            rbtnPPChuaTra.Checked = true;
        }

        private void LoadPhieuPhatList()
        {
            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.LoadPhieuPhatList();
        }

        private void AddPhieuPhatBinding()
        {
            numPhieuPhatID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "MaPhieuPhat"));
            numPhieuMuonID.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "MaPhieuMuon"));
            numTienPhat.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "TienPhat"));
            dtpNgayTra.DataBindings.Add(new Binding("Text", dgvPhieuPhat.DataSource, "NgayTra"));
        }

        private void DetachPhieuPhatBinding()
        {
            numPhieuPhatID.DataBindings.Clear();
            numPhieuMuonID.DataBindings.Clear();
            numTienPhat.DataBindings.Clear();
            dtpNgayTra.DataBindings.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (numTKChon.Value != 0)
            {
                int id = (int)numTKChon.Value;
                rbtnTatCaPP.Checked = true;
                PhieuPhatList.DataSource = PhieuPhatDAO.Instance.FindPhieuPhat(id);
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numPhieuMuonID.Value = 0;
            numPhieuMuonID.Value = 0;
            numTienPhat.Value = 0;
            numTKChon.Value = 0;
            rbtnPPChuaTra.Checked = false;
            rbtnPPChuaTra.Checked = true;
            previousCell = null;
        }

        private void LoadCouponList()
        {
            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.LoadBookLoanCouponList();
        }

        private void DetachCouponBinding()
        {
            numMaPhieuMuon.DataBindings.Clear();
            numMaTaiKhoan.DataBindings.Clear();
            dateNgayMuon.DataBindings.Clear();
            dateNgayTra.DataBindings.Clear();
        }

        private void rbDangMuon_CheckedChanged(object sender, EventArgs e)
        {
            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.LoadBook_Status((int)type.ChuaTra);

        }

        private void rbDaTra_CheckedChanged(object sender, EventArgs e)
        {
            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.LoadBook_Status((int)type.DaTra);

        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadCouponList();
        }

        private void AddCouponBinding()
        {
            numMaPhieuMuon.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaPhieuMuon"));
            numMaTaiKhoan.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "MaTaiKhoan"));
            dateNgayMuon.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "NgayMuon"));
            dateNgayTra.DataBindings.Add(new Binding("Text", dgvPhieuMuon.DataSource, "NgayTra"));

        }

        private void btnTimPM_Click(object sender, EventArgs e)
        {
            int id = (int)numMaTaiKhoan.Value;
            phieumuonList.DataSource = PhieuMuonSachDAO.Instance.FindBookLoanCoupon(id);
        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            if (numMaTaiKhoan.Value == 0)
            {
                MessageBox.Show("Hãy chọn tài khoản mượn sách");
                return;
            }

            Session.booksID.Clear();
            Session.booksName.Clear();
            fChooseBooks f = new fChooseBooks();
            f.ShowDialog();

            if (Session.booksID.Count != 0)
            {
                PhieuMuonSach pm = new PhieuMuonSach();
                pm.MaTaiKhoan = (int)numMaTaiKhoan.Value;
                pm.NgayMuon = DateTime.Now;
                int maPhieuMuon = PhieuMuonSachDAO.Instance.AddBookLoanCoupon(pm);
                if (maPhieuMuon > 0)
                {
                    CuonSachDAO.Instance.AddCuonSachToPhieuMuon(maPhieuMuon);
                }
            }

            LoadCouponList();
        }

        private void btnXoaPM_Click(object sender, EventArgs e)
        {
            int id = (int)numMaPhieuMuon.Value;
            PhieuMuonSachDAO.Instance.DeleteCoupon(id);
            numMaPhieuMuon.Value = 0;
            numMaTaiKhoan.Value = 0;
            dateNgayMuon.Value = DateTime.Now;
            rbTatCa.Checked = true;
            LoadCouponList();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dateNgayTra.Text != "")
            {
                MessageBox.Show("Không thể thao tác");
                return;
            }
            else
            {
                int id = (int)numMaPhieuMuon.Value;

                fCouponDetail f = new fCouponDetail(id, 0);
                f.ShowDialog();

                rbDangMuon.Checked = false;
                rbDangMuon.Checked = true;
            }
        }

        private void dgvPhieuMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachCouponBinding();

                numMaPhieuMuon.Value = 0;
                numMaTaiKhoan.Value = 0;
                dateNgayMuon.Value = DateTime.Now;
            }
            else
            {
                DetachCouponBinding();
                AddCouponBinding();
                DetachCouponBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvPhieuMuon.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnResetPM_Click(object sender, EventArgs e)
        {
            numMaPhieuMuon.Value = 0;
            numMaTaiKhoan.Value = 0;
            dateNgayMuon.Value = DateTime.Now;
            rbDangMuon.Checked = false;
            rbDangMuon.Checked = true;
            previousCell = null;
            btnThemPM.Enabled = false;
        }

        private void btnAccSearch_Click(object sender, EventArgs e)
        {
            fSearchAccountUtil f = new fSearchAccountUtil();
            f.ShowDialog();
            numMaTaiKhoan.Value = Session.temp;
            btnThemPM.Enabled = true;
        }

        private void btnChonTaiKhoan_Click(object sender, EventArgs e)
        {
            fSearchAccountUtil f = new fSearchAccountUtil();
            f.ShowDialog();
            numTKChon.Value = Session.temp;
        }

        private void rbtnTatCaPP_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhieuPhatList();
        }

        private void rbtnPPChuaTra_CheckedChanged(object sender, EventArgs e)
        {
            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.LoadPhieuPhatListByStatus((int)type.ChuaTra);
        }

        private void rbtnPPDaTra_CheckedChanged(object sender, EventArgs e)
        {
            PhieuPhatList.DataSource = PhieuPhatDAO.Instance.LoadPhieuPhatListByStatus((int)type.DaTra);
        }

        private void dgvPhieuPhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachPhieuPhatBinding();

                numPhieuMuonID.Value = 0;
                numPhieuMuonID.Value = 0;
                numTienPhat.Value = 0;
                numTKChon.Value = 0;
            }
            else
            {
                DetachPhieuPhatBinding();
                AddPhieuPhatBinding();
                DetachPhieuPhatBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvPhieuPhat.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dgvPhieuPhat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvPhieuPhat.Rows[e.RowIndex];

                firstCellValue = (int)selectedRow.Cells[0].Value;
                
                fCouponDetail f = new fCouponDetail(0, firstCellValue);
                f.Show();
            }
            catch
            {

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (numPhieuPhatID.Value != 0)
            {
                int id = (int)numPhieuPhatID.Value;
                decimal debt = (decimal)numTienPhat.Value;
                fPay f = new fPay(id, debt);
                f.Show();
                LoadCouponList();
                rbtnPPChuaTra.Checked = true;
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng");
            }
        }
        private void dgvPhieuMuon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvPhieuMuon.Rows[e.RowIndex];

                firstCellValue = (int)selectedRow.Cells[0].Value;

                fCouponDetail f = new fCouponDetail(firstCellValue, 0);
                f.Show();
            }
            catch
            {

            }
        }

        private void btnXoaPP_Click(object sender, EventArgs e)
        {
            if (numPhieuPhatID.Value != 0)
            {
                int id = (int)numPhieuPhatID.Value;
                PhieuPhatDAO.Instance.DeletePhieuPhat(id);
                LoadPhieuPhatList();
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng");
            }
        }

        private void numTKChon_ValueChanged(object sender, EventArgs e)
        {
            if(numTKChon.Value != 0)
            {
                btnTim.Enabled = true;
            }
            else
            {
                btnTim.Enabled = false;
            }
        }

        private void numMaTaiKhoan_ValueChanged(object sender, EventArgs e)
        {
            if(numMaTaiKhoan.Value != 0)
            {
                btnXoaPM.Enabled = true;
                btnTraSach.Enabled = true;
            }
            else
            {
                btnXoaPM.Enabled = false;
                btnTraSach.Enabled = false;
            }
        }

        private void numPhieuPhatID_ValueChanged(object sender, EventArgs e)
        {
            if (numPhieuPhatID.Value != 0)
            {
                btnThanhToan.Enabled = true;
                btnXoaPP.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnXoaPP.Enabled = false;
            }
        }
    }
}