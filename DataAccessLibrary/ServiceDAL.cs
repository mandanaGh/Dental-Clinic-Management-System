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

    public class ServiceDAL
    {
        private static SqlCommand sqlCommand;
        private static ServiceDOL.QueryStatus queryStatus;

        public ServiceDAL(ServiceDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ServiceDAL(ServiceDOL.QueryStatus QueryStatusField, ServiceBOL _ServiceBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ServiceBOL);
        }
        public ServiceBOL[] Select(int _PatientId)
        {
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _PatientId, false);
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ServiceBOL[] ServiceBOLs = new ServiceBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int ServiceId = Convert.ToInt32(row["SERVICEID"]);
                    short ServiceTypeId = Convert.ToInt16(row["SERVICETYPEID"]);
                    string ServiceTypeTitle = DataConvertor.ConvertToString(row["SERVICETYPETITLE"]);
                    bool IsLoaboratory= Convert.ToBoolean(row["ISLABORATORY"]);
                    int PatientId = Convert.ToInt32(row["PATIENTID"]);
                    bool IsFinished = Convert.ToBoolean(row["ISFINISHED"]);
                    DateTime Date = Convert.ToDateTime(row["DATE"]);                    
                    decimal Discount = Convert.ToDecimal(row["DISCOUNT"]);
                    long Price = Convert.ToInt64(row["PRICE"]);
                    ServiceBOLs[index] = new ServiceBOL(ServiceId, PatientId, ServiceTypeId, ServiceTypeTitle,IsLoaboratory, IsFinished, Discount, Date,Price);
                }
                return ServiceBOLs;
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
                case ServiceDOL.QueryStatus.Select:
                    return ServiceDOL.Select;
                case ServiceDOL.QueryStatus.Delete:
                    return ServiceDOL.Delete;
                case ServiceDOL.QueryStatus.Update:
                    return ServiceDOL.Update;
                case ServiceDOL.QueryStatus.Insert:
                    return ServiceDOL.Insert;
                case ServiceDOL.QueryStatus.SelectMaxId:
                    return ServiceDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(ServiceBOL _ServiceBOL)
        {
            sqlCommand.Parameters.Add("@ServiceId", SqlDbType.Int).Value = ValidateParameter("@ServiceId", _ServiceBOL.ServiceId, true);
            sqlCommand.Parameters.Add("@ServiceTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@ServiceTypeId", _ServiceBOL.ServiceTypeId, true);
            sqlCommand.Parameters.Add("@ServiceTitle", SqlDbType.NVarChar).Value = ValidateParameter("@ServiceTitle", _ServiceBOL.ServiceTypeTitle, true);            
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _ServiceBOL.PatientId, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _ServiceBOL.Date, true);
            sqlCommand.Parameters.Add("@Discount", SqlDbType.Decimal).Value = ValidateParameter("@Discount", _ServiceBOL.Discount, true);
            sqlCommand.Parameters.Add("@IsFinished", SqlDbType.Bit).Value = ValidateParameter("@IsFinished", _ServiceBOL.IsFinished, true);
            sqlCommand.Parameters.Add("@Price", SqlDbType.BigInt).Value = ValidateParameter("@Price", _ServiceBOL.Price, true);
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
