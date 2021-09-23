using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class AppointmentTypeDOL
    {
        public const string Select = @"SELECT APPOINTMENTTYPEID, APPOINTMENTTYPETITLE, DESCRIPTION FROM APPOINTMENTTYPE";
        public const string Insert = @"INSERT INTO APPOINTMENTTYPE(APPOINTMENTTYPEID, APPOINTMENTTYPETITLE,DESCRIPTION) VALUES (@AppointmentTypeId,@AppointmentTypeTitle,@Description)";
        public const string SelectComboBox = @"SELECT APPOINTMENTTYPEID, APPOINTMENTTYPETITLE FROM APPOINTMENTTYPE UNION (SELECT ID AS APPOINTMENTTYPEID, TEXT AS APPOINTMENTTYPETITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM APPOINTMENTTYPE WHERE APPOINTMENTTYPEID=@AppointmentTypeId";
        public const string Update = "UPDATE APPOINTMENTTYPE SET APPOINTMENTTYPETITLE = @AppointmentTypeTitle ,DESCRIPTION = @Description  WHERE APPOINTMENTTYPEID = @AppointmentTypeId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(APPOINTMENTTYPEID),0)+1 AS MAX_APPOINTMENTTYPE_ID FROM APPOINTMENTTYPE";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
