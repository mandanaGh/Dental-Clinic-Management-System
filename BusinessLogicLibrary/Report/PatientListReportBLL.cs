using System;
using System.Collections.Generic;
using System.Text;
using BusinessObjectLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PatientListReportBLL
    {
        public List<PatientListReportItemsBOL> Select(PatientListReportFilterBOL _PatientListReportBOL)
        {            
            return PatientListReportDAL.Select(_PatientListReportBOL);
        }
        public List<PatientListReportPatientBOL> SelectServiceCount(PatientListReportFilterBOL _PatientListReportBOL)
        {
            return PatientListReportDAL.SelectServiceCount(_PatientListReportBOL);
        }
    }
}
