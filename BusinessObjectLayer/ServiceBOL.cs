using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class ServiceBOL
    {
        private int serviceId;
        private int patientId;
        private short serviceTypeId;
        private string serviceTypeTitle;
        private bool isLaboratory;
        private bool isFinished;
        private decimal discount;
        private DateTime date;
        private long price;
        
        public int ServiceId
        {
            get { return this.serviceId; }
            set { this.serviceId = value; }
        }
        public int PatientId
        {
            get { return this.patientId; }
            set { this.patientId = value; }
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
        public bool IsLaboratory
        {
            get { return this.isLaboratory; }
            set { this.isLaboratory = value; }
        }
        public bool IsFinished
        {
            get { return this.isFinished; }
            set { this.isFinished = value; }
        }
        public decimal Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public long Price
        {
            get { return this.price; }
            set { this.price= value; }
        }
        public ServiceBOL() { }
        public ServiceBOL(int ServiceId)
        {
            this.serviceId = ServiceId;
        }
        public ServiceBOL(int ServiceId, int PatientId, short ServiceTypeId, string ServiceTypeTitle, bool IsLaboratory, bool IsFinished, decimal Discount, DateTime Date, long Price)
        {
            this.serviceId = ServiceId;
            this.serviceTypeId = ServiceTypeId;
            this.serviceTypeTitle = ServiceTypeTitle;
            this.isLaboratory = IsLaboratory;
            this.patientId = PatientId;
            this.isFinished= IsFinished;
            this.discount= Discount;
            this.date = Date;
            this.price = Price;
        }
    }
}
