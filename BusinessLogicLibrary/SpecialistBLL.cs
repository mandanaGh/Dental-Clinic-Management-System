using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class SpecialistBLL
    {
        public SpecialistBOL[] Select()
        {
            SpecialistDAL _SpecialistDAL = new SpecialistDAL(SpecialistDOL.QueryStatus.Select);
            return _SpecialistDAL.Select();
        }
        public void Insert(SpecialistBOL _SpecialistBOL)
        {
            SpecialistDAL _SpecialistDAL = new SpecialistDAL(SpecialistDOL.QueryStatus.Insert, _SpecialistBOL);
            _SpecialistDAL.Insert();
        }
        public void Update(SpecialistBOL _SpecialistBOL)
        {
            SpecialistDAL _SpecialistDAL = new SpecialistDAL(SpecialistDOL.QueryStatus.Update, _SpecialistBOL);
            _SpecialistDAL.Update();
        }
        public void Delete(SpecialistBOL _SpecialistBOL)
        {
            SpecialistDAL _SpecialistDAL = new SpecialistDAL(SpecialistDOL.QueryStatus.Delete, _SpecialistBOL);
            _SpecialistDAL.Delete();
        }
        public long? SelectMaxId()
        {
            SpecialistDAL _SpecialistDAL = new SpecialistDAL(SpecialistDOL.QueryStatus.SelectMaxId);
            return _SpecialistDAL.SelectMaxId();
        }
        public SpecialistBOL[] SelectComboBox()
        {
            SpecialistDAL _SpecialistDAL = new SpecialistDAL(SpecialistDOL.QueryStatus.SelectComboBox);
            return _SpecialistDAL.SelectComboBox();
        }
    }
}
