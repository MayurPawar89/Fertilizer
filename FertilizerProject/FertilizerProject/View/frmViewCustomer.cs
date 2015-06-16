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
                //nCustID,sFirstName,sLastName,sAddress,sPhoneNo, sTaluka, 
                //sDistrict, sState, nPincode, 
                //sGroup, sCategory, nPhone, sEmailid, sCity, sDob, nOpeningBal, nClosingBal
			//nCreditBal, nInterestRate, dtCreatedate, dtModifieddate
                _customer = new Customer();
                _customer.nCustID = 0;//Convert.ToInt64(txtCustomerID.Text);
                _customer.sFirstName = txtFirstName.Text.Trim();
                _customer.sLastName = txtLastName.Text.Trim();
                _customer.sAddress = txtAddress.Text.Trim();
                _customer.sPhoneNo = txtPhoneNo.Text.Trim();
                _customer.sTaluka = cmb1.Text.Trim();
                _customer.sDistrict = cmb2.Text.Trim();
                _customer.sState = cmb3.Text.Trim();
                _customer.nPincode = Convert.ToInt64(cmb4.Text);
                _customer.sGroup = cmb5.Text.Trim();
                _customer.sCategory = cmb6.Text.Trim();
                _customer.sEmailid = txtEmail.Text.Trim();
                _customer.sCity = txtCity.Text.Trim();
                _customer.dtDOB = Convert.ToDateTime(dob.Text.Trim());
                _customer.nOpeningBal = Convert.ToInt64(txtOpening.Text);
                _customer.nClosingBal = Convert.ToInt64(txtClosing.Text);
                _customer.nInterestRate = Convert.ToInt64(txtInterest.Text);

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

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void customControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
