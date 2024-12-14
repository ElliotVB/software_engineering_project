using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace TCC_App
{
    // Creator: Elliot

    // Displays detailed information about a specific event, as well as a button which links to the booking page
    // Accessed through pressing an event button on the event search page
    public partial class UI_EventInformation : UserControl
    {
        private FormUI form;
        Dictionary<string, string> eventInfo;

        public UI_EventInformation(FormUI form, Dictionary<string, string> eventInfo)
        {
            InitializeComponent();
            this.form = form;
            this.eventInfo = eventInfo;

            pctEventImage.BackgroundImage = TCC_App.Properties.Resources._event; 
            EventName.Text = $"{eventInfo["EventName"]}";
            EventDescription.Text = $"{eventInfo["EventDesc"]}";
            EventLocation.Text = $"{eventInfo["Location"]}";
            EventDateTime.Text = $"{eventInfo["DateTime"].ToString()}";

            // Placeholder for Price, needs to be discussed with client
            EventPrice.Text = $"{eventInfo["EventLink"]}";

            // Fix for loading image from ImageLink
            try
            {
                // Check if the ImageLink is a URL or file path
                if (Uri.IsWellFormedUriString(eventInfo["ImageLink"], UriKind.Absolute))
                {
                    // If it's a URL, download the image
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = webClient.DownloadData(eventInfo["ImageLink"]);
                        using (var stream = new System.IO.MemoryStream(imageData))
                        {
                            pctEventImage.BackgroundImage = Image.FromStream(stream);
                        }
                    }
                }
                else
                {
                    // If it's a file path, load the image
                    pctEventImage.BackgroundImage = Image.FromFile(eventInfo["ImageLink"]);
                }
            }
            catch (Exception ex)
            {
                // Handle error (e.g., invalid path or URL)
                Console.WriteLine($"Error loading image: {ex.Message}");
                pctEventImage.BackgroundImage = TCC_App.Properties.Resources._event; // Set default image in case of error
            }
        }

        // Returns the event cost as a string
        // TEMP: currently ignores discount, as User isn't implemented
        private string GetCostAsString(int cost, int discount)
        {
            return "Entry cost: £" + cost + ".00";
        }

        // TEMP - switches form to placeholder
        private void buttonHome_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new placeholder(form));
        }

        private void EventInfoLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Book_Click(object sender, EventArgs e)
        {
        }
    }
}
