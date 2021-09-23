using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class SecurityBOL
    {
        private short roleId;
        private short pageId;
        private string pageTitle;
        private short accessId;
        private string accessTitle;

        public short RoleId
        {
            get { return this.roleId; }
            set { this.roleId= value; }
        }
        public short PageId
        {
            get { return this.pageId; }
            set { this.pageId = value; }
        }
        public string PageTitle
        {
            get { return this.pageTitle; }
            set { this.pageTitle = value; }
        }
        public short AccessId
        {
            get { return this.accessId; }
            set { this.accessId = value; }
        }
        public string AccessTitle
        {
            get { return this.accessTitle; }
            set { this.accessTitle = value; }
        }
        public SecurityBOL() { }
        public SecurityBOL(short RoleId)
        {
            this.roleId = RoleId;
        }
        public SecurityBOL(short PageId, string PageTitle,short AccessId,string AccessTitle)
        {            
            this.pageId = PageId;
            this.pageTitle = PageTitle;
            this.accessId = AccessId;
            this.accessTitle = AccessTitle;
        }
    }
}
