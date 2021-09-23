using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class SecurityBLL
    {
        public void InsertUpdate(SecurityBOL _SecurityBOL)
        {
            SecurityDAL _SecurityDAL = new SecurityDAL(SecurityDOL.QueryStatus.Delete, _SecurityBOL);
            _SecurityDAL.Delete();
            if (_SecurityBOL.AccessId != 1)
            {
                _SecurityDAL = new SecurityDAL(SecurityDOL.QueryStatus.Insert, _SecurityBOL);
                _SecurityDAL.Insert();
            }
        }
        public SecurityBOL[] Select(SecurityBOL _SecurityBOL)
        {
            SecurityDAL _SecurityDAL = new SecurityDAL(SecurityDOL.QueryStatus.Select, _SecurityBOL);
            return _SecurityDAL.Select();
        }
    }
}
