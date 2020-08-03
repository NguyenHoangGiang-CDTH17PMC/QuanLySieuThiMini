﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini
{
    public partial class frmLoainhanvien : Form
    {
        BUS.LoainhanvienBUS lnvb;
        public frmLoainhanvien()
        {
            InitializeComponent();
            lnvb = new BUS.LoainhanvienBUS();
        }
        public void Hienthiloainhanvien()
        {
            DataTable dt = lnvb.Tableloainhanvien();
            dgvHienthiloainv.DataSource = dt;
        }
        private void btnHuythaotacloainv_Click(object sender, EventArgs e)
        {
            txtTenloainhanvien.Text = "";
            btnThemloainv.Enabled = true;
            btnSualoainv.Enabled = false;
            btnXoaloainv.Enabled = false;
        }

        private void frmLoainhanvien_Load(object sender, EventArgs e)
        {
            Hienthiloainhanvien();
            btnSualoainv.Enabled = false;
            btnXoaloainv.Enabled = false;
        }

        private void btnThemloainv_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTenloainhanvien.Text))
            {
                DTO.Loainhanvien lnv = new DTO.Loainhanvien();
                lnv.TENLOAI1 = txtTenloainhanvien.Text;
                if(lnvb.Themloainhanvien(lnv))
                {
                    Hienthiloainhanvien();
                    txtTenloainhanvien.Text = "";
                }
                
            }
        }
        int ID;
        private void btnSualoainv_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTenloainhanvien.Text))
            {
                DTO.Loainhanvien lnv = new DTO.Loainhanvien();
                lnv.TENLOAI1 = txtTenloainhanvien.Text;
                lnv.MALOAI1 = ID;
                if (lnvb.Sualoainhanvien(lnv))
                {
                    Hienthiloainhanvien();
                    btnThemloainv.Enabled = true;
                    btnSualoainv.Enabled = false;
                    btnXoaloainv.Enabled = false;
                    txtTenloainhanvien.Text = "";
                }
            }
        }
        private void dgvHienthiloainv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    ID = Int32.Parse(dgvHienthiloainv.Rows[index].Cells["MALOAI"].Value.ToString());
                    txtTenloainhanvien.Text = dgvHienthiloainv.Rows[index].Cells["TENLOAI"].Value.ToString();
                    btnSualoainv.Enabled = true;
                    btnXoaloainv.Enabled = true;
                    btnThemloainv.Enabled = false;
                }
            }catch
            {
            }
        }
        private void btnXoaloainv_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTenloainhanvien.Text))
            {
                DTO.Loainhanvien lnv = new DTO.Loainhanvien();
                lnv.TENLOAI1 = txtTenloainhanvien.Text;
                lnv.MALOAI1 = ID;
                if (lnvb.Xoaloainhanvien(lnv))
                {
                    Hienthiloainhanvien();
                    btnThemloainv.Enabled = true;
                    btnSualoainv.Enabled = false;
                    btnXoaloainv.Enabled = false;
                    txtTenloainhanvien.Text = "";
                }  
            }
        }
        private void btnDongloainv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
