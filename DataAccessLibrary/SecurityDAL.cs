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
    
    public class SecurityDAL
    {
        private static SqlCommand sqlCommand;
        private SecurityDOL.QueryStatus queryStatus;

        public SecurityDAL(SecurityDOL.QueryStatus QueryStatusField, SecurityBOL _SecurityBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_SecurityBOL);
        }
        public SecurityBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                SecurityBOL[] SecurityBOLs = new SecurityBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short PageId = Convert.ToInt16(row["PAGEID"]);
                    string PageTitle = DataConvertor.ConvertToString(row["PAGETITLE"]);
                    short AccessId = Convert.ToInt16(row["ACCESSID"]);
                    string AccessTitle = DataConvertor.ConvertToString(row["ACCESSTITLE"]);
                    SecurityBOLs[index] = new SecurityBOL(PageId, PageTitle, AccessId, AccessTitle);
                }
                return SecurityBOLs;
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
                case SecurityDOL.QueryStatus.Select:
                    return SecurityDOL.Select;            
                case SecurityDOL.QueryStatus.Insert:
                    return SecurityDOL.Insert;
                case SecurityDOL.QueryStatus.Delete:
                    return SecurityDOL.Delete;
            }
            return string.Empty;
        }
        private void SetParameter(SecurityBOL _SecurityBOL)
        {
            sqlCommand.Parameters.Add("@RoleId", SqlDbType.TinyInt).Value = ValidateParameter("@RoleId", _SecurityBOL.RoleId, false);
            sqlCommand.Parameters.Add("@PageId", SqlDbType.TinyInt).Value = ValidateParameter("@PageId", _SecurityBOL.PageId, true);
            sqlCommand.Parameters.Add("@AccessId", SqlDbType.TinyInt).Value = ValidateParameter("@AccessId", _SecurityBOL.AccessId, true);
        }
        private void ExecuteNonQuery()
        {
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            sqlCommand.ExecuteNonQuery();
            _ConnectionDAL.CloseConnection();
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
