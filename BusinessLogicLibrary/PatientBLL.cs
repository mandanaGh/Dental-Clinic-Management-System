using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    using BusinessObjectLayer;
    using DataAccessLayer;
    using DataObjectLayer;

    public class PatientBLL
    {
        public PatientBOL[] Select()
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.Select);
            return _PatientDAL.Select();
        }
        public void Insert(PatientBOL _PatientBOL, List<PatientDiseasesBOL> _PatientDiseasesBOLs)
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.Insert, _PatientBOL);
            _PatientDAL.Insert();
            if (_PatientDiseasesBOLs.Count > 0)
            {
                PatientDiseasesBLL _PatientDiseasesBLL = new PatientDiseasesBLL();
                _PatientDiseasesBLL.Delete(_PatientDiseasesBOLs);
                _PatientDiseasesBLL.Insert(_PatientDiseasesBOLs);
            }
        }
        public void Update(PatientBOL _PatientBOL, List<PatientDiseasesBOL> _PatientDiseasesBOLs)
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.Update, _PatientBOL);
            _PatientDAL.Update();
            PatientDiseasesBLL _PatientDiseasesBLL = new PatientDiseasesBLL();
            _PatientDiseasesBLL.Delete((int)_PatientBOL.PatientId);
            if (_PatientDiseasesBOLs.Count > 0)
                _PatientDiseasesBLL.Insert(_PatientDiseasesBOLs);
        }
        public void Delete(PatientBOL _PatientBOL)
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.Delete, _PatientBOL);
            _PatientDAL.Delete();
        }
        public int? SelectMaxId()
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.SelectMaxId);
            return _PatientDAL.SelectMaxId();
        }
        public string Select(int PatientId)
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.SelectToothColor);
            return _PatientDAL.Select(PatientId);
        }
        public void Update(PatientBOL _PatientBOL, string toothColor)
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.UpdateToothColor, _PatientBOL);
            _PatientDAL.Update(toothColor);
        }
        public PatientBOL[] SelectAlarm()
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.SelectAlarm);
            return _PatientDAL.SelectAlarm();
        }
        public bool HasAlarm()
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.SelectAlarm);
            return _PatientDAL.HasAlarm();
        }
        public bool IsDangerous(int PatientId)
        {
            PatientDAL _PatientDAL = new PatientDAL(PatientDOL.QueryStatus.IsDangerous);
            return _PatientDAL.IsDangerous(PatientId);
        }
    }
}

