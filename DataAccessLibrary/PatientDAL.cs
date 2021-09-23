using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using DataObjectLayer;
    using DataConvertor;
    using BusinessObjectLayer;

    public class PatientDAL
    {
        private static SqlCommand sqlCommand;
        private static PatientDOL.QueryStatus queryStatus;
        public PatientDAL(PatientDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public PatientDAL(PatientDOL.QueryStatus QueryStatusField, PatientBOL _PatientBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PatientBOL);
        }
        public PatientBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PatientBOL[] _PatientBOL = new PatientBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int? PatientId = DataConvertor.ConvertToInt(row["PATIENTID"]);
                    int? PatientCode = DataConvertor.ConvertToInt(row["PATIENTCODE"]);
                    string FirstName = DataConvertor.ConvertToString(row["FIRSTNAME"]);
                    string LastName = DataConvertor.ConvertToString(row["LASTNAME"]);
                    bool Gender = DataConvertor.ConvertToBoolean(row["GENDER"]);
                    string Tel = DataConvertor.ConvertToString(row["TEL"]);
                    string Mobile = DataConvertor.ConvertToString(row["MOBILE"]);
                    string Address = DataConvertor.ConvertToString(row["ADDRESS"]);
                    short? InsuranceTypeId = DataConvertor.ConvertToShort(row["INSURANCETYPEID"]);
                    string InsuranceTypeTitle = DataConvertor.ConvertToString(row["INSURANCETYPETITLE"]);
                    DateTime? Birthday = DataConvertor.ConvertToDate(row["BIRTHDAY"]);
                    DateTime? ExpiredDate = DataConvertor.ConvertToDate(row["EXPIREDDATE"]);
                    string InsuranceCode = DataConvertor.ConvertToString(row["INSURANCECODE"]);
                    bool Married = DataConvertor.ConvertToBoolean(row["MARRIED"]);
                    string NationalCode = DataConvertor.ConvertToString(row["NATIONALCODE"]);
                    short? JobId = DataConvertor.ConvertToShort(row["JOBID"]);
                    string JobTitle = DataConvertor.ConvertToString(row["JOBTITLE"]);
                    bool IsUseSpecialDrag = DataConvertor.ConvertToBoolean(row["ISUSESPECIALDRAG"]);
                    bool IsPregnant = DataConvertor.ConvertToBoolean(row["ISPREGNANT"]);
                    bool IsUnderPhysician = DataConvertor.ConvertToBoolean(row["ISUNDERPHYSICIAN"]);
                    string PhisicianDescription = DataConvertor.ConvertToString(row["PHISICIANDESCRIPTION"]);
                    DateTime? Date = DataConvertor.ConvertToDate(row["DATE"]);
                    bool IsPenAlergic = DataConvertor.ConvertToBoolean(row["ISPENALERGIC"]);
                    bool IsAsprinAlergic = DataConvertor.ConvertToBoolean(row["ISASPRINALERGIC"]);
                    bool IsOutDragAlergic = DataConvertor.ConvertToBoolean(row["ISOUTDRAGALERGIC"]);
                    bool IsOtherAlergic = DataConvertor.ConvertToBoolean(row["ISOTHERALERGIC"]);
                    string RelevantName = DataConvertor.ConvertToString(row["RELEVANTNAME"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    bool IsNormal = DataConvertor.ConvertToBoolean(row["ISNORMAL"]);
                    _PatientBOL[index] = new PatientBOL(PatientId, PatientCode, FirstName, LastName, Gender, Tel, Mobile, Address, InsuranceTypeId, InsuranceTypeTitle, Birthday, ExpiredDate, InsuranceCode, Married, NationalCode, JobId, JobTitle, IsUseSpecialDrag, IsPregnant, IsUnderPhysician, PhisicianDescription, Date, IsPenAlergic, IsAsprinAlergic, IsOutDragAlergic, IsOtherAlergic, RelevantName, Description, IsNormal);
                }
                return _PatientBOL;
            }
            return null;
        }
        public string Select(int PatientId)
        {
            sqlCommand.Parameters.Add("@PATIENTId", SqlDbType.Int).Value = ValidateParameter("@PATIENTId", PatientId, false);
            return ExecuteScalar().ToString();
        }
        public void Update(string toothColor)
        {
            sqlCommand.Parameters.Add("@ToothColor", SqlDbType.NVarChar).Value = ValidateParameter("@ToothColor", toothColor, true);
            ExecuteNonQuery();
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
        public int? SelectMaxId()
        {
            return DataConvertor.ConvertToInt(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case PatientDOL.QueryStatus.Select:
                    return PatientDOL.Select;
                case PatientDOL.QueryStatus.SelectAlarm:
                    return PatientDOL.SelectAlarm;
                case PatientDOL.QueryStatus.Delete:
                    return PatientDOL.Delete;
                case PatientDOL.QueryStatus.Update:
                    return PatientDOL.Update;
                case PatientDOL.QueryStatus.Insert:
                    return PatientDOL.Insert;
                case PatientDOL.QueryStatus.SelectMaxId:
                    return PatientDOL.SelectMaxId;
                case PatientDOL.QueryStatus.SelectToothColor:
                    return PatientDOL.SelectToothColor;
                case PatientDOL.QueryStatus.UpdateToothColor:
                    return PatientDOL.UpdateToothColor;
                case PatientDOL.QueryStatus.IsDangerous:
                    return PatientDOL.IsDangerous;
            }
            return string.Empty;
        }
        private void SetParameter(PatientBOL _PatientBOL)
        {
            sqlCommand.Parameters.Add("@PATIENTId", SqlDbType.Int).Value = ValidateParameter("@PATIENTId", _PatientBOL.PatientId, true);
            sqlCommand.Parameters.Add("@PATIENTCODE", SqlDbType.Int).Value = ValidateParameter("@PATIENTCODE", _PatientBOL.PatientCode, true);
            sqlCommand.Parameters.Add("@FIRSTNAME", SqlDbType.NVarChar).Value = ValidateParameter("@FIRSTNAME", _PatientBOL.FirstName, true);
            sqlCommand.Parameters.Add("@LASTNAME", SqlDbType.NVarChar).Value = ValidateParameter("@LASTNAME", _PatientBOL.LastName, true);
            sqlCommand.Parameters.Add("@GENDER", SqlDbType.Bit).Value = ValidateParameter("@GENDER", _PatientBOL.Gender, true);
            sqlCommand.Parameters.Add("@TEL", SqlDbType.NChar).Value = ValidateParameter("@TEL", _PatientBOL.Tel, true);
            sqlCommand.Parameters.Add("@MOBILE", SqlDbType.NChar).Value = ValidateParameter("@MOBILE", _PatientBOL.Mobile, true);
            sqlCommand.Parameters.Add("@ADDRESS", SqlDbType.NVarChar).Value = ValidateParameter("@ADDRESS", _PatientBOL.Address, true);
            sqlCommand.Parameters.Add("@INSURANCETYPEID", SqlDbType.TinyInt).Value = ValidateParameter("@INSURANCETYPEID", _PatientBOL.InsuranceTypeId, true);
            sqlCommand.Parameters.Add("@BIRTHDAY", SqlDbType.DateTime).Value = ValidateParameter("@BIRTHDAY", _PatientBOL.Birthday, true);
            sqlCommand.Parameters.Add("@EXPIREDDATE", SqlDbType.DateTime).Value = ValidateParameter("@EXPIREDDATE", _PatientBOL.ExpiredDate, true);
            sqlCommand.Parameters.Add("@INSURANCECODE", SqlDbType.NVarChar).Value = ValidateParameter("@INSURANCECODE", _PatientBOL.InsuranceCode, true);
            sqlCommand.Parameters.Add("@MARRIED", SqlDbType.BigInt).Value = ValidateParameter("@MARRIED", _PatientBOL.Married, true);
            sqlCommand.Parameters.Add("@NATIONALCODE", SqlDbType.NChar).Value = ValidateParameter("@NATIONALCODE", _PatientBOL.NationalCode, true);
            sqlCommand.Parameters.Add("@JOBID", SqlDbType.TinyInt).Value = ValidateParameter("@JOBID", _PatientBOL.JobId, true);
            sqlCommand.Parameters.Add("@ISUSESPECIALDRAG", SqlDbType.Bit).Value = ValidateParameter("@ISUSESPECIALDRAG", _PatientBOL.IsUseSpecialDrag, true);
            sqlCommand.Parameters.Add("@ISPREGNANT", SqlDbType.Bit).Value = ValidateParameter("@ISPREGNANT", _PatientBOL.IsPregnant, true);
            sqlCommand.Parameters.Add("@ISUNDERPHYSICIAN", SqlDbType.Bit).Value = ValidateParameter("@ISUNDERPHYSICIAN", _PatientBOL.IsUnderPhysician, true);
            sqlCommand.Parameters.Add("@PHISICIANDESCRIPTION", SqlDbType.NVarChar).Value = ValidateParameter("@PHISICIANDESCRIPTION", _PatientBOL.PhysicianDescription, true);
            sqlCommand.Parameters.Add("@DATE", SqlDbType.DateTime).Value = ValidateParameter("@DATE", _PatientBOL.Date, true);
            sqlCommand.Parameters.Add("@ISPENALERGIC", SqlDbType.Bit).Value = ValidateParameter("@ISPENALERGIC", _PatientBOL.IsPenAlergic, true);
            sqlCommand.Parameters.Add("@ISASPRINALERGIC", SqlDbType.Bit).Value = ValidateParameter("@ISASPRINALERGIC", _PatientBOL.IsAsprinAlergic, true);
            sqlCommand.Parameters.Add("@ISOUTDRAGALERGIC", SqlDbType.Bit).Value = ValidateParameter("@ISOUTDRAGALERGIC", _PatientBOL.IsOutDragAlergic, true);
            sqlCommand.Parameters.Add("@ISOTHERALERGIC", SqlDbType.Bit).Value = ValidateParameter("@ISOTHERALERGIC", _PatientBOL.IsOtherAlergic, true);
            sqlCommand.Parameters.Add("@RELEVANTNAME", SqlDbType.NVarChar).Value = ValidateParameter("@RELEVANTNAME", _PatientBOL.RelevantName, true);
            sqlCommand.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar).Value = ValidateParameter("@DESCRIPTION", _PatientBOL.Description, true);
            sqlCommand.Parameters.Add("@ISNORMAL", SqlDbType.Bit).Value = ValidateParameter("@ISNORMAL", _PatientBOL.IsNormal, true);
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
        public PatientBOL[] SelectAlarm()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PatientBOL[] _PatientBOL = new PatientBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int PatientId = Convert.ToInt32(row["PATIENTID"]);
                    string FirstName = DataConvertor.ConvertToString(row["FIRSTNAME"]);
                    string LastName = DataConvertor.ConvertToString(row["LASTNAME"]);
                    string Tel = DataConvertor.ConvertToString(row["TEL"]);
                    short ServiceTypeId = Convert.ToInt16(row["SERVICETYPEID"]);
                    string ServiceTypeTitle = DataConvertor.ConvertToString(row["SERVICETYPETITLE"]);
                    _PatientBOL[index] = new PatientBOL(PatientId, FirstName, LastName, ServiceTypeId, ServiceTypeTitle, Tel);
                }
                return _PatientBOL;
            }
            return null;
        }
        public bool HasAlarm()
        {
            sqlCommand.CommandText = string.Format("SELECT COUNT(*) AS COUNT FROM ({0}) AS TBL", sqlCommand.CommandText);
            return Convert.ToBoolean(ExecuteScalar());
        }
        public bool IsDangerous(int PatientId)
        {         
            sqlCommand.Parameters.Add("@PATIENTId", SqlDbType.Int).Value = ValidateParameter("@PATIENTId", PatientId, false);
            return DataConvertor.ConvertToBoolean(ExecuteScalar());
        }
    }
}
