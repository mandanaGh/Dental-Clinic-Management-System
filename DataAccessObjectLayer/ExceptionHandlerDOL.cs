namespace DataObjectLayer
{
    public static class ExceptionHandlerDOL 
    {
       public static string select = "SELECT TITLE, KEY_VALUES, DESCRIPTION, HELP_NOTE FROM EXCEPTION_HANDLER WHERE (@KEY_VALUES LIKE '%' + KEY_VALUES + '%') ORDER BY { fn LENGTH(KEY_VALUES) } DESC";       
    }
}
