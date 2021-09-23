using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class UserBOL
    {
        private short? userId;
        private string userName;
        private string password;
        private string newPassword;
        private short? roleId;
        private string roleTitle;
        private string description;
        private bool isLocked;

        public short? UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string NewPassword
        {
            get { return this.newPassword; }
            set { this.newPassword = value; }
        }
        public short? RoleId
        {
            get { return this.roleId; }
            set { this.roleId = value; }
        }
        public string RoleTitle
        {
            get { return this.roleTitle; }
            set { this.roleTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public bool IsLocked
        {
            get { return this.isLocked; }
            set { this.isLocked = value; }
        }
        public UserBOL() { }
        public UserBOL(short? UserID, string UserName, string Password, string NewPassword, short? RoleId, string RoleTitle, string Description, bool IsLocked)
        {
            this.userId = UserID;
            this.userName = UserName;
            this.password = Password;
            this.newPassword = NewPassword;
            this.roleId = RoleId;
            this.roleTitle = RoleTitle;
            this.description = Description;
            this.isLocked = IsLocked;
        }
    }
}
