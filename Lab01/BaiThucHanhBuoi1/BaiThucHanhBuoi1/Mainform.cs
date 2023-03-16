using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        //Click đôi vào nút chương trình sẽ tạo hàm sự kiện này 
        //Khi ta click chuột vào nút chương trình sẽ làm gì?
        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNNap = txtTen.Text;

            MessageBox.Show($"Xin chào các bạn {tenDaNNap}. Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Ví dụ bên trên nhập trên gì bên dưới sao chép lại
        //Hộp thoại sao chép không cho phép gõ, chỉ cho sao chép bên trên, cần xử lý như sau

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {

        }

        //Bây giờ muốn xử lý sự kiện, trông ô tên gõ gì thì ô sao chép có nội dung như vậy, không cần nhấn nút sao chép
        //Xử lý như sau:
        //Click đổi vào TextBox, sự kiện TextChanged được tạo, nhưng mà bây giờ cần bắt ô sự kiện thay đổi ở ô nhập tên, không phải ô sao chép
    }
}
