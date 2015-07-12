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
using System.IO;
using WebCam_Capture;
using WinFormCharpWebCam;



namespace FertilizerProject
{
    public partial class frmViewCustomer : Form
    {
        public frmViewCustomer()
        {
            InitializeComponent();
        }
        WebCam webcam;
        Int64 i = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer _customer = null;
            try
            {
                _customer = new Customer();
                _customer.nCustID = 0;// Convert.ToInt64(txtCustomerID.Text);
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
                _customer.nCreditBal = Convert.ToInt64(txtCredit.Text);
                _customer.nInterestRate = Convert.ToInt64(txtInterest.Text);
                i = _customer.InsertUpdateCustomer();
                SaveFileDialog s = new SaveFileDialog();

                s.FileName = i.ToString() + "_" + txtFirstName.Text.Trim() + "_" + txtLastName.Text.Trim();// Default file name
                s.DefaultExt = ".Jpg";// Default file extension
                s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

                //System.Drawing.Image image = null;
                // Show save file dialog box
                // Process save file dialog box results
                if (s.ShowDialog() == DialogResult.OK)
                {
                    // Save Image
                    string filename = s.FileName;
                    FileStream fstream = new FileStream(filename, FileMode.Create);

                    //image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                    Bitmap newImg = new Bitmap(bmpImage);
                    bmpImage.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bmpImage.Dispose();
                    bmpImage = null;
                    fstream.Close();

                }
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


        private void frmViewCustomer_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            webcam.Start();
            webcam.Continue();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }


    }
}
