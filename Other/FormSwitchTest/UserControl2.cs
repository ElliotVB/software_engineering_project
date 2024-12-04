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
    public partial class UserControl2 : UserControl
    {
        main mainForm;

        //Constructer requires a main object to be passed to it so that main.SwitchForm can be accessed
        public UserControl2(main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        //Switches form when the button is pressed
        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SwitchForm(new UserControl1(mainForm));
        }
    }
}
