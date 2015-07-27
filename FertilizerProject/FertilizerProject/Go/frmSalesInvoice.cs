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
using WebCam_Capture;
using WinFormCharpWebCam;
using System.IO;

namespace FertilizerProject
{
    public partial class frmSalesInvoice : Form
    {
        public frmSalesInvoice()
        {
            InitializeComponent();
        }
        DataTable _dtInvoiveTable = null;
        WebCam webcam;
        Int64 i = 0;
        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            LoadBillingInformation();
            LoadCustomers();
            LoadFertItems();
            CreateInvoiceTable();
            label22.Enabled = false;
            textBox1.Enabled = false;
        }

        private void LoadFertItems()
        {
            DataTable _dt = GetFertItems();
            cmbFertItem.DisplayMember = "sTypeName";
            cmbFertItem.ValueMember = "nTypeID";

            //DataRow dr = _dt.NewRow();
            //dr["sTypeName"] = "Select";
            //dr["nTypeID"] = "0";
            //_dt.Rows.InsertAt(dr, 0);

            cmbFertItem.DataSource = _dt;
        }

        private DataTable GetFertItems(Int64 nTypeID = 0)
        {
            Fertilizer _Fertilizer = null;
            DataTable _dt = null;
            try
            {
                _Fertilizer = new Fertilizer();
                _dt = _Fertilizer.GetItemList(nTypeID);
            }
            catch (Exception)
            {
            }
            return _dt;
        }

        private void LoadBillingInformation()
        {
            lblInvoiceNo.Text = Convert.ToString(GetInvoiceNumber());
            lblUserName.Text = "Andrew";
            //dtpInvoiceDate.Text = System.DateTime.Now.Date;
        }

        private Int64 GetInvoiceNumber()
        {
            FertilizerSales _FertilizerSales = null;
            Int64 nIno = 0;
            try
            {
                _FertilizerSales = new FertilizerSales();
                nIno = _FertilizerSales.GetInvoiceNo();
            }
            catch (Exception)
            {
            }
            return nIno;
        }

        private void LoadCustomers()
        {
            DataTable _dt = GetCustomers();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "nCustID";

            DataRow dr = _dt.NewRow();
            dr["Name"] = "Select";
            _dt.Rows.InsertAt(dr, 0);

            cmbCustomer.DataSource = _dt;
        }

        private DataTable GetCustomers(Int64 nCustID = 0)
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
            if (cmbCustomer.SelectedIndex > 0)
            {
                DataTable _dtCustomer = GetCustomers(Convert.ToInt64(cmbCustomer.SelectedValue));

                if (_dtCustomer != null && _dtCustomer.Rows.Count > 0)
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

        private void cmbFertItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 _nTypeID = 0;
            if (cmbFertItem.Text == "All")
                _nTypeID = 0;
            else
                _nTypeID = Convert.ToInt64(cmbFertItem.SelectedValue);

            LoadFertilizerByType(_nTypeID);
        }

        private void LoadFertilizerByType(Int64 TypeID)
        {
            DataTable _dt = GetFertilizerByType(TypeID);
            if (cmbFertilizerList.DataSource == null)
                cmbFertilizerList.Items.Clear();// = null;
            if (_dt != null && _dt.Rows.Count > 0)
            {
                cmbFertilizerList.DisplayMember = "sFName";
                cmbFertilizerList.ValueMember = "nFID";

                DataRow dr = _dt.NewRow();
                dr["sFName"] = "Select";
                _dt.Rows.InsertAt(dr, 0);

                cmbFertilizerList.DataSource = _dt;
            }
            else
            {
                cmbFertilizerList.DisplayMember = "sFName";
                cmbFertilizerList.ValueMember = "nFID";

                DataRow dr = _dt.NewRow();
                dr["sFName"] = "Select";
                dr["nFID"] = "-1";
                _dt.Rows.InsertAt(dr, 0);

                cmbFertilizerList.DataSource = _dt;
            }
        }

        private DataTable GetFertilizer(long FertID)
        {
            Fertilizer _Fertilizer = null;
            DataTable _dt = null;
            try
            {
                _Fertilizer = new Fertilizer();
                _dt = _Fertilizer.GetFertilizer(FertID);
            }
            catch (Exception)
            {
            }
            return _dt;
        }

        private DataTable GetFertilizerByType(Int64 nTypeID)
        {
            Fertilizer _Fertilizer = null;
            DataTable _dt = null;
            try
            {
                _Fertilizer = new Fertilizer();
                _dt = _Fertilizer.GetFertilizerByType(nTypeID);
            }
            catch (Exception)
            {
            }
            return _dt;
        }

