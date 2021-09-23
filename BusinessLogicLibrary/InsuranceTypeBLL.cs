using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class InsuranceTypeBLL
    {
        public InsuranceTypeBOL[] Select()
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.Select);
            return _InsuranceTypeDAL.Select();
        }
        public InsuranceTypeBOL[] SelectComboBox()
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.SelectComboBox);
            return _InsuranceTypeDAL.SelectComboBox();
        }
        public void Insert(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.Insert, _InsuranceTypeBOL);
            _InsuranceTypeDAL.Insert();
        }
        public void Update(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.Update, _InsuranceTypeBOL);
            _InsuranceTypeDAL.Update();
        }
        public void Delete(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.Delete, _InsuranceTypeBOL);
            _InsuranceTypeDAL.Delete();
        }

        public long? SelectMaxId()
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.SelectMaxId);
            return _InsuranceTypeDAL.SelectMaxId();
        }
        public decimal GetPercent(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            InsuranceTypeDAL _InsuranceTypeDAL = new InsuranceTypeDAL(InsuranceTypeDOL.QueryStatus.GetPercent, _InsuranceTypeBOL);
            return _InsuranceTypeDAL.GetPercent();
        }
    }
}
