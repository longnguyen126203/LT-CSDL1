﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class formChinh : Form
    {
        public formChinh()
        {
            InitializeComponent();
        }

        private void tsmlBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void tsmlBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void tsmlBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }

        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            var form = new frmBai4();
            form.ShowDialog();
        }
    }
}
