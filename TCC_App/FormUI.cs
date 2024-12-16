using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMApplication;
using Microsoft.VisualBasic.ApplicationServices;
namespace TCC_App
{
    //Creator: Elliot

    //Contains display panels which are used to hold UI elements
    //The majority of the UI is loaded into Display, with two exceptions:
        //The login screen is loaded into LoginPanel
        //The navigation bar is loaded into NavigationPanel
    public partial class FormUI : Form
    {
        //Contains information about the user currently logged in
        //Stored here to reduce load times whenever the profile is clicked
        public User user { get; private set; }
        public FormUI()
        {
            InitializeComponent();

            //Loads the login UI
            Display.Controls.Add(new UI_Login(this));
            LoginPanel.Controls.Add(new UI_Login(this));
        }


        //Switches Display to show the form passed to the method
        public void SwitchForm(UserControl form)
        {
            Display.Controls.Clear();
            Display.Controls.Add(form);
        }

        //Initilizes user with information passed to the class (from login)
        //Loads the navigation bar and the main page into their respective panels
        public void LoadMainUI(User user)
        {
            this.user = user;
            Display.Controls.Add(new UI_MainPage(this, user));
            NavigationPanel.Controls.Add(new UI_NavigationBar(this));
        }
    }
}