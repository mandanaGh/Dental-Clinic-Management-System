using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class ServiceTypeBOL
    {
        private short? serviceTypeId;
        private string serviceTypeTitle;
        private long? price;
        private short? session;
        private string serviceTypeCode;
        private short? nextRefrence;
        private string description;
        private bool isLaboratory;

        public short? ServiceTypeId
        {
            get { return this.serviceTypeId; }
            set { this.serviceTypeId = value; }
        }
        public string ServiceTypeTitle
        {
            get { return this.serviceTypeTitle; }
            set { this.serviceTypeTitle = value; }
        }
        public long? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public short? Session
        {
            get { return this.session; }
            set { this.session = value; }
        }
        public string ServiceTypeCode
        {
            get { return this.serviceTypeCode; }
            set { this.serviceTypeCode = value; }
        }
        public short? NextRefrence
        {
            get { return this.nextRefrence; }
            set { this.nextRefrence = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public bool IsLaboratory
        {
            get { return this.isLaboratory; }
            set { this.isLaboratory = value; }
        }
        public ServiceTypeBOL() { }
        public ServiceTypeBOL(short? ServiceTypeId, string ServiceTypeTitle, long? Price, short? Session, string ServiceTypeCode, short? NextRefrence, string Description, bool IsLaboratory)
        {
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
            this.price = Price;
            this.session = Session;
            this.serviceTypeCode = ServiceTypeCode;
            this.nextRefrence = NextRefrence;
            this.description = Description;
            this.isLaboratory = IsLaboratory;
        }
        public ServiceTypeBOL(short? ServiceTypeId, string ServiceTypeTitle)
        {
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
        }
        public ServiceTypeBOL(short? ServiceTypeId)
        {
            this.serviceTypeId = ServiceTypeId;
        }
    }
}
