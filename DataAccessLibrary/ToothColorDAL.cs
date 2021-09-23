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
    
    public class ToothColorDAL
    {
        private static SqlCommand sqlCommand;
        private static ToothColorDOL.QueryStatus queryStatus;

        public ToothColorDAL(ToothColorDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ToothColorDAL(ToothColorDOL.QueryStatus QueryStatusField, ToothColorBOL _ToothColorBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ToothColorBOL);
        }
        public ToothColorBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ToothColorBOL[] ToothColorBOLs = new ToothColorBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? ToothColorId = DataConvertor.ConvertToShort(row["TOOTHCOLORID"]);
                    string ToothColorTitle = DataConvertor.ConvertToString(row["TOOTHCOLORTITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    ToothColorBOLs[index] = new ToothColorBOL(ToothColorId, ToothColorTitle, Description);
                }
                return ToothColorBOLs;
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
                case ToothColorDOL.QueryStatus.Select:
                    return ToothColorDOL.Select;
                case ToothColorDOL.QueryStatus.SelectComboBox:
                    return ToothColorDOL.SelectComboBox;
                case ToothColorDOL.QueryStatus.Delete:
                    return ToothColorDOL.Delete;
                case ToothColorDOL.QueryStatus.Update:
                    return ToothColorDOL.Update;
                case ToothColorDOL.QueryStatus.Insert:
                    return ToothColorDOL.Insert;
                case ToothColorDOL.QueryStatus.SelectMaxId:
                    return ToothColorDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(ToothColorBOL _ToothColorBOL)
        {
            sqlCommand.Parameters.Add("@ToothColorId", SqlDbType.TinyInt).Value = ValidateParameter("@ToothColorId", _ToothColorBOL.ToothColorId, false);
            sqlCommand.Parameters.Add("@ToothColorTitle", SqlDbType.NVarChar).Value = ValidateParameter("@ToothColorTitle", _ToothColorBOL.ToothColorTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _ToothColorBOL.Description, true);
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
        public ToothColorBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ToothColorBOL[] ToothColorBOLs = new ToothColorBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? ToothColorId = DataConvertor.ConvertToShort(row["ToothColorID"]);
                    string ToothColorTitle = DataConvertor.ConvertToString(row["ToothColorTITLE"]);
                    ToothColorBOLs[index] = new ToothColorBOL(ToothColorId, ToothColorTitle,null);
                }
                return ToothColorBOLs;
            }
            return null;
        }
    }
}
