using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class AccessBOL
    {
        private short accessId;
        private string accessTitle;

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
        public AccessBOL() { }
        public AccessBOL(short AccessId, string AccessTitle)
        {
            this.accessId = AccessId;
            this.accessTitle = AccessTitle;
        }
    }
}
