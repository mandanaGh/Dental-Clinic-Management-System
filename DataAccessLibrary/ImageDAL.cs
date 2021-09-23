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

    public class ImageDAL
    {
        private static SqlCommand sqlCommand;
        private static ImageDOL.QueryStatus queryStatus;

        public ImageDAL(ImageDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public ImageDAL(ImageDOL.QueryStatus QueryStatusField, ImageBOL _ImageBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_ImageBOL);
        }
        public ImageBOL[] Select(int _PatientId)
        {
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _PatientId, false);
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                ImageBOL[] ImageBOLs = new ImageBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    long? ImageId = DataConvertor.ConvertToLong(row["IMAGEID"]);
                    string ImageTitle = DataConvertor.ConvertToString(row["IMAGETITLE"]);
                    int PatientId = Convert.ToInt32(row["PATIENTID"]);
                    string ImagePath= DataConvertor.ConvertToString(row["IMAGEPATH"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    ImageBOLs[index] = new ImageBOL(ImageId,PatientId, ImageTitle, ImagePath, Description);
                }
                return ImageBOLs;
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
                case ImageDOL.QueryStatus.Select:
                    return ImageDOL.Select;
                case ImageDOL.QueryStatus.Delete:
                    return ImageDOL.Delete;
                case ImageDOL.QueryStatus.Update:
                    return ImageDOL.Update;
                case ImageDOL.QueryStatus.Insert:
                    return ImageDOL.Insert;
                case ImageDOL.QueryStatus.SelectMaxId:
                    return ImageDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(ImageBOL _ImageBOL)
        {
            sqlCommand.Parameters.Add("@ImageId", SqlDbType.BigInt).Value = ValidateParameter("@ImageId", _ImageBOL.ImageId, true);
            sqlCommand.Parameters.Add("@ImageTitle", SqlDbType.NVarChar).Value = ValidateParameter("@ImageTitle", _ImageBOL.ImageTitle, true);
            sqlCommand.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = ValidateParameter("@ImagePath", _ImageBOL.ImagePath, true);
            sqlCommand.Parameters.Add("@PatientId", SqlDbType.Int).Value = ValidateParameter("@PatientId", _ImageBOL.PatientId, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _ImageBOL.Description, true);
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
