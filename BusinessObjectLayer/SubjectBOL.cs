using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class SubjectBOL
    {
        private short? jabId;
        private string jabTitle;
        private string description;

        public short? SubjectId
        {
            get { return this.jabId; }
            set { this.jabId = value; }
        }
        public string SubjectTitle
        {
            get { return this.jabTitle; }
            set { this.jabTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public SubjectBOL() { }
        public SubjectBOL(short? SubjectId, string SubjectTitle, string Description)
        {
            this.jabId = SubjectId;
            this.jabTitle = SubjectTitle;
            this.description = Description;
        }
    }
}
