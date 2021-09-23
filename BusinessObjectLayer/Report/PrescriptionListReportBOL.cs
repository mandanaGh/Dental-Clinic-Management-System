using System;
using System.Data;

namespace BusinessObjectLayer
{
    public class PrescriptionListReportFilterBOL
    {
        private short insuranceTypeId;
        private DateTime fromDate;
        private DateTime toDate;

        public short InsuranceTypeId
        {
            get { return this.insuranceTypeId; }
            set { this.insuranceTypeId = value; }
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
        public PrescriptionListReportFilterBOL() { }
        public PrescriptionListReportFilterBOL(short InsuranceTypeId, DateTime FromDate, DateTime ToDate)
        {
            this.insuranceTypeId = InsuranceTypeId;
            this.fromDate = FromDate;
            this.toDate = ToDate;
        }
    }
    public class PrescriptionListReportItemsBOL
    {        
        private string patientName;
        private long insuranceCode;
        private DateTime date;
        private string persianDate;
        private string doctorName;
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
        public string DoctorName
        {
            get { return this.doctorName; }            
        }
        public long Price
        {
            get { return this.price; }
        }        
        public PrescriptionListReportItemsBOL(string PatientName, long InsuranceCode, DateTime Date, string PersianDate, string DoctorName, long Price)
        {
            this.patientName = PatientName;
            this.insuranceCode = InsuranceCode;
            this.date = Date;
            this.persianDate = PersianDate;
            this.doctorName = DoctorName;
            this.price = Price;            
        }
    }
}
