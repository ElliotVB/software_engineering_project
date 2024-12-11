﻿using System;
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

            //This is done in code since the foreColour is used in searchBox_Clicked()
            searchBox.ForeColor = global.DefaultSearchBoxColour;

            GenerateEventsFromDB();
        }


        //Generates a set of events within the event layout
        //Only shows events which contin the searchTerm (which is empty by default, resulting in all events being shown)
        //Currently just generates "dummy" events - will eventually be changed to generate events from the DB
        //NOTE - split this into different functions after DB is implemented
        //NOTE - add some sort of verification for if the current date is before today
        private void GenerateEventsFromDB(string searchTerm = "")
        {
            //Clears events from layout if any exist
            if (eventFlowLayout.Controls.Count > 0)
            {
                eventFlowLayout.Controls.Clear();
            }

            //Stores events taken from the DB
            List<EventButton> events = new List<EventButton>();

            //TEMP - Generates 20 "dummy" events
            //Shoud be replaced with a loop which gets events from DB (if they match search)
            for (int i = 0; i < 20; i++)
            {
                EventButton e = new EventButton(form, "Event no. " + (i + 1), "Example event description.", "TCC building", new DateTime(2025, 1, i + 1, 18, 30, 0), "N/A", "N/A", 5, 3, 0, i);
                //Checking search term + if date has already passed
                if (global.CheckSearchTerm(e.GetInfoForSearch(), searchTerm) && !global.HasDateTimePassed(e.dateTime))
                {
                    events.Add(e);
                }
            }

            DisplayEvents(events);

        }

        //Adds events to the UI in chronological order
        private void DisplayEvents(List<EventButton> events)
        {
            //Iterates through events until all have been added
            while (events.Count > 0)
            {
                //Stores the earliest DateTime within events
                DateTime earliest = DateTime.MaxValue;
                //Stores the index of the earliest events
                int index = 0;

                //Finds the earliest event, and stores its index
                foreach (EventButton e in events)
                {
                    if (e.dateTime < earliest)
                    {
                        earliest = e.dateTime;
                        index = events.IndexOf(e);
                    }
                }

                //Event is removed from the list when added
                eventFlowLayout.Controls.Add(events[index]);
                events.RemoveAt(index);
            }
        }


        //Deletes the default text in the search box the first time it's clicked
        private void searchBox_Clicked(object sender, EventArgs e)
        {
            if (!IsSearchDefaultTextClear())
            {
                searchBox.Text = null;
                searchBox.ForeColor = Color.Black;
            }
        }

        //Updates the events display to only show events which contain the search term in their name, description, or tags
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Only runs search if the default text has been cleared
            if (IsSearchDefaultTextClear())
            {
                GenerateEventsFromDB(searchBox.Text);
            }
        }

        //Returns true if the default text has been cleared, otherwise returns false
        private bool IsSearchDefaultTextClear()
        {
            if (searchBox.ForeColor == global.DefaultSearchBoxColour)
            {
                return false;
            }
            else
            {
                return true;
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
