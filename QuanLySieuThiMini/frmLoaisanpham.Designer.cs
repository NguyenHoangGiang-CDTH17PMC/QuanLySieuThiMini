﻿namespace QuanLySieuThiMini
{
    partial class frmLoaisanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaisanpham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuythaotacloaisp = new System.Windows.Forms.Button();
            this.btnDongloaisp = new System.Windows.Forms.Button();
            this.btnSualoaisp = new System.Windows.Forms.Button();
            this.btnThemloaisp = new System.Windows.Forms.Button();
            this.dgvLoaisanpham = new System.Windows.Forms.DataGridView();
            this.txtTenloaisp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MALOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 349);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuythaotacloaisp);
            this.groupBox1.Controls.Add(this.btnDongloaisp);
            this.groupBox1.Controls.Add(this.btnSualoaisp);
            this.groupBox1.Controls.Add(this.btnThemloaisp);
            this.groupBox1.Controls.Add(this.dgvLoaisanpham);
            this.groupBox1.Controls.Add(this.txtTenloaisp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(612, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            // 
            // btnHuythaotacloaisp
            // 
            this.btnHuythaotacloaisp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHuythaotacloaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuythaotacloaisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuythaotacloaisp.Location = new System.Drawing.Point(446, 143);
            this.btnHuythaotacloaisp.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuythaotacloaisp.Name = "btnHuythaotacloaisp";
            this.btnHuythaotacloaisp.Size = new System.Drawing.Size(138, 38);
            this.btnHuythaotacloaisp.TabIndex = 8;
            this.btnHuythaotacloaisp.Text = "Hủy thao tác";
            this.btnHuythaotacloaisp.UseVisualStyleBackColor = false;
            this.btnHuythaotacloaisp.Click += new System.EventHandler(this.btnHuythaotacloaisp_Click);
            // 
            // btnDongloaisp
            // 
            this.btnDongloaisp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDongloaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongloaisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongloaisp.Location = new System.Drawing.Point(446, 191);
            this.btnDongloaisp.Margin = new System.Windows.Forms.Padding(5);
            this.btnDongloaisp.Name = "btnDongloaisp";
            this.btnDongloaisp.Size = new System.Drawing.Size(138, 38);
            this.btnDongloaisp.TabIndex = 7;
            this.btnDongloaisp.Text = "Đóng";
            this.btnDongloaisp.UseVisualStyleBackColor = false;
            this.btnDongloaisp.Click += new System.EventHandler(this.btnDongloaisp_Click);
            // 
            // btnSualoaisp
            // 
            this.btnSualoaisp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSualoaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSualoaisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSualoaisp.Location = new System.Drawing.Point(446, 95);
            this.btnSualoaisp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSualoaisp.Name = "btnSualoaisp";
            this.btnSualoaisp.Size = new System.Drawing.Size(138, 38);
            this.btnSualoaisp.TabIndex = 6;
            this.btnSualoaisp.Text = "Sửa";
            this.btnSualoaisp.UseVisualStyleBackColor = false;
            this.btnSualoaisp.Click += new System.EventHandler(this.btnSualoaisp_Click);
            // 
            // btnThemloaisp
            // 
            this.btnThemloaisp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemloaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemloaisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemloaisp.Location = new System.Drawing.Point(446, 47);
            this.btnThemloaisp.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemloaisp.Name = "btnThemloaisp";
            this.btnThemloaisp.Size = new System.Drawing.Size(138, 38);
            this.btnThemloaisp.TabIndex = 4;
            this.btnThemloaisp.Text = "Thêm ";
            this.btnThemloaisp.UseVisualStyleBackColor = false;
            this.btnThemloaisp.Click += new System.EventHandler(this.btnThemloaisp_Click);
            // 
            // dgvLoaisanpham
            // 
            this.dgvLoaisanpham.AllowUserToAddRows = false;
            this.dgvLoaisanpham.AllowUserToDeleteRows = false;
            this.dgvLoaisanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaisanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAISP,
            this.TENLOAISP});
            this.dgvLoaisanpham.Location = new System.Drawing.Point(65, 65);
            this.dgvLoaisanpham.Margin = new System.Windows.Forms.Padding(5);
            this.dgvLoaisanpham.Name = "dgvLoaisanpham";
            this.dgvLoaisanpham.ReadOnly = true;
            this.dgvLoaisanpham.Size = new System.Drawing.Size(352, 174);
            this.dgvLoaisanpham.TabIndex = 3;
            this.dgvLoaisanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaisanpham_CellClick);
            // 
            // txtTenloaisp
            // 
            this.txtTenloaisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenloaisp.Location = new System.Drawing.Point(138, 28);
            this.txtTenloaisp.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenloaisp.Name = "txtTenloaisp";
            this.txtTenloaisp.Size = new System.Drawing.Size(279, 26);
            this.txtTenloaisp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 67);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // MALOAISP
            // 
            this.MALOAISP.DataPropertyName = "MALOAI";
            this.MALOAISP.HeaderText = "Mã loại";
            this.MALOAISP.Name = "MALOAISP";
            this.MALOAISP.ReadOnly = true;
            this.MALOAISP.Visible = false;
            // 
            // TENLOAISP
            // 
            this.TENLOAISP.DataPropertyName = "TENLOAI";
            this.TENLOAISP.HeaderText = "Tên Loại sản phẩm";
            this.TENLOAISP.Name = "TENLOAISP";
            this.TENLOAISP.ReadOnly = true;
            this.TENLOAISP.Width = 310;
            // 
            // frmLoaisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(638, 362);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaisanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaisanpham_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisanpham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenloaisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuythaotacloaisp;
        private System.Windows.Forms.Button btnDongloaisp;
        private System.Windows.Forms.Button btnSualoaisp;
        private System.Windows.Forms.Button btnThemloaisp;
        private System.Windows.Forms.DataGridView dgvLoaisanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAISP;
    }
}