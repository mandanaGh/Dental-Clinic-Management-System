using System;
using System.Collections.Generic;
using System.Text;
using BusinessObjectLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PrescriptionListReportBLL
    {
        public List<PrescriptionListReportItemsBOL> Select(PrescriptionListReportFilterBOL _PrescriptionListReportBOL)
        {            
            return PrescriptionListReportDAL.Select(_PrescriptionListReportBOL);
        }
    }
}
