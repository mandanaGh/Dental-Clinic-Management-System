using System;
using System.Collections.Generic;
using System.Text;
using BusinessObjectLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class LaboratoryReportBLL
    {
        public List<LaboratoryReportItemsBOL> Select(LaboratoryReportFilterBOL _LaboratoryReportBOL)
        {            
            return LaboratoryReportDAL.Select(_LaboratoryReportBOL);
        }       
    }
}
