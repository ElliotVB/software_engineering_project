using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMApplication
{
    public partial class RemoveUserControl : UserControl
    {
        public RemoveUserControl()
        {
            InitializeComponent();
            LoadUserData();
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void LoadUserData()
        {
            DataTable dataTable = new DataTable();

            
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            dataTable.Rows.Add(1, "John", "D", "1234567890", "JohnD@example.com", "Active");
            dataTable.Rows.Add(4, "Lucy", "C", "0987654321", "LucyC@example.com", "Active");
            dataTable.Rows.Add(5, "Chris", "H", "1112223333", "ChrisH@example.com", "Inactive");
            dataTable.Rows.Add(6, "Samantha", "W", "2223334444", "SamanthaW@example.com", "Active");

            dataGridViewUsers.DataSource = dataTable;
        }



        private void btnRemoveUser(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");
           
        }


        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
        }
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        

    }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");
        }
    }
    
}
