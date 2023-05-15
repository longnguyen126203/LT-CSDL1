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
        int categoryID;
        
        public frmFood()
        {
            InitializeComponent();
        }

        public void LoadFood(int categoryID)
        {
            this.categoryID = categoryID;
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

            sqlCommand.CommandText = "Select ID, Name, Unit, Price, Notes from Food Where FoodCategoryID = " + categoryID;

            //tạo đối tượng DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            
            //tạo datatable để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            //Hiển thị danh sách món ăn lên Form
            dgvFood.DataSource = dt;

            dgvFood.Columns[0].ReadOnly = true;

            //Đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            SqlCommand sqlcommand = sqlconnection.CreateCommand();

            sqlconnection.Open();
            //sqlcommand.ExecuteNonQuery();


            sqlcommand.CommandText = "DELETE FROM Food WHERE FoodCategoryID = " + categoryID;
            

            for (int i = 0; i < dgvFood.Rows.Count - 1; i++)
            {
                
                string query = string.Format("" +
                    "INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)" + " " +
                    "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
                    dgvFood.Rows[i].Cells["Name"].Value,
                    dgvFood.Rows[i].Cells["Unit"].Value,
                    categoryID,
                    dgvFood.Rows[i].Cells["Price"].Value,
                    dgvFood.Rows[i].Cells["Notes"].Value).ToString();
                sqlcommand.CommandText = query;
                sqlcommand.ExecuteNonQuery();
            }

                
            sqlconnection.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;

            var selectedRow = dgvFood.SelectedRows[0];

            string foodID = selectedRow.Cells[0].Value.ToString();

            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            SqlCommand sqlcommand = sqlconnection.CreateCommand();

            string query = "DELETE FROM Food WHERE ID = " + foodID;
            sqlcommand.CommandText = query;

            sqlconnection.Open();

            int numOfRowsEffected = sqlcommand.ExecuteNonQuery();

            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("Có lỗi xảy ra.");
                return;
            }

            dgvFood.Rows.Remove(selectedRow);
            
            sqlconnection.Close();
        }
    }
}
