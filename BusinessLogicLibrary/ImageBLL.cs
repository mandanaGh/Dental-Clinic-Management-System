using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class ImageBLL
    {
        public ImageBOL[] Select(int PatientId)
        {
            ImageDAL _ImageDAL = new ImageDAL(ImageDOL.QueryStatus.Select);
            return _ImageDAL.Select(PatientId);
        }
        public void Insert(ImageBOL _ImageBOL)
        {
            ImageDAL _ImageDAL = new ImageDAL(ImageDOL.QueryStatus.Insert, _ImageBOL);
            _ImageDAL.Insert();
        }
        public void Update(ImageBOL _ImageBOL)
        {
            ImageDAL _ImageDAL = new ImageDAL(ImageDOL.QueryStatus.Update, _ImageBOL);
            _ImageDAL.Update();
        }
        public void Delete(ImageBOL _ImageBOL)
        {
            ImageDAL _ImageDAL = new ImageDAL(ImageDOL.QueryStatus.Delete, _ImageBOL);
            _ImageDAL.Delete();
        }
        public long? SelectMaxId()
        {
            ImageDAL _ImageDAL = new ImageDAL(ImageDOL.QueryStatus.SelectMaxId);
            return _ImageDAL.SelectMaxId();
        }
    }
}
