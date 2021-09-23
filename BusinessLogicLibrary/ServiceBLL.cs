using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ServiceBLL
    {
        public ServiceBOL[] Select(int PatientId)
        {
            ServiceDAL _ServiceDAL = new ServiceDAL(ServiceDOL.QueryStatus.Select);
            return _ServiceDAL.Select(PatientId);
        }
        public void Insert(ServiceBOL _ServiceBOL)
        {
            ServiceDAL _ServiceDAL = new ServiceDAL(ServiceDOL.QueryStatus.Insert, _ServiceBOL);
            _ServiceDAL.Insert();
        }
        public void Update(ServiceBOL _ServiceBOL)
        {
            ServiceDAL _ServiceDAL = new ServiceDAL(ServiceDOL.QueryStatus.Update, _ServiceBOL);
            _ServiceDAL.Update();
        }
        public void Delete(ServiceBOL _ServiceBOL)
        {
            ServiceDAL _ServiceDAL = new ServiceDAL(ServiceDOL.QueryStatus.Delete, _ServiceBOL);
            _ServiceDAL.Delete();
        }
        public long? SelectMaxId()
        {
            ServiceDAL _ServiceDAL = new ServiceDAL(ServiceDOL.QueryStatus.SelectMaxId);
            return _ServiceDAL.SelectMaxId();
        }       
    }
}
