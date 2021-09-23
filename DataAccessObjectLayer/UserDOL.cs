namespace DataObjectLayer
{
    public class UserDOL
    {
        public const string Select = @"SELECT ROLE.ROLETITLE, [USER].USERID, [USER].USERNAME, [USER].PASSWORD, [USER].ISLOCKED, [USER].DESCRIPTION, [USER].ROLEID FROM [USER] INNER JOIN ROLE ON [USER].ROLEID = ROLE.ROLEID";
        public const string Insert = @"INSERT INTO [USER] ( USERID,USERNAME, PASSWORD, ISLOCKED, DESCRIPTION, ROLEID) VALUES(@USERID,@USERNAME, @PASSWORD, @ISLOCKED, @DESCRIPTION, @ROLEID)";
        public const string Delete = "DELETE FROM [USER] WHERE USERID=@USERID";
        public const string Update = "UPDATE [USER] SET USERNAME = @USERNAME, PASSWORD = @PASSWORD, ISLOCKED = @ISLOCKED, DESCRIPTION = @DESCRIPTION, ROLEID = @ROLEID WHERE USERID=@USERID";
        public const string LockUser = @"UPDATE [USER] SET ISLOCKED = 'True' WHERE USERNAME = @UserName";
        public const string CheckUserValid = @"SELECT COUNT(*) FROM [USER] WHERE USERNAME = @UserName AND PASSWORD=@Password";
        public const string CheckUserLock = @"SELECT ISLOCKED FROM [USER] WHERE USERNAME = @UserName";
        public const string ChangePassword = @"UPDATE [USER] SET PASSWORD = @NewPassword WHERE USERNAME = @UserName";
        public const string LoadUserProfile = @"SELECT USERNAME, USERID, PASSWORD, ISLOCKED, DESCRIPTION, ROLEID FROM [USER] WHERE USERNAME = @UserName";
        public const string SelectMaxId = "SELECT ISNULL(MAX(USERID),0)+1 AS MAX_ROLE_ID FROM [USER]";
        public enum QueryStatus {Select, Insert, Delete, Update, SelectMaxId , LockUser, CheckUserValid, CheckUserLock, ChangePassword, LoadUserProfile };
    }
}
