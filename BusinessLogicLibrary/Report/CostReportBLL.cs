using System;
using System.Collections.Generic;
using System.Text;
using BusinessObjectLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CostReportBLL
    {
        public List<CostReportItemsBOL> Select(CostReportFilterBOL _CostReportBOL)
        {            
            return CostReportDAL.Select(_CostReportBOL);
        }
        public List<CostReportPatientBOL> Select(CostReportFilterBOL _CostReportBOL,bool IsNormal)
        {
            return CostReportDAL.SelectPatient(_CostReportBOL,IsNormal);
        }
    }
}
