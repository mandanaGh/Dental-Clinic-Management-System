using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class LaboratoryStateBOL
    {
        private short? laboratoryStateId;
        private string laboratoryStateTitle;
        private string description;

        public short? LaboratoryStateId
        {
            get { return this.laboratoryStateId; }
            set { this.laboratoryStateId = value; }
        }
        public string LaboratoryStateTitle
        {
            get { return this.laboratoryStateTitle; }
            set { this.laboratoryStateTitle = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public LaboratoryStateBOL() { }
        public LaboratoryStateBOL(short? LaboratoryStateId, string LaboratoryStateTitle)
        {
            this.laboratoryStateId = LaboratoryStateId;
            this.laboratoryStateTitle = LaboratoryStateTitle;         
        }
        public LaboratoryStateBOL(short? LaboratoryStateId, string LaboratoryStateTitle, string Description)
        {
            this.laboratoryStateId = LaboratoryStateId;
            this.laboratoryStateTitle = LaboratoryStateTitle;
            this.description = Description;
        }
    }
}
