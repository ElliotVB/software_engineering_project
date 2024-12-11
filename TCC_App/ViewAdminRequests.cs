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
    public partial class ViewAdminRequests : UserControl
    {
         public ViewAdminRequests()
        {
            InitializeComponent();
            LoadAdminRequestData();
            dataGridViewAdminRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAdminRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void LoadAdminRequestData()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("AdminRequestID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("RequestDescription", typeof(string));
            dataTable.Columns.Add("RequestTime", typeof(DateTime));

            dataTable.Rows.Add(1, 1, "Need access to admin panel", DateTime.Now);
            dataTable.Rows.Add(2, 4, "Request for new user role", DateTime.Now);
            dataTable.Rows.Add(3, 5, "Permission to edit settings", DateTime.Now);
            dataTable.Rows.Add(4, 6, "Access to advanced reporting", DateTime.Now);

            dataGridViewAdminRequests.DataSource = dataTable;
        }


        private void btndeleterequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");
           
            }

        

        private void ViewAdminRequests_Load(object sender, EventArgs e)
        {
        }


        private void dataGridViewAdminRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewAdminRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");

        }
    }
}
