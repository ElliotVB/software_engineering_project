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
    //Creators: Aziz (UI), Elliot (Code)
    public partial class UI_Profile : UserControl
    {
        FormUI form;
        Dictionary<string, string> userInfo;
        public UI_Profile(FormUI form, Dictionary<string, string> userInfo)
        {
            InitializeComponent();
            this.form = form;
            this.userInfo = userInfo;

            // Display user information on the UI
            lblHeader.Text = $"{userInfo["FullName"]}";
            lblUserFullName.Text = $"Full Name: {userInfo["FullName"]}";
            lblEmailAddress.Text = $"Email address: {userInfo["Email"]}";
            lblUserPhoneNumber.Text = $"Phone number: {userInfo["PhoneNumber"]}";
            lblSubStatus.Text = $"Subscription status: {userInfo["Status"]}";
            pctProfileImage.ImageLocation = userInfo["ImageLink"];
                      
            this.form = form;
        }
        private void edit_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Edit_Profile(form));
        }
    }
}
