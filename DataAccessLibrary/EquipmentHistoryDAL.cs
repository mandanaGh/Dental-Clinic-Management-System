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

    public class EquipmentHistoryDAL
    {
        private static SqlCommand sqlCommand;
        private static EquipmentHistoryDOL.QueryStatus queryStatus;

        public EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus QueryStatusField, EquipmentHistoryBOL _EquipmentHistoryBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_EquipmentHistoryBOL);
        }
        public EquipmentHistoryBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                EquipmentHistoryBOL[] EquipmentHistoryBOLs = new EquipmentHistoryBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    long? EquipmentHistoryId = DataConvertor.ConvertToLong(row["EQUIPMENTHISTORYID"]);
                    short? EquipmentId = DataConvertor.ConvertToShort(row["EQUIPMENTID"]);                    
                    string EquipmentTitle = DataConvertor.ConvertToString(row["EQUIPMENTTITLE"]);
                    bool IsInput = DataConvertor.ConvertToBoolean(row["ISINPUT"]);
                    int Count = DataConvertor.ConvertToInt(row["COUNT"]);
                    DateTime Date = (DateTime)(row["DATE"]);
                    EquipmentHistoryBOLs[index] = new EquipmentHistoryBOL(EquipmentHistoryId, EquipmentId, EquipmentTitle, Count, IsInput, Date);
                }
                return EquipmentHistoryBOLs;
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
                case EquipmentHistoryDOL.QueryStatus.Select:
                    return EquipmentHistoryDOL.Select;
                case EquipmentHistoryDOL.QueryStatus.Delete:
                    return EquipmentHistoryDOL.Delete;
                case EquipmentHistoryDOL.QueryStatus.Update:
                    return EquipmentHistoryDOL.Update;
                case EquipmentHistoryDOL.QueryStatus.Insert:
                    return EquipmentHistoryDOL.Insert;
                case EquipmentHistoryDOL.QueryStatus.SelectMaxId:
                    return EquipmentHistoryDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(EquipmentHistoryBOL _EquipmentHistoryBOL)
        {
            sqlCommand.Parameters.Add("@EquipmentHistoryId", SqlDbType.BigInt).Value = ValidateParameter("@EquipmentHistoryId", _EquipmentHistoryBOL.EquipmentHistoryId, true);
            sqlCommand.Parameters.Add("@EquipmentId", SqlDbType.SmallInt).Value = ValidateParameter("@EquipmentId", _EquipmentHistoryBOL.EquipmentId, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _EquipmentHistoryBOL.Date, true);
            sqlCommand.Parameters.Add("@IsInput", SqlDbType.Bit).Value = ValidateParameter("@IsInput", _EquipmentHistoryBOL.IsInput, true);
            sqlCommand.Parameters.Add("@Count", SqlDbType.Int).Value = ValidateParameter("@Count", _EquipmentHistoryBOL.Count, true);
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
