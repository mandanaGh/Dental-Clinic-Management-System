using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class SubjectDOL
    {
        public const string Select = @"SELECT SUBJECTID, SUBJECTTITLE, DESCRIPTION FROM SUBJECT";
        public const string Insert = @"INSERT INTO SUBJECT(SUBJECTID, SUBJECTTITLE,DESCRIPTION) VALUES (@SubjectId,@SubjectTitle,@Description)";
        public const string SelectComboBox = @"SELECT SUBJECTID, SUBJECTTITLE FROM SUBJECT UNION (SELECT ID AS SUBJECTID, TEXT AS SUBJECTTITLE FROM NOSELECTION)";
        public const string Delete = "DELETE FROM SUBJECT WHERE SUBJECTID=@SubjectId";
        public const string Update = "UPDATE SUBJECT SET SUBJECTTITLE = @SubjectTitle ,DESCRIPTION = @Description  WHERE SUBJECTID = @SubjectId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(SUBJECTID),0)+1 AS MAX_SUBJECT_ID FROM SUBJECT";
        public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
