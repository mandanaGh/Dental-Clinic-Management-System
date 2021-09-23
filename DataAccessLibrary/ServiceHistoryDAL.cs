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

    public class ServiceHistoryDAL
    {
        private static SqlCommand sqlCommand;
        private static ServiceHistoryDOL.QueryStatus queryStatus;

        public ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus QueryStatusField, ServiceHistoryBOL _ServiceHistoryBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ServiceHistoryBOL);
        }
        public ServiceHistoryBOL[] Select(int _ServiceId)
        {
            sqlCommand.Parameters.Add("@ServiceId", SqlDbType.Int).Value = ValidateParameter("@ServiceId", _ServiceId, false);
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ServiceHistoryBOL[] ServiceHistoryBOLs = new ServiceHistoryBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int ServiceHistoryId = Convert.ToInt32(row["SERVICEHISTORYID"]);
                    int ServiceId = Convert.ToInt32(row["SERVICEID"]);
                    short DoctorId = Convert.ToInt16(row["DOCTORID"]);
                    string DoctorName= Convert.ToString(string.Format("{0} {1}",row["FIRSTNAME"],row["LASTNAME"]));
                    DateTime Date = Convert.ToDateTime(row["DATE"]);
                    string Description = Convert.ToString(row["DESCRIPTION"]);
                    string Tooth = Convert.ToString(row["TOOTH"]);
                    ServiceHistoryBOLs[index] = new ServiceHistoryBOL(ServiceHistoryId,ServiceId, DoctorId, DoctorName, Date, Tooth, Description);
                }
                return ServiceHistoryBOLs;
            }
            return null;
        }
        public int SelectCount(int _ServiceId)
        {
            sqlCommand.Parameters.Add("@ServiceId", SqlDbType.Int).Value = ValidateParameter("@ServiceId", _ServiceId, false);
            int result = Convert.ToInt32(ExecuteScalar());            
            return result;
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
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case ServiceHistoryDOL.QueryStatus.Select:
                    return ServiceHistoryDOL.Select;
                case ServiceHistoryDOL.QueryStatus.SelectCount:
                    return string.Format(ServiceHistoryDOL.SelectCount,ServiceHistoryDOL.Select);
                case ServiceHistoryDOL.QueryStatus.Delete:
                    return ServiceHistoryDOL.Delete;
                case ServiceHistoryDOL.QueryStatus.Update:
                    return ServiceHistoryDOL.Update;
                case ServiceHistoryDOL.QueryStatus.Insert:
                    return ServiceHistoryDOL.Insert;
            }
            return string.Empty;
        }
        private void SetParameter(ServiceHistoryBOL _ServiceHistoryBOL)
        {
            sqlCommand.Parameters.Add("@ServiceHistoryId", SqlDbType.Int).Value = ValidateParameter("@ServiceHistoryId", _ServiceHistoryBOL.ServiceHistoryId, true);
            sqlCommand.Parameters.Add("@ServiceId", SqlDbType.Int).Value = ValidateParameter("@ServiceId", _ServiceHistoryBOL.ServiceId, true);
            sqlCommand.Parameters.Add("@DoctorId", SqlDbType.TinyInt).Value = ValidateParameter("@DoctorId", _ServiceHistoryBOL.DoctorId, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _ServiceHistoryBOL.Date, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _ServiceHistoryBOL.Description, true);
            sqlCommand.Parameters.Add("@Tooth", SqlDbType.NVarChar).Value = ValidateParameter("@Tooth", _ServiceHistoryBOL.Tooth, true);            
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
    }
}
