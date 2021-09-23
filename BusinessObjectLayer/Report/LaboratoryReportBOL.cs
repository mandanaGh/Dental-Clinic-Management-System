using System;
using System.Data;

namespace BusinessObjectLayer
{
    public class LaboratoryReportFilterBOL
    {
        private short? laboratoryId;
        private short? laboratoryStateId;
        private DateTime fromDate;
        private DateTime toDate;
        public short? LaboratoryId
        {
            get { return this.laboratoryId; }
            set { this.laboratoryId = value; }
        }
        public short? LaboratoryStateId
        {
            get { return this.laboratoryStateId; }
            set { this.laboratoryStateId = value; }
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

        public LaboratoryReportFilterBOL() { }
        public LaboratoryReportFilterBOL(short? LaboratoryId, short? LaboratoryStateId,DateTime FromDate, DateTime ToDate)
        {
            this.laboratoryId = LaboratoryId;
            this.laboratoryStateId = LaboratoryStateId;            
            this.fromDate = FromDate;
            this.toDate = ToDate;
        }
    }
    public class LaboratoryReportItemsBOL
    {
        private DateTime date;
        private string persianDate;
        private short laboratoryId;
        private string laboratoryTitle;
        private short laboratoryStateId;
        private string laboratoryStateTitle;
        private short serviceTypeId;
        private string serviceTypeTitle;
        private string firstName;
        private string lastName;
        private string patientCode;
        private string diseases;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string PersianDate
        {
            get { return this.persianDate; }
            set { this.persianDate = value; }
        }
        public short LaboratoryId
        {
            get { return this.laboratoryId; }
            set { this.laboratoryId = value; }
        }
        public string LaboratoryTitle
        {
            get { return this.laboratoryTitle; }
            set { this.laboratoryTitle = value; }
        }
        public short LaboratoryStateId
        {
            get { return this.laboratoryStateId; }
            set { this.laboratoryStateId = value; }
        }
        public string LaboratoryStateTitle
        {
            get { return this.laboratoryStateTitle; }
            set { this.laboratoryStateTitle = value; }
        }
        public short ServiceTypeId
        {
            get { return this.serviceTypeId; }
            set { this.serviceTypeId = value; }
        }
        public string ServiceTypeTitle
        {
            get { return this.serviceTypeTitle; }
            set { this.serviceTypeTitle = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string PatientCode
        {
            get { return this.patientCode; }
            set { this.patientCode = value; }
        }
        public string Diseases
        {
            get { return this.diseases; }
            set { this.diseases = value; }
        }

        public LaboratoryReportItemsBOL(DateTime Date, string PersianDate, short LaboratoryId, string LaboratoryTitle, short LaboratoryStateId, string LaboratoryStateTitle, short ServiceTypeId, string ServiceTypeTitle, string FirstName, string LastName, string PatientCode, string Diseases)
        {
            this.date = Date;
            this.persianDate = PersianDate;
            this.laboratoryId = LaboratoryId;
            this.laboratoryTitle = LaboratoryTitle;
            this.laboratoryStateId = LaboratoryStateId;
            this.laboratoryStateTitle = LaboratoryStateTitle;
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.patientCode = PatientCode;
            this.diseases = Diseases;          
        }
    }
}
