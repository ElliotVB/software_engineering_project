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
    //Creator: Elliot

    //Contains a single panel called "Display"
    //Different UserControls can be loaded into Display to make them show on the form
    //When loading a form, a reference to this form must be passed to its constructor - this allows it to call SwitchForm
    //VERY IMPORTANT - The constructor for all User Forms must be edited to take a reference to this form, which must be stored in a local "FormUI" variable
        //View "placeholder.cs" for an example of this
    public partial class FormUI : Form
    {
        public FormUI()
        {
            InitializeComponent();

            //Loads a placeholder from into Display - should be replaced with the login screen when that is implemented
            Display.Controls.Add(new placeholder(this));
        }

        //Switches Display to show the form passed to the method
        //An example use of this method is present within "placeholder.cs"
        public void SwitchForm(UserControl form)
        {
            Display.Controls.Clear();
            Display.Controls.Add(form);
        }
    }
}