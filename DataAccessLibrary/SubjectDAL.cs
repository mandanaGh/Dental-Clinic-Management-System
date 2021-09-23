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
    
    public class SubjectDAL
    {
        private static SqlCommand sqlCommand;
        private static SubjectDOL.QueryStatus queryStatus;

        public SubjectDAL(SubjectDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public SubjectDAL(SubjectDOL.QueryStatus QueryStatusField, SubjectBOL _SubjectBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_SubjectBOL);
        }
        public SubjectBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                SubjectBOL[] SubjectBOLs = new SubjectBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? SubjectId = DataConvertor.ConvertToShort(row["SUBJECTID"]);
                    string SubjectTitle = DataConvertor.ConvertToString(row["SUBJECTTITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    SubjectBOLs[index] = new SubjectBOL(SubjectId, SubjectTitle, Description);
                }
                return SubjectBOLs;
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
                case SubjectDOL.QueryStatus.Select:
                    return SubjectDOL.Select;
                case SubjectDOL.QueryStatus.SelectComboBox:
                    return SubjectDOL.SelectComboBox;
                case SubjectDOL.QueryStatus.Delete:
                    return SubjectDOL.Delete;
                case SubjectDOL.QueryStatus.Update:
                    return SubjectDOL.Update;
                case SubjectDOL.QueryStatus.Insert:
                    return SubjectDOL.Insert;
                case SubjectDOL.QueryStatus.SelectMaxId:
                    return SubjectDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(SubjectBOL _SubjectBOL)
        {
            sqlCommand.Parameters.Add("@SubjectId", SqlDbType.TinyInt).Value = ValidateParameter("@SubjectId", _SubjectBOL.SubjectId, false);
            sqlCommand.Parameters.Add("@SubjectTitle", SqlDbType.NVarChar).Value = ValidateParameter("@SubjectTitle", _SubjectBOL.SubjectTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _SubjectBOL.Description, true);
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
        public SubjectBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                SubjectBOL[] SubjectBOLs = new SubjectBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? SubjectId = DataConvertor.ConvertToShort(row["SubjectID"]);
                    string SubjectTitle = DataConvertor.ConvertToString(row["SubjectTITLE"]);
                    SubjectBOLs[index] = new SubjectBOL(SubjectId, SubjectTitle,null);
                }
                return SubjectBOLs;
            }
            return null;
        }
    }
}
