using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using DataAccessLayer;
    using BusinessObjectLayer;
    using System.Data;

    public class AccessBLL
    {
        public static AccessMode GetAccessMode(string PageTitle,long RoleId)
        {
            return AccessDAL.GetAccessMode(PageTitle, RoleId);
        }
        public static DataTable SelectComboBox()
        {
            return AccessDAL.SelectComboBox();
        }
    }
}
