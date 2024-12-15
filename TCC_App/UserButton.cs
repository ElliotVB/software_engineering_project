using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TCC_App
{
    internal class UserButton : Button
    {
        //Creator: Elliot

        //A button which is associated with a specific user
        //Loaded into UI_UserSearch
        //When pressed, it will load UI_Profile with the information contained in this button

        FormUI form;

        private string foreName;
        private string surName;
        private string email;
        private string phoneNumber;
        private string status;
        private string imageLink;
        private int index;

        public DateTime lastActive { get; }

        public UserButton(FormUI form, string foreName, string surName, string email, string phoneNumber, string status, string imageLink, DateTime lastActive, int index)
        {
            this.form = form;
            this.foreName = foreName;
            this.surName = surName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.status = status;
            this.imageLink = imageLink;
            this.index = index;
            this.lastActive = lastActive;

            Text = $"{foreName} {surName}";
            TextAlign = ContentAlignment.MiddleCenter;
            ForeColor = Color.White;
            Size = new System.Drawing.Size(75, 75);
            Cursor = System.Windows.Forms.Cursors.Hand;
            BackgroundImageLayout = ImageLayout.Stretch;

            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Tag = index;
            Margin = new System.Windows.Forms.Padding(20);


            try
            {
                // Check if imageLink is a valid URL or file path
                if (Uri.IsWellFormedUriString(imageLink, UriKind.Absolute))
                {
                    // Download image from URL
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = webClient.DownloadData(imageLink);
                        using (var stream = new System.IO.MemoryStream(imageData))
                        {
                            BackgroundImage = Image.FromStream(stream);
                        }
                    }
                }
                else if (System.IO.File.Exists(imageLink))
                {
                    // Load image from local file path
                    BackgroundImage = Image.FromFile(imageLink);
                }
                else
                {
                    throw new Exception("Invalid image link or file path.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                BackgroundImage = TCC_App.Properties.Resources.pfpPlaceholder; // Default image on error
            }
        }

        //Returns an array of strings containing the forename and surname of the user
        public string[] GetInfoForSearch()
        {
            string[] info = { foreName, surName };
            return info;
        }

        //Loads UI_Profile into Display
        protected override void OnClick(EventArgs e)
        {
            var userInfo = new Dictionary<string, string>
            {
                { "FullName", $"{foreName} {surName}" },
                { "Email", email },
                { "PhoneNumber", phoneNumber },
                { "Status", status },
                { "ImageLink", imageLink }
            };
            
            
            form.SwitchForm(new UI_Profile(form, userInfo));
        }



    }
}
