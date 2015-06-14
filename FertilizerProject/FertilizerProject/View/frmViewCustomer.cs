using FertilizerProject.App_Data;
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
    public partial class frmViewCustomer : Form
    {
        public frmViewCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer _customer = null;
            try
            {
                _customer = new Customer();
                _customer.nCustID = Convert.ToInt64(txtCustomerID.Text);
                _customer.sFirstName = txtFirstName.Text.Trim();
                _customer.sLastName = txtLastName.Text.Trim();
                _customer.sAddress = txtAddress.Text.Trim();
                _customer.sCity = txtCity.Text.Trim();
                _customer.sEmail = txtEmail.Text.Trim();
                _customer.sPhoneNo = txtPhoneNo.Text.Trim();
                _customer.dtDOB = Convert.ToDateTime(txtDOB.Text.Trim());
                _customer.InsertUpdateCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
            finally
            {
                if (_customer != null)
                {
                    _customer.Dispose();
                    _customer = null;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
