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
    public partial class frmHienthihoadonban : Form
    {
        BUS.HoadonbanBUS hdxb;
        int ID;

        public frmHienthihoadonban()
        {
            InitializeComponent();
            hdxb = new BUS.HoadonbanBUS();
        }

        public void Hienhoadonxuat()
        {
            DataTable dt = hdxb.Tablehoadonxuat();
            dgvDanhsachhoadonban.DataSource = dt;
            dgvDanhsachhoadonban.Columns["TONGTIEN"].DefaultCellStyle.Format = "N";
        }

        private void frmHienthihoadonban_Load(object sender, EventArgs e)
        {
            Hienhoadonxuat();
        }
        
        private void dgvDanhsachhoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0)
            {
                ID = Int32.Parse(dgvDanhsachhoadonban.Rows[index].Cells["MAHDX"].Value.ToString());
                DataTable dt = hdxb.Tablechitiethoadonxuat(ID);
                dgvChitiethoadonban.DataSource = dt;
                dgvChitiethoadonban.Columns["GIATIEN"].DefaultCellStyle.Format = "N";
                dgvChitiethoadonban.Columns["GIAMGIA"].DefaultCellStyle.Format = "N";
            }
        }

        private void dtpNgaylap_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = hdxb.Tabletheongay(dtpNgaylap.Value.ToString("yyyy/MM/dd"));
            dgvDanhsachhoadonban.DataSource = dt;
            dgvDanhsachhoadonban.Columns["TONGTIEN"].DefaultCellStyle.Format = "N";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
