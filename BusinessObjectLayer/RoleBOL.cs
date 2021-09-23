using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class RoleBOL
    {
        private short? roleId;
        private string roleTitle;
        private string description;

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
        public RoleBOL() { }
        public RoleBOL(short? RoleId, string RoleTitle, string Description)
        {
            this.roleId = RoleId;
            this.roleTitle = RoleTitle;
            this.description = Description;
        }
    }
}
