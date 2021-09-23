using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    using BusinessObjectLayer;
    using DataObjectLayer;
    using DataConvertor;

    public class UserDAL
    {
        private static SqlCommand sqlCommand;
        private static UserDOL.QueryStatus queryStatus;

        public UserDAL(UserDOL.QueryStatus QueryStatusField)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
        }
        public UserDAL(UserDOL.QueryStatus QueryStatusField, UserBOL _UserBOL)
        {
            queryStatus = QueryStatusField;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SetCommandText();
            SetParameter(_UserBOL);
        }
        public DataTable LoadUserProfile()
        {
            return ExecuteReader();
        }
        public void LockUser()
        {
            ExecuteNonQuery();
        }
        public bool CheckUserValid()
        {
            return Convert.ToBoolean(ExecuteScalar());
        }
        public bool CheckUserLock()
        {
            return Convert.ToBoolean(ExecuteScalar());
        }
        public void ChangePassword()
        {
            ExecuteNonQuery();
        }
        public UserBOL[] Select()
        {
            DataTable table = ExecuteReader();
            DataRow row;
            if (table.Rows.Count > 0)
            {
                UserBOL[] UserBOLs = new UserBOL[table.Rows.Count];
                for (int index = 0; index < table.Rows.Count; index++)
                {
                    row = table.Rows[index];
                    short? UserId = DataConvertor.ConvertToShort(row["USERID"]);
                    string UserName = DataConvertor.ConvertToString(row["USERNAME"]);
                    string Password= DataConvertor.ConvertToString(row["PASSWORD"]);
                    short? RoleID = DataConvertor.ConvertToShort(row["ROLEID"]);
                    string RoleTitle = DataConvertor.ConvertToString(row["ROLETITLE"]);
                    string Description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                    bool IsLocked= DataConvertor.ConvertToBoolean(row["ISLOCKED"]);
                    UserBOLs[index] = new UserBOL(UserId, UserName,Password,string.Empty,RoleID,RoleTitle, Description,IsLocked);
                }
                return UserBOLs;
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
                case UserDOL.QueryStatus.LockUser:
                    return UserDOL.LockUser;
                case UserDOL.QueryStatus.CheckUserValid:
                    return UserDOL.CheckUserValid;
                case UserDOL.QueryStatus.CheckUserLock:
                    return UserDOL.CheckUserLock;
                case UserDOL.QueryStatus.ChangePassword:
                    return UserDOL.ChangePassword;
                case UserDOL.QueryStatus.LoadUserProfile:
                    return UserDOL.LoadUserProfile;
                case UserDOL.QueryStatus.Select:
                    return UserDOL.Select;
                case UserDOL.QueryStatus.Delete:
                    return UserDOL.Delete;
                case UserDOL.QueryStatus.Update:
                    return UserDOL.Update;
                case UserDOL.QueryStatus.Insert:
                    return UserDOL.Insert;
                case UserDOL.QueryStatus.SelectMaxId:
                    return UserDOL.SelectMaxId;
            }
            return string.Empty;
        }
        private void SetParameter(UserBOL _UserBOL)
        {
            sqlCommand.Parameters.Add("@UserId", SqlDbType.TinyInt).Value = ValidateParameter("@UserId", _UserBOL.UserId, true);
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = ValidateParameter("@UserName", _UserBOL.UserName, true);
            sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = ValidateParameter("@Password", _UserBOL.Password, true);
            sqlCommand.Parameters.Add("@NewPassword", SqlDbType.NVarChar).Value = ValidateParameter("@NewPassword", _UserBOL.NewPassword, true);
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ValidateParameter("@Description", _UserBOL.Description, true);
            sqlCommand.Parameters.Add("@RoleId", SqlDbType.TinyInt).Value = ValidateParameter("@RoleId", _UserBOL.RoleId, true);            
            sqlCommand.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = ValidateParameter("@IsLocked", _UserBOL.IsLocked, true);
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
