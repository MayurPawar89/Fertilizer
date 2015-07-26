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
    public partial class frmViewFertilizer : Form
    {
        public frmViewFertilizer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Fertilizer _fertilizer = null;
            try
            {
                _fertilizer = new Fertilizer();
                _fertilizer.nFertID = Convert.ToInt64(txtFertilizerID.Text);
                _fertilizer.sFertName = txtFertilizerName.Text.Trim();
                _fertilizer.sFertCompany = txtFertilizerCompanyName.Text.Trim();
                _fertilizer.nQuntity = Convert.ToDecimal(txtFertilizerQuantity.Text.Trim());
                _fertilizer.nUnitPrice = Convert.ToDecimal(txtFertilizerPrice.Text.Trim());
                //_fertilizer.sFertUsage = txtFertilizerUsage.Text.Trim();
                _fertilizer.nTypeID = Convert.ToInt32(cmbFertilizerItem.SelectedValue);
                _fertilizer.nDiscount = Convert.ToDecimal(txtFertilizerDiscount.Text.Trim());
                _fertilizer.InsertUpdateFertilizer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
            finally
            {
                if (_fertilizer != null)
                {
                    _fertilizer.Dispose();
                    _fertilizer = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
