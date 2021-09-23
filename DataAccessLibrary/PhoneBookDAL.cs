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
    
    public class PhoneBookDAL
    {
        private static SqlCommand sqlCommand;
        private static PhoneBookDOL.QueryStatus queryStatus;

        public PhoneBookDAL(PhoneBookDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public PhoneBookDAL(PhoneBookDOL.QueryStatus QueryStatusField, PhoneBookBOL _PhoneBookBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_PhoneBookBOL);
        }
        public PhoneBookBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                PhoneBookBOL[] PhoneBookBOLs = new PhoneBookBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    int phoneBookId = (int)(row["phoneBookId"]); ;
                    string name1 = DataConvertor.ConvertToString(row["name1"]);
                    string name2 = DataConvertor.ConvertToString(row["name2"]);
                    string address1 = DataConvertor.ConvertToString(row["address1"]);
                    string address2 = DataConvertor.ConvertToString(row["address2"]);
                    string fax1 = DataConvertor.ConvertToString(row["fax1"]);
                    string fax2 = DataConvertor.ConvertToString(row["fax2"]);
                    string tel1 = DataConvertor.ConvertToString(row["tel1"]);
                    string tel2 = DataConvertor.ConvertToString(row["tel2"]);
                    string mobile1 = DataConvertor.ConvertToString(row["mobile1"]);
                    string mobile2 = DataConvertor.ConvertToString(row["mobile2"]);
                    short? subjectID = DataConvertor.ConvertToShort(row["subjectID"]);
                    string subjectTitle = DataConvertor.ConvertToString(row["subjectTitle"]);
                    string email = DataConvertor.ConvertToString(row["email"]);
                    short? cityID = DataConvertor.ConvertToShort(row["cityID"]);
                    string cityTitle = DataConvertor.ConvertToString(row["cityTitle"]);
                    PhoneBookBOLs[index] = new PhoneBookBOL(phoneBookId, name1, name2, address1, address2, fax1, fax2, tel1, tel2, mobile1, mobile2, subjectID, subjectTitle, email, cityID, cityTitle);
                }
                return PhoneBookBOLs;
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
        public int SelectMaxId()
        {
            return (int)(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case PhoneBookDOL.QueryStatus.Select:
                    return PhoneBookDOL.Select;
                case PhoneBookDOL.QueryStatus.Delete:
                    return PhoneBookDOL.Delete;
                case PhoneBookDOL.QueryStatus.Update:
                    return PhoneBookDOL.Update;
                case PhoneBookDOL.QueryStatus.Insert:
                    return PhoneBookDOL.Insert;
                case PhoneBookDOL.QueryStatus.SelectMaxId:
                    return PhoneBookDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(PhoneBookBOL _PhoneBookBOL)
        {
            sqlCommand.Parameters.Add("@phoneBookId", SqlDbType.Int).Value = ValidateParameter("@phoneBookId", _PhoneBookBOL.PhoneBookId, true);
            sqlCommand.Parameters.Add("@name1", SqlDbType.NVarChar).Value = ValidateParameter("@name1", _PhoneBookBOL.Name1, true);
            sqlCommand.Parameters.Add("@name2", SqlDbType.NVarChar).Value = ValidateParameter("@name2", _PhoneBookBOL.Name2, true);
            sqlCommand.Parameters.Add("@address1", SqlDbType.NVarChar).Value = ValidateParameter("@address1", _PhoneBookBOL.Address1, true);
            sqlCommand.Parameters.Add("@address2", SqlDbType.NVarChar).Value = ValidateParameter("@address2", _PhoneBookBOL.Address2, true);
            sqlCommand.Parameters.Add("@fax1", SqlDbType.NVarChar).Value = ValidateParameter("@fax1", _PhoneBookBOL.Fax1, true);
            sqlCommand.Parameters.Add("@fax2", SqlDbType.NVarChar).Value = ValidateParameter("@fax2", _PhoneBookBOL.Fax2, true);
            sqlCommand.Parameters.Add("@tel1", SqlDbType.NVarChar).Value = ValidateParameter("@tel1", _PhoneBookBOL.Tel1, true);
            sqlCommand.Parameters.Add("@tel2", SqlDbType.NVarChar).Value = ValidateParameter("@tel2", _PhoneBookBOL.Tel2, true);
            sqlCommand.Parameters.Add("@mobile1", SqlDbType.NVarChar).Value = ValidateParameter("@mobile1", _PhoneBookBOL.Mobile1, true);
            sqlCommand.Parameters.Add("@mobile2", SqlDbType.NVarChar).Value = ValidateParameter("@mobile2", _PhoneBookBOL.Mobile2, true);
            sqlCommand.Parameters.Add("@subjectID", SqlDbType.TinyInt).Value = ValidateParameter("@subjectID", _PhoneBookBOL.SubjectID, true);
            sqlCommand.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = ValidateParameter("@subjectTitle", _PhoneBookBOL.SubjectTitle, true);
            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = ValidateParameter("@email", _PhoneBookBOL.Email, true);
            sqlCommand.Parameters.Add("@cityID", SqlDbType.TinyInt).Value = ValidateParameter("@cityID", _PhoneBookBOL.CityID, true);
            sqlCommand.Parameters.Add("@cityTitle", SqlDbType.NVarChar).Value = ValidateParameter("@cityTitle", _PhoneBookBOL.CityTitle, true);
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
