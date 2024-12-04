using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSwitchTest
{
    public partial class main : Form
    {
        //Contains a single panel called "placeholder"
        //Different UserControls can be loaded into placeholder to make them show on the form
        //When loading a form, a reference to this form must be passed to its constructor - this allows it to call SwitchForm
        public main()
        {
            InitializeComponent();

            //Creating a new form and adding it to placeholder
            placeholder.Controls.Add(new UserControl1(this));
        }


        //Clears the current form from placeholder, then adds the form passed to the method
        public void SwitchForm(UserControl form)
        {
            placeholder.Controls.Clear();
            placeholder.Controls.Add(form);
        }


        //IGNORE
        private void main_Load(object sender, EventArgs e)
        {
         
        }
    }
}
