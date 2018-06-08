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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://www.google.com.vn/search?q=%3F&rlz=1C1PRFI_enVN" +
                "767VN767&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiAqYDX" +
                "jaPbAhWKWLwKHUM2DTEQ_AUICigB&biw=1517&bih=664");
        }
    }
}
