using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ServiceTypeBLL
    {
        public ServiceTypeBOL[] Select()
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.Select);
            return _ServiceTypeDAL.Select();
        }
        public void Insert(ServiceTypeBOL _ServiceTypeBOL)
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.Insert, _ServiceTypeBOL);
            _ServiceTypeDAL.Insert();
        }
        public void Update(ServiceTypeBOL _ServiceTypeBOL)
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.Update, _ServiceTypeBOL);
            _ServiceTypeDAL.Update();
        }
        public void Delete(ServiceTypeBOL _ServiceTypeBOL)
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.Delete, _ServiceTypeBOL);
            _ServiceTypeDAL.Delete();
        }
        public long? SelectMaxId()
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.SelectMaxId);
            return _ServiceTypeDAL.SelectMaxId();
        }
        public ServiceTypeBOL[] SelectComboBox()
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.SelectComboBox);
            return _ServiceTypeDAL.SelectComboBox();
        }
        public ServiceTypeBOL[] SelectComboBoxByIsLaboratory(ServiceTypeBOL _ServiceTypeBOL)
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.SelectComboBoxByIsLaboratory, _ServiceTypeBOL);
            return _ServiceTypeDAL.SelectComboBoxByIsLaboratory();
        }
        public long SelectServiceTypePrice(ServiceTypeBOL _ServiceTypeBOL)
        {
            ServiceTypeDAL _ServiceTypeDAL = new ServiceTypeDAL(ServiceTypeDOL.QueryStatus.SelectServiceTypePrice, _ServiceTypeBOL);
            return _ServiceTypeDAL.SelectServiceTypePrice();
        }
    }
}
