using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class EquipmentBLL
    {
        public EquipmentBOL[] Select()
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.Select);
            return _EquipmentDAL.Select();
        }
        public void Insert(EquipmentBOL _EquipmentBOL)
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.Insert, _EquipmentBOL);
            _EquipmentDAL.Insert();
        }
        public void Update(EquipmentBOL _EquipmentBOL)
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.Update, _EquipmentBOL);
            _EquipmentDAL.Update();
        }
        public void Delete(EquipmentBOL _EquipmentBOL)
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.Delete, _EquipmentBOL);
            _EquipmentDAL.Delete();
        }
        public long? SelectMaxId()
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.SelectMaxId);
            return _EquipmentDAL.SelectMaxId();
        }
        public EquipmentBOL[] SelectShortageAlarm()
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.SelectShortageAlarm);
            return _EquipmentDAL.SelectShortageAlarm();
        }
        public bool HasShortageAlarm()
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.SelectShortageAlarm);
            return _EquipmentDAL.HasShortageAlarm();
        }
        public EquipmentBOL[] SelectExpiredAlarm()
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.SelectExpiredAlarm);
            return _EquipmentDAL.SelectExpiredAlarm();
        }
        public bool HasExpiredAlarm()
        {
            EquipmentDAL _EquipmentDAL = new EquipmentDAL(EquipmentDOL.QueryStatus.SelectExpiredAlarm);
            return _EquipmentDAL.HasExpiredAlarm();
        }  
    }
}
