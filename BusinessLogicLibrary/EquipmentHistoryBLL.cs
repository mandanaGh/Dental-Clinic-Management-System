using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class EquipmentHistoryBLL
    {
        public EquipmentHistoryBOL[] Select()
        {
            EquipmentHistoryDAL _EquipmentHistoryDAL = new EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus.Select);
            return _EquipmentHistoryDAL.Select();
        }
        public void Insert(EquipmentHistoryBOL _EquipmentHistoryBOL)
        {
            EquipmentHistoryDAL _EquipmentHistoryDAL = new EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus.Insert, _EquipmentHistoryBOL);
            _EquipmentHistoryDAL.Insert();
        }
        public void Update(EquipmentHistoryBOL _EquipmentHistoryBOL)
        {
            EquipmentHistoryDAL _EquipmentHistoryDAL = new EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus.Update, _EquipmentHistoryBOL);
            _EquipmentHistoryDAL.Update();
        }
        public void Delete(EquipmentHistoryBOL _EquipmentHistoryBOL)
        {
            EquipmentHistoryDAL _EquipmentHistoryDAL = new EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus.Delete, _EquipmentHistoryBOL);
            _EquipmentHistoryDAL.Delete();
        }
        public long? SelectMaxId()
        {
            EquipmentHistoryDAL _EquipmentHistoryDAL = new EquipmentHistoryDAL(EquipmentHistoryDOL.QueryStatus.SelectMaxId);
            return _EquipmentHistoryDAL.SelectMaxId();
        }
    }
}
