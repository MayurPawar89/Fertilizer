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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                _User.InsertUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
            finally
            {
                if (_User!=null)
                {
                    _User.Dispose();
                    _User = null;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
