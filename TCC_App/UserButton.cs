using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string imageLink;

        private int index;

        public DateTime lastActive { get; }

        public UserButton(FormUI form, string foreName, string surName, string imageLink, DateTime lastActive, int index)
        {
            this.form = form;

            this.foreName = foreName;
            this.surName = surName;
            this.imageLink = imageLink;
            this.index = index;
            this.lastActive = lastActive;

            Text = $"{foreName} {surName}";
            TextAlign = ContentAlignment.MiddleCenter;
            ForeColor = Color.LightBlue;
            Size = new System.Drawing.Size(75, 75);
            Cursor = System.Windows.Forms.Cursors.Hand;
            BackgroundImage = TCC_App.Properties.Resources.pfpPlaceholder;  //TEMP - should use imageLink to find link to correct image
            BackgroundImageLayout = ImageLayout.Stretch;    //BUG - stretch doesn't seem to be working

            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Tag = index;
            Margin = new System.Windows.Forms.Padding(20);
        }

        //Returns an array of strings containing the name, forename, and stuff from profile
        //TEMP - stuff from profile not working cos user is not implemeneted
        public string[] GetInfoForSearch()
        {
            string[] info = { foreName, surName };
            return info;
        }

        //Loads UI_Profile into Display
        //TEMP - just loads the form, doesn't actually pass any info (as it isnt designed to take any)
        protected override void OnClick(EventArgs e)
        {
            form.SwitchForm(new UI_Profile(form));
        }


    }
}
