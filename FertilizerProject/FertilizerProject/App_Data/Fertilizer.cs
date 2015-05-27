using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FertilizerProject.App_Data
{
    class Fertilizer
    {
        #region "Constructor & Distructor"
        private bool disposed = false;
        public Fertilizer()
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

        ~Fertilizer()
        {
            Dispose(false);
        }
        #endregion

        #region "Properties"
        public Int64 nFertID { get; set; }

        public string sFertName { get; set; }

        public string sFertCompany { get; set; }

        public Decimal nQuntity { get; set; }

        public Decimal nUnitPrice { get; set; }

        public string sFertUsage { get; set; }

        public Decimal nDiscount { get; set; }
        #endregion

        #region"Methods"
        public Int64 InsertUpdateFertilizer()
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
                _DBParameters.Add("@nFertID", this.nFertID, ParameterDirection.InputOutput, SqlDbType.BigInt);
                _DBParameters.Add("@sFertName", this.sFertName, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@sFertCompany", this.sFertCompany, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@nQuntity", this.nQuntity, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@nUnitPrice", this.nUnitPrice, ParameterDirection.Input, SqlDbType.Decimal);
                _DBParameters.Add("@sFertUsage", this.sFertUsage, ParameterDirection.Input, SqlDbType.VarChar);
                _DBParameters.Add("@nDiscount", this.nDiscount, ParameterDirection.Input, SqlDbType.Decimal);
                _DataAccess.Execute("gsp_InsertUpdateFertilizer", _DBParameters, out _val);

                this.nFertID = (Int64)_val;
                _DataAccess.CloseConnection(false);
                _result = this.nFertID;
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

        public DataTable GetFertilizer(Int64 FertID = 0)
        {
            DataTable _dt = null;

            DBParameters _DBParameters = new DBParameters();
            DataAccess _DataAccess = new DataAccess();
            try
            {
                _DataAccess.OpenConnection(false);
                _DBParameters.clear();
                _DBParameters.Add("@nFertID", FertID, ParameterDirection.Input, SqlDbType.BigInt);
                _DataAccess.Retrive("gsp_GetFertilizer", _DBParameters, out _dt);

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
