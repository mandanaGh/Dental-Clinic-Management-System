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
using System.Resources;
using System.Reflection;
using JntMsgBox;
using UserInterface.Report;

namespace UserInterface
{

    public partial class MenuUI : Form
    {
        bool closingFlag = false;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ChangePasswordUI _ChangePasswordUI;
        ShowRoleUI _ShowRoleUI;
        ShowUserUI _ShowUserUI;
        ShowPatientUI _ShowPatientUI;
        DoctorUI _DoctorUI;
        ShowInsuranceTypeUI _ShowInsuranceTypeUI;
        ShowDiseasesUI _ShowDiseasesUI;
        ShowEquipmentUI _ShowEquipmentUI;
        ShowServiceTypeUI _ShowServiceTypeUI;
        ShowSpecialistUI _ShowSpecialistUI;
        ShowAppointmentTypeUI _ShowAppointmentTypeUI;
        ShowToothColorUI _ShowToothColorUI;
        ShowJobUI _ShowJobUI;
        ShowLaboratoryStateUI _ShowLaboratoryStateUI;
        ShowLaboratoryUI _ShowLaboratoryUI;
        EditPatientUI _EditPatientUI;
        CallAlarmUI _CallAlarmUI;
        EquipmentShortageAlarmUI _EquipmentShortageAlarmUI;
        EquipmentExpiredAlarmUI _EquipmentExpiredAlarmUI;
        AccessUI _AccessUI;
        CostReport _CostReport;
        About _About;
        BackupUI _BackupUI;
        RestoreBackupUI _RestoreBackupUI;
        PrescriptionListReport _PrescriptionListReport;
        PatientListReport _PatientListReport;
        EquipmentHistoryUI _EquipmentHistoryUI;
        ShowPhoneBookUI _ShowPhoneBookUI;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        LaboratoryReport _LaboratoryReport;
        string ExitText;
        string ChangeText;
        string BackupText;
        string ExitConfirmation;
        string ChangeConfirmation;
        string BackupConfirmation;
        private AccessMode accessMode = AccessMode.NoAccess;

