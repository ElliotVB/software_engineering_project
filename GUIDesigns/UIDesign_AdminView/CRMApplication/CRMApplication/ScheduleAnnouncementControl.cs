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
    public partial class ScheduleAnnouncementControl : UserControl
    {
      DatabaseHandler dbHandler = new DatabaseHandler();

          
        public ScheduleAnnouncementControl()
        {
            InitializeComponent();
            LoadAnnouncements();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Announcement announcement = new Announcement
            {
                Content = txtContent.Text,
                ScheduleDate = dtpScheduleDate.Value
            };

            using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "INSERT INTO Announcements (Content, ScheduleDate) VALUES (@Content, @ScheduleDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Content", announcement.Content);
                command.Parameters.AddWithValue("@ScheduleDate", announcement.ScheduleDate);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Announcement scheduled successfully!");
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            List<Announcement> announcements = new List<Announcement>();
           using (SqlConnection connection = dbHandler.CreateConnection())
            {
                string query = "SELECT * FROM Announcements";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    announcements.Add(new Announcement
                    {
                        AnnouncementID = (int)reader["AnnouncementID"],
                        Content = (string)reader["Content"],
                        ScheduleDate = (DateTime)reader["ScheduleDate"]
                    });
                }
            }

            dgvAnnouncements.DataSource = announcements;
        }
    }
}
