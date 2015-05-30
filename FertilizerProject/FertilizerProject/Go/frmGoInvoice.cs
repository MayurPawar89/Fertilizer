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
        DataTable _dtInvoiveTable = null;
        private void frmGoInvoice_Load(object sender, EventArgs e)
        {
            LoadBillingInformation();
            LoadCustomers();
            LoadFertItems();
            CreateInvoiceTable();
        }

        private void LoadFertItems()
        {
            DataTable _dt = GetFertItems();
            cmbFertItem.DisplayMember = "sTypeName";
            cmbFertItem.ValueMember = "nTypeID";

            DataRow dr = _dt.NewRow();
            dr["sTypeName"] = "Select";
            _dt.Rows.InsertAt(dr, 0);

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
            txtInvoiceNo.Text = Convert.ToString(GetInvoiceNumber());
            txtUserName.Text = "Mayur";
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
            if (cmbFertItem.SelectedIndex != 0)
            {
                LoadFertilizerByType(Convert.ToInt64(cmbFertItem.SelectedValue));
            }

        }

        private void LoadFertilizerByType(Int64 TypeID)
        {
            DataTable _dt = GetFertilizerByType(TypeID);
            if (_dt != null && _dt.Rows.Count > 0)
            {
                cmbFertilizerList.DisplayMember = "sFName";
                cmbFertilizerList.ValueMember = "nFID";

                DataRow dr = _dt.NewRow();
                dr["sFName"] = "Select";
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
                        txtFertQuantity.Text = Convert.ToString(dr["nQuantity"]);
                        txtFertUnitPrice.Text = Convert.ToString(dr["nPrice"]);
                        txtFertDiscount.Text = Convert.ToString(dr["nDiscount"]);
                    }
                }
            }
        }

        private void btnAddInCart_Click(object sender, EventArgs e)
        {
            decimal _nBasicPrice = 0,_nDiscountAmt=0,_nFinalamt=0;

            _nBasicPrice = Convert.ToDecimal(txtFertQuantity.Text) * Convert.ToDecimal(txtFertUnitPrice.Text);
            _nDiscountAmt = _nBasicPrice * (Convert.ToDecimal(txtFertDiscount.Text) / 100);
            _nFinalamt = _nBasicPrice - _nDiscountAmt;

            DataRow dr = _dtInvoiveTable.NewRow();
           
            dr["FertilizerName"] = txtFertCompany.Text;
            dr["Quantity"] = txtFertDiscount.Text;
            dr["UnitPrice"] = txtFertUnitPrice.Text;
            dr["Discount"] = txtFertDiscount.Text;
            dr["BasicPrice"] = _nBasicPrice;
            dr["Amount"] = _nFinalamt;

            _dtInvoiveTable.Rows.Add(dr);

            dgvInvoiceDetails.DataSource = _dtInvoiveTable;
            

            txtNetAmount.Text =Convert.ToString(_dtInvoiveTable.Compute("SUM(Amount)", ""));
            txtTotalAmount.Text = Convert.ToString(_dtInvoiveTable.Compute("SUM(BasicPrice)", ""));
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

        }
    }
}
