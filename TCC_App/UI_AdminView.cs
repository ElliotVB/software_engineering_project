using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_App;

namespace CRMApplication
{
    public partial class UI_AdminView : Form
    {
        private FormUI form;

        public UI_AdminView()
        {
            InitializeComponent();
            this.form = new FormUI();
            ShowUserControl(new ViewAddUserControl());

        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewFeedbackControl());
        }


        private void ShowUserControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
        }

        private void btnViewCurrentVisitors(object sender, EventArgs e)
        {
            ShowUserControl(new ViewCurrentVisitorControl());

        }



        private void btnAddUser(object sender, EventArgs e)
        {
            ShowUserControl(new ViewAddUserControl());

        }

        private void btnRemoveUser(object sender, EventArgs e)
        {
            ShowUserControl(new RemoveUserControl());

        }

        private void btnReviewAdminRequests(object sender, EventArgs e)
        {
            ShowUserControl(new ViewAdminRequests());

        }

        private void btnViewUserTag(object sender, EventArgs e)
        {
            ShowUserControl(new ViewUserTagControl());

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new placeholder(form));
            form.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
