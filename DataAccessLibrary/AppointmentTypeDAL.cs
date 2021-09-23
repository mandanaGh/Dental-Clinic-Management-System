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
    
    public class AppointmentTypeDAL
    {
        private static SqlCommand sqlCommand;
        private static AppointmentTypeDOL.QueryStatus queryStatus;

        public AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus QueryStatusField, AppointmentTypeBOL _AppointmentTypeBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_AppointmentTypeBOL);
        }
        public AppointmentTypeBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                AppointmentTypeBOL[] AppointmentTypeBOLs = new AppointmentTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? AppointmentTypeId = DataConvertor.ConvertToShort(row["APPOINTMENTTYPEID"]);
                    string AppointmentTypeTitle = DataConvertor.ConvertToString(row["APPOINTMENTTYPETITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    AppointmentTypeBOLs[index] = new AppointmentTypeBOL(AppointmentTypeId, AppointmentTypeTitle, Description);
                }
                return AppointmentTypeBOLs;
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
                case AppointmentTypeDOL.QueryStatus.Select:
                    return AppointmentTypeDOL.Select;
                case AppointmentTypeDOL.QueryStatus.SelectComboBox:
                    return AppointmentTypeDOL.SelectComboBox;
                case AppointmentTypeDOL.QueryStatus.Delete:
                    return AppointmentTypeDOL.Delete;
                case AppointmentTypeDOL.QueryStatus.Update:
                    return AppointmentTypeDOL.Update;
                case AppointmentTypeDOL.QueryStatus.Insert:
                    return AppointmentTypeDOL.Insert;
                case AppointmentTypeDOL.QueryStatus.SelectMaxId:
                    return AppointmentTypeDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(AppointmentTypeBOL _AppointmentTypeBOL)
        {
            sqlCommand.Parameters.Add("@AppointmentTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@AppointmentTypeId", _AppointmentTypeBOL.AppointmentTypeId, false);
            sqlCommand.Parameters.Add("@AppointmentTypeTitle", SqlDbType.NVarChar).Value = ValidateParameter("@AppointmentTypeTitle", _AppointmentTypeBOL.AppointmentTypeTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _AppointmentTypeBOL.Description, true);
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
        public AppointmentTypeBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                AppointmentTypeBOL[] AppointmentTypeBOLs = new AppointmentTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? AppointmentTypeId = DataConvertor.ConvertToShort(row["AppointmentTypeID"]);
                    string AppointmentTypeTitle = DataConvertor.ConvertToString(row["AppointmentTypeTITLE"]);
                    AppointmentTypeBOLs[index] = new AppointmentTypeBOL(AppointmentTypeId, AppointmentTypeTitle,null);
                }
                return AppointmentTypeBOLs;
            }
            return null;
        }
    }
}
