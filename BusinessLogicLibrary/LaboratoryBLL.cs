using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LaboratoryBLL
    {
        public LaboratoryBOL[] Select()
        {
            LaboratoryDAL _LaboratoryDAL = new LaboratoryDAL(LaboratoryDOL.QueryStatus.Select);
            return _LaboratoryDAL.Select();
        }
        public void Insert(LaboratoryBOL _LaboratoryBOL)
        {
            LaboratoryDAL _LaboratoryDAL = new LaboratoryDAL(LaboratoryDOL.QueryStatus.Insert, _LaboratoryBOL);
            _LaboratoryDAL.Insert();
        }
        public void Update(LaboratoryBOL _LaboratoryBOL)
        {
            LaboratoryDAL _LaboratoryDAL = new LaboratoryDAL(LaboratoryDOL.QueryStatus.Update, _LaboratoryBOL);
            _LaboratoryDAL.Update();
        }
        public void Delete(LaboratoryBOL _LaboratoryBOL)
        {
            LaboratoryDAL _LaboratoryDAL = new LaboratoryDAL(LaboratoryDOL.QueryStatus.Delete, _LaboratoryBOL);
            _LaboratoryDAL.Delete();
        }
        public long? SelectMaxId()
        {
            LaboratoryDAL _LaboratoryDAL = new LaboratoryDAL(LaboratoryDOL.QueryStatus.SelectMaxId);
            return _LaboratoryDAL.SelectMaxId();
        }
        public LaboratoryBOL[] SelectComboBox()
        {
            LaboratoryDAL _LaboratoryDAL = new LaboratoryDAL(LaboratoryDOL.QueryStatus.SelectComboBox);
            return _LaboratoryDAL.SelectComboBox();
        }
    }
}
