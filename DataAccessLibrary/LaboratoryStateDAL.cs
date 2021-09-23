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
    
    public class LaboratoryStateDAL
    {
        private static SqlCommand sqlCommand;
        private static LaboratoryStateDOL.QueryStatus queryStatus;

        public LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus QueryStatusField, LaboratoryStateBOL _LaboratoryStateBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LaboratoryStateBOL);
        }
        public LaboratoryStateBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LaboratoryStateBOL[] LaboratoryStateBOLs = new LaboratoryStateBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? LaboratoryStateId = DataConvertor.ConvertToShort(row["LABORATORYSTATEID"]);
                    string LaboratoryStateTitle = DataConvertor.ConvertToString(row["LABORATORYSTATETITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    LaboratoryStateBOLs[index] = new LaboratoryStateBOL(LaboratoryStateId, LaboratoryStateTitle, Description);
                }
                return LaboratoryStateBOLs;
            }
            return null;
        }
        public void Insert()
        {
            ExecuteNonQuery();
        }
        public void Update()
        {
            ExecuteNonQuery();
        }
        public void Delete()
        {
            ExecuteNonQuery();
        }
        public long? SelectMaxId()
        {
            return DataConvertor.ConvertToLong(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case LaboratoryStateDOL.QueryStatus.Select:
                    return LaboratoryStateDOL.Select;
                case LaboratoryStateDOL.QueryStatus.SelectComboBox:
                    return LaboratoryStateDOL.SelectComboBox;
                case LaboratoryStateDOL.QueryStatus.Delete:
                    return LaboratoryStateDOL.Delete;
                case LaboratoryStateDOL.QueryStatus.Update:
                    return LaboratoryStateDOL.Update;
                case LaboratoryStateDOL.QueryStatus.Insert:
                    return LaboratoryStateDOL.Insert;
                case LaboratoryStateDOL.QueryStatus.SelectMaxId:
                    return LaboratoryStateDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(LaboratoryStateBOL _LaboratoryStateBOL)
        {
            sqlCommand.Parameters.Add("@LaboratoryStateId", SqlDbType.TinyInt).Value = ValidateParameter("@LaboratoryStateId", _LaboratoryStateBOL.LaboratoryStateId, false);
            sqlCommand.Parameters.Add("@LaboratoryStateTitle", SqlDbType.NVarChar).Value = ValidateParameter("@LaboratoryStateTitle", _LaboratoryStateBOL.LaboratoryStateTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _LaboratoryStateBOL.Description, true);
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
        public LaboratoryStateBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LaboratoryStateBOL[] LaboratoryStateBOLs = new LaboratoryStateBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? LaboratoryStateId = DataConvertor.ConvertToShort(row["LaboratoryStateID"]);
                    string LaboratoryStateTitle = DataConvertor.ConvertToString(row["LaboratoryStateTITLE"]);
                    LaboratoryStateBOLs[index] = new LaboratoryStateBOL(LaboratoryStateId, LaboratoryStateTitle,null);
                }
                return LaboratoryStateBOLs;
            }
            return null;
        }
    }
}
