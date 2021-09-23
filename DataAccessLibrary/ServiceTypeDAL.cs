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

    public class ServiceTypeDAL
    {
        private static SqlCommand sqlCommand;
        private static ServiceTypeDOL.QueryStatus queryStatus;

        public ServiceTypeDAL(ServiceTypeDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ServiceTypeDAL(ServiceTypeDOL.QueryStatus QueryStatusField, ServiceTypeBOL _ServiceTypeBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ServiceTypeBOL);
        }
        public ServiceTypeBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ServiceTypeBOL[] ServiceTypeBOLs = new ServiceTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? ServiceTypeId = DataConvertor.ConvertToShort(row["SERVICETYPEID"]);
                    string ServiceTypeTitle = DataConvertor.ConvertToString(row["SERVICETYPETITLE"]);
                    long? Price = DataConvertor.ConvertToLong(row["PRICE"]);
                    short? Session = DataConvertor.ConvertToShort(row["SESSION"]);
                    string ServieTypeCode = DataConvertor.ConvertToString(row["SERVICETYPECODE"]);
                    short? NextRefrence = DataConvertor.ConvertToShort(row["NEXTREFRENCE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    bool IsLaboratory = DataConvertor.ConvertToBoolean(row["ISLABORATORY"]);                    
                    ServiceTypeBOLs[index] = new ServiceTypeBOL(ServiceTypeId, ServiceTypeTitle,Price,Session,ServieTypeCode,NextRefrence,Description,IsLaboratory);
                }
                return ServiceTypeBOLs;
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
                case ServiceTypeDOL.QueryStatus.Select:
                    return ServiceTypeDOL.Select;
                case ServiceTypeDOL.QueryStatus.SelectComboBox:
                    return ServiceTypeDOL.SelectComboBox;
                case ServiceTypeDOL.QueryStatus.SelectComboBoxByIsLaboratory:
                    return ServiceTypeDOL.SelectComboBoxByIsLaboratory;                
                case ServiceTypeDOL.QueryStatus.Delete:
                    return ServiceTypeDOL.Delete;
                case ServiceTypeDOL.QueryStatus.Update:
                    return ServiceTypeDOL.Update;
                case ServiceTypeDOL.QueryStatus.Insert:
                    return ServiceTypeDOL.Insert;
                case ServiceTypeDOL.QueryStatus.SelectMaxId:
                    return ServiceTypeDOL.SelectMaxId;
                case ServiceTypeDOL.QueryStatus.SelectServiceTypePrice:
                    return ServiceTypeDOL.SelectServiceTypePrice;
            }
            return string.Empty;
        }
        private void SetParameter(ServiceTypeBOL _ServiceTypeBOL)
        {
            sqlCommand.Parameters.Add("@ServiceTypeId", SqlDbType.SmallInt).Value = ValidateParameter("@ServiceTypeId", _ServiceTypeBOL.ServiceTypeId, true);
            sqlCommand.Parameters.Add("@ServiceTypeTitle", SqlDbType.NVarChar).Value = ValidateParameter("@ServiceTypeTitle", _ServiceTypeBOL.ServiceTypeTitle, true);
            sqlCommand.Parameters.Add("@PRICE", SqlDbType.BigInt).Value = ValidateParameter("@PRICE", _ServiceTypeBOL.Price, true);
            sqlCommand.Parameters.Add("@SESSION", SqlDbType.TinyInt).Value = ValidateParameter("@SESSION", _ServiceTypeBOL.Session, true);
            sqlCommand.Parameters.Add("@SERVICETYPECODE", SqlDbType.NVarChar).Value = ValidateParameter("@SERVICETYPECODE", _ServiceTypeBOL.ServiceTypeCode, true);
            sqlCommand.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar).Value = ValidateParameter("@DESCRIPTION", _ServiceTypeBOL.Description, true);            
            sqlCommand.Parameters.Add("@NEXTREFRENCE", SqlDbType.TinyInt).Value = ValidateParameter("@NEXTREFRENCE", _ServiceTypeBOL.NextRefrence, true);
            sqlCommand.Parameters.Add("@ISLABORATORY", SqlDbType.Bit).Value = ValidateParameter("@ISLABORATORY", _ServiceTypeBOL.IsLaboratory, true);            
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
        public ServiceTypeBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ServiceTypeBOL[] ServiceTypeBOLs = new ServiceTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? ServiceTypeId = DataConvertor.ConvertToShort(row["SERVICETYPEID"]);
                    string ServiceTypeTitle = DataConvertor.ConvertToString(row["SERVICETYPETITLE"]);
                    ServiceTypeBOLs[index] = new ServiceTypeBOL(ServiceTypeId, ServiceTypeTitle);
                }
                return ServiceTypeBOLs;
            }
            return null;
        }
        public ServiceTypeBOL[] SelectComboBoxByIsLaboratory()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ServiceTypeBOL[] ServiceTypeBOLs = new ServiceTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? ServiceTypeId = DataConvertor.ConvertToShort(row["SERVICETYPEID"]);
                    string ServiceTypeTitle = DataConvertor.ConvertToString(row["SERVICETYPETITLE"]);
                    ServiceTypeBOLs[index] = new ServiceTypeBOL(ServiceTypeId, ServiceTypeTitle);
                }
                return ServiceTypeBOLs;
            }
            return null;
        }
        public long SelectServiceTypePrice()
        {
            return Convert.ToInt64(ExecuteScalar());
        }
    }
}
