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
    public partial class fCouponDetail : Form
    {
        BindingSource CuonSach = new BindingSource();
        private DataGridViewCell previousCell;
        private int maPhieuMuon;
        private int maPhieuPhat;
        private bool check = false;

        public fCouponDetail(int muon, int phat)
        {
            InitializeComponent();

            maPhieuMuon = muon;
            maPhieuPhat = phat;

            dgvCuonSach.DataSource = CuonSach;

            LoadCuonSach(muon, phat);

            if (phat != 0)
            {
                cbTinhTrang.Enabled = false;
                btnUpdate.Enabled = false;
                dgvCuonSach.Enabled = false;
            }
        }

        public void CheckPelnalty()
        {
            foreach (DataGridViewRow row in dgvCuonSach.Rows)
            {
                if (row.Cells[8].Value != null)
                {
                    string status = row.Cells[8].Value.ToString();

                    if (status == "Đã mất" || status == "Đã hư" || status == "Trả trễ")
                    {
                        row.Cells[8].Style.BackColor = Color.Red;
                        check = true;
                    }
                }
            }
            if (check)
            {
                btnReturned.Enabled = false;
            }
            else
            {
                btnTaoPhieuPhat.Enabled = false;
            }
        }


        public void LoadCuonSach(int muon, int phat)
        {
            CuonSach.DataSource = SachDAO.Instance.LoadBookListByBorrowedOrPenaltyID(muon, phat);
        }

        private void AddCuonSachBinding()
        {
            cbTinhTrang.DataBindings.Add(new Binding("Text", dgvCuonSach.DataSource, "Tình trạng"));
            numMaSach.DataBindings.Add(new Binding("Text", dgvCuonSach.DataSource, "ID"));
        }
        private void DetachCuonSachBinding()
        {
            cbTinhTrang.DataBindings.Clear();
            numMaSach.DataBindings.Clear();
        }

        private void dgvCuonSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                DetachCuonSachBinding();

                cbTinhTrang.SelectedItem = null;
            }
            else
            {
                DetachCuonSachBinding();
                AddCuonSachBinding();
                DetachCuonSachBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvCuonSach.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tinhTrang = cbTinhTrang.Text;
            int maSach = (int)numMaSach.Value;
            CuonSachDAO.Instance.UpdateStatus(maPhieuMuon, maSach, tinhTrang);
            LoadCuonSach(maPhieuMuon, maPhieuPhat);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoPhieuPhat_Click(object sender, EventArgs e)
        {
                PhieuPhat pp = new PhieuPhat();
                pp.MaPhieuMuon = maPhieuMuon;
                PhieuPhatDAO.Instance.AddPhieuPhat(pp);
                MessageBox.Show("Đã tạo");
                this.Close();
        }

        private void dgvCuonSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            check = false;
            CheckPelnalty();
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            PhieuMuonSachDAO.Instance.UpdateCoupon_Returned(maPhieuMuon);
        }
    }
}
