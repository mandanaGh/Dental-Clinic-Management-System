using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class ServiceHistoryDOL
    {
        public const string Select = @"SELECT DOCTOR.FIRSTNAME, DOCTOR.LASTNAME, SERVICEHISTORY.SERVICEHISTORYID, SERVICEID , SERVICEHISTORY.DATE, SERVICEHISTORY.DOCTORID, SERVICEHISTORY.DESCRIPTION, TOOTH FROM SERVICEHISTORY INNER JOIN DOCTOR ON SERVICEHISTORY.DOCTORID = DOCTOR.DOCTORID WHERE (SERVICEID = @SERVICEID)";
        public const string SelectCount = "SELECT COUNT(*) AS COUNT FROM ({0}) AS COUNTTBL";
        public const string Insert = @"INSERT INTO SERVICEHISTORY (DATE, DOCTORID, DESCRIPTION, SERVICEID, TOOTH) VALUES( @DATE, @DOCTORID, @DESCRIPTION, @SERVICEID , @TOOTH)";
        public const string Delete = "DELETE FROM SERVICEHISTORY WHERE SERVICEHISTORYID=@SERVICEHISTORYID";
        public const string Update = "UPDATE SERVICEHISTORY SET DATE = @DATE, DOCTORID = @DOCTORID, DESCRIPTION = @DESCRIPTION , TOOTH = @TOOTH WHERE SERVICEHISTORYID = @SERVICEHISTORYID";
        public enum QueryStatus { Select, SelectCount, Insert, Delete, Update };
    }
}