        public MenuUI()
        {
            InitializeComponent();
            CreateVisualStyleColors();
            SetResourceManager();
            ShowAlarm();
            ShowDate();
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void ShowDate()
        {
            dateLabel.Text = DataConvertor.DataConvertor.ConvertToPersianDate(DateTime.Now);
        }
        private void ShowAlarm()
        {
            ShowCallAlarmUI();
            ShowEquipmentShortageAlarmUI();
            ShowEquipmentExpiredAlarmUI();
        }
        private void SetResourceManager()
        {
            ExitText = _ResourceManager.GetString("Exit");
            ChangeText = _ResourceManager.GetString("Change");
            BackupText = _ResourceManager.GetString("Backup");
            ExitConfirmation = _ResourceManager.GetString("ExitConfirmation");
            ChangeConfirmation = _ResourceManager.GetString("ChangeConfirmation");
            BackupConfirmation = _ResourceManager.GetString("BackupConfirmation");
        }
        private void CreateVisualStyleColors()
        {
            this.CreateBuiltInVisualStyleCommand("rcmdBlue", "Blue", Color.FromArgb(118, 153, 199));
            this.CreateBuiltInVisualStyleCommand("rcmdSilver", "Silver", Color.Silver);
            this.CreateBuiltInVisualStyleCommand("rcmdBlack", "Black", Color.Black);
            Janus.Windows.Ribbon.ButtonCommand cmdBlue = this.officeColorsRibbonGroup.Commands["rcmdBlue"] as Janus.Windows.Ribbon.ButtonCommand;
            cmdBlue.Checked = true;

            colorsGallery.MaxGalleryColumns = 6;
            AddCustomColorCommand(Color.FromArgb(96, 128, 160), "21");
            AddCustomColorCommand(Color.FromArgb(160, 96, 96), "22");
            AddCustomColorCommand(Color.FromArgb(128, 160, 96), "23");
            AddCustomColorCommand(Color.FromArgb(96, 160, 128), "24");
            AddCustomColorCommand(Color.FromArgb(128, 128, 160), "25");
            AddCustomColorCommand(Color.FromArgb(160, 96, 128), "26");

            AddCustomColorCommand(Color.FromArgb(80, 128, 192), "21");
            AddCustomColorCommand(Color.FromArgb(192, 80, 80), "22");
            AddCustomColorCommand(Color.FromArgb(128, 192, 80), "23");
            AddCustomColorCommand(Color.FromArgb(80, 192, 128), "24");
            AddCustomColorCommand(Color.FromArgb(128, 128, 192), "25");
            AddCustomColorCommand(Color.FromArgb(192, 80, 128), "26");

            AddCustomColorCommand(Color.FromArgb(40, 80, 128), "31");
            AddCustomColorCommand(Color.FromArgb(128, 40, 40), "32");
            AddCustomColorCommand(Color.FromArgb(80, 128, 40), "33");
            AddCustomColorCommand(Color.FromArgb(40, 128, 80), "45");
            AddCustomColorCommand(Color.FromArgb(80, 80, 128), "34");
            AddCustomColorCommand(Color.FromArgb(128, 40, 80), "34");

            AddCustomColorCommand(Color.FromArgb(32, 48, 80), "21");
            AddCustomColorCommand(Color.FromArgb(80, 40, 40), "22");
            AddCustomColorCommand(Color.FromArgb(48, 80, 32), "23");
            AddCustomColorCommand(Color.FromArgb(32, 80, 48), "24");
            AddCustomColorCommand(Color.FromArgb(40, 40, 80), "25");
            AddCustomColorCommand(Color.FromArgb(80, 32, 40), "26");

            AddCustomColorCommand(Color.FromArgb(24, 40, 64), "41");
            AddCustomColorCommand(Color.FromArgb(64, 24, 24), "42");
            AddCustomColorCommand(Color.FromArgb(40, 64, 32), "43");
            AddCustomColorCommand(Color.FromArgb(24, 64, 48), "45");
            AddCustomColorCommand(Color.FromArgb(32, 32, 64), "44");
            AddCustomColorCommand(Color.FromArgb(64, 24, 48), "44");
        }
        private void AddCustomColorCommand(Color clr, string name)
        {
            Janus.Windows.Ribbon.GalleryItem item = new Janus.Windows.Ribbon.GalleryItem("COLOR" + name);
            item.Tag = clr;
            item.Image = CreateColorImage(clr, 48, 48);
            this.colorsGallery.GalleryItems.Add(item);
        }
        private void MenuRibbon_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (e.Command.Key.StartsWith("COLOR"))
            {
                Janus.Windows.Common.VisualStyleManager.DefaultOffice2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Custom;
                Janus.Windows.Common.VisualStyleManager.DefaultOffice2007CustomColor = (Color)e.Command.Tag;
                foreach (Janus.Windows.Ribbon.ButtonCommand _ButtonCommand in this.officeColorsRibbonGroup.Commands)
                {
                    _ButtonCommand.Checked = false;
                }
            }
            else
            {
                switch (e.Command.Key)
                {
                    case "rcmdBlack":
                        Janus.Windows.Common.VisualStyleManager.DefaultOffice2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Black;
                        UncheckCustomColors();
                        break;
                    case "rcmdBlue":
                        Janus.Windows.Common.VisualStyleManager.DefaultOffice2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Blue;
                        UncheckCustomColors();
                        break;
                    case "rcmdSilver":
                        Janus.Windows.Common.VisualStyleManager.DefaultOffice2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver;
                        UncheckCustomColors();
                        break;
                    case "changePasswordButtonCommand":
                        ChangePassword();
                        break;
                    case "changeUserButtonCommand":
                        RestartApplication();
                        break;
                    case "exitButtonCommand":
                        GetExitConfirmtion();
                        break;
                    case "roleButtonCommand":
                        ShowRoleUI();
                        break;
                    case "insuranceButtonCommand":
                        ShowInsuranceTypeUI();
                        break;
                    case "diseasesButtonCommand":
                        ShowDiseasesUI();
                        break;
                    case "equipmentButtonCommand":
                        ShowEquipmentUI();
                        break;
                    case "serviceTypeButtonCommand":
                        ShowServiceTypeUI();
                        break;
                    case "specialistButtonCommand":
                        ShowSpecialistUI();
                        break;
                    case "appointmentTypeButtonCommand":
                        ShowAppointmentTypeUI();
                        break;
                    case "patientButtonCommand":
                        ShowPatientUI();
                        break;
                    case "equipmentHistoryButtonCommand":
                        ShowEquipmentHistoryUI();
                        break;
                    case "usersButtonCommand":
                        ShowUserUI();
                        break;
                    case "doctorButtonCommand":
                        ShowDoctor();
                        break;
                    case "toothColorButtonCommand":
                        ShowToothColor();
                        break;
                    case "jobButtonCommand":
                        ShowJobUI();
                        break;
                    case "accessButtonCommand":
                        ShowAccessUI();
                        break;
                    case "cascadeButtonCommand":
                        this.LayoutMdi(MdiLayout.Cascade);
                        break;
                    case "horizontalButtonCommand":
                        this.LayoutMdi(MdiLayout.TileHorizontal);
                        break;
                    case "verticalButtonCommand":
                        this.LayoutMdi(MdiLayout.TileVertical);
                        break;
                    case "restoreAllButtonCommand":
                        RestoreAll();
                        break;
                    case "closeAllButtonCommand":
                        CloseAll();
                        break;
                    case "minimizeAllButtonCommand":
                        MinimizeAll();
                        break;
                    case "costButtonCommand":
                        ShowCostReport();
                        break;
                    case "prescriptionListButtonCommand":
                        ShowPrescriptionList();
                        break;
                    case "patientListButtonCommand":
                        ShowPatientList();
                        break;
                    case "aboutButtonCommand":
                        ShowAbout();
                        break;
                    case "backupButtonCommand":
                        ShowBackup();
                        break;
                    case "restoreBackupButtonCommand":
                        ShowRestoreBackup();
                        break;
                    case "newPatientButtonCommand":
                        ShowEditPatientUI();
                        break;
                    case "alarmButtonCommand":
                        ShowAlarm();
                        break;
                    case "laboratoryStateButtonCommand":
                        ShowLaboratoryState();
                        break;
                    case "laboratoryButtonCommand":
                        ShowLaboratory();
                        break;
                    case "laboratoryReportButtonCommand":
                        ShowLaboratoryReport();
                        break;
                    case "phoneBookButtonCommand":
                        ShowPhoneBook();
                        break;
                }
            }
        }
        private void ShowPhoneBook()
        {
            try
            {
                if (_ShowPhoneBookUI == null || !_ShowPhoneBookUI.Visible)
                {
                    if (_ShowPhoneBookUI != null)
                        _ShowPhoneBookUI.Dispose();
                    accessMode = GetAccessMode("ShowPhoneBook");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowPhoneBookUI = new ShowPhoneBookUI(accessMode);
                    _ShowPhoneBookUI.MdiParent = this;
                    _ShowPhoneBookUI.Show();
                }
                else
                {
                    _ShowPhoneBookUI.Focus();
                    _ShowPhoneBookUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowLaboratoryReport()
        {
            try
            {
                if (_LaboratoryReport == null || !_LaboratoryReport.Visible)
                {
                    if (_LaboratoryReport != null)
                        _LaboratoryReport.Dispose();
                    accessMode = GetAccessMode("LaboratoryReport");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _LaboratoryReport = new LaboratoryReport();
                    _LaboratoryReport.MdiParent = this;
                    _LaboratoryReport.Show();
                }
                else
                {
                    _LaboratoryReport.Focus();
                    _LaboratoryReport.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowLaboratory()
        {
            try
            {
                if (_ShowLaboratoryUI == null || !_ShowLaboratoryUI.Visible)
                {
                    if (_ShowLaboratoryUI != null)
                        _ShowLaboratoryUI.Dispose();
                    accessMode = GetAccessMode("ShowLaboratory");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowLaboratoryUI = new ShowLaboratoryUI(accessMode);
                    _ShowLaboratoryUI.MdiParent = this;
                    _ShowLaboratoryUI.Show();
                }
                else
                {
                    _ShowLaboratoryUI.Focus();
                    _ShowLaboratoryUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowLaboratoryState()
        {
            try
            {
                if (_ShowLaboratoryStateUI == null || !_ShowLaboratoryStateUI.Visible)
                {
                    if (_ShowLaboratoryStateUI != null)
                        _ShowLaboratoryStateUI.Dispose();
                    accessMode = GetAccessMode("ShowLaboratoryState");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowLaboratoryStateUI = new ShowLaboratoryStateUI(accessMode);
                    _ShowLaboratoryStateUI.MdiParent = this;
                    _ShowLaboratoryStateUI.Show();
                }
                else
                {
                    _ShowLaboratoryStateUI.Focus();
                    _ShowLaboratoryStateUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowEditPatientUI()
        {
            try
            {
                if (_EditPatientUI == null || !_EditPatientUI.Visible)
                {
                    if (_EditPatientUI != null)
                        _EditPatientUI.Dispose();
                    accessMode = GetAccessMode("ShowPatient");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    if (accessMode == AccessMode.Read)
                    {
                        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                        errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
                        errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                        return;

                    }
                    _EditPatientUI = new EditPatientUI();
                    _EditPatientUI.MdiParent = this;
                    _EditPatientUI.Show();
                }
                else
                {
                    _EditPatientUI.Focus();
                    _EditPatientUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowRestoreBackup()
        {
            try
            {
                if (_RestoreBackupUI == null || !_RestoreBackupUI.Visible)
                {
                    if (_RestoreBackupUI != null)
                        _RestoreBackupUI.Dispose();
                    accessMode = GetAccessMode("RestoreBackup");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _RestoreBackupUI = new RestoreBackupUI();
                    _RestoreBackupUI.MdiParent = this;
                    _RestoreBackupUI.Show();
                }
                else
                {
                    _RestoreBackupUI.Focus();
                    _RestoreBackupUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowBackup()
        {
            try
            {
                if (_BackupUI == null || !_BackupUI.Visible)
                {
                    if (_BackupUI != null)
                        _BackupUI.Dispose();
                    accessMode = GetAccessMode("Backup");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _BackupUI = new BackupUI();
                    _BackupUI.MdiParent = this;
                    _BackupUI.Show();
                }
                else
                {
                    _BackupUI.Focus();
                    _BackupUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowAbout()
        {
            try
            {
                if (_About == null || !_About.Visible)
                {
                    if (_About != null)
                        _About.Dispose();
                    _About = new About();
                    _About.MdiParent = this;
                    _About.Show();
                }
                else
                {
                    _About.Focus();
                    _About.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowPatientList()
        {
            try
            {
                if (_PatientListReport == null || !_PatientListReport.Visible)
                {
                    if (_PatientListReport != null)
                        _PatientListReport.Dispose();
                    accessMode = GetAccessMode("PatientListReport");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _PatientListReport = new PatientListReport();
                    _PatientListReport.MdiParent = this;
                    _PatientListReport.Show();
                }
                else
                {
                    _PatientListReport.Focus();
                    _PatientListReport.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowPrescriptionList()
        {
            try
            {
                if (_PrescriptionListReport == null || !_PrescriptionListReport.Visible)
                {
                    if (_PrescriptionListReport != null)
                        _PrescriptionListReport.Dispose();
                    accessMode = GetAccessMode("PrescriptionListReport");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _PrescriptionListReport = new PrescriptionListReport();
                    _PrescriptionListReport.MdiParent = this;
                    _PrescriptionListReport.Show();
                }
                else
                {
                    _PrescriptionListReport.Focus();
                    _PrescriptionListReport.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowCostReport()
        {
            try
            {
                if (_CostReport == null || !_CostReport.Visible)
                {
                    if (_CostReport != null)
                        _CostReport.Dispose();
                    accessMode = GetAccessMode("CostReport");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _CostReport = new CostReport();
                    _CostReport.MdiParent = this;
                    _CostReport.Show();
                }
                else
                {
                    _CostReport.Focus();
                    _CostReport.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void MinimizeAll()
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.WindowState = FormWindowState.Minimized;
            }
        }
        private void CloseAll()
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.Close();
            }
        }
        private void RestoreAll()
        {
            foreach (Form childform in this.MdiChildren)
            {
                childform.WindowState = FormWindowState.Normal;
            }
        }
        private void ShowCallAlarmUI()
        {
            try
            {
                if (_CallAlarmUI == null || !_CallAlarmUI.Visible)
                {
                    if (_CallAlarmUI != null)
                        _CallAlarmUI.Dispose();
                    PatientBLL _PatientBLL = new PatientBLL();
                    if (_PatientBLL.HasAlarm())
                    {
                        _CallAlarmUI = new CallAlarmUI();
                        _CallAlarmUI.MdiParent = this;
                        _CallAlarmUI.Show();
                    }
                }
                else
                {
                    _CallAlarmUI.Focus();
                    _CallAlarmUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowEquipmentShortageAlarmUI()
        {
            try
            {
                if (_EquipmentShortageAlarmUI == null || !_EquipmentShortageAlarmUI.Visible)
                {
                    if (_EquipmentShortageAlarmUI != null)
                        _EquipmentShortageAlarmUI.Dispose();
                    EquipmentBLL _EquipmentBLL = new EquipmentBLL();
                    if (_EquipmentBLL.HasShortageAlarm())
                    {
                        _EquipmentShortageAlarmUI = new EquipmentShortageAlarmUI();
                        _EquipmentShortageAlarmUI.MdiParent = this;
                        _EquipmentShortageAlarmUI.Show();
                    }
                }
                else
                {
                    _EquipmentShortageAlarmUI.Focus();
                    _EquipmentShortageAlarmUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowEquipmentExpiredAlarmUI()
        {
            try
            {
                if (_EquipmentExpiredAlarmUI == null || !_EquipmentExpiredAlarmUI.Visible)
                {
                    if (_EquipmentExpiredAlarmUI != null)
                        _EquipmentExpiredAlarmUI.Dispose();
                    EquipmentBLL _EquipmentBLL = new EquipmentBLL();
                    if (_EquipmentBLL.HasExpiredAlarm())
                    {
                        _EquipmentExpiredAlarmUI = new EquipmentExpiredAlarmUI();
                        _EquipmentExpiredAlarmUI.MdiParent = this;
                        _EquipmentExpiredAlarmUI.Show();
                    }
                }
                else
                {
                    _EquipmentExpiredAlarmUI.Focus();
                    _EquipmentExpiredAlarmUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowRoleUI()
        {
            try
            {
                if (_ShowRoleUI == null || !_ShowRoleUI.Visible)
                {
                    if (_ShowRoleUI != null)
                        _ShowRoleUI.Dispose();
                    accessMode = GetAccessMode("ShowRole");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowRoleUI = new ShowRoleUI(accessMode);
                    _ShowRoleUI.MdiParent = this;
                    _ShowRoleUI.Show();
                }
                else
                {
                    _ShowRoleUI.Focus();
                    _ShowRoleUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowPatientUI()
        {
            try
            {
                if (_ShowPatientUI == null || !_ShowPatientUI.Visible)
                {
                    if (_ShowPatientUI != null)
                        _ShowPatientUI.Dispose();
                    accessMode = GetAccessMode("ShowPatient");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowPatientUI = new ShowPatientUI(accessMode);
                    _ShowPatientUI.MdiParent = this;
                    _ShowPatientUI.Show();
                }
                else
                {
                    _ShowPatientUI.Focus();
                    _ShowPatientUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowInsuranceTypeUI()
        {
            try
            {
                if (_ShowInsuranceTypeUI == null || !_ShowInsuranceTypeUI.Visible)
                {
                    if (_ShowInsuranceTypeUI != null)
                        _ShowInsuranceTypeUI.Dispose();
                    accessMode = GetAccessMode("ShowInsuranceType");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowInsuranceTypeUI = new ShowInsuranceTypeUI(accessMode);
                    _ShowInsuranceTypeUI.MdiParent = this;
                    _ShowInsuranceTypeUI.Show();
                }
                else
                {
                    _ShowInsuranceTypeUI.Focus();
                    _ShowInsuranceTypeUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowDiseasesUI()
        {
            try
            {
                if (_ShowDiseasesUI == null || !_ShowDiseasesUI.Visible)
                {
                    if (_ShowDiseasesUI != null)
                        _ShowDiseasesUI.Dispose();
                    accessMode = GetAccessMode("ShowDiseases");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowDiseasesUI = new ShowDiseasesUI(accessMode);
                    _ShowDiseasesUI.MdiParent = this;
                    _ShowDiseasesUI.Show();
                }
                else
                {
                    _ShowDiseasesUI.Focus();
                    _ShowDiseasesUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowEquipmentUI()
        {
            try
            {
                if (_ShowEquipmentUI == null || !_ShowEquipmentUI.Visible)
                {
                    if (_ShowEquipmentUI != null)
                        _ShowEquipmentUI.Dispose();
                    accessMode = GetAccessMode("ShowEquipment");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowEquipmentUI = new ShowEquipmentUI(accessMode);
                    _ShowEquipmentUI.MdiParent = this;
                    _ShowEquipmentUI.Show();
                }
                else
                {
                    _ShowEquipmentUI.Focus();
                    _ShowEquipmentUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowServiceTypeUI()
        {
            try
            {
                if (_ShowServiceTypeUI == null || !_ShowServiceTypeUI.Visible)
                {
                    if (_ShowServiceTypeUI != null)
                        _ShowServiceTypeUI.Dispose();
                    accessMode = GetAccessMode("ShowServiceType");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowServiceTypeUI = new ShowServiceTypeUI(accessMode);
                    _ShowServiceTypeUI.MdiParent = this;
                    _ShowServiceTypeUI.Show();
                }
                else
                {
                    _ShowServiceTypeUI.Focus();
                    _ShowServiceTypeUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowEquipmentHistoryUI()
        {
            try
            {
                if (_EquipmentHistoryUI == null || !_EquipmentHistoryUI.Visible)
                {
                    if (_EquipmentHistoryUI != null)
                        _EquipmentHistoryUI.Dispose();
                    accessMode = GetAccessMode("EquipmentHistory");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _EquipmentHistoryUI = new EquipmentHistoryUI(accessMode);
                    _EquipmentHistoryUI.MdiParent = this;
                    _EquipmentHistoryUI.Show();
                }
                else
                {
                    _EquipmentHistoryUI.Focus();
                    _EquipmentHistoryUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowSpecialistUI()
        {
            try
            {
                if (_ShowSpecialistUI == null || !_ShowSpecialistUI.Visible)
                {
                    if (_ShowSpecialistUI != null)
                        _ShowSpecialistUI.Dispose();
                    accessMode = GetAccessMode("ShowSpecialist");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowSpecialistUI = new ShowSpecialistUI(accessMode);
                    _ShowSpecialistUI.MdiParent = this;
                    _ShowSpecialistUI.Show();
                }
                else
                {
                    _ShowSpecialistUI.Focus();
                    _ShowSpecialistUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowAppointmentTypeUI()
        {
            try
            {
                if (_ShowAppointmentTypeUI == null || !_ShowAppointmentTypeUI.Visible)
                {
                    if (_ShowAppointmentTypeUI != null)
                        _ShowAppointmentTypeUI.Dispose();
                    accessMode = GetAccessMode("ShowAppointmentType");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowAppointmentTypeUI = new ShowAppointmentTypeUI(accessMode);
                    _ShowAppointmentTypeUI.MdiParent = this;
                    _ShowAppointmentTypeUI.Show();
                }
                else
                {
                    _ShowAppointmentTypeUI.Focus();
                    _ShowAppointmentTypeUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowUserUI()
        {
            try
            {
                if (_ShowUserUI == null || !_ShowUserUI.Visible)
                {
                    if (_ShowUserUI != null)
                        _ShowUserUI.Dispose();
                    accessMode = GetAccessMode("ShowUser");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowUserUI = new ShowUserUI(accessMode);
                    _ShowUserUI.MdiParent = this;
                    _ShowUserUI.Show();
                }
                else
                {
                    _ShowUserUI.Focus();
                    _ShowUserUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowJobUI()
        {
            try
            {
                if (_ShowJobUI == null || !_ShowJobUI.Visible)
                {
                    if (_ShowJobUI != null)
                        _ShowJobUI.Dispose();
                    accessMode = GetAccessMode("ShowJob");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    _ShowJobUI = new ShowJobUI(accessMode);
                    _ShowJobUI.MdiParent = this;
                    _ShowJobUI.Show();
                }
                else
                {
                    _ShowJobUI.Focus();
                    _ShowJobUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowAccessUI()
        {
            try
            {
                if (_AccessUI == null || !_AccessUI.Visible)
                {
                    if (_AccessUI != null)
                        _AccessUI.Dispose();
                    accessMode = GetAccessMode("Access");
                    if (accessMode != AccessMode.Complete)
                    {
                        _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                        errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
                        errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                        return;
                    }
                    _AccessUI = new AccessUI();
                    _AccessUI.MdiParent = this;
                    _AccessUI.Show();
                }
                else
                {
                    _ShowJobUI.Focus();
                    _ShowJobUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void ShowDoctor()
        {
            if (_DoctorUI == null || !_DoctorUI.Visible)
            {
                if (_DoctorUI != null)
                    _DoctorUI.Dispose();
                accessMode = GetAccessMode("ShowDoctor");
                if (accessMode == AccessMode.NoAccess)
                    return;
                _DoctorUI = new DoctorUI(accessMode);
                _DoctorUI.MdiParent = this;
                _DoctorUI.Show();
            }
            else
            {
                _DoctorUI.Focus();
                _DoctorUI.WindowState = FormWindowState.Normal;
            }
        }
        private void ShowToothColor()
        {
            if (_ShowToothColorUI == null || !_ShowToothColorUI.Visible)
            {
                if (_ShowToothColorUI != null)
                    _ShowToothColorUI.Dispose();
                accessMode = GetAccessMode("ShowToothColor");
                if (accessMode == AccessMode.NoAccess)
                    return;
                _ShowToothColorUI = new ShowToothColorUI(accessMode);
                _ShowToothColorUI.MdiParent = this;
                _ShowToothColorUI.Show();
            }
            else
            {
                _ShowToothColorUI.Focus();
                _ShowToothColorUI.WindowState = FormWindowState.Normal;
            }
        }
        private AccessMode GetAccessMode(string pageTitle)
        {
            errorLabelCommand.Text = string.Empty;
            AccessMode accessMode = AccessBLL.GetAccessMode(pageTitle, UserProfile.RoleId);
            if (accessMode == AccessMode.NoAccess)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
            }
            return accessMode;
        }
        private void GetExitConfirmtion()
        {                                
            if (closingFlag == false)
            {
                JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                DialogResult result = _JntMsgBoxFarsi.Show(BackupConfirmation, BackupText, JntStyle.YesNo);
                if (result == DialogResult.Yes)
                    ShowBackup();
                else
                {
                    closingFlag = true;
                    result = _JntMsgBoxFarsi.Show(ExitConfirmation, ExitText, JntStyle.YesNo);
                    if (result == DialogResult.Yes)
                        CloseForm();
                    else
                        closingFlag = false;
                }
            }
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void CloseApplication()
        {
            Application.Exit();
        }
        private void RestartApplication()
        {
            closingFlag = true;
            GetChangeConfirmtion();
        }
        private void GetChangeConfirmtion()
        {
            JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
            DialogResult result = _JntMsgBoxFarsi.Show(ChangeConfirmation, ChangeText, JntStyle.YesNo);
            if (result == DialogResult.Yes)
                Application.Restart();
            closingFlag = false;
        }
        private void ChangePassword()
        {
            try
            {
                if (_ChangePasswordUI == null || !_ChangePasswordUI.Visible)
                {
                    if (_ChangePasswordUI != null)
                        _ChangePasswordUI.Dispose();
                    _ChangePasswordUI = new ChangePasswordUI();
                    _ChangePasswordUI.Show();
                }
                else
                {
                    _ChangePasswordUI.Focus();
                    _ChangePasswordUI.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                errorLabelCommand.Text = _ExceptionHandlerBOL.Title;
                errorLabelCommand.DescriptionForegroundStyle.ForeColor = Color.Red;
            }
        }
        private void UncheckCustomColors()
        {
            foreach (Janus.Windows.Ribbon.GalleryItem item in this.colorsGallery.GalleryItems)
            {
                item.Checked = false;
            }
        }
        private void CreateBuiltInVisualStyleCommand(string key, string text, Color imageColor)
        {
            Janus.Windows.Ribbon.ButtonCommand command = new Janus.Windows.Ribbon.ButtonCommand(key);
            command.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Large;
            command.ActAsOptionButton = true;
            command.CheckOnClick = true;
            command.Text = text;
            command.Image = CreateColorImage(imageColor, 16, 16);
            command.LargeImage = CreateColorImage(imageColor, 32, 32);
            this.officeColorsRibbonGroup.Commands.Add(command);
        }
        private Image CreateColorImage(Color clr, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(clr);
            Rectangle r = new Rectangle(0, 0, width - 1, height - 1);
            g.DrawRectangle(Pens.Black, r);
            r.Inflate(-1, -1);
            g.DrawRectangle(Pens.White, r);
            g.Dispose();
            return bmp;
        }
        private void MenuUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetExitConfirmtion();            
            if (!closingFlag)
                e.Cancel = true;
            RemoveRibbonDynamicCommands();
        }
        private void RemoveRibbonDynamicCommands()
        {
            this.officeColorsRibbonGroup.Commands.Clear();
            this.colorsGallery.GalleryItems.Clear();
        }
        private void errorLabelCommand_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                errorLabelCommand.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }
        private void MenuUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseApplication();
        }
        private void patientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPatientUI();
        }
        private void newPatientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowEditPatientUI();
        }
    }
}
