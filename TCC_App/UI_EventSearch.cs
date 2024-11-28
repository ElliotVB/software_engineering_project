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
    //Creator: Elliot

    //Displys a list of buttons which link to different events
    //Search bar can be used to filter events

    /*TODO:
     * Implement dummy event buttons
     * Implement proper event buttons which take info from database
     * Implement search function
     * Redesign UI to work with navigation bar (once implemented)
     */
    public partial class UI_EventSearch : UserControl
    {
        private FormUI form;

        public UI_EventSearch(FormUI form)
        {
            InitializeComponent();
            this.form = form;

            GenerateEventsFromDB();
        }


        //Generates a set of events within the event layout
        //Currently just generates "dummy" events - will eventually be changed to generate events from the DB
        private void GenerateEventsFromDB()
        {

            //Tgenerates 20 "dummy" events
            for (int i = 0; i < 20; i++)
            {
                //CREATE A NEW CLASS THAT INHERITS FROM BUTTON (to link to event view page)
                //also give the text a border in that class's draw function
                Button b = new EventButton(form, "Event no. " + (i + 1), "Example event description.", "TCC building", "N/A", "N/A", 5, 3, 0, i);
                eventFlowLayout.Controls.Add(b);
            }
        }

        private void searchBox_Clicked(object sender, EventArgs e)
        {
            //Deletes the default text in the search box the first time it's clicked
            if (searchBox.ForeColor == Color.Gray)
            {
                searchBox.Text = null;
                searchBox.ForeColor = Color.Black;
            }
        }

        private void navigationPanel_Paint(object sender, PaintEventArgs e)
        {
            //DELETE THIS
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            //DELETE THIS
        }

        //TEMP - switches form to placeholder
        private void buttonHome_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new placeholder(form));
        }
    }
}
