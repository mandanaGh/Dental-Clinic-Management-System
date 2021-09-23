using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class InsuranceTypeDOL
    {
        public const string Select = @"SELECT INSURANCETYPEID, INSURANCETYPETITLE,[PERCENT], DESCRIPTION FROM INSURANCETYPE";
        public const string SelectComboBox = @"SELECT INSURANCETYPEID, INSURANCETYPETITLE FROM INSURANCETYPE UNION (SELECT ID AS INSURANCETYPEID, TEXT AS INSURANCETYPETITLE FROM NOSELECTION)";
        public const string Insert = @"INSERT INTO INSURANCETYPE(INSURANCETYPEID,INSURANCETYPETITLE,[PERCENT],DESCRIPTION) VALUES (@InsuranceTypeId, @InsuranceTypeTitle,@Percent,@Description)";
        public const string Delete = "DELETE FROM INSURANCETYPE WHERE INSURANCETYPEID=@InsuranceTypeId";
        public const string Update = "UPDATE INSURANCETYPE SET INSURANCETYPETITLE = @InsuranceTypeTitle ,[PERCENT] = @Percent,DESCRIPTION = @Description  WHERE INSURANCETYPEID = @InsuranceTypeId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(INSURANCETYPEID),0)+1 AS MAX_INSURANCETYPE_ID FROM INSURANCETYPE";
        public const string GetPercent = "SELECT [PERCENT] FROM INSURANCETYPE WHERE INSURANCETYPEID = @INSURANCETYPEID";
        public enum QueryStatus { Select, SelectComboBox, Insert, Delete, Update, SelectMaxId, GetPercent };
    }
}
