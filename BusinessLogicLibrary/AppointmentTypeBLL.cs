using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class AppointmentTypeBLL
    {
        public AppointmentTypeBOL[] Select()
        {
            AppointmentTypeDAL _AppointmentTypeDAL = new AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus.Select);
            return _AppointmentTypeDAL.Select();
        }
        public void Insert(AppointmentTypeBOL _AppointmentTypeBOL)
        {
            AppointmentTypeDAL _AppointmentTypeDAL = new AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus.Insert, _AppointmentTypeBOL);
            _AppointmentTypeDAL.Insert();
        }
        public void Update(AppointmentTypeBOL _AppointmentTypeBOL)
        {
            AppointmentTypeDAL _AppointmentTypeDAL = new AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus.Update, _AppointmentTypeBOL);
            _AppointmentTypeDAL.Update();
        }
        public void Delete(AppointmentTypeBOL _AppointmentTypeBOL)
        {
            AppointmentTypeDAL _AppointmentTypeDAL = new AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus.Delete, _AppointmentTypeBOL);
            _AppointmentTypeDAL.Delete();
        }
        public long? SelectMaxId()
        {
            AppointmentTypeDAL _AppointmentTypeDAL = new AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus.SelectMaxId);
            return _AppointmentTypeDAL.SelectMaxId();
        }
        public AppointmentTypeBOL[] SelectComboBox()
        {
            AppointmentTypeDAL _AppointmentTypeDAL = new AppointmentTypeDAL(AppointmentTypeDOL.QueryStatus.SelectComboBox);
            return _AppointmentTypeDAL.SelectComboBox();
        }
    }
}
