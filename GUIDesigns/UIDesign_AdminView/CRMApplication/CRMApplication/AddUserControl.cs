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

namespace CRMApplication
{
    public partial class AddUserControl : UserControl
    {
        public AddUserControl()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = cmbRole.SelectedItem.ToString()
            };
            DatabaseHandler dbHandler = new DatabaseHandler();

            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", newUser.Username);
                command.Parameters.AddWithValue("@Password", newUser.Password);
                command.Parameters.AddWithValue("@Role", newUser.Role);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("User added successfully!");
            ClearForm();
        }
        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
