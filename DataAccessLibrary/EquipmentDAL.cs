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

    public class EquipmentDAL
    {
        private static SqlCommand sqlCommand;
        private static EquipmentDOL.QueryStatus queryStatus;

        public EquipmentDAL(EquipmentDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public EquipmentDAL(EquipmentDOL.QueryStatus QueryStatusField, EquipmentBOL _EquipmentBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_EquipmentBOL);
        }
        public EquipmentBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EquipmentBOL[] EquipmentBOLs = new EquipmentBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? EquipmentId = DataConvertor.ConvertToShort(row["EQUIPMENTID"]);
                    string EquipmentTitle = DataConvertor.ConvertToString(row["EQUIPMENTTITLE"]);
                    int Count = DataConvertor.ConvertToInt(row["COUNT"]);
                    DateTime ExpiredDate = Convert.ToDateTime(row["EXPIREDDATE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    EquipmentBOLs[index] = new EquipmentBOL(EquipmentId, EquipmentTitle, Count,ExpiredDate,Description);
                }
                return EquipmentBOLs;
            }
            return null;
        }
        public EquipmentBOL[] SelectShortageAlarm()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EquipmentBOL[] EquipmentBOLs = new EquipmentBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short EquipmentId = (short)(row["EQUIPMENTID"]);
                    string EquipmentTitle = (row["EQUIPMENTTITLE"]).ToString();                    
                    EquipmentBOLs[index] = new EquipmentBOL(EquipmentId, EquipmentTitle);
                }
                return EquipmentBOLs;
            }
            return null;
        }
        public bool HasShortageAlarm()
        {
            sqlCommand.CommandText = string.Format("SELECT COUNT(*) AS COUNT FROM ({0}) AS TBL", sqlCommand.CommandText);
            return Convert.ToBoolean(ExecuteScalar());
        }
        public EquipmentBOL[] SelectExpiredAlarm()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EquipmentBOL[] EquipmentBOLs = new EquipmentBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short EquipmentId = (short)(row["EQUIPMENTID"]);
                    string EquipmentTitle = (row["EQUIPMENTTITLE"]).ToString();
                    EquipmentBOLs[index] = new EquipmentBOL(EquipmentId, EquipmentTitle);
                }
                return EquipmentBOLs;
            }
            return null;
        }
        public bool HasExpiredAlarm()
        {
            sqlCommand.CommandText = string.Format("SELECT COUNT(*) AS COUNT FROM ({0}) AS TBL", sqlCommand.CommandText);
            return Convert.ToBoolean(ExecuteScalar());
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
                case EquipmentDOL.QueryStatus.Select:
                    return EquipmentDOL.Select;
                case EquipmentDOL.QueryStatus.Delete:
                    return EquipmentDOL.Delete;
                case EquipmentDOL.QueryStatus.Update:
                    return EquipmentDOL.Update;
                case EquipmentDOL.QueryStatus.Insert:
                    return EquipmentDOL.Insert;
                case EquipmentDOL.QueryStatus.SelectMaxId:
                    return EquipmentDOL.SelectMaxId;
                case EquipmentDOL.QueryStatus.SelectShortageAlarm:
                    return EquipmentDOL.SelectShortageAlarm;
                case EquipmentDOL.QueryStatus.SelectExpiredAlarm:
                    return EquipmentDOL.SelectExpiredAlarm;                    
            }
            return string.Empty;
        }
        private void SetParameter(EquipmentBOL _EquipmentBOL)
        {
            sqlCommand.Parameters.Add("@EquipmentId", SqlDbType.SmallInt).Value = ValidateParameter("@EquipmentId", _EquipmentBOL.EquipmentId, false);
            sqlCommand.Parameters.Add("@EquipmentTitle", SqlDbType.NVarChar).Value = ValidateParameter("@EquipmentTitle", _EquipmentBOL.EquipmentTitle, true);
            sqlCommand.Parameters.Add("@Count", SqlDbType.Int).Value = ValidateParameter("@Count", _EquipmentBOL.Count, true);
            sqlCommand.Parameters.Add("@ExpiredDate", SqlDbType.DateTime).Value = ValidateParameter("@ExpiredDate", _EquipmentBOL.ExpiredDate, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _EquipmentBOL.Description, true);
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
