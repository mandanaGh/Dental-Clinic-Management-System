using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class PatientBOL
    {
        private int? patientId;
        private int? patientCode;
        private string firstName;
        private string lastName;
        private bool gender;
        private string tel;
        private string mobile;
        private string address;
        private short? insuranceTypeId;
        private string insuranceTypeTitle;
        private DateTime? birthday;
        private DateTime? expiredDate;
        private string insuranceCode;
        private bool married;
        private string nationalCode;
        private short? jobId; 
        private string jobTitle;
        private bool isUseSpecialDrag;
        private bool isPregnant;
        private bool isUnderPhysician;
        private string physicianDescription;
        private DateTime? date;
        private bool isPenAlergic;
        private bool isAsprinAlergic;
        private bool isOutDragAlergic;
        private bool isOtherAlergic;        
        private string relevantName;
        private string description;
        private string toothColor;
        private short serviceTypeId;
        private string serviceTypeTitle;
        private bool isNormal;

        public int? PatientId
        {
            get { return this.patientId; }
            set { this.patientId = value; }
        }
        public int? PatientCode
        {
            get { return this.patientCode; }
            set { this.patientCode = value; }
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
        public bool Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public string Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
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
        public DateTime? Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public DateTime? ExpiredDate
        {
            get { return this.expiredDate; }
            set { this.expiredDate = value; }
        }
        public string InsuranceCode
        {
            get { return this.insuranceCode; }
            set { this.insuranceCode = value; }
        }
        public bool Married
        {
            get { return this.married; }
            set { this.married = value; }
        }
        public string NationalCode
        {
            get { return this.nationalCode; }
            set { this.nationalCode = value; }
        }
        public string JobTitle
        {
            get { return this.jobTitle; }
            set { this.jobTitle = value; }
        }
        public bool IsUseSpecialDrag
        {
            get { return this.isUseSpecialDrag; }
            set { this.isUseSpecialDrag = value; }
        }
        public bool IsPregnant
        {
            get { return this.isPregnant; }
            set { this.isPregnant = value; }
        }
        public bool IsUnderPhysician
        {
            get { return this.isUnderPhysician; }
            set { this.isUnderPhysician = value; }
        }
        public string PhysicianDescription
        {
            get { return this.physicianDescription; }
            set { this.physicianDescription = value; }
        }
        public DateTime? Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public bool IsPenAlergic
        {
            get { return this.isPenAlergic; }
            set { this.isPenAlergic = value; }
        }
        public bool IsAsprinAlergic
        {
            get { return this.isAsprinAlergic; }
            set { this.isAsprinAlergic = value; }
        }
        public bool IsOutDragAlergic
        {
            get { return this.isOutDragAlergic; }
            set { this.isOutDragAlergic = value; }
        }
        public bool IsOtherAlergic
        {
            get { return this.isOtherAlergic; }
            set { this.isOtherAlergic = value; }
        }
        public string RelevantName
        {
            get { return this.relevantName; }
            set { this.relevantName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string ToothColor
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public short? JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }
        public string ServiceTypeTitle
        {
            get { return this.serviceTypeTitle; }
            set { this.serviceTypeTitle = value; }
        }
        public short ServiceTypeId
        {
            get { return this.serviceTypeId; }
            set { this.serviceTypeId = value; }
        }
        public bool IsNormal
        {
            get { return this.isNormal; }
            set { this.isNormal= value; }
        }
        public PatientBOL() { }
        public PatientBOL(int? PatientId, int? PatientCode, string FirstName, string LastName, bool Gender, string Tel, string Mobile, string Address, short? InsuranceTypeId, string InsuranceTypeTitle, DateTime? Birthday, DateTime? ExpiredDate, string InsuranceCode, bool Married, string NationalCode, short? JobId, string JobTitle, bool IsUseSpecialDrag, bool IsPregnant, bool IsUnderPhysician, string PhysicianDescription, DateTime? Date, bool IsPenAlergic, bool IsAsprinAlergic, bool IsOutDragAlergic, bool IsOtherAlergic, string RelevantName, string Description, bool IsNormal)
        {
            this.patientId = PatientId;
            this.patientCode = PatientCode;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.gender = Gender;
            this.tel = Tel;
            this.mobile = Mobile;
            this.address = Address;
            this.insuranceTypeId = InsuranceTypeId;
            this.insuranceTypeTitle = InsuranceTypeTitle;
            this.birthday = Birthday;
            this.expiredDate = ExpiredDate;
            this.insuranceCode = InsuranceCode;
            this.married = Married;
            this.nationalCode = NationalCode;
            this.jobId= JobId;
            this.jobTitle = JobTitle;
            this.isUseSpecialDrag = IsUseSpecialDrag;
            this.isPregnant = IsPregnant;
            this.isUnderPhysician = IsUnderPhysician;
            this.physicianDescription = PhysicianDescription;
            this.date = Date;
            this.isPenAlergic = IsPenAlergic;
            this.isAsprinAlergic = IsAsprinAlergic;
            this.isOutDragAlergic= IsOutDragAlergic;
            this.isOtherAlergic = IsOtherAlergic;
            this.relevantName = RelevantName;
            this.description = Description;
            this.isNormal = IsNormal;
        }
        public PatientBOL(int PatientId, string ToothColor)
        {
            this.patientId = PatientId;
            this.toothColor = ToothColor;
        }
        public PatientBOL(int PatientId, string FirstName, string LastName, short ServiceTypeId, string ServiceTypeTitle, string Tel)
        {
            this.patientId = PatientId;            
            this.firstName = FirstName;
            this.lastName = LastName;
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
            this.tel = Tel;
        }
    }
}
