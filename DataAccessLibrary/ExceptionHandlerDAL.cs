using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
    using DataObjectLayer;
    using ComplexDataType;

    public static class ExceptionHandlerDAL
    {   
        public static DataTable Select(string ExeptionMessage)
        {           
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(new ConnectionDAL().GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(ExceptionHandlerDOL.select, connection))
                {
                    command.Parameters.Add("KEY_VALUES", SqlDbType.VarChar).Value = ValidateParameter("KEY_VALUE",ExeptionMessage,true);
                    command.Connection.Open();
                    result.Load(command.ExecuteReader());
                    command.Connection.Close();
                }
            }
            return result;
        }
        private static object ValidateParameter(string ParameterName, object Value, bool IsNullable)
        {
            if (Value == null && !IsNullable)
                throw new ArgumentNullException(ParameterName);
            return (Value == null ? DBNull.Value : Value);
        }
    }
}