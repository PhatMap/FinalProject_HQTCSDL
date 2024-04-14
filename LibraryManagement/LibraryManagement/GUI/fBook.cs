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
        BindingSource theloaiList = new BindingSource();

        public fBook()
        {
            InitializeComponent();
            dgvTheLoai.DataSource = theloaiList;

            DetachGenreBinding();

            LoadGenreList();
        }
        private void DetachGenreBinding()
        {
            txtBoxTenTheLoai.DataBindings.Clear();
            txtBoxMaTheLoai.DataBindings.Clear();
        }
        private void LoadGenreList()
        {
            theloaiList.DataSource = TheLoaiDAO.Instance.LoadGenreList();
        }
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            tl.TenTheLoai = txtBoxTenTheLoai.Text;
            TheLoaiDAO.Instance.AddGenre(tl);
            LoadGenreList();
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai();
            tl.TenTheLoai = txtBoxTenTheLoai.Text;
            tl.MaTheLoai = int.Parse(txtBoxMaTheLoai.Text);
            TheLoaiDAO.Instance.UpdateGenre(tl);
            LoadGenreList();
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetachGenreBinding();
            GenreBinding();
        }
        private void GenreBinding()
        {
            txtBoxTenTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "TenTheLoai"));
            txtBoxMaTheLoai.DataBindings.Add(new Binding("Text", dgvTheLoai.DataSource, "MaTheLoai"));
        }

        private void btnFindGenre_Click(object sender, EventArgs e)
        {
            TheLoai tl = new TheLoai
            {
                MaTheLoai = string.IsNullOrEmpty(txtBoxMaTheLoai.Text) ? 0 : int.Parse(txtBoxMaTheLoai.Text),
                TenTheLoai = string.IsNullOrEmpty(txtBoxTenTheLoai.Text) ? "" : txtBoxTenTheLoai.Text,
            };

            theloaiList.DataSource = TheLoaiDAO.Instance.FindGenre(tl);
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            DetachGenreBinding();
            GenreBinding();
            TheLoai tl = new TheLoai();
            tl.MaTheLoai = int.Parse(txtBoxMaTheLoai.Text);
            tl.TenTheLoai = txtBoxTenTheLoai.Text;
            TheLoaiDAO.Instance.DeleteGenre(tl);
            LoadGenreList();
            DetachGenreBinding();
        }
    }
}
