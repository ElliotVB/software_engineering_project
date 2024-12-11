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
        public UI_Profile(FormUI form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void edit_BT_Click(object sender, EventArgs e)
        {
            form.SwitchForm(new UI_Edit_Profile(form));
        }
    }
}
