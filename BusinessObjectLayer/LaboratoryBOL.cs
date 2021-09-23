using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LaboratoryBOL
    {
        private short? laboratoryId;
        private string laboratoryTitle;
        private string address;
        private string tel;

        public short? LaboratoryId
        {
            get { return this.laboratoryId; }
            set { this.laboratoryId = value; }
        }
        public string LaboratoryTitle
        {
            get { return this.laboratoryTitle; }
            set { this.laboratoryTitle = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public LaboratoryBOL() { }
        public LaboratoryBOL(short? LaboratoryId, string LaboratoryTitle)
        {
            this.laboratoryId = LaboratoryId;
            this.laboratoryTitle = LaboratoryTitle;
        }   
        public LaboratoryBOL(short? LaboratoryId, string LaboratoryTitle, string Address,string Tel)
        {
            this.laboratoryId = LaboratoryId;
            this.laboratoryTitle = LaboratoryTitle;
            this.address = Address;
            this.tel = Tel;
        }        
    }
}
