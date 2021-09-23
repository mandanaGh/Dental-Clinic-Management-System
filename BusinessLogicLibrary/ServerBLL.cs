using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    using DataAccessLayer;
    using System.Data.SqlClient;

    public static class ServerBLL
    {
        public static int GetIntValue(string Key)
        {
            return ServerDAL.GetIntValue(Key);
        }
        public static string GetStringValue(string Key)
        {
            return ServerDAL.GetStringValue(Key);
        }
        public static long GetLongValue(string Key)
        {
            return ServerDAL.GetLongValue(Key);
        }
        public static bool GetBooleanValue(string Key)
        {
            return ServerDAL.GetBooleanValue(Key);
        }
        public static string GetConnectionStrings()
        {
            return ServerDAL.GetConnectionStrings();
        }
        public static string GetServerPath()
        {
            return ServerDAL.GetServerPath();
        }
        public static bool BackUp(string Path, string Name)
        {
            return new DatabaseBLL().BackUp(Path, Name);
        }
        public static bool RestoreBackUp(string Path, string Name)
        {
            return new DatabaseBLL().RestoreBackUp(Path, Name);
        }
    }
}