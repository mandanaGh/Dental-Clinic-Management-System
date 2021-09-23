using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class PatientDiseasesDOL
    {
        public const string Select = @"SELECT DISEASES.DISEASESID, DISEASES.DISEASESTITLE, DISEASES.ISDANGEROUS, DISEASES.DESCRIPTION FROM DISEASES INNER JOIN PATIENTDISEASES ON DISEASES.DISEASESID = PATIENTDISEASES.DISEASESID WHERE (PATIENTDISEASES.PATIENTID = @PATIENTID)";
        public const string Insert = @"INSERT INTO PATIENTDISEASES(PATIENTID,DISEASESID) VALUES (@PATIENTID,@DISEASESID)";
        public const string Delete = "DELETE FROM PATIENTDISEASES WHERE PATIENTID = @PATIENTID";     
        public enum QueryStatus { Select, Insert, Delete};
    }
}
