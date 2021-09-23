using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public static class UserProfile
    {
        private static short userID;
        private static string userName;
        private static string fisrtName;
        private static string lastName;
        private static short roleId;
        private static string description;

        public static short UserID
        {
            get
            {
                return userID;
            }
        }
        public static string UserName
        {
            get
            {
                return userName;
            }
        }
        public static string FisrtName
        {
            get
            {
                return fisrtName;
            }
        }
        public static string LastName
        {
            get
            {
                return lastName;
            }
        }
        public static short RoleId
        {
            get
            {
                return roleId;
            }
        }
        public static string Description
        {
            get
            {
                return description;
            }
        }
        public static void Load(short UserID, string UserName, string FirstName, string LastName, short RoleId, string Description)
        {
            userID = UserID;
            userName = UserName;
            fisrtName = FirstName;
            lastName = LastName;
            roleId = RoleId;
            description = Description;
        }
   }
}
