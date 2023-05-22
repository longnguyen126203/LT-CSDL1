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
    public partial class FormThemNhomMonAn : Form
    {
        public FormThemNhomMonAn()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
			try
			{
				string connectionString = "server=PC408; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE AddNew @id OUTPUT, @name, @type";

				command.Parameters.Add("@id", SqlDbType.Int);
				command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@type", SqlDbType.Int);
				

				command.Parameters["@id"].Direction = ParameterDirection.Output;

				command.Parameters["@name"].Value = txtNhomMa.Text;
				command.Parameters["@type"].Value = cbbTypeMa.SelectedIndex;
				

				connection.Open();

				int numRowAffected = command.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string categoryID = command.Parameters["@id"].Value.ToString();
					MessageBox.Show("Successfully adding new category. Category ID = " + categoryID, "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding category fail");
				}

				connection.Close();
				connection.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

        
    }
}
