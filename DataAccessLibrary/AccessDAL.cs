using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using BusinessObjectLayer;
    using System.Data;
    using DataConvertor;

    public class AccessDAL
    {
        private static string getAccessMode = "SELECT ACCESS.ACCESSTITLE FROM (SELECT SECURITY_ROLE.ACCESSID FROM (SELECT SECURITY.ACCESSID, SECURITY.PAGEID FROM SECURITY INNER JOIN ROLE ON SECURITY.ROLEID = ROLE.ROLEID WHERE (SECURITY.ROLEID = @RoleId)) AS SECURITY_ROLE INNER JOIN PAGE ON SECURITY_ROLE.PAGEID = PAGE.PAGEID WHERE (PAGE.PAGETITLE = @PAGETITLE)) AS PAGE_SECURITY_ROLE INNER JOIN ACCESS ON ACCESS.ACCESSID = PAGE_SECURITY_ROLE.ACCESSID";
        private static string selectComboBox = "SELECT ACCESS.ACCESSID,ACCESS.ACCESSNAME AS ACCESSTITLE FROM ACCESS";
        public static AccessMode GetAccessMode(string PageTitle, long RoleId)
        {
            using (SqlConnection connection = new SqlConnection(new ConnectionDAL().GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(getAccessMode, connection))
                {              
                    command.Parameters.Add("@RoleId", SqlDbType.Int).Value = ValidateParameter("@RoleId", RoleId, false);
                    command.Parameters.Add("@PageTitle", SqlDbType.NVarChar).Value = ValidateParameter("@PageTitle", PageTitle, false);
                    command.Connection.Open();
                    string accessTitle = DataConvertor.ConvertToString(command.ExecuteScalar());
                    command.Connection.Close();
                    if (accessTitle == AccessMode.Complete.ToString())
                        return AccessMode.Complete;
                    else if (accessTitle == AccessMode.Read.ToString())
                        return AccessMode.Read;
                    else if (accessTitle == AccessMode.Insert.ToString())
                        return AccessMode.Insert;
                    else
                        return AccessMode.NoAccess;
                }
            }
        }
        public static DataTable SelectComboBox()
        {
            using (SqlConnection connection = new SqlConnection(new ConnectionDAL().GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(selectComboBox, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());
                    connection.Close();
                    return dataTable;                    
                }
            }
            return null;
        }
        private static object ValidateParameter(string ParameterName, object Value, bool IsNullable)
        {
            if (Value == null && !IsNullable)
                throw new ArgumentNullException(ParameterName);
            return (Value == null ? DBNull.Value : Value);
        }
    }
}
