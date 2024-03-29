﻿namespace LibraryManagement.GUI
{
    partial class fAccount
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbMaTaiKhoan = new System.Windows.Forms.Label();
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTenChucVu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChucNangs = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpAccNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.inpAccName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inpAccPass = new System.Windows.Forms.TextBox();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFindAcc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFixAcc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.cbAccPosition = new System.Windows.Forms.ComboBox();
            this.inpAccId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inpAccEmail = new System.Windows.Forms.TextBox();
            this.inpAccAddress = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlChucNangs.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin tài khoản";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Controls.Add(this.btnUpdateProfile);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 514);
            this.panel2.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(258, 452);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(202, 60);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Location = new System.Drawing.Point(0, 452);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(195, 60);
            this.btnUpdateProfile.TabIndex = 7;
            this.btnUpdateProfile.Text = "Cập nhật";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbEmail);
            this.panel12.Controls.Add(this.label15);
            this.panel12.Controls.Add(this.label14);
            this.panel12.Controls.Add(this.lbGioiTinh);
            this.panel12.Controls.Add(this.lbNgaySinh);
            this.panel12.Controls.Add(this.lbDiaChi);
            this.panel12.Controls.Add(this.lbMaTaiKhoan);
            this.panel12.Controls.Add(this.lbTenTaiKhoan);
            this.panel12.Controls.Add(this.label13);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 29);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(460, 423);
            this.panel12.TabIndex = 6;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(95, 369);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(72, 29);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "None";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 29);
            this.label15.TabIndex = 13;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 29);
            this.label14.TabIndex = 12;
            this.label14.Text = "Giới tính:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(131, 306);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(72, 29);
            this.lbGioiTinh.TabIndex = 11;
            this.lbGioiTinh.Text = "None";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(144, 252);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(72, 29);
            this.lbNgaySinh.TabIndex = 9;
            this.lbNgaySinh.Text = "None";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(109, 165);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(294, 87);
            this.lbDiaChi.TabIndex = 8;
            this.lbDiaChi.Text = "None                                     \r\n\r\n\r\n";
            // 
            // lbMaTaiKhoan
            // 
            this.lbMaTaiKhoan.AutoSize = true;
            this.lbMaTaiKhoan.Location = new System.Drawing.Point(171, 45);
            this.lbMaTaiKhoan.Name = "lbMaTaiKhoan";
            this.lbMaTaiKhoan.Size = new System.Drawing.Size(72, 29);
            this.lbMaTaiKhoan.TabIndex = 7;
            this.lbMaTaiKhoan.Text = "None";
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(187, 105);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(72, 29);
            this.lbTenTaiKhoan.TabIndex = 6;
            this.lbTenTaiKhoan.Text = "None";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Mã tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thông tin chi tiết";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTenChucVu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlChucNangs);
            this.panel1.Location = new System.Drawing.Point(474, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 514);
            this.panel1.TabIndex = 3;
            // 
            // lbTenChucVu
            // 
            this.lbTenChucVu.AutoSize = true;
            this.lbTenChucVu.Location = new System.Drawing.Point(121, 4);
            this.lbTenChucVu.Name = "lbTenChucVu";
            this.lbTenChucVu.Size = new System.Drawing.Size(72, 29);
            this.lbTenChucVu.TabIndex = 16;
            this.lbTenChucVu.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chức vụ:";
            // 
            // pnlChucNangs
            // 
            this.pnlChucNangs.Controls.Add(this.label16);
            this.pnlChucNangs.Location = new System.Drawing.Point(-2, 35);
            this.pnlChucNangs.Name = "pnlChucNangs";
            this.pnlChucNangs.Size = new System.Drawing.Size(456, 478);
            this.pnlChucNangs.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(-1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 31);
            this.label16.TabIndex = 17;
            this.label16.Text = "Các chức năng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý nhóm tài khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvAccount);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 544);
            this.panel5.TabIndex = 2;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTaiKhoan,
            this.TenTaiKhoan,
            this.MatKhau,
            this.DiaChi,
            this.Email,
            this.NgaySinh,
            this.TenChucVu,
            this.GioiTinh});
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccount.Location = new System.Drawing.Point(0, 137);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(953, 407);
            this.dgvAccount.TabIndex = 3;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.MinimumWidth = 6;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.MinimumWidth = 6;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Chức vụ";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtpAccNgaySinh);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.inpAccName);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.inpAccPass);
            this.panel8.Controls.Add(this.btnDeleteAcc);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnFindAcc);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.btnFixAcc);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnAddAcc);
            this.panel8.Controls.Add(this.cbAccPosition);
            this.panel8.Controls.Add(this.inpAccId);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.inpAccEmail);
            this.panel8.Controls.Add(this.inpAccAddress);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 141);
            this.panel8.TabIndex = 2;
            // 
            // dtpAccNgaySinh
            // 
            this.dtpAccNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpAccNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAccNgaySinh.Location = new System.Drawing.Point(114, 98);
            this.dtpAccNgaySinh.Name = "dtpAccNgaySinh";
            this.dtpAccNgaySinh.Size = new System.Drawing.Size(200, 25);
            this.dtpAccNgaySinh.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày sinh";
            // 
            // inpAccName
            // 
            this.inpAccName.Location = new System.Drawing.Point(117, 0);
            this.inpAccName.Name = "inpAccName";
            this.inpAccName.Size = new System.Drawing.Size(263, 25);
            this.inpAccName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mật khẩu";
            // 
            // inpAccPass
            // 
            this.inpAccPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAccPass.Location = new System.Drawing.Point(651, 0);
            this.inpAccPass.Name = "inpAccPass";
            this.inpAccPass.Size = new System.Drawing.Size(297, 23);
            this.inpAccPass.TabIndex = 1;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Location = new System.Drawing.Point(875, 93);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteAcc.TabIndex = 8;
            this.btnDeleteAcc.Text = "Xóa";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên tài khoản";
            // 
            // btnFindAcc
            // 
            this.btnFindAcc.Location = new System.Drawing.Point(720, 93);
            this.btnFindAcc.Name = "btnFindAcc";
            this.btnFindAcc.Size = new System.Drawing.Size(75, 38);
            this.btnFindAcc.TabIndex = 10;
            this.btnFindAcc.Text = "Tìm";
            this.btnFindAcc.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Chức vụ";
            // 
            // btnFixAcc
            // 
            this.btnFixAcc.Location = new System.Drawing.Point(595, 91);
            this.btnFixAcc.Name = "btnFixAcc";
            this.btnFixAcc.Size = new System.Drawing.Size(75, 38);
            this.btnFixAcc.TabIndex = 9;
            this.btnFixAcc.Text = "Sửa";
            this.btnFixAcc.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mã tài khoản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email";
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(351, 93);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(189, 38);
            this.btnAddAcc.TabIndex = 7;
            this.btnAddAcc.Text = "Thêm";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // cbAccPosition
            // 
            this.cbAccPosition.FormattingEnabled = true;
            this.cbAccPosition.Location = new System.Drawing.Point(618, 29);
            this.cbAccPosition.Name = "cbAccPosition";
            this.cbAccPosition.Size = new System.Drawing.Size(330, 27);
            this.cbAccPosition.TabIndex = 6;
            // 
            // inpAccId
            // 
            this.inpAccId.Location = new System.Drawing.Point(117, 63);
            this.inpAccId.Name = "inpAccId";
            this.inpAccId.Size = new System.Drawing.Size(197, 25);
            this.inpAccId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ";
            // 
            // inpAccEmail
            // 
            this.inpAccEmail.Location = new System.Drawing.Point(117, 32);
            this.inpAccEmail.Name = "inpAccEmail";
            this.inpAccEmail.Size = new System.Drawing.Size(330, 25);
            this.inpAccEmail.TabIndex = 1;
            // 
            // inpAccAddress
            // 
            this.inpAccAddress.Location = new System.Drawing.Point(453, 62);
            this.inpAccAddress.Name = "inpAccAddress";
            this.inpAccAddress.Size = new System.Drawing.Size(495, 25);
            this.inpAccAddress.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(959, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lịch làm việc";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(959, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quy định";
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAccount";
            this.Text = "fAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlChucNangs.ResumeLayout(false);
            this.pnlChucNangs.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnFindAcc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFixAcc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.ComboBox cbAccPosition;
        private System.Windows.Forms.TextBox inpAccId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inpAccEmail;
        private System.Windows.Forms.TextBox inpAccAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inpAccName;
        private System.Windows.Forms.TextBox inpAccPass;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbMaTaiKhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenChucVu;
        private System.Windows.Forms.Panel pnlChucNangs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpAccNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}