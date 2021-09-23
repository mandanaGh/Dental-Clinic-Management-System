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

    public class InsuranceTypeDAL
    {
        private static SqlCommand sqlCommand;
        private static InsuranceTypeDOL.QueryStatus queryStatus;

        public InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus QueryStatusField, InsuranceTypeBOL _InsuranceTypeBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_InsuranceTypeBOL);
        }
        public InsuranceTypeBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InsuranceTypeBOL[] InsuranceTypeBOLs = new InsuranceTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? InsuranceTypeId = DataConvertor.ConvertToShort(row["INSURANCETYPEID"]);
                    string InsuranceTypeTitle = DataConvertor.ConvertToString(row["INSURANCETYPETITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    decimal Percent = DataConvertor.ConvertToDecimal(row["PERCENT"]);
                    InsuranceTypeBOLs[index] = new InsuranceTypeBOL(InsuranceTypeId, InsuranceTypeTitle, Percent, Description);
                }
                return InsuranceTypeBOLs;
            }
            return null;
        }
        public InsuranceTypeBOL[] SelectComboBox()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                InsuranceTypeBOL[] InsuranceTypeBOLs = new InsuranceTypeBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? InsuranceTypeId = DataConvertor.ConvertToShort(row["INSURANCETYPEID"]);
                    string InsuranceTypeTitle = DataConvertor.ConvertToString(row["INSURANCETYPETITLE"]);
                    InsuranceTypeBOLs[index] = new InsuranceTypeBOL(InsuranceTypeId, InsuranceTypeTitle, 0, null);
                }
                return InsuranceTypeBOLs;
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

        public decimal GetPercent()
        {
            return  DataConvertor.ConvertToDecimal(ExecuteScalar());
        }
        private string SetCommandText()
        {
            switch (queryStatus)
            {
                case InsuranceTypeDOL.QueryStatus.Select:
                    return InsuranceTypeDOL.Select;
                case InsuranceTypeDOL.QueryStatus.SelectComboBox:
                    return InsuranceTypeDOL.SelectComboBox;
                case InsuranceTypeDOL.QueryStatus.Delete:
                    return InsuranceTypeDOL.Delete;
                case InsuranceTypeDOL.QueryStatus.Update:
                    return InsuranceTypeDOL.Update;
                case InsuranceTypeDOL.QueryStatus.Insert:
                    return InsuranceTypeDOL.Insert;
                case InsuranceTypeDOL.QueryStatus.SelectMaxId:
                    return InsuranceTypeDOL.SelectMaxId;
                case InsuranceTypeDOL.QueryStatus.GetPercent:
                    return InsuranceTypeDOL.GetPercent;
            }
            return string.Empty;
        }
        private void SetParameter(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            sqlCommand.Parameters.Add("@InsuranceTypeId", SqlDbType.Int).Value = ValidateParameter("@InsuranceTypeId", _InsuranceTypeBOL.InsuranceTypeId, false);
            sqlCommand.Parameters.Add("@InsuranceTypeTitle", SqlDbType.NVarChar).Value = ValidateParameter("@InsuranceTypeTitle", _InsuranceTypeBOL.InsuranceTypeTitle, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _InsuranceTypeBOL.Description, true);
            sqlCommand.Parameters.Add("@Percent", SqlDbType.Decimal).Value = ValidateParameter("@Percent", _InsuranceTypeBOL.Percent, false);
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
