using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace WindowsFormsApp15
{
    public partial class DanhSachGiaoVien : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();
        }
        public static string str;
        private void DanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            DanhSachGVBUL cls = new DanhSachGVBUL();
            cboTenLop.DataSource = cls.LayMaLop();
            cboTenLop.DisplayMember = "TenLop";
            cboTenLop.ValueMember = "MaLop";
            txtTenTruong.Text = "Trường THPT Lương Thế Vinh";

            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy-HH:mm"); 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DanhSachGVBUL cls = new DanhSachGVBUL();
            PhanCongGiangDay x = new PhanCongGiangDay();
            x.MaLop = cboTenLop.SelectedValue.ToString();
            dgvDSGV.DataSource = cls.HienThiDS(x);
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            str = cboTenLop.SelectedValue.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportGiaoVien frm = new frmReportGiaoVien();
            frm.ShowDialog();
        }
        public string getMaLop()
        {
            return str;
        }
    }
}
