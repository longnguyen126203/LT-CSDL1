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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

			string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT * FROM Bills";

			connection.Open();

			string categoryName = command.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ hóa đơn";

			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvHoaDon.DataSource = table;

			// Prevent user to edit ID
			dgvHoaDon.Columns[0].ReadOnly = true;

			connection.Close();
		}

		private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
		{
			FormDetailsOrders billDetails = new FormDetailsOrders();
			string billID = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
			billDetails.LoadBillDetails(int.Parse(billID));
			billDetails.Show();
		}

		private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = new DataGridViewRow();
			row = dgvHoaDon.Rows[e.RowIndex];
			string Amount = Convert.ToString(row.Cells["Amount"].Value);
			string Discount = Convert.ToString(row.Cells["Discount"].Value);
			txtTienDaGiamGia.Text = (int.Parse(Amount) - (int.Parse(Amount) * float.Parse(Discount))).ToString();
			txtTienChuaGiamGia.Text = Amount;
			txtThucThu.Text = (int.Parse(txtTienChuaGiamGia.Text) - int.Parse(txtTienDaGiamGia.Text)).ToString();
		}
	}
}
