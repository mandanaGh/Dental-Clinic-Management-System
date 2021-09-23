using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class SpecialistBOL
    {
        private short? specialistId;
        private string specialistTitle;
        private string description;

        public short? SpecialistId
        {
            get { return this.specialistId; }
            set { this.specialistId = value; }
        }
        public string SpecialistTitle
        {
            get { return this.specialistTitle; }
            set { this.specialistTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public SpecialistBOL() { }
        public SpecialistBOL(short? SpecialistId, string SpecialistTitle, string Description)
        {
            this.specialistId = SpecialistId;
            this.specialistTitle = SpecialistTitle;
            this.description = Description;
        }
    }
}
