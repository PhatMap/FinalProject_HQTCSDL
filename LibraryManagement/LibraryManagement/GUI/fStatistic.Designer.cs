﻿namespace LibraryManagement.GUI
{
    partial class fStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartSach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.dgvtheLoai = new System.Windows.Forms.DataGridView();
            this.Total_Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartMuonPhat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartTaiKhoan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Total_Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Publishers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSach)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMuonPhat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartSach);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 541);
            this.panel2.TabIndex = 1;
            // 
            // chartSach
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSach.ChartAreas.Add(chartArea1);
            this.chartSach.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSach.Legends.Add(legend1);
            this.chartSach.Location = new System.Drawing.Point(0, 0);
            this.chartSach.Name = "chartSach";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "SachSeries";
            this.chartSach.Series.Add(series1);
            this.chartSach.Size = new System.Drawing.Size(699, 541);
            this.chartSach.TabIndex = 0;
            this.chartSach.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 579);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvtheLoai);
            this.tabPage1.Controls.Add(this.dgvTacGia);
            this.tabPage1.Controls.Add(this.dgvNXB);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chartMuonPhat);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(953, 544);
            this.panel6.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(959, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.AllowUserToResizeColumns = false;
            this.dgvNXB.AllowUserToResizeRows = false;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total_Publishers});
            this.dgvNXB.Location = new System.Drawing.Point(711, 392);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvNXB.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNXB.RowTemplate.Height = 24;
            this.dgvNXB.Size = new System.Drawing.Size(240, 150);
            this.dgvNXB.TabIndex = 2;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.AllowUserToResizeColumns = false;
            this.dgvTacGia.AllowUserToResizeRows = false;
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total_Authors});
            this.dgvTacGia.Location = new System.Drawing.Point(711, 6);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTacGia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(240, 150);
            this.dgvTacGia.TabIndex = 3;
            // 
            // dgvtheLoai
            // 
            this.dgvtheLoai.AllowUserToAddRows = false;
            this.dgvtheLoai.AllowUserToDeleteRows = false;
            this.dgvtheLoai.AllowUserToResizeColumns = false;
            this.dgvtheLoai.AllowUserToResizeRows = false;
            this.dgvtheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtheLoai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total_Categories});
            this.dgvtheLoai.Location = new System.Drawing.Point(711, 202);
            this.dgvtheLoai.Name = "dgvtheLoai";
            this.dgvtheLoai.ReadOnly = true;
            this.dgvtheLoai.RowHeadersVisible = false;
            this.dgvtheLoai.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvtheLoai.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtheLoai.RowTemplate.Height = 24;
            this.dgvtheLoai.Size = new System.Drawing.Size(240, 150);
            this.dgvtheLoai.TabIndex = 4;
            // 
            // Total_Categories
            // 
            this.Total_Categories.DataPropertyName = "Total_Categories";
            this.Total_Categories.HeaderText = "Tổng thể loại";
            this.Total_Categories.MinimumWidth = 6;
            this.Total_Categories.Name = "Total_Categories";
            this.Total_Categories.ReadOnly = true;
            // 
            // chartMuonPhat
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMuonPhat.ChartAreas.Add(chartArea2);
            this.chartMuonPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartMuonPhat.Legends.Add(legend2);
            this.chartMuonPhat.Location = new System.Drawing.Point(0, 0);
            this.chartMuonPhat.Name = "chartMuonPhat";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "MuonSeries";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "PhatSeries";
            this.chartMuonPhat.Series.Add(series2);
            this.chartMuonPhat.Series.Add(series3);
            this.chartMuonPhat.Size = new System.Drawing.Size(953, 544);
            this.chartMuonPhat.TabIndex = 1;
            this.chartMuonPhat.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartTaiKhoan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 544);
            this.panel3.TabIndex = 2;
            // 
            // chartTaiKhoan
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTaiKhoan.ChartAreas.Add(chartArea3);
            this.chartTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartTaiKhoan.Legends.Add(legend3);
            this.chartTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.chartTaiKhoan.Name = "chartTaiKhoan";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "TaiKhoanSeries";
            this.chartTaiKhoan.Series.Add(series4);
            this.chartTaiKhoan.Size = new System.Drawing.Size(953, 544);
            this.chartTaiKhoan.TabIndex = 0;
            this.chartTaiKhoan.Text = "chart1";
            // 
            // Total_Authors
            // 
            this.Total_Authors.DataPropertyName = "Total_Authors";
            this.Total_Authors.HeaderText = "Tổng tác giả";
            this.Total_Authors.MinimumWidth = 6;
            this.Total_Authors.Name = "Total_Authors";
            this.Total_Authors.ReadOnly = true;
            // 
            // Total_Publishers
            // 
            this.Total_Publishers.DataPropertyName = "Total_Publishers";
            this.Total_Publishers.HeaderText = "Tổng nhà xuất bản";
            this.Total_Publishers.MinimumWidth = 6;
            this.Total_Publishers.Name = "Total_Publishers";
            this.Total_Publishers.ReadOnly = true;
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStatistic";
            this.Text = "fStatistic";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSach)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMuonPhat)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSach;
        private System.Windows.Forms.DataGridView dgvtheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Categories;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMuonPhat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Publishers;
    }
}