using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class RecieveBLL
    {
        public RecieveBOL[] Select(int PatientId)
        {
            RecieveDAL _RecieveDAL = new RecieveDAL(RecieveDOL.QueryStatus.Select);
            return _RecieveDAL.Select(PatientId);
        }
        public void Insert(RecieveBOL _RecieveBOL)
        {
            RecieveDAL _RecieveDAL = new RecieveDAL(RecieveDOL.QueryStatus.Insert, _RecieveBOL);
            _RecieveDAL.Insert();
        }
        public void Update(RecieveBOL _RecieveBOL)
        {
            RecieveDAL _RecieveDAL = new RecieveDAL(RecieveDOL.QueryStatus.Update, _RecieveBOL);
            _RecieveDAL.Update();
        }
        public void Delete(RecieveBOL _RecieveBOL)
        {
            RecieveDAL _RecieveDAL = new RecieveDAL(RecieveDOL.QueryStatus.Delete, _RecieveBOL);
            _RecieveDAL.Delete();
        }
        public long? SelectMaxId()
        {
            RecieveDAL _RecieveDAL = new RecieveDAL(RecieveDOL.QueryStatus.SelectMaxId);
            return _RecieveDAL.SelectMaxId();
        }
    }
}
