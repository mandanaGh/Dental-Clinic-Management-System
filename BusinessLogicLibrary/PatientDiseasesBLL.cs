using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class PatientDiseasesBLL
    {
        public PatientDiseasesBOL[] Select(PatientDiseasesBOL _PatientDiseasesBOL)
        {
            PatientDiseasesDAL _PatientDiseasesDAL = new PatientDiseasesDAL(PatientDiseasesDOL.QueryStatus.Select, _PatientDiseasesBOL);
            return _PatientDiseasesDAL.Select();
        }
        internal void Insert(List<PatientDiseasesBOL> _PatientDiseasesBOLs)
        {
            foreach (PatientDiseasesBOL _PatientDiseasesBOL in _PatientDiseasesBOLs)
            {
                PatientDiseasesDAL _PatientDiseasesDAL = new PatientDiseasesDAL(PatientDiseasesDOL.QueryStatus.Insert, _PatientDiseasesBOL);
                _PatientDiseasesDAL.Insert();
            }
        }
        internal void Delete(List<PatientDiseasesBOL> _PatientDiseasesBOLs)
        {
            PatientDiseasesBOL _PatientDiseasesBOL = new PatientDiseasesBOL(null, _PatientDiseasesBOLs[0].PatientId);
            PatientDiseasesDAL _PatientDiseasesDAL = new PatientDiseasesDAL(PatientDiseasesDOL.QueryStatus.Delete, _PatientDiseasesBOL);
            _PatientDiseasesDAL.Delete();
        }
        internal void Delete(int PatientId)
        {
            PatientDiseasesBOL _PatientDiseasesBOL = new PatientDiseasesBOL(PatientId);
            PatientDiseasesDAL _PatientDiseasesDAL = new PatientDiseasesDAL(PatientDiseasesDOL.QueryStatus.Delete, _PatientDiseasesBOL);
            _PatientDiseasesDAL.Delete();
        }
    }
}