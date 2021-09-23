using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class EquipmentBOL
    {
        private short? equipmentId;
        private string equipmentTitle;
        private int count;
        private DateTime expiredDate;
        private string description;

        public short? EquipmentId
        {
            get { return this.equipmentId; }
            set { this.equipmentId = value; }
        }
        public string EquipmentTitle
        {
            get { return this.equipmentTitle; }
            set { this.equipmentTitle = value; }
        }
        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
        public DateTime ExpiredDate
        {
            get { return this.expiredDate; }
            set { this.expiredDate= value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public EquipmentBOL() { }
        public EquipmentBOL(short? EquipmentId, string EquipmentTitle, int Count, DateTime ExpiredDate, string Description)
        {
            this.equipmentId = EquipmentId;
            this.equipmentTitle = EquipmentTitle;
            this.count = Count;
            this.expiredDate = ExpiredDate;
            this.description = Description;
        }
        public EquipmentBOL(short EquipmentId, string EquipmentTitle)
        {
            this.equipmentId = EquipmentId;
            this.equipmentTitle = EquipmentTitle;      
        }
    }
}
