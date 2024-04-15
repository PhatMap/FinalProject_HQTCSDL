namespace LibraryManagement.GUI
{
    partial class fCoupon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.rbDaTra = new System.Windows.Forms.RadioButton();
            this.rbDangMuon = new System.Windows.Forms.RadioButton();
            this.btnTPhieuPhat = new System.Windows.Forms.Button();
            this.comboBoxTinhTrang = new System.Windows.Forms.ComboBox();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtBoxMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnXoaPP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimPP = new System.Windows.Forms.Button();
            this.btnSuaPP = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemPP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 579);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(959, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu mượn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPhieuMuon);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 544);
            this.panel5.TabIndex = 2;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.MaSach,
            this.MaTaiKhoan,
            this.TinhTrang,
            this.NgayMuon,
            this.NgayTra});
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 133);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(953, 411);
            this.dgvPhieuMuon.TabIndex = 3;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.MinimumWidth = 10;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 10;
            this.MaSach.Name = "MaSach";
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            this.MaTaiKhoan.MinimumWidth = 10;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 10;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 10;
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 10;
            this.NgayTra.Name = "NgayTra";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAccSearch);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.txtBoxMaPhieuMuon);
            this.panel8.Controls.Add(this.btnTraSach);
            this.panel8.Controls.Add(this.rbTatCa);
            this.panel8.Controls.Add(this.rbDaTra);
            this.panel8.Controls.Add(this.rbDangMuon);
            this.panel8.Controls.Add(this.btnTPhieuPhat);
            this.panel8.Controls.Add(this.comboBoxTinhTrang);
            this.panel8.Controls.Add(this.dateNgayTra);
            this.panel8.Controls.Add(this.dateNgayMuon);
            this.panel8.Controls.Add(this.txtBoxMaSach);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.txtBoxMaTaiKhoan);
            this.panel8.Controls.Add(this.btnXoaPP);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnTimPP);
            this.panel8.Controls.Add(this.btnSuaPP);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnThemPP);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 133);
            this.panel8.TabIndex = 2;
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.Location = new System.Drawing.Point(361, 104);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(128, 23);
            this.btnAccSearch.TabIndex = 22;
            this.btnAccSearch.Text = "Tìm Tài Khoản";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            this.btnAccSearch.Click += new System.EventHandler(this.btnAccSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Phiếu Mượn";
            // 
            // txtBoxMaPhieuMuon
            // 
            this.txtBoxMaPhieuMuon.Location = new System.Drawing.Point(130, 107);
            this.txtBoxMaPhieuMuon.Name = "txtBoxMaPhieuMuon";
            this.txtBoxMaPhieuMuon.Size = new System.Drawing.Size(200, 22);
            this.txtBoxMaPhieuMuon.TabIndex = 20;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(820, 37);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(128, 23);
            this.btnTraSach.TabIndex = 19;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Location = new System.Drawing.Point(627, 70);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(68, 20);
            this.rbTatCa.TabIndex = 18;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất Cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            this.rbTatCa.CheckedChanged += new System.EventHandler(this.rbTatCa_CheckedChanged);
            // 
            // rbDaTra
            // 
            this.rbDaTra.AutoSize = true;
            this.rbDaTra.Location = new System.Drawing.Point(510, 70);
            this.rbDaTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDaTra.Name = "rbDaTra";
            this.rbDaTra.Size = new System.Drawing.Size(69, 20);
            this.rbDaTra.TabIndex = 17;
            this.rbDaTra.TabStop = true;
            this.rbDaTra.Text = "Đã Trả";
            this.rbDaTra.UseVisualStyleBackColor = true;
            this.rbDaTra.CheckedChanged += new System.EventHandler(this.rbDaTra_CheckedChanged);
            // 
            // rbDangMuon
            // 
            this.rbDangMuon.AutoSize = true;
            this.rbDangMuon.Location = new System.Drawing.Point(371, 70);
            this.rbDangMuon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDangMuon.Name = "rbDangMuon";
            this.rbDangMuon.Size = new System.Drawing.Size(96, 20);
            this.rbDangMuon.TabIndex = 16;
            this.rbDangMuon.TabStop = true;
            this.rbDangMuon.Text = "Đang Mượn";
            this.rbDangMuon.UseVisualStyleBackColor = true;
            this.rbDangMuon.CheckedChanged += new System.EventHandler(this.rbDangMuon_CheckedChanged);
            // 
            // btnTPhieuPhat
            // 
            this.btnTPhieuPhat.Location = new System.Drawing.Point(820, 65);
            this.btnTPhieuPhat.Name = "btnTPhieuPhat";
            this.btnTPhieuPhat.Size = new System.Drawing.Size(128, 23);
            this.btnTPhieuPhat.TabIndex = 15;
            this.btnTPhieuPhat.Text = "Tạo phiếu phạt";
            this.btnTPhieuPhat.UseVisualStyleBackColor = true;
            // 
            // comboBoxTinhTrang
            // 
            this.comboBoxTinhTrang.FormattingEnabled = true;
            this.comboBoxTinhTrang.Items.AddRange(new object[] {
            "Đang mượn",
            "Đã trả"});
            this.comboBoxTinhTrang.Location = new System.Drawing.Point(130, 70);
            this.comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            this.comboBoxTinhTrang.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTinhTrang.TabIndex = 14;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Location = new System.Drawing.Point(500, 31);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(200, 22);
            this.dateNgayTra.TabIndex = 12;
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Location = new System.Drawing.Point(500, 4);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.dateNgayMuon.TabIndex = 11;
            // 
            // txtBoxMaSach
            // 
            this.txtBoxMaSach.Location = new System.Drawing.Point(130, 6);
            this.txtBoxMaSach.Name = "txtBoxMaSach";
            this.txtBoxMaSach.Size = new System.Drawing.Size(200, 22);
            this.txtBoxMaSach.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã tài khoản";
            // 
            // txtBoxMaTaiKhoan
            // 
            this.txtBoxMaTaiKhoan.Location = new System.Drawing.Point(130, 37);
            this.txtBoxMaTaiKhoan.Name = "txtBoxMaTaiKhoan";
            this.txtBoxMaTaiKhoan.Size = new System.Drawing.Size(200, 22);
            this.txtBoxMaTaiKhoan.TabIndex = 1;
            // 
            // btnXoaPP
            // 
            this.btnXoaPP.Location = new System.Drawing.Point(873, 0);
            this.btnXoaPP.Name = "btnXoaPP";
            this.btnXoaPP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPP.TabIndex = 8;
            this.btnXoaPP.Text = "Xóa";
            this.btnXoaPP.UseVisualStyleBackColor = true;
            this.btnXoaPP.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã sách";
            // 
            // btnTimPP
            // 
            this.btnTimPP.Location = new System.Drawing.Point(724, 36);
            this.btnTimPP.Name = "btnTimPP";
            this.btnTimPP.Size = new System.Drawing.Size(75, 23);
            this.btnTimPP.TabIndex = 10;
            this.btnTimPP.Text = "Tìm";
            this.btnTimPP.UseVisualStyleBackColor = true;
            this.btnTimPP.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSuaPP
            // 
            this.btnSuaPP.Location = new System.Drawing.Point(724, 65);
            this.btnSuaPP.Name = "btnSuaPP";
            this.btnSuaPP.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPP.TabIndex = 9;
            this.btnSuaPP.Text = "Sửa";
            this.btnSuaPP.UseVisualStyleBackColor = true;
            this.btnSuaPP.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày mượn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ngày trả";
            // 
            // btnThemPP
            // 
            this.btnThemPP.Location = new System.Drawing.Point(724, 7);
            this.btnThemPP.Name = "btnThemPP";
            this.btnThemPP.Size = new System.Drawing.Size(75, 23);
            this.btnThemPP.TabIndex = 7;
            this.btnThemPP.Text = "Thêm";
            this.btnThemPP.UseVisualStyleBackColor = true;
            this.btnThemPP.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tình trạng sách";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(959, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phiếu phạt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 550);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 112);
            this.panel2.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(451, 8);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 22);
            this.textBox6.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiền phạt";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(130, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(200, 22);
            this.textBox5.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(820, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Tạo phiếu phạt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã tài khoản";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 22);
            this.textBox4.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(873, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(724, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Tìm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(724, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(724, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Thêm";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tình trạng sách";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(959, 550);
            this.dataGridView2.TabIndex = 3;
            // 
            // fCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCoupon";
            this.Text = "fCoupon";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtBoxMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxMaTaiKhoan;
        private System.Windows.Forms.Button btnXoaPP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimPP;
        private System.Windows.Forms.Button btnSuaPP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThemPP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTPhieuPhat;
        private System.Windows.Forms.ComboBox comboBoxTinhTrang;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.RadioButton rbDaTra;
        private System.Windows.Forms.RadioButton rbDangMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMaPhieuMuon;
        private System.Windows.Forms.Button btnAccSearch;
    }
}