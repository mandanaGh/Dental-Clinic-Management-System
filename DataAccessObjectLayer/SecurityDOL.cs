using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class SecurityDOL
    {
        public const string Select = @"SELECT PAGE.PAGENAME AS PAGETITLE,PAGE.PAGEID, ISNULL(SECURITY.ACCESSID, 1) AS ACCESSID, ISNULL(ACCESS.ACCESSNAME, N'بدون دسترسی') AS ACCESSTITLE FROM ACCESS INNER JOIN SECURITY ON ACCESS.ACCESSID = SECURITY.ACCESSID RIGHT OUTER JOIN PAGE ON SECURITY.PAGEID = PAGE.PAGEID AND SECURITY.ROLEID = @ROLEID";
        public const string Insert = @"INSERT INTO SECURITY(PAGEID, ACCESSID, ROLEID) VALUES (@PAGEID, @ACCESSID, @ROLEID)";        
        public const string Delete = @"DELETE FROM SECURITY WHERE  ROLEID = @ROLEID AND PAGEID = @PAGEID";        
        public enum QueryStatus { Select, Insert, Delete};
    }
}
