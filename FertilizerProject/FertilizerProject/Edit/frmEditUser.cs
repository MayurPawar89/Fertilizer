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
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            grpBoxUsers.Visible = false;
            GetUsersList();
            //fillTreeView(_lstUsers);
        }

        private void fillTreeView(List<string> _lstUsers)
        {
            trvUsers.Nodes.Clear();

            trvUsers.Nodes.Add("User");
            trvUsers.Nodes[0].Tag = "RootUser";

            foreach (var item in _lstUsers)
            {
                trvUsers.Nodes[0].Nodes.Add(item.ToString());
            }
        }

        private void GetUsersList()
        {
            User _user = null;
            DataTable _dt = null;
            try
            {
                _user = new User();
                _dt = _user.GetUser();
                if (_dt!=null&&_dt.Rows.Count>0)
                {
                    TreeNode RootNode = new TreeNode("Users");
                    RootNode.Tag = Convert.ToInt64("0");
                    trvUsers.Nodes.Add(RootNode);
                    foreach (DataRow dr in _dt.Rows)
                    {
                        TreeNode ChildNode = new TreeNode(Convert.ToString(dr["sFirstName"]) + " " + Convert.ToString(dr["sLastName"]));
                        ChildNode.Tag = Convert.ToInt64(dr["nUserID"]);
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
            if (e.Node.Tag.ToString()!="0")
            {
                ShowSelectedUser(e.Node);
            }
            else
            {
                grpBoxUsers.Visible = false;
            }
            
        }

        private void ShowSelectedUser(TreeNode treeNode)
        {
            User _user = null;
            DataTable _dt = null;
            try
            {
                _user = new User();
                _dt = _user.GetUser(Convert.ToInt64(treeNode.Tag));
                if (_dt!=null&&_dt.Rows.Count>0)
                {
                       txtUserID.Text = _dt.Rows[0]["nUserID"].ToString();
                        txtFirstName.Text = _dt.Rows[0]["sFirstName"].ToString();
                        txtLastName.Text = _dt.Rows[0]["sLastName"].ToString();
                        txtEmail.Text = _dt.Rows[0]["sEmail"].ToString();
                        txtUserName.Text = _dt.Rows[0]["sUserName"].ToString();
                        txtPassword.Text = _dt.Rows[0]["sPassword"].ToString();
                }
            }
            catch (Exception)
            {
            }


            grpBoxUsers.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User _User = null;
            try
            {
                _User = new User();
                _User.nUserID = Convert.ToInt64(txtUserID.Text);
                _User.sFirstName = txtFirstName.Text.Trim();
                _User.sLastName = txtLastName.Text.Trim();
                _User.sEmail = txtEmail.Text.Trim();
                _User.sUserName = txtUserName.Text.Trim();
                _User.sPassword = txtPassword.Text.Trim();
                _User.InsertUpdateUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
            finally
            {
                if (_User != null)
                {
                    _User.Dispose();
                    _User = null;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
