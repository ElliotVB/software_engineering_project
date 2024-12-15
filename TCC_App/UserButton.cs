﻿using System;
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
        User user;

        public UserButton(FormUI form, User user)
        {
            this.form = form;
            this.user = user;

            Text = user.GetNameAsString();
            TextAlign = ContentAlignment.MiddleCenter;
            ForeColor = Color.White;
            Size = new System.Drawing.Size(75, 75);
            Cursor = System.Windows.Forms.Cursors.Hand;
            BackgroundImageLayout = ImageLayout.Stretch;

            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Margin = new System.Windows.Forms.Padding(20);


            try
            {
                // Check if imageLink is a valid URL or file path
                if (Uri.IsWellFormedUriString(user.imageLink, UriKind.Absolute))
                {
                    // Download image from URL
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = webClient.DownloadData(user.imageLink);
                        using (var stream = new System.IO.MemoryStream(imageData))
                        {
                            BackgroundImage = Image.FromStream(stream);
                        }
                    }
                }
                else if (System.IO.File.Exists(user.imageLink))
                {
                    // Load image from local file path
                    BackgroundImage = Image.FromFile(user.imageLink);
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
            string[] info = { user.foreName, user.surName };
            return info;
        }

        //Returns user.lastActive
        public DateTime GetLastActive()
        {
            return user.lastActive;
        }

        //Loads UI_Profile into Display
        protected override void OnClick(EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form, user));
        }

    }
}