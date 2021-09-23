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
    
    public class SpecialistDAL
    {
        private static SqlCommand sqlCommand;
        private static SpecialistDOL.QueryStatus queryStatus;

        public SpecialistDAL(SpecialistDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public SpecialistDAL(SpecialistDOL.QueryStatus QueryStatusField, SpecialistBOL _SpecialistBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_SpecialistBOL);
        }
        public SpecialistBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                SpecialistBOL[] SpecialistBOLs = new SpecialistBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? SpecialistId = DataConvertor.ConvertToShort(row["SPECIALISTID"]);
                    string SpecialistTitle = DataConvertor.ConvertToString(row["SPECIALISTTITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    SpecialistBOLs[index] = new SpecialistBOL(SpecialistId, SpecialistTitle, Description);
                }
                return SpecialistBOLs;
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
                case SpecialistDOL.QueryStatus.Select:
                    return SpecialistDOL.Select;
                case SpecialistDOL.QueryStatus.SelectComboBox:
                    return SpecialistDOL.SelectComboBox;
                case SpecialistDOL.QueryStatus.Delete:
                    return SpecialistDOL.Delete;
                case SpecialistDOL.QueryStatus.Update:
                    return SpecialistDOL.Update;
                case SpecialistDOL.QueryStatus.Insert:
                    return SpecialistDOL.Insert;
                case SpecialistDOL.QueryStatus.SelectMaxId:
                    return SpecialistDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(SpecialistBOL _SpecialistBOL)
        {
            sqlCommand.Parameters.Add("@SpecialistId", SqlDbType.TinyInt).Value = ValidateParameter("@SpecialistId", _SpecialistBOL.SpecialistId, false);
            sqlCommand.Parameters.Add("@SpecialistTitle", SqlDbType.NVarChar).Value = ValidateParameter("@SpecialistTitle", _SpecialistBOL.SpecialistTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _SpecialistBOL.Description, true);
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
        public SpecialistBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                SpecialistBOL[] SpecialistBOLs = new SpecialistBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? SpecialistId = DataConvertor.ConvertToShort(row["SpecialistID"]);
                    string SpecialistTitle = DataConvertor.ConvertToString(row["SpecialistTITLE"]);
                    SpecialistBOLs[index] = new SpecialistBOL(SpecialistId, SpecialistTitle,null);
                }
                return SpecialistBOLs;
            }
            return null;
        }
    }
}
