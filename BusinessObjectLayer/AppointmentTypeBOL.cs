using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class AppointmentTypeBOL
    {
        private short? appointmentTypeId;
        private string appointmentTypeTitle;
        private string description;

        public short? AppointmentTypeId
        {
            get { return this.appointmentTypeId; }
            set { this.appointmentTypeId = value; }
        }
        public string AppointmentTypeTitle
        {
            get { return this.appointmentTypeTitle; }
            set { this.appointmentTypeTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public AppointmentTypeBOL() { }
        public AppointmentTypeBOL(short? AppointmentTypeId, string AppointmentTypeTitle, string Description)
        {
            this.appointmentTypeId = AppointmentTypeId;
            this.appointmentTypeTitle = AppointmentTypeTitle;
            this.description = Description;
        }
    }
}
