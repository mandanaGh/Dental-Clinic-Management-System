using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ServiceHistoryBLL
    {
        public ServiceHistoryBOL[] Select(int ServiceId)
        {
            ServiceHistoryDAL _ServiceHistoryDAL = new ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus.Select);
            return _ServiceHistoryDAL.Select(ServiceId);
        }
        public int SelectCount(int ServiceId)
        {
            ServiceHistoryDAL _ServiceHistoryDAL = new ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus.SelectCount);
            return _ServiceHistoryDAL.SelectCount(ServiceId);
        }
        public void Insert(ServiceHistoryBOL _ServiceHistoryBOL)
        {
            ServiceHistoryDAL _ServiceHistoryDAL = new ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus.Insert, _ServiceHistoryBOL);
            _ServiceHistoryDAL.Insert();
        }
        public void Update(ServiceHistoryBOL _ServiceHistoryBOL)
        {
            ServiceHistoryDAL _ServiceHistoryDAL = new ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus.Update, _ServiceHistoryBOL);
            _ServiceHistoryDAL.Update();
        }
        public void Delete(ServiceHistoryBOL _ServiceHistoryBOL)
        {
            ServiceHistoryDAL _ServiceHistoryDAL = new ServiceHistoryDAL(ServiceHistoryDOL.QueryStatus.Delete, _ServiceHistoryBOL);
            _ServiceHistoryDAL.Delete();
        }
    }
}
