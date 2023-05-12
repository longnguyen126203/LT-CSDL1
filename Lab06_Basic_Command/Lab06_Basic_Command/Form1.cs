using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true;";

            //tạo đối tượng kết nối 
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //thiết lập lệnh truy vấn cho đối tượng Command
            string query = "select ID, Name, Type from Category";
            sqlCommand.CommandText = query;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            //Thực thi bằng phương pháp ExcuteReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //gọi hàm hiển thị dữ liệu lên màn hình
            this.DisplayCategory(sqlDataReader);

            //đóng kết nối
            sqlConnection.Close();
        }

        private void DisplayCategory(SqlDataReader reader)
        {
            //xóa tất cả các dòng hiện tại
            lvCategory.Items.Clear();

            //Đọc một dòng dữ liệu
            while (reader.Read())
            {
                //tạo một dòng mới trong ListView
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                //thêm dòng mới vào ListView
                lvCategory.Items.Add(item);

                //bổ sung các thông tin khác cho ListViewItem
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng kết nối
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //thiết lập truy vấn cho đối tượng Command
            sqlCommand.CommandText = "insert into Category(Name, [Type])" +
                "values (N'" + txtName.Text + "', " + txtType.Text + ")";

            //Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            //thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            //Đóng kết nối
            sqlConnection.Close();

            if(numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");

                //tải lại dữ liệu
                btnLoad.PerformClick();

                //xóa các ô nhập
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            //lấy dòng được chọn trong ListView
            ListViewItem item = lvCategory.SelectedItems[0];

            //Hiển thị dữ liệu lên TextBox
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text;

            //hiển thị nút cập nhật và xóa
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //tạo đối tượng kết nối
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //thiết lập truy vấn cho đối tượng Command
            sqlCommand.CommandText = "update category set Name = N'" + txtName.Text +
                                                  "', [Type] = " + txtType.Text +
                                                  " where id = " + txtID.Text;

            //mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            //thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            //Đóng kết nối
            sqlConnection.Close();

            if(numOfRowsEffected == 1)
            {
                // cập nhật lại dữ liệu trên ListView
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;

                //Xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                // Disable các nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //tạo đối tượng kết nối
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //thiết lập truy vấn cho đối tượng Command
            sqlCommand.CommandText = "delete from category " +
                "where id = " + txtID.Text;

            //mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            //thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            //Đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                // cập nhật lại dữ liệu trên ListView
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;

                //Xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                // Disable các nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmiViewFood_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                frmFood foodForm = new frmFood();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }


    }
}
