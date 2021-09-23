using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class EquipmentDOL
    {
        public const string Select = @"SELECT EQUIPMENTID, EQUIPMENTTITLE, EXPIREDDATE, COUNT, DESCRIPTION FROM EQUIPMENT";
        public const string Insert = @"INSERT INTO EQUIPMENT (EQUIPMENTID,EQUIPMENTTITLE, EXPIREDDATE, COUNT, DESCRIPTION) VALUES(@EQUIPMENTID,@EQUIPMENTTITLE, @EXPIREDDATE, @COUNT, @DESCRIPTION)";
        public const string Delete = "DELETE FROM EQUIPMENT WHERE EQUIPMENTID=@EQUIPMENTID";
        public const string Update = "UPDATE EQUIPMENT SET EQUIPMENTTITLE = @EquipmentTitle ,EXPIREDDATE =  @ExpiredDate,COUNT = @Count,DESCRIPTION = @Description  WHERE EQUIPMENTID = @EQUIPMENTID";
        public const string SelectMaxId = "SELECT ISNULL(MAX(EQUIPMENTID),0)+1 AS MAX_EQUIPMENT_ID FROM EQUIPMENT";
        public const string SelectShortageAlarm = "SELECT EquipmentId, EquipmentTitle FROM dbo.GetEquipmentShortage()";
        public const string SelectExpiredAlarm = "SELECT EQUIPMENTID, EQUIPMENTTITLE FROM EQUIPMENT WHERE  DATEDIFF(d, GETDATE(), EXPIREDDATE) <= 31 AND DATEDIFF(d, GETDATE(), EXPIREDDATE)>= 24";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId, SelectShortageAlarm, SelectExpiredAlarm };
    }
}
