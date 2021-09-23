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

    public class PatientDiseasesDAL
    {
        private static SqlCommand sqlCommand;
        private static PatientDiseasesDOL.QueryStatus queryStatus;

        public PatientDiseasesDAL(PatientDiseasesDOL.QueryStatus QueryStatusField, PatientDiseasesBOL _PatientDiseasesBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PatientDiseasesBOL);
        }
        public PatientDiseasesBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PatientDiseasesBOL[] PatientDiseasesBOLs = new PatientDiseasesBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? DiseasesId = DataConvertor.ConvertToShort(row["DISEASESID"]);
                    int? PatientId = DataConvertor.ConvertToInt(row["DISEASESID"]);
                    PatientDiseasesBOLs[index] = new PatientDiseasesBOL(DiseasesId, PatientId);
                }
                return PatientDiseasesBOLs;
            }
            return null;
        }
        public void Insert()
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
                case PatientDiseasesDOL.QueryStatus.Select:
                    return PatientDiseasesDOL.Select;
                case PatientDiseasesDOL.QueryStatus.Delete:
                    return PatientDiseasesDOL.Delete;
                case PatientDiseasesDOL.QueryStatus.Insert:
                    return PatientDiseasesDOL.Insert;
            }
            return string.Empty;
        }
        private void SetParameter(PatientDiseasesBOL _PatientDiseasesBOL)
        {
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _PatientDiseasesBOL.PatientId, false);
            sqlCommand.Parameters.Add("@DiseasesID", SqlDbType.TinyInt).Value = ValidateParameter("@DiseasesId", _PatientDiseasesBOL.DiseasesId, true);
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
