using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using DataObjectLayer;
    using BusinessObjectLayer;
    using DataConvertor;

    public class LaboratoryServiceDAL
    {
        private static SqlCommand sqlCommand;
        private static LaboratoryServiceDOL.QueryStatus queryStatus;

        public LaboratoryServiceDAL(LaboratoryServiceDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LaboratoryServiceDAL(LaboratoryServiceDOL.QueryStatus QueryStatusField, LaboratoryServiceBOL _LaboratoryServiceBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LaboratoryServiceBOL);
        }
        public LaboratoryServiceBOL Select(int _ServiceId)
        {
            sqlCommand.Parameters.Add("@ServiceId", SqlDbType.Int).Value = ValidateParameter("@ServiceId", _ServiceId, false);
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                int index = 0;
                LaboratoryServiceBOL _LaboratoryServiceBOL = new LaboratoryServiceBOL();
                row = table.Rows[index];
                short LaboratoryId = Convert.ToInt16(row["LABORATORYID"]);
                int ServiceId = Convert.ToInt32(row["SERVICEID"]);
                DateTime Date = Convert.ToDateTime(row["DATE"]);
                string Description = Convert.ToString(row["DESCRIPTION"]);
                short LaboratoryStateId = Convert.ToInt16(row["LABORATORYSTATEID"]);
                string Tooth = Convert.ToString(row["TOOTH"]);
                short ToothColorId = Convert.ToInt16(row["TOOTHCOLORID"]);                
                _LaboratoryServiceBOL = new LaboratoryServiceBOL(LaboratoryId, ServiceId, Date, LaboratoryStateId, Tooth, ToothColorId,Description);
                return _LaboratoryServiceBOL;
            }
            return null;
        }        
        public void Insert()
        {
            ExecuteNonQuery();
        }
        public void Delete()
        {
            ExecuteNonQuery();
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case LaboratoryServiceDOL.QueryStatus.Select:
                    return LaboratoryServiceDOL.Select;                
                case LaboratoryServiceDOL.QueryStatus.Delete:
                    return LaboratoryServiceDOL.Delete;
                case LaboratoryServiceDOL.QueryStatus.Insert:
                    return LaboratoryServiceDOL.Insert;
            }
            return string.Empty;
        }
        private void SetParameter(LaboratoryServiceBOL _LaboratoryServiceBOL)
        {
            sqlCommand.Parameters.Add("@LaboratoryId", SqlDbType.TinyInt).Value = ValidateParameter("@LaboratoryeId", _LaboratoryServiceBOL.LaboratoryId, false);
            sqlCommand.Parameters.Add("@ServiceId", SqlDbType.Int).Value = ValidateParameter("@ServiceId", _LaboratoryServiceBOL.ServiceId, false);            
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _LaboratoryServiceBOL.Date, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _LaboratoryServiceBOL.Description, true);
            sqlCommand.Parameters.Add("@Tooth", SqlDbType.NVarChar).Value = ValidateParameter("@Tooth", _LaboratoryServiceBOL.Tooth, true);
            sqlCommand.Parameters.Add("@LaboratoryStateId", SqlDbType.TinyInt).Value = ValidateParameter("@LaboratoryStateId", _LaboratoryServiceBOL.LaboratoryStateId, true);
            sqlCommand.Parameters.Add("@ToothColorId", SqlDbType.TinyInt).Value = ValidateParameter("@ToothColorId", _LaboratoryServiceBOL.ToothColorId, true);
        }
        private void ExecuteNonQuery()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            sqlCommand.ExecuteNonQuery();
            _ConnectionDAL.CloseConnection();
        }
        private object ExecuteScalar()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            object Object = sqlCommand.ExecuteScalar();
            _ConnectionDAL.CloseConnection();
            return Object;
        }
        private static DataTable ExecuteReader()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            _ConnectionDAL.CloseConnection();
            return dataTable;
        }
        private static object ValidateParameter(string ParameterName, object Value, bool IsNullable)
        {
            if (Value == null && !IsNullable)
                throw new ArgumentNullException(ParameterName);
            return (Value == null ? DBNull.Value : Value);
        }
    }
}
