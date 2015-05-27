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
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
        }
        public string  fstrServerName = "";
        public string fstrUserName = "";
        public string fstrPassword = "";
        public string fstrMessageboxCaption = "Wrong Information";
        public string fstrDatabasename = "";
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWindows.Checked)
                rdbWindows.Font = new Font("Tahoma", 9, FontStyle.Bold);
            else
                rdbWindows.Font = new Font("Tahoma", 9, FontStyle.Regular);
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSQL.Checked)
                rdbSQL.Font = new Font("Tahoma", 9, FontStyle.Bold);
            else
                rdbSQL.Font = new Font("Tahoma", 9, FontStyle.Regular);
        }

        public string GetConnectionString(string strSQLServerName, string strDatabase, bool isSQLAuthentication, string sUserName, string sPassword)
        {
            string strConnectionString = null;
            if (isSQLAuthentication == false)
            {
                strConnectionString = "SERVER=" + strSQLServerName + ";DATABASE=" + strDatabase + ";Integrated Security=SSPI";
            }
            else
            {
                strConnectionString = "SERVER=" + strSQLServerName + ";DATABASE=" + strDatabase + ";User ID=" + sUserName + ";Password=" + sPassword + "";
            }
            return strConnectionString;
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Connectionstr = "";

                if (txtServerName.Text == "")
                {
                    MessageBox.Show("Please enter Sql Server name", fstrMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtServerName.Focus();
                }
                else
                    if (txtDatabaseName.Text == "")
                    {
                        MessageBox.Show("Please enter Sql Server name", fstrMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDatabaseName.Focus();
                    }
                    else
                        if (txtUserName.Text == "")
                        {
                            MessageBox.Show("Please enter Sql Server name", fstrMessageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtUserName.Focus();
                        }
                if (rdbWindows.Checked == true)
                {
                    fstrServerName = txtServerName.Text.Trim();
                    fstrDatabasename = txtDatabaseName.Text.Trim();
                    fstrUserName = txtUserName.Text.Trim();
                    fstrPassword = txtPassword.Text.Trim();
                    Connectionstr = GetConnectionString(fstrServerName, fstrDatabasename, false, fstrUserName, fstrPassword);

                }
                else
                {
                    fstrServerName = txtServerName.Text.Trim();
                    fstrDatabasename = txtDatabaseName.Text.Trim();
                    fstrUserName = txtUserName.Text.Trim();
                    fstrPassword = txtPassword.Text.Trim();
                    Connectionstr = GetConnectionString(fstrServerName, fstrDatabasename, true, fstrUserName, fstrPassword);

                }
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

    }
}
