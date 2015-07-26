using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FertilizerProject.App_Data;

namespace FertilizerProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim()==""&&txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Please enter username and password!!!");
                return;
            }
            else
            {
                if (txtUserName.Text.Trim()=="")
                {
                    MessageBox.Show("Please enter username!!!");
                    return;
                }
                else if (txtPassword.Text.Trim()=="")
                {
                    MessageBox.Show("Please enter password!!!");
                    return;
                }
            }

            string sUserName = string.Empty;
            string sPassword = string.Empty;
            string sDBUserName = string.Empty;
            string sDBPassword = string.Empty;
            bool bIsValidUser = false;

            sUserName = txtUserName.Text.Trim();
            sPassword = txtPassword.Text.Trim();

            User _user = new User();
            DataTable _dtUserDetails = _user.GetUseratLogin(sUserName);
            if (_dtUserDetails != null && _dtUserDetails.Rows.Count > 0)
            {
                foreach (DataRow drUser in _dtUserDetails.Rows)
                {
                    if (Convert.ToString(drUser["sUserName"]) == sUserName)
                    {
                        sDBPassword = Encryption.DecryptToBase64String(Convert.ToString(drUser["sPassword"]));
                        //change if condition by using decryption method of encryption class
                        if (sDBPassword == sPassword)
                        {
                            EnumClass.sUserName = Convert.ToString(drUser["sUserName"]);
                            bIsValidUser = true;
                        }
                        else
                        {
                            MessageBox.Show("Password not match. Please check and enter again.");
                            bIsValidUser = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Name not match. Please check and enter again.");
                        bIsValidUser = false;
                    }
                }
            }
            if (bIsValidUser)
            {
                Dashboard frmDashboard = new Dashboard();
                this.Hide();
                frmDashboard.Show();
            }
        }
    }
}
