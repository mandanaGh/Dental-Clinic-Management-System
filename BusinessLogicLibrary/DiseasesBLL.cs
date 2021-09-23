using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class DiseasesBLL
    {
        public DiseasesBOL[] Select()
        {
            DiseasesDAL _DiseasesDAL = new DiseasesDAL(DiseasesDOL.QueryStatus.Select);
            return _DiseasesDAL.Select();
        }
        public void Insert(DiseasesBOL _DiseasesBOL)
        {
            DiseasesDAL _DiseasesDAL = new DiseasesDAL(DiseasesDOL.QueryStatus.Insert, _DiseasesBOL);
            _DiseasesDAL.Insert();
        }
        public void Update(DiseasesBOL _DiseasesBOL)
        {
            DiseasesDAL _DiseasesDAL = new DiseasesDAL(DiseasesDOL.QueryStatus.Update, _DiseasesBOL);
            _DiseasesDAL.Update();
        }
        public void Delete(DiseasesBOL _DiseasesBOL)
        {
            DiseasesDAL _DiseasesDAL = new DiseasesDAL(DiseasesDOL.QueryStatus.Delete, _DiseasesBOL);
            _DiseasesDAL.Delete();
        }
        public long? SelectMaxId()
        {
            DiseasesDAL _DiseasesDAL = new DiseasesDAL(DiseasesDOL.QueryStatus.SelectMaxId);
            return _DiseasesDAL.SelectMaxId();
        }
    }
}
