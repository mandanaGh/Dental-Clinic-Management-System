using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class JobBLL
    {
        public JobBOL[] Select()
        {
            JobDAL _JobDAL = new JobDAL(JobDOL.QueryStatus.Select);
            return _JobDAL.Select();
        }
        public void Insert(JobBOL _JobBOL)
        {
            JobDAL _JobDAL = new JobDAL(JobDOL.QueryStatus.Insert, _JobBOL);
            _JobDAL.Insert();
        }
        public void Update(JobBOL _JobBOL)
        {
            JobDAL _JobDAL = new JobDAL(JobDOL.QueryStatus.Update, _JobBOL);
            _JobDAL.Update();
        }
        public void Delete(JobBOL _JobBOL)
        {
            JobDAL _JobDAL = new JobDAL(JobDOL.QueryStatus.Delete, _JobBOL);
            _JobDAL.Delete();
        }
        public long? SelectMaxId()
        {
            JobDAL _JobDAL = new JobDAL(JobDOL.QueryStatus.SelectMaxId);
            return _JobDAL.SelectMaxId();
        }
        public JobBOL[] SelectComboBox()
        {
            JobDAL _JobDAL = new JobDAL(JobDOL.QueryStatus.SelectComboBox);
            return _JobDAL.SelectComboBox();
        }
    }
}
