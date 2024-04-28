namespace LibraryManagement.GUI
{
    partial class fCouponDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCuonSach = new System.Windows.Forms.DataGridView();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numMaSach = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnTaoPhieuPhat = new System.Windows.Forms.Button();
            this.btnReturned = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuonSach
            // 
            this.dgvCuonSach.AllowUserToAddRows = false;
            this.dgvCuonSach.AllowUserToDeleteRows = false;
            this.dgvCuonSach.AllowUserToResizeColumns = false;
            this.dgvCuonSach.AllowUserToResizeRows = false;
            this.dgvCuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuonSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuonSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuonSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCuonSach.Location = new System.Drawing.Point(0, 51);
            this.dgvCuonSach.MultiSelect = false;
            this.dgvCuonSach.Name = "dgvCuonSach";
            this.dgvCuonSach.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuonSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCuonSach.RowHeadersVisible = false;
            this.dgvCuonSach.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCuonSach.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCuonSach.RowTemplate.Height = 24;
            this.dgvCuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuonSach.Size = new System.Drawing.Size(1018, 499);
            this.dgvCuonSach.TabIndex = 15;
            this.dgvCuonSach.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCuonSach_CellFormatting);
            this.dgvCuonSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCuonSach_CellMouseClick);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang mượn",
            "Trả trễ",
            "Đã hư",
            "Đã mất",
            "Đã trả"});
            this.cbTinhTrang.Location = new System.Drawing.Point(111, 12);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(176, 24);
            this.cbTinhTrang.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tình trạng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(626, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 33);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numMaSach
            // 
            this.numMaSach.Enabled = false;
            this.numMaSach.Location = new System.Drawing.Point(379, 14);
            this.numMaSach.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numMaSach.Name = "numMaSach";
            this.numMaSach.ReadOnly = true;
            this.numMaSach.Size = new System.Drawing.Size(120, 22);
            this.numMaSach.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã sách";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(926, 11);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(80, 33);
            this.btnDone.TabIndex = 21;
            this.btnDone.Text = "Đóng";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnTaoPhieuPhat
            // 
            this.btnTaoPhieuPhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuPhat.Location = new System.Drawing.Point(764, 12);
            this.btnTaoPhieuPhat.Name = "btnTaoPhieuPhat";
            this.btnTaoPhieuPhat.Size = new System.Drawing.Size(128, 31);
            this.btnTaoPhieuPhat.TabIndex = 22;
            this.btnTaoPhieuPhat.Text = "Tạo phiếu phạt";
            this.btnTaoPhieuPhat.UseVisualStyleBackColor = true;
            this.btnTaoPhieuPhat.Click += new System.EventHandler(this.btnTaoPhieuPhat_Click);
            // 
            // btnReturned
            // 
            this.btnReturned.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturned.Location = new System.Drawing.Point(517, 10);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(80, 33);
            this.btnReturned.TabIndex = 23;
            this.btnReturned.Text = "Trả sách";
            this.btnReturned.UseVisualStyleBackColor = true;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // fCouponDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1018, 550);
            this.Controls.Add(this.btnReturned);
            this.Controls.Add(this.btnTaoPhieuPhat);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMaSach);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.dgvCuonSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCouponDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCouponDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuonSach;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnTaoPhieuPhat;
        private System.Windows.Forms.Button btnReturned;
    }
}