using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using BusinessLogicLayer;

    public static class ExceptionHandlerBLL
    {
        public static ExceptionHandlerBOL HandleException(Exception exception)
        {
            return HandleMessage(exception.GetBaseException().Message);
        }
        public static ExceptionHandlerBOL HandleMessage(string Message)
        {
            try
            {
                DataTable table = ExceptionHandlerDAL.Select(Message);
                foreach (DataRow row in table.Rows)
                {
                    string title = row["TITLE"].ToString();
                    string keyValues = row["KEY_VALUES"].ToString();
                    string description = row["DESCRIPTION"].ToString();
                    string helpNote = row["HELP_NOTE"].ToString();
                    string originalMessage = Message;
                    return (new ExceptionHandlerBOL(title, keyValues, description, helpNote, originalMessage));
                }
                return (new ExceptionHandlerBOL(ServerBLL.GetStringValue("DefaultExceptionTitle"), string.Empty, ServerBLL.GetStringValue("DefaultExceptionDescription"), ServerBLL.GetStringValue("DefaultExceptionHelpNote"), Message));
            }
            catch
            {
                return (new ExceptionHandlerBOL(ServerBLL.GetStringValue("OfflineExceptionTitle"), string.Empty, ServerBLL.GetStringValue("OfflineExceptionDescription"), ServerBLL.GetStringValue("OfflineExceptionHelpNote"), Message));
            }
        }
    }
}
