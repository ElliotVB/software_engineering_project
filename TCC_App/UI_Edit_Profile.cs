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
    public partial class UI_Edit_Profile : UserControl
    {
        FormUI form;

        public UI_Edit_Profile(FormUI form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form.SwitchForm(new UI_Profile(form, userInfo));
        }

        private void edit_BT_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
