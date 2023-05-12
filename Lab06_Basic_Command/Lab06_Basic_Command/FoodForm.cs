using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab06_Basic_Command
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {

        }

        public void LoadFood(int categoryID)
        {
            //tạo đối tượng kết nối
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //thiết lập truy vấn cho đối tượng command
            sqlCommand.CommandText = "select name from category where id = " + categoryID;

            //mở kết nối cơ sở dữ liệu
            sqlConnection.Open();

            //Gán tên nhóm sản phẩm cho tiêu đề
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách món ăn thuộc nhóm: " + catName;

            sqlCommand.CommandText = "select * from food where FoodCategoryID = " + categoryID;

            //tạo đối tượng DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            
            //tạo datatable để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            //Hiển thị danh sách món ăn lên Form
            dgvFood.DataSource = dt;

            //Đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridView data = new DataGridView();
            
        }
    }
}
