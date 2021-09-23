using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class RecieveDOL
    {
        public const string Select = @"SELECT RECIEVEID, DATE, PRICE, ISINPUT ,PATIENTID FROM RECIEVE WHERE PATIENTID=@PATIENTID";
        public const string Insert = @"INSERT INTO RECIEVE ( DATE, PRICE, ISINPUT, PATIENTID) VALUES( @DATE, @PRICE, @ISINPUT, @PATIENTID)";
        public const string Delete = "DELETE FROM RECIEVE WHERE RECIEVEID=@RECIEVEID";
        public const string Update = "UPDATE RECIEVE SET DATE = @DATE, PRICE = @PRICE, ISINPUT = @ISINPUT WHERE RECIEVEID = @RecieveId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(RECIEVEID),0)+1 AS MAX_RECIEVE_ID FROM RECIEVE";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
