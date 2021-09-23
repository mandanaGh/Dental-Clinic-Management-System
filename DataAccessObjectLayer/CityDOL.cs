using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class CityDOL
    {
        public const string Select = @"SELECT CITYID, CITYTITLE, DESCRIPTION FROM CITY";
        public const string Insert = @"INSERT INTO CITY(CITYID, CITYTITLE,DESCRIPTION) VALUES (@CityId,@CityTitle,@Description)";
        public const string SelectComboBox = @"SELECT CITYID, CITYTITLE FROM CITY UNION (SELECT ID AS CITYID, TEXT AS CITYTITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM CITY WHERE CITYID=@CityId";
        public const string Update = "UPDATE CITY SET CITYTITLE = @CityTitle ,DESCRIPTION = @Description  WHERE CITYID = @CityId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(CITYID),0)+1 AS MAX_CITY_ID FROM CITY";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
