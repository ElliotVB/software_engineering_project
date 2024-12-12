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
//by yusef
namespace CRMApplication
{
    public partial class ViewFeedbackControl : UserControl
    {
        public ViewFeedbackControl()
        {
            InitializeComponent();
            LoadFeedbackData();
            dataGridViewFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void LoadFeedbackData()
        {
            
            DataTable dataTable = new DataTable();

            
            dataTable.Columns.Add("FeedbackID", typeof(int));
            dataTable.Columns.Add("BookingID", typeof(int));
            dataTable.Columns.Add("FeedbackScore", typeof(int));
            dataTable.Columns.Add("FeedbackText", typeof(string));
            dataTable.Columns.Add("UserID", typeof(int));

            dataTable.Rows.Add(1, 1, 5, "Excellent service!", 1);
            dataTable.Rows.Add(2, 2, 4, "Good, but there is room for improvement.", 4);
            dataTable.Rows.Add(3, 3, 3, "Average experience.", 5);
            dataTable.Rows.Add(4, 4, 2, "Not satisfied with the service.", 6);

            dataGridViewFeedback.DataSource = dataTable;
        }


        private void btnremovefeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No DB is Attached");

        }




        private void dataGridViewFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void ViewFeedbackControl_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("No DB is Attached");
        }
    }
}
