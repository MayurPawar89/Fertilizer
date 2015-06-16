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
                _Customer.sEmailid  = txtEmail.Text.Trim();
                _Customer.sAddress = txtAddress.Text.Trim();
                _Customer.sPhoneNo = txtPhoneNo.Text.Trim();
                _Customer.sCity = txtCity.Text.Trim();
                _Customer.dtDOB = Convert.ToDateTime(txtDOB.Text.Trim());
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
                        txtEmail.Text = _dt.Rows[0]["sEmail"].ToString();
                        txtAddress.Text = _dt.Rows[0]["sAddress"].ToString();
                        txtPhoneNo.Text = _dt.Rows[0]["sPhoneNo"].ToString();
                        txtCity.Text = _dt.Rows[0]["sCity"].ToString();
                        txtDOB.Text = _dt.Rows[0]["dtDOB"].ToString();
                    
                }
            }
            catch (Exception)
            {
            }


            grpBoxCustomer.Visible = true;
        }
    }
}
