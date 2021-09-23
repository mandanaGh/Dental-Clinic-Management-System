using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class SpecialistDOL
    {
        public const string Select = @"SELECT SPECIALISTID, SPECIALISTTITLE, DESCRIPTION FROM SPECIALIST";
        public const string Insert = @"INSERT INTO SPECIALIST(SPECIALISTID, SPECIALISTTITLE,DESCRIPTION) VALUES (@SpecialistId,@SpecialistTitle,@Description)";
        public const string SelectComboBox = @"SELECT SPECIALISTID, SPECIALISTTITLE FROM SPECIALIST UNION (SELECT ID AS SPECIALISTID, TEXT AS SPECIALISTTITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM SPECIALIST WHERE SPECIALISTID=@SpecialistId";
        public const string Update = "UPDATE SPECIALIST SET SPECIALISTTITLE = @SpecialistTitle ,DESCRIPTION = @Description  WHERE SPECIALISTID = @SpecialistId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(SPECIALISTID),0)+1 AS MAX_SPECIALIST_ID FROM SPECIALIST";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
