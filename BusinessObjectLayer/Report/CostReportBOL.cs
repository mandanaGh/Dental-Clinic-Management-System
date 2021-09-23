using System;
using System.Data;

namespace BusinessObjectLayer
{
    public class CostReportFilterBOL
    {
        private short insuranceTypeId;
        private short doctorID;
        private DateTime fromDate;
        private DateTime toDate;
        private bool isNormal;
        public short InsuranceTypeId
        {
            get { return this.insuranceTypeId; }
            set { this.insuranceTypeId = value; }
        }
        public short DoctorID
        {
            get { return this.doctorID; }
            set { this.doctorID = value; }
        }
        public DateTime FromDate
        {
            get { return this.fromDate; }
            set { this.fromDate = value; }
        }
        public DateTime ToDate
        {
            get { return this.toDate; }
            set { this.toDate = value; }
        }
        public bool IsNormal
        {
            get { return this.isNormal; }
            set { this.isNormal = value; }
        }
        public CostReportFilterBOL() { }
        public CostReportFilterBOL(short InsuranceTypeId, short DoctorID, DateTime FromDate, DateTime ToDate)
        {
            this.insuranceTypeId = InsuranceTypeId;
            this.doctorID = DoctorID;
            this.fromDate = FromDate;
            this.toDate = ToDate;
        }
        public CostReportFilterBOL(short InsuranceTypeId, short DoctorID, DateTime FromDate, DateTime ToDate, bool IsNormal)
        {
            this.insuranceTypeId = InsuranceTypeId;
            this.doctorID = DoctorID;
            this.fromDate = FromDate;
            this.toDate = ToDate;
            this.isNormal = IsNormal;
        }
    }
    public class CostReportItemsBOL
    {
        private short serviceTypeId;
        private string serviceTypeTitle;
        private string serviceTypeCode;
        private long price;
        private int count;

        public short ServiceTypeId
        {
            get { return this.serviceTypeId; }
        }
        public string ServiceTypeTitle
        {
            get { return this.serviceTypeTitle; }
        }
        public string ServiceTypeCode
        {
            get { return this.serviceTypeCode; }
        }
        public long Price
        {
            get { return this.price; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public CostReportItemsBOL(short ServiceTypeId, string ServiceTypeTitle, string ServiceTypeCode, long Price, int Count)
        {
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
            this.serviceTypeCode = ServiceTypeCode;
            this.price = Price;
            this.count = Count;
        }
    }
    public class CostReportPatientBOL
    {
        private string serviceTypeTitle;
        private long price;
        private int count;
        public string ServiceTypeTitle
        {
            get { return this.serviceTypeTitle; }
        }
        public long Price
        {
            get { return this.price; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public CostReportPatientBOL()
        {
        }
        public CostReportPatientBOL(string ServiceTypeTitle, long Price, int Count)
        {
            this.serviceTypeTitle = ServiceTypeTitle;
            this.price = Price;
            this.count = Count;
        }
    }
}
