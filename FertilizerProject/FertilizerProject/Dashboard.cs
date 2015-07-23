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
            frmSalesInvoice frm = new frmSalesInvoice();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_VoucherPayment_Click(object sender, EventArgs e)
        {
            frmVoucherPayment frm = new frmVoucherPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_VoucherReceipt_Click(object sender, EventArgs e)
        {
            FrmVoucherReciept frm = new FrmVoucherReciept();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_FileViewUser_Click(object sender, EventArgs e)
        {
            frmEditUser frm = new frmEditUser();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_FileViewItem_Click(object sender, EventArgs e)
        {
            frmEditFertilizer frm = new frmEditFertilizer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_FileViewCustomer_Click(object sender, EventArgs e)
        {
            frmEditCustomer frm = new frmEditCustomer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_FileNewUser_Click(object sender, EventArgs e)
        {
            
            frmViewUsers frm = new frmViewUsers();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void TSMI_FileNewItem_Click(object sender, EventArgs e)
        {
            frmViewFertilizer frm = new frmViewFertilizer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
            
        }

        private void TSMI_FileNewCustomer_Click(object sender, EventArgs e)
        {
            frmViewCustomer frm = new frmViewCustomer();
            frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
            
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
