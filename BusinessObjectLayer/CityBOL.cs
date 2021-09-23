using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class CityBOL
    {
        private short? jabId;
        private string jabTitle;
        private string description;

        public short? CityId
        {
            get { return this.jabId; }
            set { this.jabId = value; }
        }
        public string CityTitle
        {
            get { return this.jabTitle; }
            set { this.jabTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public CityBOL() { }
        public CityBOL(short? CityId, string CityTitle, string Description)
        {
            this.jabId = CityId;
            this.jabTitle = CityTitle;
            this.description = Description;
        }
    }
}
