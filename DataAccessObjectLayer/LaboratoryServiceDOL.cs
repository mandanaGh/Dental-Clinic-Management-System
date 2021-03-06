using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class LaboratoryServiceDOL
    {
        public const string Select = @"SELECT TOOTH, DESCRIPTION, LABORATORYSTATEID, DATE, SERVICEID, LABORATORYID,TOOTHCOLORID FROM LABORATORYSERVICE WHERE SERVICEID = @SERVICEID";
        public const string Insert = @"INSERT INTO LABORATORYSERVICE(TOOTH, DESCRIPTION, LABORATORYSTATEID, DATE, SERVICEID, LABORATORYID,TOOTHCOLORID) VALUES(@TOOTH, @DESCRIPTION, @LABORATORYSTATEID, @DATE, @SERVICEID, @LABORATORYID,@TOOTHCOLORID)";
        public const string Delete = "DELETE FROM LABORATORYSERVICE WHERE (SERVICEID = @SERVICEID)";
        public const string Update = "UPDATE LABORATORYSERVICE SET TOOTH = @TOOTH, DESCRIPTION = @DESCRIPTION, LABORATORYSTATEID = @LABORATORYSTATEID, DATE = @DATE ,TOOTHCOLORID = @TOOTHCOLORID WHERE (SERVICEID = @SERVICEID) AND (LABORATORYID = @LABORATORYID)";
        public enum QueryStatus { Select, Insert, Delete, Update };
    }
}
