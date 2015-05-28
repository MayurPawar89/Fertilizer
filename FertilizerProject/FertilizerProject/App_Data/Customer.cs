using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject.App_Data
{
    class Customer
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public Customer()
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

        ~Customer()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nCustID { get; set; }

        public string sFirstName { get; set; }

        public string sLastName { get; set; }

        public string sAddress { get; set; }

        public string sPhoneNo { get; set; }

        public string sEmail { get; set; }

        public string sCity { get; set; }

        public DateTime dtDOB { get; set; }
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
                _DBParameters.Add("@nCustID", this.nCustID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                _DBParameters.Add("@sFirstName", this.sFirstName, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sLastName", this.sLastName, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sAddress", this.sAddress, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sPhoneNo", this.sPhoneNo, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sEmail", this.sEmail, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sCity", this.sCity, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@dtDOB", this.dtDOB, ParameterDirection.Input, SqlDbType.DateTime);
                _DataAccess.Execute("gsp_InsertUpdateCustomer", _DBParameters, out _val);

                this.nCustID = (Int64)_val;
                _DataAccess.CloseConnection(false);
                _result = this.nCustID;
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

        public DataTable GetCustomer(Int64 CustID = 0)
        {
            DataTable _dt = null;

            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            try
            {
                _DataAccess.OpenConnection(false);
                _DBParameters.clear();
                _DBParameters.Add("@nCustID", CustID, ParameterDirection.Input, SqlDbType.BigInt);
                _DataAccess.Retrive("gsp_GetCustomer", _DBParameters, out _dt);

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

        public DataTable GetCustomerDetails(Int64 CustID = 0)
        {
            DataTable _dt = null;

            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            try
            {
                _DataAccess.OpenConnection(false);
                _DBParameters.clear();
                _DBParameters.Add("@nCustID", CustID, ParameterDirection.Input, SqlDbType.BigInt);
                _DataAccess.Retrive("gsp_GetCustomerDetails", _DBParameters, out _dt);

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
        #endregion
    }
}
