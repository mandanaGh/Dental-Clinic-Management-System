using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class RecieveBOL
    {
        private int recieveId;
        private int patientId;        
        private bool isInput;
        private long price;
        private DateTime date;

        public int RecieveId
        {
            get { return this.recieveId; }
            set { this.recieveId = value; }
        }
        public int PatientId
        {
            get { return this.patientId; }
            set { this.patientId = value; }
        } 
        public bool IsInput
        {
            get { return this.isInput; }
            set { this.isInput = value; }
        }
        public long Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public RecieveBOL() { }
        public RecieveBOL(int RecieveId, int PatientId, bool IsInput, long Price, DateTime Date)
        {
            this.recieveId = RecieveId;           
            this.patientId = PatientId;
            this.isInput= IsInput;
            this.price= Price;
            this.date = Date;
        }
    }
}
