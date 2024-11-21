using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign_EventSearch
{
    public partial class EventView : Form
    {
        public EventView()
        {
            InitializeComponent();
        }

        public void InitializeDetails(string name, string description, string location, string eventLink, string imageLink, int cost, int memberDiscount, int accessRequired)
        {
            EventImage.BackgroundImage = UIDesign_EventSearch.Properties.Resources._event;  //TEMP: should use imageLink
            EventName.Text = name;
            EventDescription.Text = description;
            EventLocation.Text = location;
            EventPrice.Text = GetCostAsString(cost, memberDiscount);
            //TEMP: currently doesn't initialize contacts, as User isn't implemented
        }

        //Returns the event cost as a string
        //TEMP: currently ignores discount, as User isn't implemented
        //TEMP: cost and discount should be changed to doubles and truncate, as currently they can only be full pounds
        private string GetCostAsString(int cost, int discount)
        {
            return "Entry cost: £" + cost + ".00";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventView_Load(object sender, EventArgs e)
        {

        }

        private void EventDescription_Click(object sender, EventArgs e)
        {

        }

        private void EventInfoLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            Consts.FormEventView.Hide();
            Consts.FormEventSearch.Show();
        }
    }
}
