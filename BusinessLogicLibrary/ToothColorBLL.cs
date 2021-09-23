using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ToothColorBLL
    {
        public ToothColorBOL[] Select()
        {
            ToothColorDAL _ToothColorDAL = new ToothColorDAL(ToothColorDOL.QueryStatus.Select);
            return _ToothColorDAL.Select();
        }
        public void Insert(ToothColorBOL _ToothColorBOL)
        {
            ToothColorDAL _ToothColorDAL = new ToothColorDAL(ToothColorDOL.QueryStatus.Insert, _ToothColorBOL);
            _ToothColorDAL.Insert();
        }
        public void Update(ToothColorBOL _ToothColorBOL)
        {
            ToothColorDAL _ToothColorDAL = new ToothColorDAL(ToothColorDOL.QueryStatus.Update, _ToothColorBOL);
            _ToothColorDAL.Update();
        }
        public void Delete(ToothColorBOL _ToothColorBOL)
        {
            ToothColorDAL _ToothColorDAL = new ToothColorDAL(ToothColorDOL.QueryStatus.Delete, _ToothColorBOL);
            _ToothColorDAL.Delete();
        }
        public long? SelectMaxId()
        {
            ToothColorDAL _ToothColorDAL = new ToothColorDAL(ToothColorDOL.QueryStatus.SelectMaxId);
            return _ToothColorDAL.SelectMaxId();
        }
        public ToothColorBOL[] SelectComboBox()
        {
            ToothColorDAL _ToothColorDAL = new ToothColorDAL(ToothColorDOL.QueryStatus.SelectComboBox);
            return _ToothColorDAL.SelectComboBox();
        }
    }
}
