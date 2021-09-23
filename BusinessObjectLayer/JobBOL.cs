using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class JobBOL
    {
        private short? jabId;
        private string jabTitle;
        private string description;

        public short? JobId
        {
            get { return this.jabId; }
            set { this.jabId = value; }
        }
        public string JobTitle
        {
            get { return this.jabTitle; }
            set { this.jabTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public JobBOL() { }
        public JobBOL(short? JobId, string JobTitle, string Description)
        {
            this.jabId = JobId;
            this.jabTitle = JobTitle;
            this.description = Description;
        }
    }
}
