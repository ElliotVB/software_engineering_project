﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_App
{
    internal class EventButton : Button
    {
        //Creator: Elliot

        //A button which is associated with a specific event
        //Loaded into UI_EventSearch
        //When pressed, it will load UI_EventInfo with the information contained in this button

        private string name;
        private string description;
        private string eventLink;
        private string imageLink;
        private string location;
        public DateTime dateTime { get; }

        private int cost;
        private int memberDiscount;
        private int accessRequired;

        private FormUI form;

        //The following will be added once the relevant classes have been implemented:
        //private User[] organisers;
        //private User[] creators;
        //private Tag[] tags;

        //Switches form to EventView when pressed
        //Loads EventView with the information contained within this button

        public EventButton(FormUI form, string name, string description, string location, DateTime dateTime, string eventLink, string imageLink, int cost, int memberDiscount, int accessRequired, int index)
        {
            this.form = form;

            this.name = name;
            this.description = description;
            this.location = location;
            this.dateTime = dateTime;
            this.eventLink = eventLink;
            this.imageLink = imageLink;
            this.cost = cost;
            this.memberDiscount = memberDiscount;
            this.accessRequired = accessRequired;

            Text = name;
            TextAlign = ContentAlignment.BottomCenter;
            Size = new System.Drawing.Size(150, 100);
            Cursor = System.Windows.Forms.Cursors.Hand;
            Image = TCC_App.Properties.Resources._event;  //TEMP - should use imageLink to find link to correct image
            BackgroundImageLayout = ImageLayout.Stretch;    //BUG - stretch doesn't seem to be working
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Tag = index;
            Margin = new System.Windows.Forms.Padding(20);

        }


        //Returns an array of strings containing the name, description, and tags
        //TEMP - Does not currently return tags, as they are not yet implemented
        public string[] GetInfoForSearch()
        {
            string[] info = { name, description };
            return info;
        }


        //Loads UI_EventView into Display
        protected override void OnClick(EventArgs e)
        {
            form.SwitchForm(new UI_EventInformation(form, name, description, location, dateTime, eventLink, imageLink, cost, memberDiscount, accessRequired));

            /*OLD IMPLEMENTATION
            Consts.FormEventView.InitializeDetails(name, description, location, dateTime, eventLink, imageLink, cost, memberDiscount, accessRequired);
            Consts.FormEventView.Show();
            Consts.FormEventSearch.Hide();
            */
        }
    }
}
