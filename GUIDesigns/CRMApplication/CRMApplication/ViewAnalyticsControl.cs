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
    public partial class ViewAnalyticsControl : UserControl
    {
        DatabaseHandler dbHandler = new DatabaseHandler();

        public ViewAnalyticsControl()
        {
            InitializeComponent();
            LoadAnalytics();
        }

        private void LoadAnalytics()
        {
            DataTable analyticsData = new DataTable();
            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                //query the database to get an statistic
                string query = "SELECT COUNT(*) AS TaskCount, AVG(DATEDIFF(day, DueDate, GETDATE())) AS AvgDaysOverdue FROM Tasks";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(analyticsData);
            }

            dgvAnalytics.DataSource = analyticsData;
        }
    }
}
