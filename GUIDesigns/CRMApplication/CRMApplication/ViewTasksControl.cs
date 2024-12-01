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
    public partial class ViewTasksControl : UserControl
    {
        DatabaseHandler dbHandler = new DatabaseHandler();

        public ViewTasksControl()
        {
            InitializeComponent();
            LoadTasks();
        }
        private void LoadTasks()
        {
            List<Task> tasks = new List<Task>();
            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "SELECT * FROM Tasks";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tasks.Add(new Task
                    {
                        TaskID = (int)reader["TaskID"],
                        Description = (string)reader["Description"],
                        DueDate = (DateTime)reader["DueDate"]
                    });
                }
            }

            dgvTasks.DataSource = tasks;
        }

        private void ViewTasksControl_Load(object sender, EventArgs e)
        {

        }
    }
}
