using System;
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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghiaAnh.Text;

            listBox1.Items.Add(tu);
            list.Add(nghia);

            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaAnh.Text = "";

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            txtHienThiNghia.Text = nghia;
        }

        private void txtHienThiNghia_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lay so thu tu cua tu trong listbox
            var stt = listBox1.SelectedIndex;   
            
            //Tra nghia cua tu trong danh sach list dua vao so thu tu 
            txtHienThiNghia.Text = list[stt];
        }
    }
}
