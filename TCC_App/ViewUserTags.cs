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
    public partial class ViewUserTagControl : UserControl
    {
          public ViewUserTagControl()
        {
            InitializeComponent();
            LoadUserTagData();
            dataGridViewUserTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUserTags.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void LoadUserTagData()
    {
        DataTable dataTable = new DataTable();

        
        dataTable.Columns.Add("UserID", typeof(int));
        dataTable.Columns.Add("TagID", typeof(int));
        dataTable.Columns.Add("DateOfInterest", typeof(DateTime));

        dataTable.Rows.Add(1, 2, DateTime.Now);
        dataTable.Rows.Add(4, 3, DateTime.Now);
        dataTable.Rows.Add(5, 1, DateTime.Now);
        dataTable.Rows.Add(6, 2, DateTime.Now);

        dataGridViewUserTags.DataSource = dataTable;
    }



    private void buttonDeleteUserTag(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");

        }

        private void dataGridViewUserTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ViewAnalyticsControl_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewUserTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("No DB is Attached");
            }
        }
    }
}

