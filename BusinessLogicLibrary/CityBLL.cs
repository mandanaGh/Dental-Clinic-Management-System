using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class CityBLL
    {
        public CityBOL[] Select()
        {
            CityDAL _CityDAL = new CityDAL(CityDOL.QueryStatus.Select);
            return _CityDAL.Select();
        }
        public void Insert(CityBOL _CityBOL)
        {
            CityDAL _CityDAL = new CityDAL(CityDOL.QueryStatus.Insert, _CityBOL);
            _CityDAL.Insert();
        }
        public void Update(CityBOL _CityBOL)
        {
            CityDAL _CityDAL = new CityDAL(CityDOL.QueryStatus.Update, _CityBOL);
            _CityDAL.Update();
        }
        public void Delete(CityBOL _CityBOL)
        {
            CityDAL _CityDAL = new CityDAL(CityDOL.QueryStatus.Delete, _CityBOL);
            _CityDAL.Delete();
        }
        public long? SelectMaxId()
        {
            CityDAL _CityDAL = new CityDAL(CityDOL.QueryStatus.SelectMaxId);
            return _CityDAL.SelectMaxId();
        }
        public CityBOL[] SelectComboBox()
        {
            CityDAL _CityDAL = new CityDAL(CityDOL.QueryStatus.SelectComboBox);
            return _CityDAL.SelectComboBox();
        }
    }
}
