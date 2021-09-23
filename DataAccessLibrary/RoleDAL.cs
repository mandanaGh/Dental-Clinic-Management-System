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
    
    public class RoleDAL
    {
        private static SqlCommand sqlCommand;
        private static RoleDOL.QueryStatus queryStatus;

        public RoleDAL(RoleDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public RoleDAL(RoleDOL.QueryStatus QueryStatusField, RoleBOL _RoleBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_RoleBOL);
        }
        public RoleBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                RoleBOL[] RoleBOLs = new RoleBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? RoleId = DataConvertor.ConvertToShort(row["ROLEID"]);
                    string RoleTitle = DataConvertor.ConvertToString(row["ROLETITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    RoleBOLs[index] = new RoleBOL(RoleId, RoleTitle, Description);
                }
                return RoleBOLs;
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
        public short SelectMaxId()
        {
            return (short)(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case RoleDOL.QueryStatus.Select:
                    return RoleDOL.Select;
                case RoleDOL.QueryStatus.SelectComboBox:
                    return RoleDOL.SelectComboBox;
                case RoleDOL.QueryStatus.Delete:
                    return RoleDOL.Delete;
                case RoleDOL.QueryStatus.Update:
                    return RoleDOL.Update;
                case RoleDOL.QueryStatus.Insert:
                    return RoleDOL.Insert;
                case RoleDOL.QueryStatus.SelectMaxId:
                    return RoleDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(RoleBOL _RoleBOL)
        {
            sqlCommand.Parameters.Add("@RoleId", SqlDbType.TinyInt).Value = ValidateParameter("@RoleId", _RoleBOL.RoleId, false);
            sqlCommand.Parameters.Add("@RoleTitle", SqlDbType.NVarChar).Value = ValidateParameter("@RoleTitle", _RoleBOL.RoleTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _RoleBOL.Description, true);
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
        public RoleBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                RoleBOL[] RoleBOLs = new RoleBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? RoleId = DataConvertor.ConvertToShort(row["RoleID"]);
                    string RoleTitle = DataConvertor.ConvertToString(row["RoleTITLE"]);
                    RoleBOLs[index] = new RoleBOL(RoleId, RoleTitle,null);
                }
                return RoleBOLs;
            }
            return null;
        }
    }
}
