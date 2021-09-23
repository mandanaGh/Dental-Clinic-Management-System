using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataAccessLayer
{
    public static class ServerDAL
    {
        public static int GetIntValue(string Key)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings[Key]);
        }
        public static string GetStringValue(string Key)
        {
            return ConfigurationManager.AppSettings[Key];
        }
        public static long GetLongValue(string Key)
        {
            return Convert.ToInt64(ConfigurationManager.AppSettings[Key]);
        }
        public static bool GetBooleanValue(string Key)
        {
            return ConfigurationManager.AppSettings[Key].ToUpper() == "TRUE";
        }
        public static string GetConnectionStrings()
        {
            //return @"Data Source=(LOCAL);AttachDbFilename=F:\Project\CLINIC\CLINIC\Clinic.mdf;Integrated Security=True;Pooling=False";
            //return string.Format("{0}{1}{2}", @"Data Source=.\SQLEXPRESS;AttachDbFilename=", GetServerPath(), @"Clinic.mdf;Integrated Security=True;User Instance=False");
            //Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Project\CLINIC\CLINIC\bin\Debug\Clinic.mdf;Integrated Security=True;Pooling=False
           // return string.Format("{0}{1}{2}", @"Data Source=.\sqlexpress;AttachDbFilename=", GetServerPath(), @"Clinic.mdf;Integrated Security=True;User Instance=False");
           return @"Data Source=(LOCAL)\sqlexpress;Initial Catalog=CLINIC.MDF;Integrated Security=True";
        }
        public static string GetServerPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
