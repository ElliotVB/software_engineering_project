using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIDesign_EventSearch
{
    internal class EventButton : Button
    {
        private string name;
        private string description;
        private string eventLink;
        private string imageLink;
        private string location;

        private int cost;
        private int memberDiscount;
        private int accessRequired;

        //private static User organisers[];
        //private static User creators[];

        //Switches form to EventView when pressed
        //Loads EventView with the information contained within this button

        public EventButton(string name, string description, string location, string eventLink, string imageLink, int cost, int memberDiscount, int accessRequired, int index)
        {
            this.name = name;
            this.description = description;
            this.location = location;
            this.eventLink = eventLink;
            this.imageLink = imageLink;
            this.cost = cost;
            this.memberDiscount = memberDiscount;
            this.accessRequired = accessRequired;

            Text = name;
            TextAlign = ContentAlignment.BottomCenter;
            Size = new System.Drawing.Size(150, 100);
            Cursor = System.Windows.Forms.Cursors.Hand;
            Image = UIDesign_EventSearch.Properties.Resources._event;  //TEMP - should use imageLink
            BackgroundImageLayout = ImageLayout.Stretch;    //TEMP - stretch doesn't seem to be working
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Tag = index;
            Margin = new System.Windows.Forms.Padding(20);
            
        }

        protected override void OnClick(EventArgs e)
        {
            Consts.FormEventView.InitializeDetails(name, description, location, eventLink, imageLink, cost, memberDiscount, accessRequired);
            Consts.FormEventView.Show();
            Consts.FormEventSearch.Hide();
        }
    }
}
