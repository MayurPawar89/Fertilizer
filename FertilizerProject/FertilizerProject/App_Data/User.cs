using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FertilizerProject.App_Data
{
    class User
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public User()
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

        ~User()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nUserID { get; set; }

        public string sFirstName { get; set; }

        public string sLastName { get; set; }

        public string sEmail { get; set; }

        public string sPassword { get; set; }

        public string sUserName { get; set; }
        #endregion

        #region"Methods"
        public Int64 InsertUser()
        {
            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            object _val = null;
            try
            {
                _DBParameters = new DBParameters();
                _DataAccess = new DataAccess();

                _DataAccess.OpenConnection(false);

                _DBParameters.clear();
                _DBParameters.Add("@nUserID", this.nUserID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                _DBParameters.Add("@sFirstName", this.sFirstName, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sLastName", this.sLastName, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sEmail", this.sEmail, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sUserName", this.sUserName, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sPassword", this.sPassword, ParameterDirection.Input, SqlDbType.VarChar);
                _DataAccess.Execute("gsp_InsertUpdateUser", _DBParameters, out _val);

                this.nUserID = (Int64)_val;
                _DataAccess.CloseConnection(false);
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
            return this.nUserID;
        }
        #endregion
    }
}
