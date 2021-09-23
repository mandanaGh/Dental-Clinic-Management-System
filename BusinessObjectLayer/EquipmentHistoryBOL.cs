using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class EquipmentHistoryBOL
    {
        private long? equipmentHistoryId;
        private short? equipmentId;
        private string equipmentTitle;
        private int count;
        private bool isInput;
        private DateTime date;

        public long? EquipmentHistoryId
        {
            get { return this.equipmentHistoryId; }
            set { this.equipmentHistoryId = value; }
        }
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
        public bool IsInput
        {
            get { return this.isInput; }
            set { this.isInput = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public EquipmentHistoryBOL() { }
        public EquipmentHistoryBOL(long? EquipmentHistoryId, short? EquipmentId, string EquipmentTitle, int Count, bool IsInput, DateTime Date)
        {
            this.equipmentHistoryId = EquipmentHistoryId;
            this.equipmentId = EquipmentId;
            this.equipmentTitle = EquipmentTitle;
            this.count = Count;
            this.isInput = IsInput;
            this.date = Date;
        }
    }
}
