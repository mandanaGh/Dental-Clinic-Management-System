using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class RoleBLL
    {
        public RoleBOL[] Select()
        {
            RoleDAL _RoleDAL = new RoleDAL(RoleDOL.QueryStatus.Select);
            return _RoleDAL.Select();
        }
        public void Insert(RoleBOL _RoleBOL)
        {
            RoleDAL _RoleDAL = new RoleDAL(RoleDOL.QueryStatus.Insert, _RoleBOL);
            _RoleDAL.Insert();
        }
        public void Update(RoleBOL _RoleBOL)
        {
            RoleDAL _RoleDAL = new RoleDAL(RoleDOL.QueryStatus.Update, _RoleBOL);
            _RoleDAL.Update();
        }
        public void Delete(RoleBOL _RoleBOL)
        {
            RoleDAL _RoleDAL = new RoleDAL(RoleDOL.QueryStatus.Delete, _RoleBOL);
            _RoleDAL.Delete();
        }
        public short SelectMaxId()
        {
            RoleDAL _RoleDAL = new RoleDAL(RoleDOL.QueryStatus.SelectMaxId);
            return _RoleDAL.SelectMaxId();
        }
        public RoleBOL[] SelectComboBox()
        {
            RoleDAL _RoleDAL = new RoleDAL(RoleDOL.QueryStatus.SelectComboBox);
            return _RoleDAL.SelectComboBox();
        }
    }
}
