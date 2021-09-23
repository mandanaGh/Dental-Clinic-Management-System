using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class ServiceHistoryBOL
    {
        private int serviceHistoryId;
        private int serviceId;        
        private short doctorId;
        private string doctorName;        
        private DateTime date;
        private string tooth;
        private string description;
        public int ServiceHistoryId
        {
            get { return this.serviceHistoryId; }
            set { this.serviceHistoryId = value; }
        }
        public int ServiceId
        {
            get { return this.serviceId; }
            set { this.serviceId = value; }
        }
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
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
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
        public ServiceHistoryBOL() { }
        public ServiceHistoryBOL(int ServiceHistoryId, int ServiceId, short DoctorId, string DoctorName, DateTime Date, string Tooth, string Description)
        {
            this.serviceHistoryId = ServiceHistoryId;
            this.serviceId = ServiceId;            
            this.doctorId = DoctorId;
            this.doctorName = DoctorName;
            this.date = Date;
            this.tooth = Tooth;
            this.description = Description;
        }
    }
}
