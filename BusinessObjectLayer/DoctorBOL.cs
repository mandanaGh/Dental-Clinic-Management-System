using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class DoctorBOL
    {
        private short doctorId;
        private string doctorName;
        private string firstName;
        private string lastName;
        private bool gender;
        string doctorCode;
        int medicalCode;
        short specialistId;
        string specialistTitle;

        public short DoctorId
        {
            get { return this.doctorId; }
            set { this.doctorId = value; }        
        }
        public string DoctorName
        {
            get { return this.doctorName; }
            set { this.doctorName = value; }
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
        public string DoctorCode
        {
            get { return this.doctorCode; }
            set { this.doctorCode = value; }
        }
        public int MedicalCode
        {
            get { return this.medicalCode; }
            set { this.medicalCode = value; }
        }
        public short SpecialistId
        {
            get { return this.specialistId; }
            set { this.specialistId = value; }
        }
        public string SpecialistTitle
        {
            get { return this.specialistTitle; }
            set { this.specialistTitle = value; }
        }
        public DoctorBOL() { }
        public DoctorBOL(short DoctorId,string FirstName,string LastName,string DoctorCode,int MedicalCode,short SpecialistId,string SpecialistTitle,bool Gender)
        {
            this.doctorId = DoctorId;
            this.firstName= FirstName;
            this.lastName = LastName;
            this.gender= Gender;
            this.doctorCode = DoctorCode;
            this.medicalCode= MedicalCode;
            this.specialistId= SpecialistId;
            this.specialistTitle= SpecialistTitle;            
        }
        public DoctorBOL(short DoctorId, string DoctorName)
        {
            this.doctorId = DoctorId;
            this.doctorName = DoctorName;            
        }
        public DoctorBOL(short DoctorId, string DoctorName, int MedicalCode)
        {
            this.doctorId = DoctorId;
            this.doctorName = DoctorName;
            this.medicalCode = MedicalCode;
        }
    }
}
