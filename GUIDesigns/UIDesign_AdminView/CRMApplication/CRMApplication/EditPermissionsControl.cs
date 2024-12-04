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
    public partial class EditPermissionsControl : UserControl
    {
      DatabaseHandler dbHandler = new DatabaseHandler();

        public EditPermissionsControl()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            List<User> users = new List<User>();
           
            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = (string)reader["Username"],
                        Role = (string)reader["Role"]
                    });
                }
            }

            cmbUsers.DataSource = users;
            cmbUsers.DisplayMember = "Username";
            cmbUsers.ValueMember = "UserID";
        }
        private void EditPermissionsControl_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedUserID = (int)cmbUsers.SelectedValue;
            string newRole = cmbRoles.SelectedItem.ToString();

           
            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "UPDATE Users SET Role = @Role WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Role", newRole);
                command.Parameters.AddWithValue("@UserID", selectedUserID);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("User role updated successfully!");
        }
    }
    
}
