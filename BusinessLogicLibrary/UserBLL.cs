using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BusinessLogicLayer
{
    using DataAccessLayer;
    using BusinessObjectLayer;
    using DataObjectLayer;
    using DataConvertor;
    using BusinessLogicLayer;

    public class UserBLL
    {
        public UserBLL()
        {
        }
        public void LockUser(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.LockUser, _UserBOL);
            _UserDAL.LockUser();
        }
        public bool CheckUserValid(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.CheckUserValid, _UserBOL);
            return _UserDAL.CheckUserValid();
        }
        public bool CheckUserLock(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.CheckUserLock, _UserBOL);
            return _UserDAL.CheckUserLock();
        }
        public void ChangePassword(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.ChangePassword, _UserBOL);
            _UserDAL.ChangePassword();
        }
        public void LoadUserProfile(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.LoadUserProfile, _UserBOL);
            DataTable table = _UserDAL.LoadUserProfile();
            if (table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                short userID = Convert.ToInt16(row["USERID"]);
                string userName = DataConvertor.ConvertToString(row["USERNAME"]);
                short roleId = Convert.ToInt16(row["ROLEID"]);
                string description = DataConvertor.ConvertToString(row["DESCRIPTION"]);
                UserProfile.Load(userID, userName, null, null, roleId, description);
            }
        }
        public UserBOL[] Select()
        {
            UserDAL _UserDALs = new UserDAL(UserDOL.QueryStatus.Select);
            return _UserDALs.Select();
        }
        public void Insert(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.Insert, _UserBOL);
            _UserDAL.Insert();
        }
        public void Update(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.Update, _UserBOL);
            _UserDAL.Update();
        }
        public void Delete(UserBOL _UserBOL)
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.Delete, _UserBOL);
            _UserDAL.Delete();
        }
        public long? SelectMaxId()
        {
            UserDAL _UserDAL = new UserDAL(UserDOL.QueryStatus.SelectMaxId);
            return _UserDAL.SelectMaxId();
        }
    }

}