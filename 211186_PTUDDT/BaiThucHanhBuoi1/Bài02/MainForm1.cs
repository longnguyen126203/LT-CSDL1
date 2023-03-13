using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài02
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện khi người dùng đã chọn giới tính là Nam
        //Click đôi vào Control Checkbox
        //Đây là sự kiện nếu thay đổi việc check(check hoặc bỏ check đều xảy ra sự kiên)
        //Nếu muốn kiểm tra nếu nút được check mới thông báo thì sửa như sau:

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn giới tính là Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
                MessageBox.Show("Bạn chọn giới tính là Nữ", "Thông báo");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor = Color.Green;
        }
    }
}
