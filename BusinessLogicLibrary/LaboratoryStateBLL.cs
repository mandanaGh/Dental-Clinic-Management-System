using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LaboratoryStateBLL
    {
        public LaboratoryStateBOL[] Select()
        {
            LaboratoryStateDAL _LaboratoryStateDAL = new LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus.Select);
            return _LaboratoryStateDAL.Select();
        }
        public void Insert(LaboratoryStateBOL _LaboratoryStateBOL)
        {
            LaboratoryStateDAL _LaboratoryStateDAL = new LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus.Insert, _LaboratoryStateBOL);
            _LaboratoryStateDAL.Insert();
        }
        public void Update(LaboratoryStateBOL _LaboratoryStateBOL)
        {
            LaboratoryStateDAL _LaboratoryStateDAL = new LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus.Update, _LaboratoryStateBOL);
            _LaboratoryStateDAL.Update();
        }
        public void Delete(LaboratoryStateBOL _LaboratoryStateBOL)
        {
            LaboratoryStateDAL _LaboratoryStateDAL = new LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus.Delete, _LaboratoryStateBOL);
            _LaboratoryStateDAL.Delete();
        }
        public long? SelectMaxId()
        {
            LaboratoryStateDAL _LaboratoryStateDAL = new LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus.SelectMaxId);
            return _LaboratoryStateDAL.SelectMaxId();
        }
        public LaboratoryStateBOL[] SelectComboBox()
        {
            LaboratoryStateDAL _LaboratoryStateDAL = new LaboratoryStateDAL(LaboratoryStateDOL.QueryStatus.SelectComboBox);
            return _LaboratoryStateDAL.SelectComboBox();
        }
    }
}
