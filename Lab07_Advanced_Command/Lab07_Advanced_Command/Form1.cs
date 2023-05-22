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

namespace Lab07_Advanced_Command
{
    public partial class FormFood : Form
    {
        private DataTable foodTable;
        public FormFood()
        {
            InitializeComponent();
        }

        private void LoadCategory()
        {
            string connectionString = "server = PC408; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID, Name from category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);// Lấy dữ liệu từ csdl vào datatable

            conn.Close();
            conn.Dispose();

            cbbCategory.DataSource = dt;//đưa dữ liệu vào combobox

            cbbCategory.DisplayMember = "Name";//hiển thị tên nhóm sản phẩm

            cbbCategory.ValueMember = "ID";//nhưng khi lấy giá trị thì lấy ID của nhóm
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;

            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";
            command.Parameters.Add("@categoryId", SqlDbType.Int);

            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                command.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                command.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            foodTable = new DataTable();

            connection.Open();

            adapter.Fill(foodTable);

            connection.Close();
            connection.Dispose();

            dgvFoodList.DataSource = foodTable;

            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;

        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			if(dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				command.Parameters.Add("@foodId", SqlDbType.Int);
				command.Parameters["@foodId"].Value = rowView["ID"];

				command.Parameters.Add("@numSaleFood", SqlDbType.Int);
				command.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				connection.Open();

				command.ExecuteNonQuery();

				string result = command.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show ("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

                if (string.IsNullOrWhiteSpace(result))
                    MessageBox.Show("Món " + rowView["Name"] + " chưa bán được " + rowView["Unit"] + " nào!");

				connection.Close();
			}

			command.Dispose();
			connection.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FormFoodInfo formFood = new FormFoodInfo();
            formFood.FormClosed += FormFood_FormClosed;

            formFood.Show(this);
        }

        private void FormFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FormFoodInfo foodForm = new FormFoodInfo();
                foodForm.FormClosed += new FormClosedEventHandler(FormFood_FormClosed);

                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
		{
			if (foodTable == null) return;

			string filterExpression = $"Name LIKE '%{txtSearchByName.Text}%'";
			string sortExpression = "Price DESC";

			DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

			DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);

			dgvFoodList.DataSource = foodView;
		}

        
    }
}
