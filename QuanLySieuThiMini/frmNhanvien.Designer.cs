﻿namespace QuanLySieuThiMini
{
    partial class frmNhanvien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHienthinhanvien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LOAINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimnhanvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDongnhanvien = new DevComponents.DotNetBar.ButtonX();
            this.btnHuythaotacnv = new DevComponents.DotNetBar.ButtonX();
            this.btnXoanhanvien = new DevComponents.DotNetBar.ButtonX();
            this.btnSuanhanvien = new DevComponents.DotNetBar.ButtonX();
            this.btnThemnhanvien = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbGioitinhnu = new System.Windows.Forms.RadioButton();
            this.rdbGioitinhnam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTentaikhoan = new System.Windows.Forms.TextBox();
            this.cbbLoainhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSodienthoainv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiachinv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthinhanvien)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 796);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvHienthinhanvien);
            this.groupBox3.Location = new System.Drawing.Point(3, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 307);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhân viên";
            // 
            // dgvHienthinhanvien
            // 
            this.dgvHienthinhanvien.AllowUserToAddRows = false;
            this.dgvHienthinhanvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvHienthinhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHienthinhanvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHienthinhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHienthinhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthinhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.DIACHI,
            this.SDT,
            this.GIOITINH,
            this.LOAINV,
            this.MALOAI,
            this.TENTK,
            this.MATKHAU,
            this.XOA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHienthinhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHienthinhanvien.Location = new System.Drawing.Point(7, 28);
            this.dgvHienthinhanvien.Name = "dgvHienthinhanvien";
            this.dgvHienthinhanvien.ReadOnly = true;
            this.dgvHienthinhanvien.Size = new System.Drawing.Size(841, 273);
            this.dgvHienthinhanvien.TabIndex = 4;
            this.dgvHienthinhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienthinhanvien_CellClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Visible = false;
            this.MANV.Width = 120;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            this.TENNV.Width = 250;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 300;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 150;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính(Nam)";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // LOAINV
            // 
            this.LOAINV.DataPropertyName = "TENLOAI";
            this.LOAINV.HeaderText = "Là nhân viên";
            this.LOAINV.Name = "LOAINV";
            this.LOAINV.ReadOnly = true;
            this.LOAINV.Width = 200;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "LOAINV";
            this.MALOAI.HeaderText = "Mã loại";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Visible = false;
            // 
            // TENTK
            // 
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tài khoản đăng nhập";
            this.TENTK.Name = "TENTK";
            this.TENTK.ReadOnly = true;
            this.TENTK.Width = 150;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Visible = false;
            this.MATKHAU.Width = 150;
            // 
            // XOA
            // 
            this.XOA.DataPropertyName = "XOA";
            this.XOA.HeaderText = "XOA";
            this.XOA.Name = "XOA";
            this.XOA.ReadOnly = true;
            this.XOA.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTimnhanvien);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Location = new System.Drawing.Point(3, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 64);
            this.panel3.TabIndex = 4;
            // 
            // txtTimnhanvien
            // 
            // 
            // 
            // 
            this.txtTimnhanvien.Border.Class = "TextBoxBorder";
            this.txtTimnhanvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimnhanvien.Location = new System.Drawing.Point(209, 15);
            this.txtTimnhanvien.Name = "txtTimnhanvien";
            this.txtTimnhanvien.PreventEnterBeep = true;
            this.txtTimnhanvien.Size = new System.Drawing.Size(368, 29);
            this.txtTimnhanvien.TabIndex = 1;
            this.txtTimnhanvien.TextChanged += new System.EventHandler(this.txtTimnhanvien_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(19, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(162, 29);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm kiếm nhân viên ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDongnhanvien);
            this.groupBox2.Controls.Add(this.btnHuythaotacnv);
            this.groupBox2.Controls.Add(this.btnXoanhanvien);
            this.groupBox2.Controls.Add(this.btnSuanhanvien);
            this.groupBox2.Controls.Add(this.btnThemnhanvien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDongnhanvien
            // 
            this.btnDongnhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongnhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongnhanvien.Location = new System.Drawing.Point(602, 33);
            this.btnDongnhanvien.Name = "btnDongnhanvien";
            this.btnDongnhanvien.Size = new System.Drawing.Size(101, 30);
            this.btnDongnhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongnhanvien.TabIndex = 10;
            this.btnDongnhanvien.Text = "Thoát";
            this.btnDongnhanvien.Click += new System.EventHandler(this.btnDongnhanvien_Click);
            // 
            // btnHuythaotacnv
            // 
            this.btnHuythaotacnv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuythaotacnv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuythaotacnv.Location = new System.Drawing.Point(458, 33);
            this.btnHuythaotacnv.Name = "btnHuythaotacnv";
            this.btnHuythaotacnv.Size = new System.Drawing.Size(138, 30);
            this.btnHuythaotacnv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuythaotacnv.TabIndex = 9;
            this.btnHuythaotacnv.Text = "Hủy thao tác";
            this.btnHuythaotacnv.Click += new System.EventHandler(this.btnHuythaotacnv_Click);
            // 
            // btnXoanhanvien
            // 
            this.btnXoanhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoanhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoanhanvien.Location = new System.Drawing.Point(151, 33);
            this.btnXoanhanvien.Name = "btnXoanhanvien";
            this.btnXoanhanvien.Size = new System.Drawing.Size(101, 30);
            this.btnXoanhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoanhanvien.TabIndex = 8;
            this.btnXoanhanvien.Text = "Xóa";
            this.btnXoanhanvien.Click += new System.EventHandler(this.btnXoanhanvien_Click);
            // 
            // btnSuanhanvien
            // 
            this.btnSuanhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuanhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuanhanvien.Location = new System.Drawing.Point(267, 33);
            this.btnSuanhanvien.Name = "btnSuanhanvien";
            this.btnSuanhanvien.Size = new System.Drawing.Size(101, 30);
            this.btnSuanhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuanhanvien.TabIndex = 7;
            this.btnSuanhanvien.Text = "Sửa";
            this.btnSuanhanvien.Click += new System.EventHandler(this.btnSuanhanvien_Click);
            // 
            // btnThemnhanvien
            // 
            this.btnThemnhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemnhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemnhanvien.Location = new System.Drawing.Point(34, 33);
            this.btnThemnhanvien.Name = "btnThemnhanvien";
            this.btnThemnhanvien.Size = new System.Drawing.Size(101, 30);
            this.btnThemnhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemnhanvien.TabIndex = 6;
            this.btnThemnhanvien.Text = "Thêm";
            this.btnThemnhanvien.Click += new System.EventHandler(this.btnThemnhanvien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdbGioitinhnu);
            this.groupBox1.Controls.Add(this.rdbGioitinhnam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtXacnhanmatkhau);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTentaikhoan);
            this.groupBox1.Controls.Add(this.cbbLoainhanvien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSodienthoainv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiachinv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Giới tính";
            // 
            // rdbGioitinhnu
            // 
            this.rdbGioitinhnu.AutoSize = true;
            this.rdbGioitinhnu.Location = new System.Drawing.Point(318, 277);
            this.rdbGioitinhnu.Name = "rdbGioitinhnu";
            this.rdbGioitinhnu.Size = new System.Drawing.Size(51, 25);
            this.rdbGioitinhnu.TabIndex = 15;
            this.rdbGioitinhnu.Text = "Nữ";
            this.rdbGioitinhnu.UseVisualStyleBackColor = true;
            // 
            // rdbGioitinhnam
            // 
            this.rdbGioitinhnam.AutoSize = true;
            this.rdbGioitinhnam.Checked = true;
            this.rdbGioitinhnam.Location = new System.Drawing.Point(194, 277);
            this.rdbGioitinhnam.Name = "rdbGioitinhnam";
            this.rdbGioitinhnam.Size = new System.Drawing.Size(63, 25);
            this.rdbGioitinhnam.TabIndex = 14;
            this.rdbGioitinhnam.TabStop = true;
            this.rdbGioitinhnam.Text = "Nam";
            this.rdbGioitinhnam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Xác nhận mật khẩu";
            // 
            // txtXacnhanmatkhau
            // 
            this.txtXacnhanmatkhau.Location = new System.Drawing.Point(194, 242);
            this.txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            this.txtXacnhanmatkhau.Size = new System.Drawing.Size(224, 29);
            this.txtXacnhanmatkhau.TabIndex = 12;
            this.txtXacnhanmatkhau.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(194, 207);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(224, 29);
            this.txtMatkhau.TabIndex = 10;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên tài khoản";
            // 
            // txtTentaikhoan
            // 
            this.txtTentaikhoan.Location = new System.Drawing.Point(194, 170);
            this.txtTentaikhoan.Name = "txtTentaikhoan";
            this.txtTentaikhoan.Size = new System.Drawing.Size(224, 29);
            this.txtTentaikhoan.TabIndex = 8;
            // 
            // cbbLoainhanvien
            // 
            this.cbbLoainhanvien.BackColor = System.Drawing.Color.White;
            this.cbbLoainhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoainhanvien.FormattingEnabled = true;
            this.cbbLoainhanvien.Location = new System.Drawing.Point(194, 134);
            this.cbbLoainhanvien.Name = "cbbLoainhanvien";
            this.cbbLoainhanvien.Size = new System.Drawing.Size(224, 29);
            this.cbbLoainhanvien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSodienthoainv
            // 
            this.txtSodienthoainv.Location = new System.Drawing.Point(194, 98);
            this.txtSodienthoainv.MaxLength = 10;
            this.txtSodienthoainv.Name = "txtSodienthoainv";
            this.txtSodienthoainv.Size = new System.Drawing.Size(224, 29);
            this.txtSodienthoainv.TabIndex = 4;
            this.txtSodienthoainv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSodienthoainv_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // txtDiachinv
            // 
            this.txtDiachinv.Location = new System.Drawing.Point(194, 63);
            this.txtDiachinv.Name = "txtDiachinv";
            this.txtDiachinv.Size = new System.Drawing.Size(447, 29);
            this.txtDiachinv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(194, 28);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(306, 29);
            this.txtTennhanvien.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(-1, -1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(872, 808);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(871, 805);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanvien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthinhanvien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTentaikhoan;
        private System.Windows.Forms.ComboBox cbbLoainhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSodienthoainv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiachinv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbGioitinhnu;
        private System.Windows.Forms.RadioButton rdbGioitinhnam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXacnhanmatkhau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHienthinhanvien;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimnhanvien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnDongnhanvien;
        private DevComponents.DotNetBar.ButtonX btnHuythaotacnv;
        private DevComponents.DotNetBar.ButtonX btnXoanhanvien;
        private DevComponents.DotNetBar.ButtonX btnSuanhanvien;
        private DevComponents.DotNetBar.ButtonX btnThemnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn XOA;
    }
}