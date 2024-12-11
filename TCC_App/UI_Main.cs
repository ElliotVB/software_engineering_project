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
    public partial class UI_MainPage : UserControl
    {
        FormUI form;

        public UI_MainPage(FormUI form)
        {
            this.form = form;
            InitializeComponent();
        }

    }
}
