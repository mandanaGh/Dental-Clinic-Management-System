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
    
    public class LaboratoryDAL
    {
        private static SqlCommand sqlCommand;
        private static LaboratoryDOL.QueryStatus queryStatus;

        public LaboratoryDAL(LaboratoryDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public LaboratoryDAL(LaboratoryDOL.QueryStatus QueryStatusField, LaboratoryBOL _LaboratoryBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_LaboratoryBOL);
        }
        public LaboratoryBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LaboratoryBOL[] LaboratoryBOLs = new LaboratoryBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? LaboratoryId = DataConvertor.ConvertToShort(row["LABORATORYID"]);
                    string LaboratoryTitle = DataConvertor.ConvertToString(row["LABORATORYTITLE"]);
                    string Address = DataConvertor.ConvertToString(row["ADDRESS"]);
                    string Tel = DataConvertor.ConvertToString(row["TEL"]);
                    LaboratoryBOLs[index] = new LaboratoryBOL(LaboratoryId, LaboratoryTitle, Address,Tel);
                }
                return LaboratoryBOLs;
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
                case LaboratoryDOL.QueryStatus.Select:
                    return LaboratoryDOL.Select;
                case LaboratoryDOL.QueryStatus.SelectComboBox:
                    return LaboratoryDOL.SelectComboBox;
                case LaboratoryDOL.QueryStatus.Delete:
                    return LaboratoryDOL.Delete;
                case LaboratoryDOL.QueryStatus.Update:
                    return LaboratoryDOL.Update;
                case LaboratoryDOL.QueryStatus.Insert:
                    return LaboratoryDOL.Insert;
                case LaboratoryDOL.QueryStatus.SelectMaxId:
                    return LaboratoryDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(LaboratoryBOL _LaboratoryBOL)
        {
            sqlCommand.Parameters.Add("@LaboratoryId", SqlDbType.TinyInt).Value = ValidateParameter("@LaboratoryId", _LaboratoryBOL.LaboratoryId, false);
            sqlCommand.Parameters.Add("@LaboratoryTitle", SqlDbType.NVarChar).Value = ValidateParameter("@LaboratoryTitle", _LaboratoryBOL.LaboratoryTitle, true);
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = ValidateParameter("@Address", _LaboratoryBOL.Address, true);
            sqlCommand.Parameters.Add("@Tel", SqlDbType.NChar).Value = ValidateParameter("@Tel", _LaboratoryBOL.Tel, true);
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
        public LaboratoryBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                LaboratoryBOL[] LaboratoryBOLs = new LaboratoryBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? LaboratoryId = DataConvertor.ConvertToShort(row["LaboratoryID"]);
                    string LaboratoryTitle = DataConvertor.ConvertToString(row["LaboratoryTITLE"]);
                    LaboratoryBOLs[index] = new LaboratoryBOL(LaboratoryId, LaboratoryTitle);
                }
                return LaboratoryBOLs;
            }
            return null;
        }
    }
}
