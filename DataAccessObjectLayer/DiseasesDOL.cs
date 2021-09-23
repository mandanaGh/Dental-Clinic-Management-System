using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class DiseasesDOL
    {
        public const string Select = @"SELECT DISEASESID, DISEASESTITLE,ISDANGEROUS ,DESCRIPTION  FROM DISEASES";
        public const string SelectByPatient = @"SELECT DISEASES.DISEASESID, DISEASES.DISEASESTITLE, DISEASES.ISDANGEROUS, DISEASES.DESCRIPTION FROM DISEASES INNER JOIN PATIENTDISEASES ON DISEASES.DISEASESID = PATIENTDISEASES.DISEASESID WHERE (PATIENTDISEASES.PATIENTID = @PATIENTID)";
        public const string Insert = @"INSERT INTO DISEASES(DISEASESID,DISEASESTITLE,ISDANGEROUS,DESCRIPTION) VALUES (@DiseasesId,@DiseasesTitle,@IsDangerous,@Description)";
        public const string Delete = "DELETE FROM DISEASES WHERE DISEASESID=@DiseasesId";
        public const string Update = "UPDATE DISEASES SET DISEASESTITLE = @DiseasesTitle ,ISDANGEROUS = @IsDangerous,DESCRIPTION = @Description  WHERE DISEASESID = @DiseasesId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(DISEASESID),0)+1 AS MAX_DISEASES_ID FROM DISEASES";
        public enum QueryStatus { Select, SelectByPatient, Insert, Delete, Update, SelectMaxId };
    }
}
