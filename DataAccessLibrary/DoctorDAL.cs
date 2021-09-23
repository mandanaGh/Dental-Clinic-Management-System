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
    
    public class DoctorDAL
    {
        private static SqlCommand sqlCommand;
        private static DoctorDOL.QueryStatus queryStatus;

        public DoctorDAL(DoctorDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public DoctorDAL(DoctorDOL.QueryStatus QueryStatusField, DoctorBOL _DoctorBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_DoctorBOL);
        }
        public DoctorBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                DoctorBOL[] DoctorBOLs = new DoctorBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short DoctorId = Convert.ToInt16(row["DOCTORID"]);
                    string FirstName= DataConvertor.ConvertToString(row["FIRSTNAME"]);
                    string LastName = DataConvertor.ConvertToString(row["LASTNAME"]);
                    string DoctorCode = DataConvertor.ConvertToString(row["DOCTORCODE"]);
                    int MedicalCode = Convert.ToInt32(row["MedicalCode"]);
                    short SpecialistId = Convert.ToInt16(row["SPECIALISTID"]);
                    string SpecialistTitle = DataConvertor.ConvertToString(row["SPECIALISTTITLE"]);
                    bool Gender = (bool)row["GENDER"];
                    DoctorBOLs[index] = new DoctorBOL(DoctorId, FirstName, LastName,DoctorCode,MedicalCode,SpecialistId,SpecialistTitle,Gender);
                }
                return DoctorBOLs;
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
                case DoctorDOL.QueryStatus.Select:
                    return DoctorDOL.Select;                
                case DoctorDOL.QueryStatus.Delete:
                    return DoctorDOL.Delete;
                case DoctorDOL.QueryStatus.Update:
                    return DoctorDOL.Update;
                case DoctorDOL.QueryStatus.Insert:
                    return DoctorDOL.Insert;
                case DoctorDOL.QueryStatus.SelectMaxId:
                    return DoctorDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(DoctorBOL _DoctorBOL)
        {
            sqlCommand.Parameters.Add("@DoctorId", SqlDbType.TinyInt).Value = ValidateParameter("@DoctorId", _DoctorBOL.DoctorId, true);
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = ValidateParameter("@FirstName", _DoctorBOL.FirstName, true);
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = ValidateParameter("@LastName", _DoctorBOL.LastName, true);
            sqlCommand.Parameters.Add("@DoctorCode", SqlDbType.NVarChar).Value = ValidateParameter("@DoctorCode", _DoctorBOL.DoctorCode, true);
            sqlCommand.Parameters.Add("@SpecialistId", SqlDbType.TinyInt).Value = ValidateParameter("@SpecialistId", _DoctorBOL.SpecialistId, true);
            sqlCommand.Parameters.Add("@MedicalCode", SqlDbType.Int).Value = ValidateParameter("@MedicalCode", _DoctorBOL.MedicalCode, true);
            sqlCommand.Parameters.Add("@Gender", SqlDbType.Bit).Value = ValidateParameter("@Gender", _DoctorBOL.Gender, true);            
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
