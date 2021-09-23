using System;
using System.Drawing;
using System.Windows.Forms;
using ComplexDataType;
using System.Resources;
using BusinessObjectLayer;
using System.Reflection;
using BusinessLogicLayer;
using JntMsgBox;

namespace UserInterface
{
    using DataConvertor;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using BusinessLogicLayer;
    using System.Diagnostics;
    using System.Security.AccessControl;

    public partial class ShowPatientUI : Form
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        PatientBLL _PatientBLL;
        private AccessMode _AccessMode;
        string DangerousConfirmation;
        string DangerousText;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        private void SetResourceManager()
        {
            try
            {
                DangerousText = _ResourceManager.GetString("Dangerous");
                DangerousConfirmation = _ResourceManager.GetString("DangerousConfirmation");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public ShowPatientUI(AccessMode accessMode)
        {
            InitializeComponent();
            SetResourceManager();
            _AccessMode = accessMode;
            newPatientButton.Enabled = (accessMode != AccessMode.Read);
            _PatientBLL = new PatientBLL();
            FillPatientGridEx();
        }
        private void FillPatientGridEx()
        {
            try
            {
                PatientBOL[] _PatientBOL = _PatientBLL.Select();
                patientGridEX.ClearItems();
                if (_PatientBOL != null)
                {
                    for (int index = 0; index < _PatientBOL.Length; index++)
                        patientGridEX.AddItem(_PatientBOL[index].PatientId, _PatientBOL[index].PatientCode, _PatientBOL[index].FirstName, _PatientBOL[index].LastName, _PatientBOL[index].Gender, _PatientBOL[index].Tel, _PatientBOL[index].Mobile, _PatientBOL[index].InsuranceTypeId, _PatientBOL[index].InsuranceTypeTitle, _PatientBOL[index].Birthday, _PatientBOL[index].ExpiredDate, _PatientBOL[index].InsuranceCode, _PatientBOL[index].Married, _PatientBOL[index].NationalCode, _PatientBOL[index].Address, _PatientBOL[index].JobId, _PatientBOL[index].JobTitle, _PatientBOL[index].IsUseSpecialDrag, _PatientBOL[index].IsPregnant, _PatientBOL[index].IsUnderPhysician, _PatientBOL[index].PhysicianDescription, _PatientBOL[index].Date, _PatientBOL[index].IsPenAlergic, _PatientBOL[index].IsAsprinAlergic, _PatientBOL[index].IsOutDragAlergic, _PatientBOL[index].IsOtherAlergic, _PatientBOL[index].RelevantName, _PatientBOL[index].Description, _PatientBOL[index].IsNormal);
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void newPatientButton_Click(object sender, EventArgs e)
        {
            new EditPatientUI().ShowDialog();
            FillPatientGridEx();
        }
        private void patientGridEX_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                if (_AccessMode != AccessMode.NoAccess)
                {
                    if (patientGridEX.CurrentRow != null)
                        if (patientGridEX.CurrentRow.RowIndex > -1)
                            if (patientGridEX.CurrentRow.Group == null)
                            {
                                ItemSelected();
                            }
                }
                else
                {
                    _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                    noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                    noticeLabel.Text = _ExceptionHandlerBOL.Title;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowPatientUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void noticeLabel_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                noticeLabel.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }
        private void patientGridEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (patientGridEX.RowCount != 0)
                    ItemSelected();
        }
        private void ItemSelected()
        {
            try
            {
                PatientBOL _PatientBOL = new PatientBOL();
                _PatientBOL.PatientId = DataConvertor.ConvertToInt(patientGridEX.CurrentRow.Cells["PATIENTID"].Value);
                _PatientBOL.PatientCode = DataConvertor.ConvertToInt(patientGridEX.CurrentRow.Cells["PATIENTCODE"].Value);
                _PatientBOL.FirstName = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["FIRSTNAME"].Value);
                _PatientBOL.LastName = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["LASTNAME"].Value);
                _PatientBOL.Gender = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["GENDER"].Value);
                _PatientBOL.Tel = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["TEL"].Value);
                _PatientBOL.Mobile = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["MOBILE"].Value);
                _PatientBOL.Address = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["ADDRESS"].Value);
                _PatientBOL.InsuranceTypeId = DataConvertor.ConvertToShort(patientGridEX.CurrentRow.Cells["INSURANCETYPEID"].Value);
                _PatientBOL.Birthday = DataConvertor.ConvertToDate(patientGridEX.CurrentRow.Cells["BIRTHDAY"].Value);
                _PatientBOL.ExpiredDate = DataConvertor.ConvertToDate(patientGridEX.CurrentRow.Cells["EXPIREDDATE"].Value);
                _PatientBOL.InsuranceCode = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["INSURANCECODE"].Value);
                _PatientBOL.Married = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["MARRIED"].Value);
                _PatientBOL.NationalCode = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["NATIONALCODE"].Value);
                _PatientBOL.JobId = DataConvertor.ConvertToShort(patientGridEX.CurrentRow.Cells["JOBID"].Value);
                _PatientBOL.IsUseSpecialDrag = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISUSESPECIALDRAG"].Value);
                _PatientBOL.IsPregnant = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISPREGNANT"].Value);
                _PatientBOL.IsUnderPhysician = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISUNDERPHYSICIAN"].Value);
                _PatientBOL.PhysicianDescription = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["PHYSICIANDESCRIPTION"].Value);
                _PatientBOL.Date = DataConvertor.ConvertToDate(patientGridEX.CurrentRow.Cells["DATE"].Value);
                _PatientBOL.IsPenAlergic = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISPENALERGIC"].Value);
                _PatientBOL.IsAsprinAlergic = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISASPIRINALERGIC"].Value);
                _PatientBOL.IsOutDragAlergic = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISOUTDRAGALERGIC"].Value);
                _PatientBOL.IsOtherAlergic = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISOTHERALERGIC"].Value);
                _PatientBOL.RelevantName = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["RELEVANTNAME"].Value);
                _PatientBOL.Description = DataConvertor.ConvertToString(patientGridEX.CurrentRow.Cells["DESCRIPTION"].Value);
                _PatientBOL.IsNormal = DataConvertor.ConvertToBoolean(patientGridEX.CurrentRow.Cells["ISNORMAL"].Value);
                if (IsDangerous((int)_PatientBOL.PatientId))
                {
                    JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                    DialogResult result = _JntMsgBoxFarsi.Show(DangerousConfirmation, DangerousText, JntStyle.OkCancel);
                    if (result == DialogResult.Cancel)
                        return;
                }
                new EditPatientUI(_PatientBOL, _AccessMode).ShowDialog();
                FillPatientGridEx();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private bool IsDangerous(int PatientId)
        {
         return new PatientBLL().IsDangerous(PatientId);             
        }
    }
}
