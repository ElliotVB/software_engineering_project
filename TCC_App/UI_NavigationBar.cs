using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_App
{
    public partial class UI_NavigationBar : UserControl
    {
        //Creators: Aziz (UI design), Elliot (code)
        FormUI form;

        public UI_NavigationBar(FormUI form)
        {
            InitializeComponent();
            this.form = form; 

            //TEMP - Should check if user is admin to check if the admin button should display
        }

        private void Main_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_MainPage(form));
        }

        private void events_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_EventSearch(form));
        }

        private void users_BT_Click(object sender, EventArgs e)
        {
            //user search not implemented
        }

        private void profile_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form));
        }

        private void admin_BT_Click(object sender, EventArgs e)
        {
            //Admin not implemented (in user form)
        }
    }
}
