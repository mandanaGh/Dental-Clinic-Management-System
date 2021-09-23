using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessObjectLayer;
    using BusinessLogicLayer;
    using DataConvertor;
    using JntMsgBox;
    using ComplexDataType;

    public partial class ServiceHistoryUI : Form
    {
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        public string PatientName;
        public string ServiceTypeTitle;
        public int ServiceId;
        ServiceHistoryBLL _ServiceHistoryBLL = new ServiceHistoryBLL();
        ServiceHistoryBOL _ServiceHistoryBOL = new ServiceHistoryBOL();
        private DoctorBOL _DoctorBOL = new DoctorBOL();
        private FormMode _FormMode = FormMode.Insert;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        char[] spliter = { ';', ':' };
        string checkBoxName = "checkBox";
        string Tooth;
        string CancelText;
        string UpdateText;
        string InsertText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        AccessMode _AccessMode;
        public ServiceHistoryUI(AccessMode accessMode)
        {
            InitializeComponent();
            _AccessMode = accessMode;
        }
        private void FillInfo()
        {
            patientNameTextBox.Text = PatientName;
            serviceTypeTitleTextBox.Text = ServiceTypeTitle;
        }
        private void SetAccess()
        {
            if (_FormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
                updateButton.Enabled = deleteButton.Enabled = serviceGroupBox.Enabled = false;
            if (_FormMode == FormMode.Update && _AccessMode == AccessMode.Read)
                updateButton.Enabled = deleteButton.Enabled = serviceGroupBox.Enabled = false;
            if (_FormMode == FormMode.Insert && _AccessMode == AccessMode.Read)
                insertCancelButton.Enabled = serviceGroupBox.Enabled = false;
            requieredValidationProvider.ValidationMessages(false);
        }
        private void SetResourceManager()
        {
            CancelText = _ResourceManager.GetString("Cancel");
            UpdateText = _ResourceManager.GetString("Update");
            InsertText = _ResourceManager.GetString("Insert");
            DeleteText = _ResourceManager.GetString("Delete");
            UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
            DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
        }
        private void SetServiceHistoryUpdateVisibility(bool visibility)
        {
            deleteButton.Visible = visibility;
            updateButton.Visible = visibility;
            doctorNameTextBox.Text = descriptionTextBox.Text = string.Empty;
            servicePersianDateTimePicker.SelectedDateTime = DateTime.Now;
            for (int i = 0; i < toothPanel.Controls.Count; i++)
            {
                if (toothPanel.Controls[i].GetType().Name == "CheckBox")
                    ((CheckBox)(toothPanel.Controls[i])).Checked = false;
            }
            serviceGroupBox.Enabled = insertCancelButton.Enabled = true;
            if (visibility)
            {
                insertCancelButton.Text = CancelText;
                _FormMode = FormMode.Update;
            }
            else
            {
                insertCancelButton.Text = InsertText;
                _FormMode = FormMode.Insert;
            }
            SetAccess();
        }
        private void insertCancelButton_Click(object sender, EventArgs e)
        {
            if (_FormMode == FormMode.Insert)
                if (ValidateItem())
                    InsertServiceHistory();
            if (_FormMode == FormMode.Update)
                SetServiceHistoryUpdateVisibility(false);
        }
        private bool ValidateItem()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void InsertServiceHistory()
        {
            try
            {
                _ServiceHistoryBOL.ServiceId = ServiceId;
                _ServiceHistoryBOL.DoctorId = _DoctorBOL.DoctorId;
                _ServiceHistoryBOL.Date = servicePersianDateTimePicker.SelectedDateTime;
                _ServiceHistoryBOL.Description = descriptionTextBox.Text;
                _ServiceHistoryBOL.Tooth = SetTooth();
                _ServiceHistoryBLL.Insert(_ServiceHistoryBOL);
                SetServiceHistoryUpdateVisibility(false);
                FillServiceHistoryGridEx();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private string SetTooth()
        {
            Tooth = string.Empty;
            try
            {
                for (int i = 0; i < toothPanel.Controls.Count; i++)
                {
                    if ("CheckBox" == toothPanel.Controls[i].GetType().Name)
                        if (((CheckBox)(toothPanel.Controls[i])).Checked)
                            if (((CheckBox)(toothPanel.Controls[i])).Name.StartsWith(checkBoxName))
                            {
                                string toothId = string.Format("{0};", ((CheckBox)(toothPanel.Controls[i])).Name.Replace(checkBoxName, string.Empty));
                                Tooth += toothId;
                            }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            return Tooth;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
                if (_DialogResult == DialogResult.OK)
                    UpdateServiceHistory();
            }
        }
        private void UpdateServiceHistory()
        {
            try
            {
                _ServiceHistoryBOL.DoctorId = _DoctorBOL.DoctorId;
                _ServiceHistoryBOL.Date = servicePersianDateTimePicker.SelectedDateTime;
                _ServiceHistoryBOL.Description = descriptionTextBox.Text;
                _ServiceHistoryBOL.Tooth = SetTooth();
                _ServiceHistoryBLL.Update(_ServiceHistoryBOL);
                SetServiceHistoryUpdateVisibility(false);
                FillServiceHistoryGridEx();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
            {
                DeleteServiceHistory();
                SetServiceHistoryUpdateVisibility(false);
            }
        }
        private void DeleteServiceHistory()
        {
            try
            {
                _ServiceHistoryBLL.Delete(_ServiceHistoryBOL);
                FillServiceHistoryGridEx();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
        private void FillServiceHistoryGridEx()
        {
            serviceHistoryGridEX.ClearItems();
            try
            {
                ServiceHistoryBOL[] _ServiceHistoryBOL = _ServiceHistoryBLL.Select(ServiceId);
                if (_ServiceHistoryBOL != null)
                    for (int index = 0; index < _ServiceHistoryBOL.Length; index++)
                        serviceHistoryGridEX.AddItem(_ServiceHistoryBOL[index].ServiceHistoryId, _ServiceHistoryBOL[index].Date, DataConvertor.ConvertToPersianDate(_ServiceHistoryBOL[index].Date), _ServiceHistoryBOL[index].DoctorId, _ServiceHistoryBOL[index].DoctorName, _ServiceHistoryBOL[index].Description, _ServiceHistoryBOL[index].Tooth);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadServiceHistory()
        {
            try
            {
                _ServiceHistoryBOL.ServiceHistoryId = (int)(serviceHistoryGridEX.CurrentRow.Cells["SERVICEHISTORYID"].Value);
                _ServiceHistoryBOL.DoctorId = (short)(serviceHistoryGridEX.CurrentRow.Cells["DOCTORID"].Value);
                _ServiceHistoryBOL.DoctorName = serviceHistoryGridEX.CurrentRow.Cells["DOCTORNAME"].Value.ToString();
                _ServiceHistoryBOL.Date = (DateTime)(serviceHistoryGridEX.CurrentRow.Cells["DATE"].Value);
                _ServiceHistoryBOL.Tooth = (string)(serviceHistoryGridEX.CurrentRow.Cells["TOOTH"].Value);
                _ServiceHistoryBOL.Description = (string)(serviceHistoryGridEX.CurrentRow.Cells["DESCRIPTION"].Value);
                doctorNameTextBox.Text = _ServiceHistoryBOL.DoctorName;
                _DoctorBOL.DoctorId = _ServiceHistoryBOL.DoctorId;
                _DoctorBOL.DoctorName = _ServiceHistoryBOL.DoctorName;
                servicePersianDateTimePicker.SelectedDateTime = _ServiceHistoryBOL.Date;
                descriptionTextBox.Text = _ServiceHistoryBOL.Description;
                ToothCheckBoxCheck(_ServiceHistoryBOL.Tooth);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void serviceHistoryGridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (serviceHistoryGridEX.CurrentRow != null)
                    if (serviceHistoryGridEX.CurrentRow.RowIndex > -1)
                        if (serviceHistoryGridEX.CurrentRow.Group == null)
                        {
                            SetServiceHistoryUpdateVisibility(true);
                            LoadServiceHistory();
                        }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ServiceHistory_Load(object sender, EventArgs e)
        {
            FillInfo();
            SetResourceManager();
            FillServiceHistoryGridEx();
            SetServiceHistoryUpdateVisibility(false);
        }
        private void doctorLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorLOV _DoctorLOV = new DoctorLOV();
                if (_DoctorLOV.ShowDialog() == DialogResult.OK)
                {
                    _DoctorBOL = new DoctorBOL(_DoctorLOV.DoctorID, _DoctorLOV.DoctorName);
                    if (_DoctorBOL.DoctorId > 0)
                        doctorNameTextBox.Text = _DoctorBOL.DoctorName;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ToothCheckBoxCheck(string Tooth)
        {
            try
            {
                string[] toothSet = Tooth.Split(spliter[0]);
                if (toothSet.Length > 0)
                {
                    foreach (string item in toothSet)
                        if (item != string.Empty && item != null)
                        {
                            string CheckBoxName = string.Format("{0}{1}", checkBoxName, item);
                            ((CheckBox)(toothPanel.Controls.Find(CheckBoxName, false)[0])).Checked = true;
                        }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void downCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[16];
            int j = 0;
            for (int i = 17; i <= 32; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downCheckBox.Checked);
        }
        private void upCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[16];
            int j = 0;
            for (int i = 1; i <= 16; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upCheckBox.Checked);
        }
        private void upLeftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 1; i <= 8; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upLeftCheckBox.Checked);
        }
        private void upRightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 9; i <= 16; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upRightCheckBox.Checked);
        }
        private void downRightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 17; i <= 24; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downRightCheckBox.Checked);
        }
        private void downLeftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 25; i <= 32; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downLeftCheckBox.Checked);
        }
        private void down2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[10];
            int j = 0;
            for (int i = 43; i <= 52; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, down2CheckBox.Checked);
        }
        private void up2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[10];
            int j = 0;
            for (int i = 33; i <= 42; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, up2CheckBox.Checked);
        }
        private void upLeft2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 38; i <= 42; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upLeft2CheckBox.Checked);
        }
        private void upRight2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 33; i <= 37; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upRight2CheckBox.Checked);
        }
        private void downRight2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 48; i <= 52; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downRight2CheckBox.Checked);
        }
        private void downLeft2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 43; i <= 47; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downLeft2CheckBox.Checked);
        }
        void SetCheckBoxCheck(int[] checkBoxList, bool Checked)
        {
            string _CheckBoxName;
            for (int i = 0; i < checkBoxList.Length; i++)
            {
                _CheckBoxName = string.Format("{0}{1}", checkBoxName, checkBoxList[i]);
                ((CheckBox)(toothPanel.Controls[_CheckBoxName])).Checked = Checked;
            }
        }
        private void ServiceHistoryUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
    }
}
