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
    public partial class ViewFeedbackControl : UserControl
    {
        DatabaseHandler dbHandler = new DatabaseHandler();

        public ViewFeedbackControl()
        {
            InitializeComponent();
            LoadFeedback();
        }

        private void LoadFeedback()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "SELECT * FROM Feedback";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    feedbacks.Add(new Feedback
                    {
                        FeedbackID = (int)reader["FeedbackID"],
                        Comment = (string)reader["Comment"],
                        DateReceived = (DateTime)reader["DateReceived"]
                    });
                }
            }

            dgvFeedback.DataSource = feedbacks;
        }
    }
}
