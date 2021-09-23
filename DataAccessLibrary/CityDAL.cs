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
    
    public class CityDAL
    {
        private static SqlCommand sqlCommand;
        private static CityDOL.QueryStatus queryStatus;

        public CityDAL(CityDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public CityDAL(CityDOL.QueryStatus QueryStatusField, CityBOL _CityBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_CityBOL);
        }
        public CityBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                CityBOL[] CityBOLs = new CityBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? CityId = DataConvertor.ConvertToShort(row["CITYID"]);
                    string CityTitle = DataConvertor.ConvertToString(row["CITYTITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    CityBOLs[index] = new CityBOL(CityId, CityTitle, Description);
                }
                return CityBOLs;
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
                case CityDOL.QueryStatus.Select:
                    return CityDOL.Select;
                case CityDOL.QueryStatus.SelectComboBox:
                    return CityDOL.SelectComboBox;
                case CityDOL.QueryStatus.Delete:
                    return CityDOL.Delete;
                case CityDOL.QueryStatus.Update:
                    return CityDOL.Update;
                case CityDOL.QueryStatus.Insert:
                    return CityDOL.Insert;
                case CityDOL.QueryStatus.SelectMaxId:
                    return CityDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(CityBOL _CityBOL)
        {
            sqlCommand.Parameters.Add("@CityId", SqlDbType.TinyInt).Value = ValidateParameter("@CityId", _CityBOL.CityId, false);
            sqlCommand.Parameters.Add("@CityTitle", SqlDbType.NVarChar).Value = ValidateParameter("@CityTitle", _CityBOL.CityTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _CityBOL.Description, true);
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
        public CityBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                CityBOL[] CityBOLs = new CityBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? CityId = DataConvertor.ConvertToShort(row["CityID"]);
                    string CityTitle = DataConvertor.ConvertToString(row["CityTITLE"]);
                    CityBOLs[index] = new CityBOL(CityId, CityTitle,null);
                }
                return CityBOLs;
            }
            return null;
        }
    }
}
