using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject.App_Data
{
    class VoucherPayment
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public VoucherPayment()
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

        ~VoucherPayment()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nPaymentID { get; set; }
        public Int64 nManualno { get; set; }

        public string sPaymentDate { get; set; }
        public Int64 nDebitAcc { get; set; }
        public Int64 nAmount { get; set; }
        public string sPaymentMode { get; set; }
        public string sCategory { get; set; }
        public string sDetails { get; set; }
        
         
        #endregion

        #region"Methods"
        public Int64 InsertUpdateCustomer()
        {
            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            Int64 _result = 0;
            object _val = null;
            try
            {
                _DBParameters = new DBParameters();
                _DataAccess = new DataAccess();

                _DataAccess.OpenConnection(false);
               
                _DBParameters.clear();
                _DBParameters.Add("@nPaymentID", this.nPaymentID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                _DBParameters.Add("@nManualno", this.nManualno, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@sPaymentDate", this.sPaymentDate, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@nDebitAcc", this.nDebitAcc, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@nAmount", this.nAmount, ParameterDirection.Input, SqlDbType.BigInt);
                _DBParameters.Add("@sPaymentMode", this.sPaymentMode, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sCategory", this.sCategory, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sDetails", this.sDetails, ParameterDirection.Input, SqlDbType.VarChar);

                _DataAccess.Execute("gsp_InsertUpdatePayment", _DBParameters, out _val);

                this.nPaymentID = (Int64)_val;
                _DataAccess.CloseConnection(false);
                _result = this.nPaymentID;
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

        public DataTable GetPayment(Int64 CustID = 0)
        {
            DataTable _dt = null;

            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            try
            {
                _DataAccess.OpenConnection(false);
                _DBParameters.clear();
                _DBParameters.Add("@nPaymentID", nPaymentID, ParameterDirection.Input, SqlDbType.BigInt);
                _DataAccess.Retrive("gsp_GetPayment", _DBParameters, out _dt);

                _DataAccess.CloseConnection(false);
            }
            catch (Exception)
            {
                if (_DataAccess != null) { _DataAccess.RollBack(); _DataAccess.CloseConnection(false); }
            }
            finally
            {
                if (_DBParameters != null) { _DBParameters.Dispose(); }
            }
            return _dt;
        }

        //public DataTable GetCustomerDetails(Int64 CustID = 0)
        //{
        //    DataTable _dt = null;

        //    DBParameters _DBParameters = new DBParameters();
        //    DataAccess _DataAccess = new DataAccess();
        //    try
        //    {
        //        _DataAccess.OpenConnection(false);
        //        _DBParameters.clear();
        //        _DBParameters.Add("@nCustID", CustID, ParameterDirection.Input, SqlDbType.BigInt);
        //        _DataAccess.Retrive("gsp_GetCustomerDetails", _DBParameters, out _dt);

        //        _DataAccess.CloseConnection(false);
        //    }
        //    catch (Exception)
        //    {
        //        if (_DataAccess != null) { _DataAccess.RollBack(); _DataAccess.CloseConnection(false); }
        //    }
        //    finally
        //    {
        //        if (_DBParameters != null) { _DBParameters.Dispose(); }
        //    }
        //    return _dt;
        //}
        #endregion
    }
}
