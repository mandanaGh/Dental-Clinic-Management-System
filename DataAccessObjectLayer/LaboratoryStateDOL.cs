using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class LaboratoryStateDOL
    {
        public const string Select = @"SELECT LABORATORYSTATEID, LABORATORYSTATETITLE, DESCRIPTION FROM LABORATORYSTATE";
        public const string Insert = @"INSERT INTO LABORATORYSTATE(LABORATORYSTATEID, LABORATORYSTATETITLE,DESCRIPTION) VALUES (@LaboratoryStateId,@LaboratoryStateTitle,@Description)";
        public const string SelectComboBox = @"SELECT LABORATORYSTATEID, LABORATORYSTATETITLE FROM LABORATORYSTATE UNION (SELECT ID AS LABORATORYSTATEID, TEXT AS LABORATORYSTATETITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM LABORATORYSTATE WHERE LABORATORYSTATEID=@LaboratoryStateId";
        public const string Update = "UPDATE LABORATORYSTATE SET LABORATORYSTATETITLE = @LaboratoryStateTitle ,DESCRIPTION = @Description  WHERE LABORATORYSTATEID = @LaboratoryStateId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(LABORATORYSTATEID),0)+1 AS MAX_LABORATORYSTATE_ID FROM LABORATORYSTATE";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
