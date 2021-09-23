using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class DiseasesBOL
    {
        private short? diseasesId;
        private string diseasesTitle;
        private bool isDangerous;
        private string description;

        public short? DiseasesId
        {
            get { return this.diseasesId; }
            set { this.diseasesId = value; }
        }
        public string DiseasesTitle
        {
            get { return this.diseasesTitle; }
            set { this.diseasesTitle = value; }
        }
        public bool IsDangerous
        {
            get { return this.isDangerous; }
            set { this.isDangerous = value; }
        }        
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public DiseasesBOL() { }
        public DiseasesBOL(short? DiseasesId, string DiseasesTitle, bool IsDangerous, string Description)
        {
            this.diseasesId = DiseasesId;
            this.diseasesTitle = DiseasesTitle;
            this.isDangerous = IsDangerous;
            this.description = Description;
        }
    }
}
