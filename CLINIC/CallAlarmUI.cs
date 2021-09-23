using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjectLayer;
using BusinessLogicLayer;

namespace UserInterface
{
    public partial class CallAlarmUI : Form
    {
        ShowPatientUI _PatientUI;
        PatientBLL _PatientBLL = new PatientBLL();
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public CallAlarmUI()
        {
            InitializeComponent();
            FillAlaramGridEX();
        }
        private void FillAlaramGridEX()
        {
            alarmGridEX.ClearItems();
            try
            {
                PatientBOL[] _PatientBOL = _PatientBLL.SelectAlarm();
                if (_PatientBOL != null)
                {
                    for (int index = 0; index < _PatientBOL.Length; index++)
                        alarmGridEX.AddItem(_PatientBOL[index].PatientId, _PatientBOL[index].FirstName, _PatientBOL[index].LastName, _PatientBOL[index].ServiceTypeId, _PatientBOL[index].ServiceTypeTitle, _PatientBOL[index].Tel);
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowPatientUI()
        {
            try
            {
                if (_PatientUI == null || !_PatientUI.Visible)
                {
                    if (_PatientUI != null)
                        _PatientUI.Dispose();
                   AccessMode accessMode = GetAccessMode("ShowPatient");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _PatientUI = new ShowPatientUI(accessMode);
                    _PatientUI.MdiParent = ParentForm;
                    _PatientUI.Show();
                }
                else
                {
                    _PatientUI.Focus();
                    _PatientUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void alarmGridEX_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            ShowPatientUI();
        }
        private AccessMode GetAccessMode(string pageTitle)
        {
            noticeLabel.Text = string.Empty;
            AccessMode accessMode = AccessBLL.GetAccessMode(pageTitle, UserProfile.RoleId);
            if (accessMode == AccessMode.NoAccess)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            return accessMode;
        }
        private void CallAlarmUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void alarmGridEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                ShowPatientUI();
        }
    }
}
