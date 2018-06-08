using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class frmReportGiaoVien : Form
    {
        public frmReportGiaoVien()
        {
            InitializeComponent();
        }
        DanhSachGiaoVien cls = new DanhSachGiaoVien();
        private void frmReportGiaoVien_Load(object sender, EventArgs e)
        {
            string str = cls.getMaLop();
            this.CanBoGiaoVienTableAdapter.Fill(this.dsGiaoVien.CanBoGiaoVien, str);
            this.reportViewer1.RefreshReport();
        }
    }
}
