using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject.App_Data
{
    class FertilizerSales
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public FertilizerSales()
        {
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }

        ~FertilizerSales()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"

        #region "Fert_Sales"
        //[nSalesID], [sInvoiceNo], [dtInvoiceDate], [nUserID], [nTypeID], [nFertID], [nCustID], [nPaymentType], [nNetAmount], [nPaidAmount], [nBalanceAmount], [nTotalAmount], [dtCreatedDate], [dtModifiedDate]

        public Int64 nSalesID { get; set; }
        public string sInvoiceNo { get; set; }
        public DateTime dtInvoiceDate { get; set; }
        public Int64 nUserID { get; set; }
        public Int32 nTypeID { get; set; }
        public Int64 nFertID { get; set; }
        public Int64 nCustID { get; set; }
        public Byte byteimage { get; set; }
        public Int32 nPaymentType { get; set; }
        public Decimal nNetAmount { get; set; }
        public Decimal nPaidAmount { get; set; }
        public Decimal nBalanceAmount { get; set; }
        public Decimal nTotalAmount { get; set; }
        #endregion

        #region "Fert_SalesDetails"
        //[nSalesDetailID], [nSalesID], [sInvoiceNo], [dtInvoiceDate], [nUserID], [nCustID], [nTypeID], [nFertID], 
        //[sFertCompany], [nQuntity], [nUnitPrice], [nDiscount], [nAmount]
        public Int64 nSalesDetailID { get; set; }
        public string sFertCompany { get; set; }
        public Decimal nQuntity { get; set; }
        public Decimal nUnitPrice { get; set; }
        public Decimal nDiscount { get; set; }
        public Decimal nAmount { get; set; }
        #endregion

        #endregion

        #region "Methods"
        public Int64 InsertUpdateSales()
        {
            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            Int64 _result = 0;
            object _val = null;
            try
            {
                //[nSalesID], [sInvoiceNo], [dtInvoiceDate], [nUserID], [nTypeID], [nFertID], [nCustID], [nPaymentType], 
                //[nNetAmount], [nPaidAmount], [nBalanceAmount], [nTotalAmount]

                //[nSalesDetailID], [nSalesID], [sInvoiceNo], [dtInvoiceDate], [nUserID], [nCustID], [nTypeID], [nFertID], 
                //[sFertCompany], [nQuntity], [nUnitPrice], [nDiscount], [nAmount]

                _DBParameters = new DBParameters();
                _DataAccess = new DataAccess();

                _DataAccess.OpenConnection(false);

                _DBParameters.clear();
                _DBParameters.Add("@nSalesID", this.nSalesID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                _DBParameters.Add("@sInvoiceNo", this.sInvoiceNo, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@dtInvoiceDate", this.dtInvoiceDate, ParameterDirection.Input, SqlDbType.DateTime);
                _DBParameters.Add("@nUserID", this.nUserID, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@nTypeID", this.nTypeID, ParameterDirection.Input, SqlDbType.Int);
                _DBParameters.Add("@nFertID", this.nFertID, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@nCustID", this.nCustID, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@nPaymentType", this.nPaymentType, ParameterDirection.Input, SqlDbType.Int);
                _DBParameters.Add("@nNetAmount", this.nNetAmount, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nPaidAmount", this.nPaidAmount, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nBalanceAmount", this.nBalanceAmount, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nTotalAmount", this.nTotalAmount, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nSalesDetailID", this.nSalesDetailID, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@sFertCompany", this.sFertCompany, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@nQuntity", this.nQuntity, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nUnitPrice", this.nUnitPrice, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nDiscount", this.nDiscount, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nAmount", this.nAmount, ParameterDirection.Input, SqlDbType.Decimal);
                _DataAccess.Execute("gsp_InsertUpdateSales", _DBParameters, out _val);

                this.nSalesID = (Int64)_val;
                _DataAccess.CloseConnection(false);
                _result = this.nSalesID;
            }
            catch (Exception ex)
            {
                _DataAccess.CloseConnection(false);
                MessageBox.Show("Exception: " + ex.ToString());
            }
            finally
            {
                if (_DBParameters != null)
                {
                    _DBParameters.Dispose();
                    _DBParameters = null;
                }
                if (_DataAccess != null)
                {
                    _DataAccess.Dispose();
                }
            }
            return _result;
        }

        public Int64 GetInvoiceNo()
        {
            Int64 _result = 0;
            
            DataTable _dt = new DataTable();
            DataAccess _DataAccess = new DataAccess();
            try
            {
                _DataAccess.OpenConnection(false);
                _DataAccess.Retrive("gsp_GetInvoiceNo",out _dt);
                if (_dt!=null&&_dt.Rows.Count>0)
                {
                    _result = Convert.ToInt64(_dt.Rows[0][0]);
                }
               
                _DataAccess.CloseConnection(false);
            }
            catch (Exception)
            {
                if (_DataAccess != null) { _DataAccess.RollBack(); _DataAccess.CloseConnection(false); }
            }
            finally
            {
            }
            return _result;
        }
        #endregion
    }
}
