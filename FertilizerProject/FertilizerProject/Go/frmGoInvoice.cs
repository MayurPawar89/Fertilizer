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
    public partial class frmGoInvoice : Form
    {
        public frmGoInvoice()
        {
            InitializeComponent();
        }

        private void frmGoInvoice_Load(object sender, EventArgs e)
        {
            DataTable _dt=GetCustomers();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "nCustID";

            DataRow dr = _dt.NewRow();
            dr["Name"] = "Select";
            _dt.Rows.InsertAt(dr, 0);

            cmbCustomer.DataSource = _dt;
        }

        private DataTable GetCustomers(Int64 nCustID=0)
        {
            Customer _Customer = null;
            DataTable _dt = null;
            try
            {
                _Customer = new Customer();
                _dt = _Customer.GetCustomerDetails(nCustID);
            }
            catch (Exception)
            {
            }
            return _dt;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex>0)
            {
                DataTable _dtCustomer = GetCustomers(Convert.ToInt64(cmbCustomer.SelectedValue));

                if (_dtCustomer!=null && _dtCustomer.Rows.Count>0)
                {
                    foreach (DataRow dr in _dtCustomer.Rows)
                    {
                        txtCustAddress.Text = dr["sAddress"].ToString();
                        txtCustCity.Text = dr["sCity"].ToString();
                        txtCustPhone.Text = dr["sPhoneNo"].ToString();
                    }
                }
            }
        }
    }
}
