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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPhieuMuonID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.numTienPhatID = new System.Windows.Forms.NumericUpDown();
            this.numPhieuPhatID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPhieuPhat = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimPM = new System.Windows.Forms.Button();
            this.btnSuaPM = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuMuonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienPhatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuPhatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).BeginInit();
            this.panel8.SuspendLayout();
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
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 550);
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
            this.panel5.Size = new System.Drawing.Size(953, 544);
            this.panel5.TabIndex = 2;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 135);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(953, 409);
            this.dgvPhieuMuon.TabIndex = 3;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
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
            this.panel1.Controls.Add(this.dgvPhieuPhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 550);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numPhieuMuonID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayTra);
            this.panel2.Controls.Add(this.numTienPhatID);
            this.panel2.Controls.Add(this.numPhieuPhatID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 112);
            this.panel2.TabIndex = 4;
            // 
            // numPhieuMuonID
            // 
            this.numPhieuMuonID.Location = new System.Drawing.Point(130, 63);
            this.numPhieuMuonID.Name = "numPhieuMuonID";
            this.numPhieuMuonID.Size = new System.Drawing.Size(120, 22);
            this.numPhieuMuonID.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày trả";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(391, 66);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayTra.TabIndex = 23;
            // 
            // numTienPhatID
            // 
            this.numTienPhatID.Location = new System.Drawing.Point(391, 8);
            this.numTienPhatID.Name = "numTienPhatID";
            this.numTienPhatID.Size = new System.Drawing.Size(120, 22);
            this.numTienPhatID.TabIndex = 21;
            // 
            // numPhieuPhatID
            // 
            this.numPhieuPhatID.Location = new System.Drawing.Point(130, 8);
            this.numPhieuPhatID.Name = "numPhieuPhatID";
            this.numPhieuPhatID.Size = new System.Drawing.Size(120, 22);
            this.numPhieuPhatID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiền phạt";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(820, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(724, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(820, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(724, 65);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(724, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã phiếu phạt";
            // 
            // dgvPhieuPhat
            // 
            this.dgvPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuPhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuPhat.Location = new System.Drawing.Point(0, 118);
            this.dgvPhieuPhat.Name = "dgvPhieuPhat";
            this.dgvPhieuPhat.RowHeadersWidth = 51;
            this.dgvPhieuPhat.RowTemplate.Height = 24;
            this.dgvPhieuPhat.Size = new System.Drawing.Size(959, 432);
            this.dgvPhieuPhat.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAccSearch);
            this.panel8.Controls.Add(this.label1);
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
            this.panel8.Controls.Add(this.btnXoaPM);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnTimPM);
            this.panel8.Controls.Add(this.btnSuaPM);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnThemPM);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 133);
            this.panel8.TabIndex = 4;
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.Location = new System.Drawing.Point(361, 104);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(128, 23);
            this.btnAccSearch.TabIndex = 22;
            this.btnAccSearch.Text = "Tìm Tài Khoản";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Phiếu Mượn";
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
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2);
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
            this.rbTatCa.Margin = new System.Windows.Forms.Padding(2);
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
            this.rbDaTra.Margin = new System.Windows.Forms.Padding(2);
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
            this.rbDangMuon.Margin = new System.Windows.Forms.Padding(2);
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
            // btnXoaPM
            // 
            this.btnXoaPM.Location = new System.Drawing.Point(873, 0);
            this.btnXoaPM.Name = "btnXoaPM";
            this.btnXoaPM.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPM.TabIndex = 8;
            this.btnXoaPM.Text = "Xóa";
            this.btnXoaPM.UseVisualStyleBackColor = true;
            this.btnXoaPM.Click += new System.EventHandler(this.btnXoaPM_Click);
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
            // btnTimPM
            // 
            this.btnTimPM.Location = new System.Drawing.Point(724, 36);
            this.btnTimPM.Name = "btnTimPM";
            this.btnTimPM.Size = new System.Drawing.Size(75, 23);
            this.btnTimPM.TabIndex = 10;
            this.btnTimPM.Text = "Tìm";
            this.btnTimPM.UseVisualStyleBackColor = true;
            this.btnTimPM.Click += new System.EventHandler(this.btnTimPM_Click);
            // 
            // btnSuaPM
            // 
            this.btnSuaPM.Location = new System.Drawing.Point(724, 65);
            this.btnSuaPM.Name = "btnSuaPM";
            this.btnSuaPM.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPM.TabIndex = 9;
            this.btnSuaPM.Text = "Sửa";
            this.btnSuaPM.UseVisualStyleBackColor = true;
            this.btnSuaPM.Click += new System.EventHandler(this.btnSuaPM_Click);
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
            // btnThemPM
            // 
            this.btnThemPM.Location = new System.Drawing.Point(724, 7);
            this.btnThemPM.Name = "btnThemPM";
            this.btnThemPM.Size = new System.Drawing.Size(75, 23);
            this.btnThemPM.TabIndex = 7;
            this.btnThemPM.Text = "Thêm";
            this.btnThemPM.UseVisualStyleBackColor = true;
            this.btnThemPM.Click += new System.EventHandler(this.btnThemPM_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuMuonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienPhatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhieuPhatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTienPhatID;
        private System.Windows.Forms.NumericUpDown numPhieuPhatID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.NumericUpDown numPhieuMuonID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMaPhieuMuon;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.RadioButton rbDaTra;
        private System.Windows.Forms.RadioButton rbDangMuon;
        private System.Windows.Forms.Button btnTPhieuPhat;
        private System.Windows.Forms.ComboBox comboBoxTinhTrang;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.TextBox txtBoxMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxMaTaiKhoan;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimPM;
        private System.Windows.Forms.Button btnSuaPM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThemPM;
        private System.Windows.Forms.Label label9;
    }
}