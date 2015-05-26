using FertilizerProject.App_Data;
using FertilizerProject.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void TSMI_EditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frm = new frmEditUser();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
