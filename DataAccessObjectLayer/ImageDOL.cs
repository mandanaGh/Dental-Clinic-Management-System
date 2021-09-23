using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class ImageDOL
    {
        public const string Select = @"SELECT PATIENTID,IMAGEPATH, IMAGEID,  IMAGETITLE, DESCRIPTION FROM IMAGE WHERE PATIENTID = @PATIENTID";
        public const string Insert = @"INSERT INTO IMAGE (IMAGEPATH, IMAGETITLE, DESCRIPTION, PATIENTID) VALUES (@IMAGEPATH, @IMAGETITLE, @DESCRIPTION,@PATIENTID)";
        public const string Delete = "DELETE FROM IMAGE WHERE IMAGEID=@IMAGEId";
        public const string Update = "UPDATE IMAGE SET IMAGEPATH = @IMAGEPATH, IMAGETITLE = @IMAGETITLE, DESCRIPTION = @DESCRIPTION WHERE IMAGEID = @ImageId";
        public const string SelectMaxId = "SELECT ISNULL(MAX(IMAGEID),0)+1 AS MAX_IMAGE_ID FROM IMAGE";
        public enum QueryStatus { Select, Insert, Delete, Update, SelectMaxId };
    }
}
