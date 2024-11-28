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
    //Placeholder User Control which the project will load into (until it is eventually replaced with the login screen)
    //Contains buttons which link directly to other User Controls, so that we can navigate the project before the navigation bar has been implemented

    public partial class placeholder : UserControl
    {
        //Stores a reference to FormUI
        //This enables form.SwitchForm to be called from within this class
        FormUI form;


        //Constructor takes a reference to FormUI
        public placeholder(FormUI form)
        {
            InitializeComponent();

            //Storing reference to FormUI
            this.form = form;
        }


        //Example function to show how to use SwitchForm
        //This would just switch the form to a new placeholder - although SwitchForm should be used to switch between different forms
        private void Example()
        {
            form.SwitchForm(new placeholder(form));
        }
    }
}
