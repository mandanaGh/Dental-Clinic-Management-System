using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class LaboratoryDOL
    {
        public const string Select = @"SELECT LABORATORYID, LABORATORYTITLE, ADDRESS , TEL FROM LABORATORY";
        public const string Insert = @"INSERT INTO LABORATORY(LABORATORYID, LABORATORYTITLE,ADDRESS,TEL) VALUES (@LaboratoryId,@LaboratoryTitle,@Address,@Tel)";
        public const string SelectComboBox = @"SELECT LABORATORYID, LABORATORYTITLE FROM LABORATORY UNION (SELECT ID AS LABORATORYID, TEXT AS LABORATORYTITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM LABORATORY WHERE LABORATORYID=@LaboratoryId";
        public const string Update = "UPDATE LABORATORY SET LABORATORYTITLE = @LaboratoryTitle ,ADDRESS = @Address , TEL = @Tel  WHERE LABORATORYID = @LaboratoryId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(LABORATORYID),0)+1 AS MAX_LABORATORY_ID FROM LABORATORY";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