        private void cmbFertilizerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFertilizerList.SelectedIndex > 0)
            {
                DataTable _dtFertilizer = GetFertilizer(Convert.ToInt64(cmbFertilizerList.SelectedValue));

                if (_dtFertilizer != null && _dtFertilizer.Rows.Count > 0)
                {
                    foreach (DataRow dr in _dtFertilizer.Rows)
                    {
                        txtFertCompany.Text = Convert.ToString(dr["sFCompany"]);
                        txtFertAvailableQuntity.Text = Convert.ToString(dr["nQuantity"]);
                        txtFertUnitPrice.Text = Convert.ToString(dr["nPrice"]);
                        txtFertDiscount.Text = Convert.ToString(dr["nDiscount"]);
                    }
                }
            }
        }

        private void btnAddInCart_Click(object sender, EventArgs e)
        {
            if (!ValidateControl(false))
            {
                return;
            }

            DataRow dr = _dtInvoiveTable.NewRow();
           
            dr["FertilizerName"] = txtFertCompany.Text;
            dr["Quantity"] = txtFertQuantity.Text;
            dr["UnitPrice"] = txtFertUnitPrice.Text;
            dr["Discount"] = txtFertDiscount.Text;
            dr["BasicPrice"] = txtFertAmount.Text;
            dr["Amount"] = txtFertDiscountAmount.Text;

            _dtInvoiveTable.Rows.Add(dr);

            dgvInvoiceDetails.DataSource = _dtInvoiveTable;

            txtNetAmount.Text =Convert.ToString(_dtInvoiveTable.Compute("SUM(Amount)", ""));
            txtTotalAmount.Text = Convert.ToString(_dtInvoiveTable.Compute("SUM(BasicPrice)", ""));
            txtFertAvailableQuntity.Text = Convert.ToString(Convert.ToDecimal(txtFertAvailableQuntity.Text) - Convert.ToDecimal(txtFertQuantity.Text));
           
        }

        private void CreateInvoiceTable()
        {
            _dtInvoiveTable = new DataTable();
            _dtInvoiveTable.Columns.Add("Sr.No", typeof(System.Int16));
            _dtInvoiveTable.Columns["Sr.No"].AutoIncrement = true;
            _dtInvoiveTable.Columns["Sr.No"].AutoIncrementSeed = 1;
            _dtInvoiveTable.Columns["Sr.No"].AutoIncrementStep = 1;
            
            _dtInvoiveTable.Columns.Add("FertilizerName", typeof(System.String));
            _dtInvoiveTable.Columns.Add("Quantity", typeof(System.Decimal));
            _dtInvoiveTable.Columns.Add("UnitPrice", typeof(System.Decimal));
            _dtInvoiveTable.Columns.Add("Discount", typeof(System.Decimal));
            _dtInvoiveTable.Columns.Add("BasicPrice", typeof(System.Decimal));
            _dtInvoiveTable.Columns.Add("Amount", typeof(System.Decimal));

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFertilizerControl();
        }

        private void ClearFertilizerControl()
        {
            cmbFertItem.SelectedIndex = 0;
            cmbFertilizerList.SelectedIndex = -1;
            txtFertCompany.Clear();
            txtFertAvailableQuntity.Clear();
            txtFertUnitPrice.Clear();
            txtFertDiscount.Clear();
            txtFertQuantity.Clear();
            txtFertAmount.Clear();
            txtFertDiscountAmount.Clear();
        }

        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            if (!ValidateControl(true))
            {
                return;
            }
            int nPaymentType = 0;
            if (rdbCredit.Checked)
                nPaymentType = Convert.ToInt32(EnumClass.PaymentMode.credit);
            else if (rdbCash.Checked)
                nPaymentType = Convert.ToInt32(EnumClass.PaymentMode.cash);
            else if (rdbCheque.Checked)
                nPaymentType = Convert.ToInt32(EnumClass.PaymentMode.cheque);
            

            FertilizerSales _Sales = new FertilizerSales();
            _Sales.nSalesID = 0;
            _Sales.sInvoiceNo = lblInvoiceNo.Text;
            _Sales.dtInvoiceDate = Convert.ToDateTime(dtpInvoiceDate.Text);
            _Sales.nUserID = 106173476718006097;
            _Sales.nTypeID = Convert.ToInt32(cmbFertItem.SelectedValue);
            _Sales.nFertID = Convert.ToInt64(cmbFertilizerList.SelectedValue);
            _Sales.nCustID = Convert.ToInt64(cmbCustomer.SelectedValue);
            _Sales.byteimage = 0;
            _Sales.nPaymentType = nPaymentType;
            _Sales.nNetAmount = Convert.ToDecimal(txtNetAmount.Text);
            _Sales.nPaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
            _Sales.nBalanceAmount = Convert.ToDecimal(txtBalanceAmount.Text);
            _Sales.nTotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            _Sales.nSalesDetailID = 0;
            _Sales.sFertCompany = txtFertCompany.Text;
            _Sales.nQuntity = Convert.ToDecimal(txtFertQuantity.Text);
            _Sales.nUnitPrice = Convert.ToDecimal(txtFertUnitPrice.Text);
            _Sales.nDiscount = Convert.ToDecimal(txtFertDiscount.Text);
            _Sales.nAmount = Convert.ToDecimal(txtFertAmount.Text);
            i=_Sales.InsertUpdateSales();

            Fertilizer _Fertilizer = new Fertilizer();
            _Fertilizer.nFertID = Convert.ToInt64(cmbFertilizerList.SelectedValue);
            _Fertilizer.nQuntity = Convert.ToDecimal(txtFertAvailableQuntity.Text);
            _Fertilizer.UpdateFertilizerAfterSales();
            if (radioButton3.Checked == true)
            {

                SaveFileDialog s = new SaveFileDialog();
                s.FileName = i.ToString() + "_" + cmbCustomer.Text.Trim() + "_";// Default file name
                s.DefaultExt = ".Jpg";// Default file extension
                s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension
                if (s.ShowDialog() == DialogResult.OK)
                {
                    string filename = s.FileName;
                    FileStream fstream = new FileStream(filename, FileMode.Create);
                    Bitmap bmpImage = new Bitmap(picPhoto.Image);
                    Bitmap newImg = new Bitmap(bmpImage);
                    bmpImage.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bmpImage.Dispose();
                    bmpImage = null;
                    fstream.Close();

                }

            }
            else if (radioButton2.Checked == true)
            {
                SaveFileDialog s = new SaveFileDialog();

                s.FileName = i.ToString() + "_" + textBox1.Text.Trim();
                s.DefaultExt = ".Jpg";// Default file extension
                s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension
                if (s.ShowDialog() == DialogResult.OK)
                {
                    
                    string filename = s.FileName;
                    FileStream fstream = new FileStream(filename, FileMode.Create);
                    Bitmap bmpImage = new Bitmap(picPhoto.Image);
                    Bitmap newImg = new Bitmap(bmpImage);
                    bmpImage.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bmpImage.Dispose();
                    bmpImage = null;
                    fstream.Close();

                }

            }
        }

        private bool ValidateControl(bool _bIsFromSave)
        {
            bool _result = true;

            if (cmbCustomer.Text == "Select" && _bIsFromSave)
            {
                MessageBox.Show("Select customer for invoice", EnumClass.sShopName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCustomer.Focus();
                _result = false;
            }
            else if (cmbFertItem.Text == "None")
            {
                MessageBox.Show("Select item type for invoice", EnumClass.sShopName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbFertItem.Focus();
                _result = false;
            }
            else if (cmbFertilizerList.Text == "Select" || cmbFertilizerList.Text == "")
            {
                MessageBox.Show("Select item for invoice", EnumClass.sShopName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbFertilizerList.Focus();
                _result = false;
            }
            else if (txtFertQuantity.Text == "")
            {
                MessageBox.Show("Enter quantity for invoice", EnumClass.sShopName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFertQuantity.Focus();
                _result = false;
            }
            else if (dgvInvoiceDetails.Rows.Count == 0 && _bIsFromSave)
            {
                MessageBox.Show("There is no record to save.\nPlease add an item.", EnumClass.sShopName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFertQuantity.Focus();
                _result = false;
            }
            return _result;
        }

        private void txtFertQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtFertQuantity.Text.Trim()!="")
            {
                decimal _nBasicPrice = 0, _nDiscountAmt = 0, _nFinalamt = 0;

                _nBasicPrice = Convert.ToDecimal(txtFertQuantity.Text) * Convert.ToDecimal(txtFertUnitPrice.Text);
                _nDiscountAmt = _nBasicPrice * (Convert.ToDecimal(txtFertDiscount.Text) / 100);
                _nFinalamt = _nBasicPrice - _nDiscountAmt;

                txtFertAmount.Text = string.Format("{0:0.00}", _nFinalamt);
                txtFertDiscountAmount.Text = string.Format("{0:0.00}", _nDiscountAmt);
            }
            else
            {
                txtFertAmount.Text = "0.00";
                txtFertDiscountAmount.Text = "0.00";
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtNetAmount.Text.Trim()!=""&&txtTotalAmount.Text.Trim()!="")
            {
                decimal _nBalanceAmt = 0;
                if (txtPaidAmount.Text!="")
                {
                    _nBalanceAmt = Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtPaidAmount.Text);
                }
                
                txtBalanceAmount.Text = string.Format("{0:0.00}", _nBalanceAmt);
            }
        }

        private void btnInvoiceClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInvoicePrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality is under precess.....");
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref picPhoto);
            webcam.Start();
            webcam.Continue();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            webcam.Stop();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label22.Enabled = false;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                label22.Enabled = true;
                textBox1.Enabled = true;
            }
        }
    }
}
