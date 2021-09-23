using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class SubjectBLL
    {
        public SubjectBOL[] Select()
        {
            SubjectDAL _SubjectDAL = new SubjectDAL(SubjectDOL.QueryStatus.Select);
            return _SubjectDAL.Select();
        }
        public void Insert(SubjectBOL _SubjectBOL)
        {
            SubjectDAL _SubjectDAL = new SubjectDAL(SubjectDOL.QueryStatus.Insert, _SubjectBOL);
            _SubjectDAL.Insert();
        }
        public void Update(SubjectBOL _SubjectBOL)
        {
            SubjectDAL _SubjectDAL = new SubjectDAL(SubjectDOL.QueryStatus.Update, _SubjectBOL);
            _SubjectDAL.Update();
        }
        public void Delete(SubjectBOL _SubjectBOL)
        {
            SubjectDAL _SubjectDAL = new SubjectDAL(SubjectDOL.QueryStatus.Delete, _SubjectBOL);
            _SubjectDAL.Delete();
        }
        public long? SelectMaxId()
        {
            SubjectDAL _SubjectDAL = new SubjectDAL(SubjectDOL.QueryStatus.SelectMaxId);
            return _SubjectDAL.SelectMaxId();
        }
        public SubjectBOL[] SelectComboBox()
        {
            SubjectDAL _SubjectDAL = new SubjectDAL(SubjectDOL.QueryStatus.SelectComboBox);
            return _SubjectDAL.SelectComboBox();
        }
    }
}
