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

    public class RecieveDAL
    {
        private static SqlCommand sqlCommand;
        private static RecieveDOL.QueryStatus queryStatus;

        public RecieveDAL(RecieveDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public RecieveDAL(RecieveDOL.QueryStatus QueryStatusField, RecieveBOL _RecieveBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_RecieveBOL);
        }
        public RecieveBOL[] Select(int _PatientId)
        {
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _PatientId, false);
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                RecieveBOL[] RecieveBOLs = new RecieveBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int RecieveId = Convert.ToInt32(row["RECIEVEID"]);
                    int PatientId = Convert.ToInt32(row["PATIENTID"]);
                    DateTime Date = Convert.ToDateTime(row["DATE"]);
                    long Price = Convert.ToInt64(row["PRICE"]);                   
                    bool IsInput = Convert.ToBoolean(row["ISINPUT"]);
                    RecieveBOLs[index] = new RecieveBOL(RecieveId, PatientId, IsInput, Price, Date);
                }
                return RecieveBOLs;
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
                case RecieveDOL.QueryStatus.Select:
                    return RecieveDOL.Select;
                case RecieveDOL.QueryStatus.Delete:
                    return RecieveDOL.Delete;
                case RecieveDOL.QueryStatus.Update:
                    return RecieveDOL.Update;
                case RecieveDOL.QueryStatus.Insert:
                    return RecieveDOL.Insert;
                case RecieveDOL.QueryStatus.SelectMaxId:
                    return RecieveDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(RecieveBOL _RecieveBOL)
        {
            sqlCommand.Parameters.Add("@RecieveId", SqlDbType.Int).Value = ValidateParameter("@RecieveId", _RecieveBOL.RecieveId, true);
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _RecieveBOL.PatientId, true);
            sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = ValidateParameter("@Date", _RecieveBOL.Date, true);
            sqlCommand.Parameters.Add("@Price", SqlDbType.BigInt).Value = ValidateParameter("@Price", _RecieveBOL.Price, true);
            sqlCommand.Parameters.Add("@IsInput", SqlDbType.Bit).Value = ValidateParameter("@IsInput", _RecieveBOL.IsInput, true);
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
