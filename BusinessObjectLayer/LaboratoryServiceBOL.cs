using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LaboratoryServiceBOL
    {
        private short laboratoryId;
        private int serviceId;
        private DateTime date;
        private short laboratoryStateId;
        private short toothColorId;
        private string tooth;
        private string description;
        public short LaboratoryId
        {
            get { return this.laboratoryId; }
            set { this.laboratoryId = value; }
        }
        public int ServiceId
        {
            get { return this.serviceId; }
            set { this.serviceId = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public short LaboratoryStateId
        {
            get { return this.laboratoryStateId; }
            set { this.laboratoryStateId = value; }
        }
        public short ToothColorId
        {
            get { return this.toothColorId; }
            set { this.toothColorId = value; }
        }
        public string Tooth
        {
            get { return this.tooth; }
            set { this.tooth = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public LaboratoryServiceBOL() 
        { 
        }
        public LaboratoryServiceBOL(short LaboratoryId, int ServiceId, DateTime Date, short LaboratoryStateId, string Tooth, short ToothColorId, string Description)
        {
            this.laboratoryId = LaboratoryId;
            this.serviceId = ServiceId;        
            this.date = Date;
            this.laboratoryStateId = LaboratoryStateId;
            this.tooth = Tooth;
            this.toothColorId = ToothColorId;
            this.description = Description;
        }
    }
}
