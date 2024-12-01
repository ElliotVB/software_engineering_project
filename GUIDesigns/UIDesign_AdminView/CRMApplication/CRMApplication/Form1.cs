using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowUserControl(new ScheduleAnnouncementControl());

        }

        private void btnScheduleAnnouncement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ScheduleAnnouncementControl());
        }

        private void btnViewAnalytics_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewAnalyticsControl());
        }

        private void btnEditPermissions_Click(object sender, EventArgs e)
        {
            ShowUserControl(new EditPermissionsControl());
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AddUserControl());
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewFeedbackControl());
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewTasksControl());
        }
        private void ShowUserControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
        }
    }
}
