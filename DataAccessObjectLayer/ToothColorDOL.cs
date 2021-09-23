using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class ToothColorDOL
    {
        public const string Select = @"SELECT TOOTHCOLORID, TOOTHCOLORTITLE, DESCRIPTION FROM TOOTHCOLOR";
        public const string Insert = @"INSERT INTO TOOTHCOLOR(TOOTHCOLORID, TOOTHCOLORTITLE,DESCRIPTION) VALUES (@ToothColorId,@ToothColorTitle,@Description)";
        public const string SelectComboBox = @"SELECT TOOTHCOLORID, TOOTHCOLORTITLE FROM TOOTHCOLOR UNION (SELECT ID AS TOOTHCOLORID, TEXT AS TOOTHCOLORTITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM TOOTHCOLOR WHERE TOOTHCOLORID=@ToothColorId";
        public const string Update = "UPDATE TOOTHCOLOR SET TOOTHCOLORTITLE = @ToothColorTitle ,DESCRIPTION = @Description  WHERE TOOTHCOLORID = @ToothColorId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(TOOTHCOLORID),0)+1 AS MAX_TOOTHCOLOR_ID FROM TOOTHCOLOR";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
