using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
    public class PatientDiseasesBOL
    {
        private short? diseasesId;
        private int? patientId;

        public short? DiseasesId
        {
            get { return this.diseasesId; }
            set { this.diseasesId = value; }
        }
        public int? PatientId
        {
            get { return this.patientId; }
            set { this.patientId = value; }
        }
        public PatientDiseasesBOL() { }
        public PatientDiseasesBOL(int? PatientId)
        {
            this.patientId = PatientId;
        }
        public PatientDiseasesBOL(short? DiseasesId, int? PatientId)
        {
            this.diseasesId = DiseasesId;
            this.patientId = PatientId;
        }
    }
}
