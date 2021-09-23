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
    using JntMsgBox;
    using ComplexDataType;
    using BusinessLogicLayer;
    using DataConvertor;

    public partial class EquipmentHistoryUI : Form
    {
        private FormMode _FormMode = FormMode.Insert;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        EquipmentHistoryBLL _EquipmentHistoryBLL = new EquipmentHistoryBLL();
        EquipmentHistoryBOL _EquipmentHistoryBOL = new EquipmentHistoryBOL();
        EquipmentBOL _EquipmentBOL = new EquipmentBOL();
        ImageBLL _ImageBLL = new ImageBLL();
        ImageBOL _ImageBOL = new ImageBOL();
        private AccessMode _AccessMode;
        string CancelText;
        string UpdateText;
        string InsertText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();

        public EquipmentHistoryUI(AccessMode accessMode)
        {
            InitializeComponent();
            _AccessMode = accessMode;
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
        private void SetEquipmentHistoryUpdateVisibility(bool visibility)
        {
            deleteButton.Visible = visibility;
            updateButton.Visible = visibility;
            equipmentTitleTextBox.Text = countNumericEditBox.Text = string.Empty;
            isInputRadioButton.Checked = true;
            isNotInputRadioButton.Checked = false;
            datePersianDateTimePicker.SelectedDateTime = DateTime.Now;
            equipmentGroupBox.Enabled = insertCancelButton.Enabled = true;
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
        private void SetAccess()
        {
            if (_FormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
                updateButton.Enabled = deleteButton.Enabled = equipmentGroupBox.Enabled = false;
            if (_FormMode == FormMode.Update && _AccessMode == AccessMode.Read)
                updateButton.Enabled = deleteButton.Enabled = equipmentGroupBox.Enabled = false;
            if (_FormMode == FormMode.Insert && _AccessMode == AccessMode.Read)
                insertCancelButton.Enabled = equipmentGroupBox.Enabled = false;
            requieredValidationProvider.ValidationMessages(false);
        }
        private void equipmentLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                EquipmentLOV _EquipmentLOV = new EquipmentLOV();
                if (_EquipmentLOV.ShowDialog() == DialogResult.OK)
                {
                    _EquipmentBOL = new EquipmentBOL(_EquipmentLOV.EquipmentID, _EquipmentLOV.EquipmentTitle);
                    if (_EquipmentBOL.EquipmentId > 0)
                        equipmentTitleTextBox.Text = _EquipmentBOL.EquipmentTitle;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
        }
        private void historyGridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (historyGridEX.CurrentRow != null)
                    if (historyGridEX.CurrentRow.RowIndex > -1)
                        if (historyGridEX.CurrentRow.Group == null)
                        {
                            SetEquipmentHistoryUpdateVisibility(true);
                            LoadEquipmentHistory();
                        }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void FillEquipmentHistoryGridEx()
        {
            historyGridEX.ClearItems();
            try
            {
                EquipmentHistoryBOL[] _EquipmentHistoryBOL = _EquipmentHistoryBLL.Select();
                if (_EquipmentHistoryBOL != null)
                    for (int index = 0; index < _EquipmentHistoryBOL.Length; index++)
                        historyGridEX.AddItem(_EquipmentHistoryBOL[index].EquipmentHistoryId, _EquipmentHistoryBOL[index].EquipmentId, _EquipmentHistoryBOL[index].EquipmentTitle, _EquipmentHistoryBOL[index].Count, _EquipmentHistoryBOL[index].Date, DataConvertor.ConvertToPersianDate(_EquipmentHistoryBOL[index].Date), _EquipmentHistoryBOL[index].IsInput);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadEquipmentHistory()
        {
            try
            {
                _EquipmentHistoryBOL.EquipmentHistoryId = DataConvertor.ConvertToLong(historyGridEX.CurrentRow.Cells["EQUIPMENTHISTORYID"].Value);
                _EquipmentHistoryBOL.EquipmentId = DataConvertor.ConvertToShort(historyGridEX.CurrentRow.Cells["EQUIPMENTID"].Value);
                _EquipmentHistoryBOL.EquipmentTitle = DataConvertor.ConvertToString(historyGridEX.CurrentRow.Cells["EQUIPMENTTITLE"].Value);
                _EquipmentHistoryBOL.Count = DataConvertor.ConvertToInt(historyGridEX.CurrentRow.Cells["COUNT"].Value);
                _EquipmentHistoryBOL.Date = (DateTime)(historyGridEX.CurrentRow.Cells["DATE"].Value);
                _EquipmentHistoryBOL.IsInput = DataConvertor.ConvertToBoolean(historyGridEX.CurrentRow.Cells["ISINPUT"].Value);
                _EquipmentBOL.EquipmentId = _EquipmentHistoryBOL.EquipmentId;
                _EquipmentBOL.EquipmentTitle = _EquipmentHistoryBOL.EquipmentTitle;
                isInputRadioButton.Checked = _EquipmentHistoryBOL.IsInput;
                isNotInputRadioButton.Checked = !_EquipmentHistoryBOL.IsInput;
                equipmentTitleTextBox.Text = _EquipmentHistoryBOL.EquipmentTitle;
                countNumericEditBox.Value = _EquipmentHistoryBOL.Count;
                datePersianDateTimePicker.SelectedDateTime = _EquipmentHistoryBOL.Date;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void insertCancelButton_Click(object sender, EventArgs e)
        {
            if (_FormMode == FormMode.Insert && ValidateItem())
                InsertEquipmentHistory();
            if (_FormMode == FormMode.Update)
                SetEquipmentHistoryUpdateVisibility(false);
        }
        private bool ValidateItem()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void InsertEquipmentHistory()
        {
            try
            {
                _EquipmentHistoryBOL.EquipmentId = _EquipmentBOL.EquipmentId;
                _EquipmentHistoryBOL.Count = Convert.ToInt32(countNumericEditBox.Value);
                _EquipmentHistoryBOL.Date = datePersianDateTimePicker.SelectedDateTime;
                _EquipmentHistoryBOL.IsInput = isInputRadioButton.Checked;
                _EquipmentHistoryBLL.Insert(_EquipmentHistoryBOL);
                SetEquipmentHistoryUpdateVisibility(false);
                FillEquipmentHistoryGridEx();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK && ValidateItem())
                UpdateEquipmentHistory();
        }
        private void UpdateEquipmentHistory()
        {
            try
            {
                _EquipmentHistoryBOL.EquipmentId = _EquipmentBOL.EquipmentId;
                _EquipmentHistoryBOL.Count = Convert.ToInt32(countNumericEditBox.Value);
                _EquipmentHistoryBOL.Date = datePersianDateTimePicker.SelectedDateTime;
                _EquipmentHistoryBOL.IsInput = isInputRadioButton.Checked;
                _EquipmentHistoryBLL.Update(_EquipmentHistoryBOL);
                SetEquipmentHistoryUpdateVisibility(false);
                FillEquipmentHistoryGridEx();
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
                DeleteEquipmentHistory();
                SetEquipmentHistoryUpdateVisibility(false);
            }
        }
        private void DeleteEquipmentHistory()
        {
            try
            {
                _EquipmentHistoryBLL.Delete(_EquipmentHistoryBOL);
                FillEquipmentHistoryGridEx();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EquipmentHistoryUI_Load(object sender, EventArgs e)
        {
            FillEquipmentHistoryGridEx();
            SetResourceManager();
            SetEquipmentHistoryUpdateVisibility(false);
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
        private void EquipmentHistoryUI_KeyDown(object sender, KeyEventArgs e)
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
