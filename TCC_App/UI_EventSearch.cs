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
        FormUI form;

        public UI_EventSearch(FormUI form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void navigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {

        }
    }
}
