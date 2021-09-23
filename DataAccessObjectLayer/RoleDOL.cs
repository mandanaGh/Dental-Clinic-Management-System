using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class RoleDOL
    {
        public const string Select = @"SELECT ROLEID, ROLETITLE, DESCRIPTION FROM ROLE";
        public const string Insert = @"INSERT INTO ROLE(ROLEID, ROLETITLE,DESCRIPTION) VALUES (@RoleId,@RoleTitle,@Description)";
        public const string SelectComboBox = @"SELECT ROLEID, ROLETITLE FROM ROLE UNION (SELECT ID AS ROLEID, TEXT AS ROLETITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM ROLE WHERE ROLEID=@RoleId";
        public const string Update = "UPDATE ROLE SET ROLETITLE = @RoleTitle ,DESCRIPTION = @Description  WHERE ROLEID = @RoleId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(ROLEID),0)+1 AS MAX_ROLE_ID FROM ROLE";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
