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

    public class DiseasesDAL
    {
        private static SqlCommand sqlCommand;
        private static DiseasesDOL.QueryStatus queryStatus;

        public DiseasesDAL(DiseasesDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public DiseasesDAL(DiseasesDOL.QueryStatus QueryStatusField, DiseasesBOL _DiseasesBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_DiseasesBOL);
        }      
        public DiseasesBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                DiseasesBOL[] DiseasesBOLs = new DiseasesBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? DiseasesId = DataConvertor.ConvertToShort(row["DISEASESID"]);
                    string DiseasesTitle = DataConvertor.ConvertToString(row["DISEASESTITLE"]);
                    bool IsDangerous = DataConvertor.ConvertToBoolean(row["ISDANGEROUS"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    DiseasesBOLs[index] = new DiseasesBOL(DiseasesId, DiseasesTitle, IsDangerous, Description);
                }
                return DiseasesBOLs;
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
                case DiseasesDOL.QueryStatus.Select:
                    return DiseasesDOL.Select;               
                case DiseasesDOL.QueryStatus.Delete:
                    return DiseasesDOL.Delete;
                case DiseasesDOL.QueryStatus.Update:
                    return DiseasesDOL.Update;
                case DiseasesDOL.QueryStatus.Insert:
                    return DiseasesDOL.Insert;
                case DiseasesDOL.QueryStatus.SelectMaxId:
                    return DiseasesDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(DiseasesBOL _DiseasesBOL)
        {            
            sqlCommand.Parameters.Add("@DiseasesId", SqlDbType.TinyInt).Value = ValidateParameter("@DiseasesId", _DiseasesBOL.DiseasesId, true);
            sqlCommand.Parameters.Add("@DiseasesTitle", SqlDbType.NVarChar).Value = ValidateParameter("@DiseasesTitle", _DiseasesBOL.DiseasesTitle, true);
            sqlCommand.Parameters.Add("@IsDangerous", SqlDbType.Bit).Value = ValidateParameter("@IsDangerous", _DiseasesBOL.IsDangerous, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _DiseasesBOL.Description, true);
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
