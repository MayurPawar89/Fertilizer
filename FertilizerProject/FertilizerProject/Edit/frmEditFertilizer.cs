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
    public partial class frmEditFertilizer : Form
    {
        public frmEditFertilizer()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                _fertilizer.sFertUsage = txtFertilizerUsage.Text.Trim();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditFertilizer_Load(object sender, EventArgs e)
        {
            grpBoxFertilizer.Visible = false;
            GetFertilizerList();
        }

        private void GetFertilizerList()
        {
            Fertilizer _fertilizer = null;
            DataTable _dt = null;
            try
            {
                _fertilizer = new Fertilizer();
                _dt = _fertilizer.GetFertilizer();
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    TreeNode RootNode = new TreeNode("Fertilizer");
                    RootNode.Tag = Convert.ToInt64("0");
                    trvFertilizer.Nodes.Add(RootNode);
                    foreach (DataRow dr in _dt.Rows)
                    {
                        TreeNode ChildNode = new TreeNode(Convert.ToString(dr["sFName"]));
                        ChildNode.Tag = Convert.ToInt64(dr["nfID"]);
                        RootNode.Nodes.Add(ChildNode);
                    }
                }
                trvFertilizer.ExpandAll();
            }
            catch (Exception)
            {
            }
        }

        private void trvFertilizer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString() != "0")
            {
                ShowSelectedUser(e.Node);
            }
            else
            {
                grpBoxFertilizer.Visible = false;
            }
        }

        private void ShowSelectedUser(TreeNode treeNode)
        {
            Fertilizer _fertilizer = null;
            DataTable _dt = null;
            try
            {
                _fertilizer = new Fertilizer();
                _dt = _fertilizer.GetFertilizer(Convert.ToInt64(treeNode.Tag));
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    txtFertilizerID.Text = _dt.Rows[0]["nFID"].ToString();
                    txtFertilizerName.Text = _dt.Rows[0]["sFName"].ToString();
                    txtFertilizerCompanyName.Text = _dt.Rows[0]["sFCompany"].ToString();
                    txtFertilizerQuantity.Text = _dt.Rows[0]["nQuantity"].ToString();
                    txtFertilizerPrice.Text = _dt.Rows[0]["nPrice"].ToString();
                    txtFertilizerUsage.Text = _dt.Rows[0]["sUsage"].ToString();
                    txtFertilizerDiscount.Text = _dt.Rows[0]["nDiscount"].ToString();
                }
            }
            catch (Exception)
            {
            }


            grpBoxFertilizer.Visible = true;
        }
    }
}
