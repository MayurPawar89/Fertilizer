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

namespace FertilizerProject.Edit
{
    public partial class frmEditCustomer : Form
    {
        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer _Customer = null;
            try
            {
                _Customer = new Customer();
                _Customer.nCustID = Convert.ToInt64(txtUserID.Text);
                _Customer.sFirstName = txtFirstName.Text.Trim();
                _Customer.sLastName = txtLastName.Text.Trim();
                _Customer.sAddress = txtAddress.Text.Trim();
                _Customer.sPhoneNo = txtPhoneNo.Text.Trim();
                _Customer.sTaluka = cmb1.Text.Trim();
                _Customer.sDistrict = cmb2.Text.Trim();
                _Customer.sState = cmb3.Text.Trim();
                _Customer.nPincode = Convert.ToInt64(cmb4.Text);
                _Customer.sGroup = cmb5.Text.Trim();
                _Customer.sCategory = cmb6.Text.Trim();
                _Customer.sEmailid = txtEmail.Text.Trim();
                _Customer.sCity = txtCity.Text.Trim();
                _Customer.dtDOB = Convert.ToDateTime(dob.Text.Trim());
                _Customer.nOpeningBal = Convert.ToInt64(txtOpening.Text.Trim());
                _Customer.nClosingBal = Convert.ToInt64(txtClosing.Text.Trim());
                _Customer.nInterestRate = Convert.ToInt64(txtInterest.Text.Trim());
                _Customer.InsertUpdateCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
            finally
            {
                if (_Customer != null)
                {
                    _Customer.Dispose();
                    _Customer = null;
                }
                Callclear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            grpBoxCustomer.Visible = false;
            GetCustomerList();
        }

        private void GetCustomerList()
        {
            Customer _Customer = null;
            DataTable _dt = null;
            try
            {
                _Customer = new Customer();
                _dt = _Customer.GetCustomer();
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    TreeNode RootNode = new TreeNode("_Customer");
                    RootNode.Tag = Convert.ToInt64("0");
                    trvUsers.Nodes.Add(RootNode);
                    foreach (DataRow dr in _dt.Rows)
                    {
                        TreeNode ChildNode = new TreeNode(Convert.ToString(dr["sFirstName"]) + " " + Convert.ToString(dr["sLastName"]));
                        ChildNode.Tag = Convert.ToInt64(dr["nCustID"]);
                        RootNode.Nodes.Add(ChildNode);
                    }
                }
                trvUsers.ExpandAll();
            }
            catch (Exception)
            {
            }
        }

        private void trvUsers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString() != "0")
            {
                ShowSelectedUser(e.Node);
            }
            else
            {
                grpBoxCustomer.Visible = false;
            }
        }
        private void Callclear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            cmb1.Text.Equals("");
            cmb2.Text.Equals("");
            cmb3.Text.Equals("");
            cmb4.Text.Equals("");
            cmb5.Text.Equals("");
            cmb6.Text.Equals("");
            txtEmail.Clear();
            txtCity.Clear();
            dob.Text.Equals("");
            txtOpening.Clear();
            txtClosing.Clear();
            txtCredit.Clear();
            txtInterest.Clear();
        }

        private void ShowSelectedUser(TreeNode treeNode)
        {
            Customer _Customer = null;
            DataTable _dt = null;
            try
            {
                _Customer = new Customer();
                _dt = _Customer.GetCustomer(Convert.ToInt64(treeNode.Tag));
                if (_dt != null && _dt.Rows.Count > 0)
                {
                        txtUserID.Text = _dt.Rows[0]["nCustID"].ToString();
                        txtFirstName.Text = _dt.Rows[0]["sFirstName"].ToString();
                        txtLastName.Text = _dt.Rows[0]["sLastName"].ToString();
                        txtAddress.Text = _dt.Rows[0]["sAddress"].ToString();
                        txtPhoneNo.Text = _dt.Rows[0]["sPhoneNo"].ToString();
                        cmb1.Text = _dt.Rows[0]["sTaluka"].ToString();
                        cmb2.Text = _dt.Rows[0]["sDistrict"].ToString();
                        cmb3.Text = _dt.Rows[0]["sState"].ToString();
                        cmb4.Text = _dt.Rows[0]["nPincode"].ToString();
                        cmb5.Text = _dt.Rows[0]["sGroup"].ToString();
                        cmb6.Text = _dt.Rows[0]["sCategory"].ToString();
                        txtEmail.Text = _dt.Rows[0]["sEmailid"].ToString();
                        txtCity.Text = _dt.Rows[0]["sCity"].ToString();
                        dob.Text = _dt.Rows[0]["sDob"].ToString();
                        txtOpening.Text = _dt.Rows[0]["nOpeningBal"].ToString();
                        txtClosing.Text = _dt.Rows[0]["nClosingBal"].ToString();
                        txtCredit.Text = _dt.Rows[0]["nCreditBal"].ToString();
                        txtInterest.Text = _dt.Rows[0]["nInterestRate"].ToString();

                    
                }
            }
            catch (Exception)
            {
            }


            grpBoxCustomer.Visible = true;
        }
    }
}
