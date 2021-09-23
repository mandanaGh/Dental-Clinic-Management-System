using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class PhoneBookBOL
    {
        private int? phoneBookId;
        private string name1;
        private string name2;
        private string address1;
        private string address2;
        private string fax1;
        private string fax2;
        private string tel1;
        private string tel2;
        private string mobile1;
        private string mobile2;
        private short? subjectID;
        private string subjectTitle;
        private string email;
        private short? cityID;
        private string cityTitle;

        public int? PhoneBookId
        {
            get { return this.phoneBookId; }
            set { this.phoneBookId = value; }
        }
        public string Name1
        {
            get { return this.name1; }
            set { this.name1 = value; }
        }
        public string Name2
        {
            get { return this.name2; }
            set { this.name2 = value; }
        }
        public string Address1
        {
            get { return this.address1; }
            set { this.address1 = value; }
        }
        public string Address2
        {
            get { return this.address2; }
            set { this.address2 = value; }
        }
        public string Fax1
        {
            get { return this.fax1; }
            set { this.fax1 = value; }
        }
        public string Fax2
        {
            get { return this.fax2; }
            set { this.fax2 = value; }
        }
        public string Tel1
        {
            get { return this.tel1; }
            set { this.tel1 = value; }
        }
        public string Tel2
        {
            get { return this.tel2; }
            set { this.tel2 = value; }
        }
        public string Mobile1
        {
            get { return this.mobile1; }
            set { this.mobile1 = value; }
        }
        public string Mobile2
        {
            get { return this.mobile2; }
            set { this.mobile2 = value; }
        }
        public short? SubjectID
        {
            get { return this.subjectID; }
            set { this.subjectID = value; }
        }
        public string SubjectTitle
        {
            get { return this.subjectTitle; }
            set { this.subjectTitle = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public short? CityID
        {
            get { return this.cityID; }
            set { this.cityID = value; }
        }
        public string CityTitle
        {
            get { return this.cityTitle; }
            set { this.cityTitle = value; }
        }
        public PhoneBookBOL() { }
        public PhoneBookBOL(int PhoneBookId)
        {
            this.phoneBookId = PhoneBookId;
        }
        public PhoneBookBOL(int? PhoneBookId, string Name1, string Name2, string Address1, string Address2, string Fax1, string Fax2, string Tel1, string Tel2, string Mobile1, string Mobile2, short? SubjectID,string SubjectTitle, string Email, short? CityID, string CityTitle)
        {
            this.phoneBookId = PhoneBookId;
            this.name1 = Name1;
            this.name2 = Name2;
            this.address1 = Address1;
            this.address2 = Address2;
            this.fax1 = Fax1;
            this.fax2 = Fax2;
            this.tel1 = Tel1;
            this.tel2 = Tel2;
            this.mobile1 = Mobile1;
            this.mobile2 = Mobile2;
            this.subjectID = SubjectID;
            this.subjectTitle = SubjectTitle;
            this.email = Email;
            this.cityID = CityID;
            this.cityTitle = CityTitle;
        }
    }
}
