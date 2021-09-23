using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class InsuranceTypeBOL
    {
        private short? insuranceTypeId;
        private string insuranceTypeTitle;
        private string description;
        private decimal percent;

        public short? InsuranceTypeId
        {
            get { return this.insuranceTypeId; }
            set { this.insuranceTypeId = value; }
        }
        public string InsuranceTypeTitle
        {
            get { return this.insuranceTypeTitle; }
            set { this.insuranceTypeTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public decimal Percent
        {
            get { return this.percent; }
            set { this.percent = value; }
        }        
        public InsuranceTypeBOL() { }
        public InsuranceTypeBOL(short? InsuranceTypeId, string InsuranceTypeTitle, decimal Percent, string Description)
        {
            this.insuranceTypeId = InsuranceTypeId;
            this.insuranceTypeTitle = InsuranceTypeTitle;
            this.percent = Percent;
            this.description = Description;            
        }
        public InsuranceTypeBOL(short? InsuranceTypeId, string InsuranceTypeTitle)
        {
            this.insuranceTypeId = InsuranceTypeId;
            this.insuranceTypeTitle = InsuranceTypeTitle;            
        }
    }
}
