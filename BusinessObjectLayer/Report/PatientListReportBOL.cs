using System;
using System.Data;

namespace BusinessObjectLayer
{
    public class PatientListReportFilterBOL
    {
        private short insuranceTypeId;
        private short doctorID;
        private DateTime fromDate;
        private DateTime toDate;

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
        public PatientListReportFilterBOL() { }
        public PatientListReportFilterBOL(short InsuranceTypeId, short DoctorID, DateTime FromDate, DateTime ToDate)
        {
            this.insuranceTypeId = InsuranceTypeId;
            this.doctorID = DoctorID;
            this.fromDate = FromDate;
            this.toDate = ToDate;
        }
    }
    public class PatientListReportItemsBOL
    {
        private string patientName;
        private long insuranceCode;
        private DateTime date;
        private string persianDate;
        private short serviceTypeId;
        private string serviceTypeTitle;
        private long price;

        public string PatientName
        {
            get { return this.patientName; }
        }
        public long InsuranceCode
        {
            get { return this.insuranceCode; }
        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public string PersianDate
        {
            get { return this.persianDate; }
        }
        public short ServiceTypeId
        {
            get { return this.serviceTypeId; }
        }
        public string ServiceTypeTitle
        {
            get { return this.serviceTypeTitle; }
        }
        public long Price
        {
            get { return this.price; }
        }
        public PatientListReportItemsBOL(string PatientName, long InsuranceCode, DateTime Date, string PersianDate, short ServiceTypeId, string ServiceTypeTitle, long Price)
        {
            this.patientName = PatientName;
            this.insuranceCode = InsuranceCode;
            this.date = Date;
            this.persianDate = PersianDate;
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
            this.price = Price;
        }
    }
    public class PatientListReportPatientBOL
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
        public PatientListReportPatientBOL()
        {
        }
        public PatientListReportPatientBOL(string ServiceTypeTitle, long Price, int Count)
        {
            this.serviceTypeTitle = ServiceTypeTitle;
            this.price = Price;
            this.count = Count;
        }
    }
}
