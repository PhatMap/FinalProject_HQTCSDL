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
            this.panel8 = new System.Windows.Forms.Panel();
            this.dateNgayTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetPM = new System.Windows.Forms.Button();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.numMaPhieuMuon = new System.Windows.Forms.NumericUpDown();
            this.numMaTaiKhoan = new System.Windows.Forms.NumericUpDown();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.rbDaTra = new System.Windows.Forms.RadioButton();
            this.rbDangMuon = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnTimPM = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaPP = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.rbtnTatCaPP = new System.Windows.Forms.RadioButton();
            this.rbtnPPDaTra = new System.Windows.Forms.RadioButton();
            this.rbtnPPChuaTra = new System.Windows.Forms.RadioButton();
            this.numTKChon = new System.Windows.Forms.NumericUpDown();
            this.btnChonTaiKhoan = new System.Windows.Forms.Button();
            this.numPhieuMuonID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numTienPhat = new System.Windows.Forms.NumericUpDown();
            this.numPhieuPhatID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPhieuPhat = new System.Windows.Forms.DataGridView();
            this.IDPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.IDPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTKChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuMuonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuPhatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 579);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu mượn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.dgvPhieuMuon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 541);
            this.panel5.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel8.Controls.Add(this.dateNgayTra);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnResetPM);
            this.panel8.Controls.Add(this.dateNgayMuon);
            this.panel8.Controls.Add(this.numMaPhieuMuon);
            this.panel8.Controls.Add(this.numMaTaiKhoan);
            this.panel8.Controls.Add(this.btnAccSearch);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.btnTraSach);
            this.panel8.Controls.Add(this.rbTatCa);
            this.panel8.Controls.Add(this.rbDaTra);
            this.panel8.Controls.Add(this.rbDangMuon);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.btnXoaPM);
            this.panel8.Controls.Add(this.btnTimPM);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.btnThemPM);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 133);
            this.panel8.TabIndex = 4;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Enabled = false;
            this.dateNgayTra.Location = new System.Drawing.Point(416, 73);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(103, 27);
            this.dateNgayTra.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày trả";
            // 
            // btnResetPM
            // 
            this.btnResetPM.Location = new System.Drawing.Point(708, 70);
            this.btnResetPM.Name = "btnResetPM";
            this.btnResetPM.Size = new System.Drawing.Size(103, 44);
            this.btnResetPM.TabIndex = 28;
            this.btnResetPM.Text = "Làm mới";
            this.btnResetPM.UseVisualStyleBackColor = true;
            this.btnResetPM.Click += new System.EventHandler(this.btnResetPM_Click);
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dateNgayMuon.Enabled = false;
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayMuon.Location = new System.Drawing.Point(416, 41);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(200, 27);
            this.dateNgayMuon.TabIndex = 26;
            // 
            // numMaPhieuMuon
            // 
            this.numMaPhieuMuon.Location = new System.Drawing.Point(416, 8);
            this.numMaPhieuMuon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMaPhieuMuon.Name = "numMaPhieuMuon";
            this.numMaPhieuMuon.ReadOnly = true;
            this.numMaPhieuMuon.Size = new System.Drawing.Size(120, 27);
            this.numMaPhieuMuon.TabIndex = 25;
            // 
            // numMaTaiKhoan
            // 
            this.numMaTaiKhoan.Location = new System.Drawing.Point(138, 87);
            this.numMaTaiKhoan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMaTaiKhoan.Name = "numMaTaiKhoan";
            this.numMaTaiKhoan.ReadOnly = true;
            this.numMaTaiKhoan.Size = new System.Drawing.Size(120, 27);
            this.numMaTaiKhoan.TabIndex = 24;
            this.numMaTaiKhoan.ValueChanged += new System.EventHandler(this.numMaTaiKhoan_ValueChanged);
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.Location = new System.Drawing.Point(5, 10);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(181, 43);
            this.btnAccSearch.TabIndex = 22;
            this.btnAccSearch.Text = "Chọn Tài Khoản";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            this.btnAccSearch.Click += new System.EventHandler(this.btnAccSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Phiếu Mượn";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Enabled = false;
            this.btnTraSach.Location = new System.Drawing.Point(845, 16);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(103, 44);
            this.btnTraSach.TabIndex = 19;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.Location = new System.Drawing.Point(350, 105);
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(78, 23);
            this.rbTatCa.TabIndex = 18;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất Cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            this.rbTatCa.CheckedChanged += new System.EventHandler(this.rbTatCa_CheckedChanged);
            // 
            // rbDaTra
            // 
            this.rbDaTra.AutoSize = true;
            this.rbDaTra.Location = new System.Drawing.Point(589, 104);
            this.rbDaTra.Margin = new System.Windows.Forms.Padding(2);
            this.rbDaTra.Name = "rbDaTra";
            this.rbDaTra.Size = new System.Drawing.Size(79, 23);
            this.rbDaTra.TabIndex = 17;
            this.rbDaTra.TabStop = true;
            this.rbDaTra.Text = "Đã Trả";
            this.rbDaTra.UseVisualStyleBackColor = true;
            this.rbDaTra.CheckedChanged += new System.EventHandler(this.rbDaTra_CheckedChanged);
            // 
            // rbDangMuon
            // 
            this.rbDangMuon.AutoSize = true;
            this.rbDangMuon.Location = new System.Drawing.Point(452, 105);
            this.rbDangMuon.Margin = new System.Windows.Forms.Padding(2);
            this.rbDangMuon.Name = "rbDangMuon";
            this.rbDangMuon.Size = new System.Drawing.Size(118, 23);
            this.rbDangMuon.TabIndex = 16;
            this.rbDangMuon.TabStop = true;
            this.rbDangMuon.Text = "Đang Mượn";
            this.rbDangMuon.UseVisualStyleBackColor = true;
            this.rbDangMuon.CheckedChanged += new System.EventHandler(this.rbDangMuon_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã tài khoản";
            // 
            // btnXoaPM
            // 
            this.btnXoaPM.Enabled = false;
            this.btnXoaPM.Location = new System.Drawing.Point(845, 70);
            this.btnXoaPM.Name = "btnXoaPM";
            this.btnXoaPM.Size = new System.Drawing.Size(103, 44);
            this.btnXoaPM.TabIndex = 8;
            this.btnXoaPM.Text = "Xóa";
            this.btnXoaPM.UseVisualStyleBackColor = true;
            this.btnXoaPM.Click += new System.EventHandler(this.btnXoaPM_Click);
            // 
            // btnTimPM
            // 
            this.btnTimPM.Location = new System.Drawing.Point(5, 70);
            this.btnTimPM.Name = "btnTimPM";
            this.btnTimPM.Size = new System.Drawing.Size(103, 44);
            this.btnTimPM.TabIndex = 10;
            this.btnTimPM.Text = "Tra";
            this.btnTimPM.UseVisualStyleBackColor = true;
            this.btnTimPM.Click += new System.EventHandler(this.btnTimPM_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày mượn";
            // 
            // btnThemPM
            // 
            this.btnThemPM.Location = new System.Drawing.Point(708, 16);
            this.btnThemPM.Name = "btnThemPM";
            this.btnThemPM.Size = new System.Drawing.Size(103, 44);
            this.btnThemPM.TabIndex = 7;
            this.btnThemPM.Text = "Tạo";
            this.btnThemPM.UseVisualStyleBackColor = true;
            this.btnThemPM.Click += new System.EventHandler(this.btnThemPM_Click);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AllowUserToResizeColumns = false;
            this.dgvPhieuMuon.AllowUserToResizeRows = false;
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhieuMuon,
            this.IDTaiKhoan,
            this.NgayMuon,
            this.NgayTra});
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 132);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(953, 409);
            this.dgvPhieuMuon.TabIndex = 3;
            this.dgvPhieuMuon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhieuMuon_CellMouseClick);
            this.dgvPhieuMuon.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhieuMuon_CellMouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(959, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phiếu phạt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvPhieuPhat);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 547);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnXoaPP);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.rbtnTatCaPP);
            this.panel2.Controls.Add(this.rbtnPPDaTra);
            this.panel2.Controls.Add(this.rbtnPPChuaTra);
            this.panel2.Controls.Add(this.numTKChon);
            this.panel2.Controls.Add(this.btnChonTaiKhoan);
            this.panel2.Controls.Add(this.numPhieuMuonID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayTra);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numTienPhat);
            this.panel2.Controls.Add(this.numPhieuPhatID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 112);
            this.panel2.TabIndex = 4;
            // 
            // btnXoaPP
            // 
            this.btnXoaPP.Enabled = false;
            this.btnXoaPP.Location = new System.Drawing.Point(734, 77);
            this.btnXoaPP.Name = "btnXoaPP";
            this.btnXoaPP.Size = new System.Drawing.Size(84, 32);
            this.btnXoaPP.TabIndex = 34;
            this.btnXoaPP.Text = "Xóa";
            this.btnXoaPP.UseVisualStyleBackColor = true;
            this.btnXoaPP.Click += new System.EventHandler(this.btnXoaPP_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(828, 28);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(123, 60);
            this.btnThanhToan.TabIndex = 33;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // rbtnTatCaPP
            // 
            this.rbtnTatCaPP.AutoSize = true;
            this.rbtnTatCaPP.Location = new System.Drawing.Point(255, 80);
            this.rbtnTatCaPP.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnTatCaPP.Name = "rbtnTatCaPP";
            this.rbtnTatCaPP.Size = new System.Drawing.Size(78, 23);
            this.rbtnTatCaPP.TabIndex = 32;
            this.rbtnTatCaPP.TabStop = true;
            this.rbtnTatCaPP.Text = "Tất Cả";
            this.rbtnTatCaPP.UseVisualStyleBackColor = true;
            this.rbtnTatCaPP.CheckedChanged += new System.EventHandler(this.rbtnTatCaPP_CheckedChanged);
            // 
            // rbtnPPDaTra
            // 
            this.rbtnPPDaTra.AutoSize = true;
            this.rbtnPPDaTra.Location = new System.Drawing.Point(480, 80);
            this.rbtnPPDaTra.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPPDaTra.Name = "rbtnPPDaTra";
            this.rbtnPPDaTra.Size = new System.Drawing.Size(79, 23);
            this.rbtnPPDaTra.TabIndex = 31;
            this.rbtnPPDaTra.TabStop = true;
            this.rbtnPPDaTra.Text = "Đã Trả";
            this.rbtnPPDaTra.UseVisualStyleBackColor = true;
            this.rbtnPPDaTra.CheckedChanged += new System.EventHandler(this.rbtnPPDaTra_CheckedChanged);
            // 
            // rbtnPPChuaTra
            // 
            this.rbtnPPChuaTra.AutoSize = true;
            this.rbtnPPChuaTra.Location = new System.Drawing.Point(358, 80);
            this.rbtnPPChuaTra.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPPChuaTra.Name = "rbtnPPChuaTra";
            this.rbtnPPChuaTra.Size = new System.Drawing.Size(95, 23);
            this.rbtnPPChuaTra.TabIndex = 30;
            this.rbtnPPChuaTra.TabStop = true;
            this.rbtnPPChuaTra.Text = "Chưa trả";
            this.rbtnPPChuaTra.UseVisualStyleBackColor = true;
            this.rbtnPPChuaTra.CheckedChanged += new System.EventHandler(this.rbtnPPChuaTra_CheckedChanged);
            // 
            // numTKChon
            // 
            this.numTKChon.Location = new System.Drawing.Point(117, 72);
            this.numTKChon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTKChon.Name = "numTKChon";
            this.numTKChon.ReadOnly = true;
            this.numTKChon.Size = new System.Drawing.Size(120, 27);
            this.numTKChon.TabIndex = 29;
            this.numTKChon.ValueChanged += new System.EventHandler(this.numTKChon_ValueChanged);
            // 
            // btnChonTaiKhoan
            // 
            this.btnChonTaiKhoan.Location = new System.Drawing.Point(8, 8);
            this.btnChonTaiKhoan.Name = "btnChonTaiKhoan";
            this.btnChonTaiKhoan.Size = new System.Drawing.Size(177, 39);
            this.btnChonTaiKhoan.TabIndex = 28;
            this.btnChonTaiKhoan.Text = "Chọn Tài Khoản";
            this.btnChonTaiKhoan.UseVisualStyleBackColor = true;
            this.btnChonTaiKhoan.Click += new System.EventHandler(this.btnChonTaiKhoan_Click);
            // 
            // numPhieuMuonID
            // 
            this.numPhieuMuonID.Location = new System.Drawing.Point(395, 42);
            this.numPhieuMuonID.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhieuMuonID.Name = "numPhieuMuonID";
            this.numPhieuMuonID.ReadOnly = true;
            this.numPhieuMuonID.Size = new System.Drawing.Size(120, 27);
            this.numPhieuMuonID.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày trả";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(631, 44);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(187, 27);
            this.dtpNgayTra.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã tài khoản";
            // 
            // numTienPhat
            // 
            this.numTienPhat.Location = new System.Drawing.Point(631, 5);
            this.numTienPhat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTienPhat.Name = "numTienPhat";
            this.numTienPhat.ReadOnly = true;
            this.numTienPhat.Size = new System.Drawing.Size(120, 27);
            this.numTienPhat.TabIndex = 21;
            // 
            // numPhieuPhatID
            // 
            this.numPhieuPhatID.Location = new System.Drawing.Point(395, 3);
            this.numPhieuPhatID.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhieuPhatID.Name = "numPhieuPhatID";
            this.numPhieuPhatID.ReadOnly = true;
            this.numPhieuPhatID.Size = new System.Drawing.Size(120, 27);
            this.numPhieuPhatID.TabIndex = 20;
            this.numPhieuPhatID.ValueChanged += new System.EventHandler(this.numPhieuPhatID_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiền phạt";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(585, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // btnTim
            // 
            this.btnTim.Enabled = false;
            this.btnTim.Location = new System.Drawing.Point(8, 59);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(103, 44);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tra";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã phiếu phạt";
            // 
            // dgvPhieuPhat
            // 
            this.dgvPhieuPhat.AllowUserToAddRows = false;
            this.dgvPhieuPhat.AllowUserToDeleteRows = false;
            this.dgvPhieuPhat.AllowUserToResizeColumns = false;
            this.dgvPhieuPhat.AllowUserToResizeRows = false;
            this.dgvPhieuPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuPhat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhat,
            this.MaTaiKhoan,
            this.NgayTraSach,
            this.IDMuon,
            this.TienPhat,
            this.NgayTraPhat});
            this.dgvPhieuPhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuPhat.Location = new System.Drawing.Point(0, 115);
            this.dgvPhieuPhat.MultiSelect = false;
            this.dgvPhieuPhat.Name = "dgvPhieuPhat";
            this.dgvPhieuPhat.ReadOnly = true;
            this.dgvPhieuPhat.RowHeadersVisible = false;
            this.dgvPhieuPhat.RowHeadersWidth = 51;
            this.dgvPhieuPhat.RowTemplate.Height = 24;
            this.dgvPhieuPhat.Size = new System.Drawing.Size(959, 432);
            this.dgvPhieuPhat.TabIndex = 3;
            this.dgvPhieuPhat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhieuPhat_CellMouseClick);
            this.dgvPhieuPhat.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhieuPhat_CellMouseDoubleClick);
            // 
            // IDPhat
            // 
            this.IDPhat.DataPropertyName = "MaPhieuPhat";
            this.IDPhat.HeaderText = "Mã phiếu phạt";
            this.IDPhat.MinimumWidth = 6;
            this.IDPhat.Name = "IDPhat";
            this.IDPhat.ReadOnly = true;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.MinimumWidth = 6;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.ReadOnly = true;
            // 
            // NgayTraSach
            // 
            this.NgayTraSach.DataPropertyName = "NgayTraSach";
            this.NgayTraSach.HeaderText = "Ngày phạt";
            this.NgayTraSach.MinimumWidth = 6;
            this.NgayTraSach.Name = "NgayTraSach";
            this.NgayTraSach.ReadOnly = true;
            // 
            // IDMuon
            // 
            this.IDMuon.DataPropertyName = "MaPhieuMuon";
            this.IDMuon.HeaderText = "Mã phiếu mượn";
            this.IDMuon.MinimumWidth = 6;
            this.IDMuon.Name = "IDMuon";
            this.IDMuon.ReadOnly = true;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "TienPhat";
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.MinimumWidth = 6;
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            // 
            // NgayTraPhat
            // 
            this.NgayTraPhat.DataPropertyName = "NgayTra";
            this.NgayTraPhat.HeaderText = "Ngày trả";
            this.NgayTraPhat.MinimumWidth = 6;
            this.NgayTraPhat.Name = "NgayTraPhat";
            this.NgayTraPhat.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Tra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IDPhieuMuon
            // 
            this.IDPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.IDPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.IDPhieuMuon.MinimumWidth = 6;
            this.IDPhieuMuon.Name = "IDPhieuMuon";
            this.IDPhieuMuon.ReadOnly = true;
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.IDTaiKhoan.HeaderText = "Mã tài khoản";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
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
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTKChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuMuonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuPhatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuPhat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTienPhat;
        private System.Windows.Forms.NumericUpDown numPhieuPhatID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.NumericUpDown numPhieuMuonID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.RadioButton rbDaTra;
        private System.Windows.Forms.RadioButton rbDangMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Button btnTimPM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThemPM;
        private System.Windows.Forms.NumericUpDown numMaPhieuMuon;
        private System.Windows.Forms.NumericUpDown numMaTaiKhoan;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.Button btnResetPM;
        private System.Windows.Forms.NumericUpDown numTKChon;
        private System.Windows.Forms.Button btnChonTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnTatCaPP;
        private System.Windows.Forms.RadioButton rbtnPPDaTra;
        private System.Windows.Forms.RadioButton rbtnPPChuaTra;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoaPP;
        private System.Windows.Forms.TextBox dateNgayTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}