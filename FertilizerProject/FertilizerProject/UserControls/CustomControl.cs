using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject
{
    public delegate void CloseHostFormEventHandler(Object sender, EventArgs e);
    public partial class CustomControl : UserControl
    {
        public event CloseHostFormEventHandler CloseFormEvent;
        public CustomControl()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            EventArgs myargs = new EventArgs();
             CloseFormEvent(this, myargs);
        }

       
    }
}
