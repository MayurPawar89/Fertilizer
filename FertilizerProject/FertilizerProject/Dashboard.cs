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
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_EditFertilizer_Click(object sender, EventArgs e)
        {
            frmEditFertilizer frm = new frmEditFertilizer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_ViewFertilizer_Click(object sender, EventArgs e)
        {
            frmViewFertilizer frm = new frmViewFertilizer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_ViewUser_Click(object sender, EventArgs e)
        {
            frmViewUsers frm = new frmViewUsers();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_ViewCustomer_Click(object sender, EventArgs e)
        {
            frmViewCustomer frm = new frmViewCustomer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_EditCustomer_Click(object sender, EventArgs e)
        {
            frmEditCustomer frm = new frmEditCustomer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_ToolSetting_ServerSetting_Click(object sender, EventArgs e)
        {
            ServerSettings frm = new ServerSettings();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void TSMI_GoInvoice_Click(object sender, EventArgs e)
        {
            frmGoInvoice frm = new frmGoInvoice();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
