using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjectLayer
{
    public class ImageBOL
    {
        private long? imageId;
        private int patientId;
        private string imageTitle;
        private string imagePath;
        private string description;

        public long? ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }
        public int PatientId
        {
            get { return this.patientId; }
            set { this.patientId = value; }
        }
        public string ImageTitle
        {
            get { return this.imageTitle; }
            set { this.imageTitle = value; }
        }
        public string ImagePath
        {
            get { return this.imagePath; }
            set { this.imagePath = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public ImageBOL() { }
        public ImageBOL(long? ImageId, int PatientId, string ImageTitle, string ImagePath, string Description)
        {
            this.imageId = ImageId;
            this.imageTitle = ImageTitle;
            this.patientId = PatientId;
            this.imagePath = ImagePath;
            this.description = Description;
        }
    }
}
