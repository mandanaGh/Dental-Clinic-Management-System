using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class JobDOL
    {
        public const string Select = @"SELECT JOBID, JOBTITLE, DESCRIPTION FROM JOB";
        public const string Insert = @"INSERT INTO JOB(JOBID, JOBTITLE,DESCRIPTION) VALUES (@JobId,@JobTitle,@Description)";
        public const string SelectComboBox = @"SELECT JOBID, JOBTITLE FROM JOB UNION (SELECT ID AS JOBID, TEXT AS JOBTITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM JOB WHERE JOBID=@JobId";
        public const string Update = "UPDATE JOB SET JOBTITLE = @JobTitle ,DESCRIPTION = @Description  WHERE JOBID = @JobId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(JOBID),0)+1 AS MAX_JOB_ID FROM JOB";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
