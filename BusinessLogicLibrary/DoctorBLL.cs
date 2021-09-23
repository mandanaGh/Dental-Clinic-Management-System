using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class DoctorBLL
    {
        public DoctorBOL[] Select()
        {
            DoctorDAL _DoctorDAL = new DoctorDAL(DoctorDOL.QueryStatus.Select);
            return _DoctorDAL.Select();
        }
        public void Insert(DoctorBOL _DoctorBOL)
        {
            DoctorDAL _DoctorDAL = new DoctorDAL(DoctorDOL.QueryStatus.Insert, _DoctorBOL);
            _DoctorDAL.Insert();
        }
        public void Update(DoctorBOL _DoctorBOL)
        {
            DoctorDAL _DoctorDAL = new DoctorDAL(DoctorDOL.QueryStatus.Update, _DoctorBOL);
            _DoctorDAL.Update();
        }
        public void Delete(DoctorBOL _DoctorBOL)
        {
            DoctorDAL _DoctorDAL = new DoctorDAL(DoctorDOL.QueryStatus.Delete, _DoctorBOL);
            _DoctorDAL.Delete();
        }
        public long? SelectMaxId()
        {
            DoctorDAL _DoctorDAL = new DoctorDAL(DoctorDOL.QueryStatus.SelectMaxId);
            return _DoctorDAL.SelectMaxId();
        }
    }
}
