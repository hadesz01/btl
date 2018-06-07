using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DTO;

namespace WindowsFormsApp15
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            QuanLyMonBUL cls = new QuanLyMonBUL();
            dgvMonHoc.DataSource = cls.HienThi();
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyMonBUL cls = new QuanLyMonBUL();
            MonHoc x = new MonHoc();
            x.MaMon = txtMaMon.Text;
            x.TenMon = txtTenMon.Text;
            x.SoTiet = int.Parse(txtSoTiet.Text);
            MessageBox.Show("Bạn có muốn Lưu không?", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            cls.Them(x);
            QuanLyMonHoc_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyMonBUL cls = new QuanLyMonBUL();
            MonHoc x = new MonHoc();
            x.MaMon = txtMaMon.Text;
            x.TenMon = txtTenMon.Text;
            x.SoTiet = int.Parse(txtSoTiet.Text);
            cls.Sua(x);
            QuanLyMonHoc_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyMonBUL cls = new QuanLyMonBUL();
            MonHoc x = new MonHoc();
            x.MaMon = txtMaMon.Text;
            cls.Xoa(x);
            QuanLyMonHoc_Load(sender, e);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            QuanLyMonBUL cls = new QuanLyMonBUL();
            MonHoc x = new MonHoc();
            x.MaMon = txtMaMon.Text;
            dgvMonHoc.DataSource = cls.Xem(x);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc_Load(sender, e);
        }
    }
}
