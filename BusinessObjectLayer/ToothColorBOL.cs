using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class ToothColorBOL
    {
        private short? toothColorId;
        private string toothColorTitle;
        private string description;

        public short? ToothColorId
        {
            get { return this.toothColorId; }
            set { this.toothColorId = value; }
        }
        public string ToothColorTitle
        {
            get { return this.toothColorTitle; }
            set { this.toothColorTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public ToothColorBOL() { }
        public ToothColorBOL(short? ToothColorId, string ToothColorTitle, string Description)
        {
            this.toothColorId = ToothColorId;
            this.toothColorTitle = ToothColorTitle;
            this.description = Description;
        }
    }
}
