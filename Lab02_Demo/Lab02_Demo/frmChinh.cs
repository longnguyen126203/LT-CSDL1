using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Demo
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmividu1_Click(object sender, EventArgs e)
        {
            var form = new frmTrungTam();
            form.ShowDialog();
        }

        private void víDụ2BàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmGiaoVien();
            form.ShowDialog();
        }
    }
}
