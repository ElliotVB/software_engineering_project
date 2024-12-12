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
using Google.Protobuf.WellKnownTypes;
//by yusef
namespace CRMApplication
{
    public partial class ViewCurrentVisitorControl : UserControl
    {
        public ViewCurrentVisitorControl()
        {
            InitializeComponent();
            LoadVisitorData();
            dataGridViewVisitors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVisitors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    private void LoadVisitorData()
    {
        DataTable dataTable = new DataTable();

        dataTable.Columns.Add("VisitorLogID", typeof(int));
        dataTable.Columns.Add("UserID", typeof(int));
        dataTable.Columns.Add("VisitDate", typeof(DateTime));
        dataTable.Columns.Add("PurposeOfVisit", typeof(string));
        dataTable.Columns.Add("DurationOfStay", typeof(string));

        dataTable.Rows.Add(1, 1, DateTime.Now, "Meeting", "2 hours");
        dataTable.Rows.Add(2, 4, DateTime.Now, "Conference", "3 hours");
        dataTable.Rows.Add(3, 5, DateTime.Now, "Tour", "1.5 hours");
        dataTable.Rows.Add(4, 6, DateTime.Now, "Workshop", "2.5 hours");

        dataGridViewVisitors.DataSource = dataTable;
    }



    private void ScheduleAnnouncementControl_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveVisitors(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");
          
        }


        private void dataGridViewVisitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewVisitors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");
            
        }
    }
}
