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

    //Displays details information about a specific event, as well as a button which links to the booking page
    //Accessed through pressing an event button on the event search page
    public partial class UI_EventInformation : UserControl
    {
        private FormUI form;

        public UI_EventInformation(FormUI form, string name, string description, string location, DateTime dateTime, string eventLink, string imageLink, int cost, int memberDiscount, int accessRequired)
        {
            InitializeComponent();
            this.form = form;

            EventImage.BackgroundImage = TCC_App.Properties.Resources._event;  //TEMP: should use imageLink
            EventName.Text = name;
            EventDescription.Text = description;
            EventLocation.Text = location;
            EventDateTime.Text = dateTime.ToString();
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

        //TEMP - switches form to placeholder
        private void buttonHome_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new placeholder(form));
        }

        private void EventLocation_Click(object sender, EventArgs e)
        {

        }

        private void Contact2_Click(object sender, EventArgs e)
        {

        }

        private void EventInfoLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
