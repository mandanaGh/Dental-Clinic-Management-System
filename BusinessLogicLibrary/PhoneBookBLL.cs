using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class PhoneBookBLL
    {
        public PhoneBookBOL[] Select()
        {
            PhoneBookDAL _PhoneBookDAL = new PhoneBookDAL(PhoneBookDOL.QueryStatus.Select);
            return _PhoneBookDAL.Select();
        }
        public void Insert(PhoneBookBOL _PhoneBookBOL)
        {
            PhoneBookDAL _PhoneBookDAL = new PhoneBookDAL(PhoneBookDOL.QueryStatus.Insert, _PhoneBookBOL);
            _PhoneBookDAL.Insert();
        }
        public void Update(PhoneBookBOL _PhoneBookBOL)
        {
            PhoneBookDAL _PhoneBookDAL = new PhoneBookDAL(PhoneBookDOL.QueryStatus.Update, _PhoneBookBOL);
            _PhoneBookDAL.Update();
        }
        public void Delete(PhoneBookBOL _PhoneBookBOL)
        {
            PhoneBookDAL _PhoneBookDAL = new PhoneBookDAL(PhoneBookDOL.QueryStatus.Delete, _PhoneBookBOL);
            _PhoneBookDAL.Delete();
        }
        public int SelectMaxId()
        {
            PhoneBookDAL _PhoneBookDAL = new PhoneBookDAL(PhoneBookDOL.QueryStatus.SelectMaxId);
            return _PhoneBookDAL.SelectMaxId();
        }
    }
}
