using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class LaboratoryServiceBLL
    {
        public LaboratoryServiceBOL Select(int ServiceId)
        {
            LaboratoryServiceDAL _LaboratoryServiceDAL = new LaboratoryServiceDAL(LaboratoryServiceDOL.QueryStatus.Select);
            return _LaboratoryServiceDAL.Select(ServiceId);
        }
        public void Insert(LaboratoryServiceBOL _LaboratoryServiceBOL)
        {
            LaboratoryServiceDAL _LaboratoryServiceDAL = new LaboratoryServiceDAL(LaboratoryServiceDOL.QueryStatus.Insert, _LaboratoryServiceBOL);
            _LaboratoryServiceDAL.Insert();
        }
        public void Delete(LaboratoryServiceBOL _LaboratoryServiceBOL)
        {
            LaboratoryServiceDAL _LaboratoryServiceDAL = new LaboratoryServiceDAL(LaboratoryServiceDOL.QueryStatus.Delete, _LaboratoryServiceBOL);
            _LaboratoryServiceDAL.Delete();
        }
        public void InsertUpdate(LaboratoryServiceBOL _LaboratoryServiceBOL)
        {
            Delete(_LaboratoryServiceBOL);
            Insert(_LaboratoryServiceBOL);
        }
    }
}
