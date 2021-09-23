using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DataConvertor
{
    public class DataConvertor
    {
        public static byte[] ConvertToByte(object Value)
        {
            byte[] result;
            result = (Value == DBNull.Value ? (byte[])null : (byte[])Value);
            return result;
        }
        public static string ConvertToString(object Value)
        {
            string result;
            result = (Value == DBNull.Value ? null : Convert.ToString(Value));
            return result;
        }
        public static long? ConvertToLong(object Value)
        {
            long? result;
            if (Value == DBNull.Value)
                result = null;
            else
                result = Convert.ToInt64(Value);
            return result;
        }
        public static bool ConvertToBoolean(object Value)
        {
            bool result;
            if (Value == DBNull.Value)
                result = false;
            else
                result = Convert.ToBoolean(Value);
            return result;
        }
        public static short? ConvertToShort(object Value)
        {
            short? result;
            if (Value == DBNull.Value)
                result = null;
            else
                result = Convert.ToInt16(Value);
            return result;
        }
        public static decimal ConvertToDecimal(object Value)
        {
           decimal result;
            if (Value == DBNull.Value)
                result = 0;
            else
                result = Convert.ToDecimal(Value);
            return result;
        }
        public static DateTime? ConvertToDate(object Value)
        {
            DateTime? result;
            if (Value == DBNull.Value)
                result = null;
            else
                result = Convert.ToDateTime(Value);
            return result;
        }
        public static int ConvertToInt(object Value)
        {
            int result;
            if (Value == DBNull.Value)
                result = 0;
            else
                result = Convert.ToInt32(Value);
            return result;
        }
        public static string ConvertToPersianDate(DateTime dateTime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return String.Format("{0}/{1}/{2}", persianCalendar.GetYear(dateTime).ToString(), persianCalendar.GetMonth(dateTime).ToString("00"), persianCalendar.GetDayOfMonth(dateTime).ToString("00"));
        }
    }
}
