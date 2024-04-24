namespace LibraryManagement.GUI
{
    partial class fPay
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
            this.numTienNhan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTienTra = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTienNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTra)).BeginInit();
            this.SuspendLayout();
            // 
            // numTienNhan
            // 
            this.numTienNhan.Location = new System.Drawing.Point(124, 89);
            this.numTienNhan.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numTienNhan.Name = "numTienNhan";
            this.numTienNhan.Size = new System.Drawing.Size(287, 22);
            this.numTienNhan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền nhận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số tiền phải trả";
            // 
            // numTienTra
            // 
            this.numTienTra.Location = new System.Drawing.Point(124, 24);
            this.numTienTra.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numTienTra.Name = "numTienTra";
            this.numTienTra.ReadOnly = true;
            this.numTienTra.Size = new System.Drawing.Size(287, 22);
            this.numTienTra.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(124, 132);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 51);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // fPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 205);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTienTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTienNhan);
            this.Name = "fPay";
            this.Text = "fPay";
            ((System.ComponentModel.ISupportInitialize)(this.numTienNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTienNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTienTra;
        private System.Windows.Forms.Button btnThanhToan;
    }
}