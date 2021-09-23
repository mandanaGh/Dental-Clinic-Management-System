using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    using BusinessObjectLayer;
    using JntMsgBox;
    using ComplexDataType;
    using System.Resources;
    using System.Reflection;
    using BusinessLogicLayer;
    using DataConvertor;

    public partial class DoctorUI : Form
    {
        private FormMode _FormMode = FormMode.Insert;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        DoctorBLL _DoctorBLL = new DoctorBLL();
        DoctorBOL _DoctorBOL = new DoctorBOL();
        string CancelText;
        string UpdateText;
        string InsertText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        AccessMode _AccessMode;
        public DoctorUI(AccessMode accessMode)
        {
            InitializeComponent();
            _AccessMode = accessMode;
        }
        private void DoctorUI_Load(object sender, EventArgs e)
        {
            SetResourceManager();
            FillDoctorGridEx();
            SpecialistComboBoxBind();
            SetDoctorUpdateVisibility(false);            
        }
        private void SetAccess()
        {            
            if (_FormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
                updateButton.Enabled = deleteButton.Enabled = docotruiGroupBox.Enabled = false;                               
            if (_FormMode == FormMode.Update && _AccessMode == AccessMode.Read)
                updateButton.Enabled = deleteButton.Enabled = docotruiGroupBox.Enabled = false;
            if (_FormMode == FormMode.Insert && _AccessMode == AccessMode.Read)
                insertCancelButton.Enabled = docotruiGroupBox.Enabled = false;
            requieredValidationProvider.ValidationMessages(false);
        }
        private void SpecialistComboBoxBind()
        {
            try
            {
                SpecialistBOL[] SpecialistRecords = new SpecialistBLL().SelectComboBox();
                specialistComboBox.Items.Clear();
                if (SpecialistRecords != null)
                    for (int index = 0; index < SpecialistRecords.Length; index++)
                    {
                        specialistComboBox.Items.Add(new ListItem(SpecialistRecords[index].SpecialistId, SpecialistRecords[index].SpecialistTitle));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
        private void doctorGridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (doctorGridEX.CurrentRow != null)
                    if (doctorGridEX.CurrentRow.RowIndex > -1)
                        if (doctorGridEX.CurrentRow.Group == null)
                        {
                            SetDoctorUpdateVisibility(true);
                            LoadDoctor();
                        }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void FillDoctorGridEx()
        {
            doctorGridEX.ClearItems();
            try
            {
                DoctorBOL[] _DoctorBOL = _DoctorBLL.Select();
                if (_DoctorBOL != null)
                    for (int index = 0; index < _DoctorBOL.Length; index++)
                        doctorGridEX.AddItem(_DoctorBOL[index].DoctorId, _DoctorBOL[index].FirstName, _DoctorBOL[index].LastName, _DoctorBOL[index].Gender, _DoctorBOL[index].DoctorCode, _DoctorBOL[index].MedicalCode, _DoctorBOL[index].SpecialistId, _DoctorBOL[index].SpecialistTitle);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadDoctor()
        {
            try
            {
                _DoctorBOL.DoctorId = (short)(doctorGridEX.CurrentRow.Cells["DOCTORID"].Value);
                _DoctorBOL.DoctorCode = DataConvertor.ConvertToString(doctorGridEX.CurrentRow.Cells["DOCTORCODE"].Value);
                _DoctorBOL.MedicalCode = (int)(doctorGridEX.CurrentRow.Cells["MEDICALCODE"].Value);
                _DoctorBOL.SpecialistId = (short)(doctorGridEX.CurrentRow.Cells["SPECIALISTID"].Value);
                _DoctorBOL.FirstName = DataConvertor.ConvertToString(doctorGridEX.CurrentRow.Cells["FIRSTNAME"].Value);
                _DoctorBOL.LastName = DataConvertor.ConvertToString(doctorGridEX.CurrentRow.Cells["LASTNAME"].Value);
                _DoctorBOL.Gender = (bool)(doctorGridEX.CurrentRow.Cells["GENDER"].Value);
                firstNametextBox.Text = _DoctorBOL.FirstName;
                lastNameTextBox.Text = _DoctorBOL.LastName;
                medicalCodeNumericEditBox.Value = _DoctorBOL.MedicalCode;
                doctorCodeTextBox.Text = _DoctorBOL.DoctorCode;
                maleRadioButton.Checked = _DoctorBOL.Gender;
                femaleRadioButton.Checked = !_DoctorBOL.Gender;
                ListItem _ListItem = new ListItem(_DoctorBOL.SpecialistId, _DoctorBOL.SpecialistTitle);
                specialistComboBox.SelectedIndex = ComboBoxSelectedIndex(specialistComboBox, _ListItem);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private int ComboBoxSelectedIndex(ComboBox _ComboBox, ListItem _ListItem)
        {
            for (int index = 0; index < _ComboBox.Items.Count; index++)
            {
                if (((ListItem)_ComboBox.Items[index]).Id == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        private void SetDoctorUpdateVisibility(bool visibility)
        {
            deleteButton.Visible = visibility;
            updateButton.Visible = visibility;
            medicalCodeNumericEditBox.Value = 0;
            firstNametextBox.Text = lastNameTextBox.Text = doctorCodeTextBox.Text = string.Empty;
            maleRadioButton.Checked = true;
            femaleRadioButton.Checked = false;
            specialistComboBox.SelectedIndex = 0;
            docotruiGroupBox.Enabled = insertCancelButton.Enabled = true;
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
            {
                if (ValidateItem())
                    InsertDoctor();
            }
            else if (_FormMode == FormMode.Update)
                SetDoctorUpdateVisibility(false);
        }
        private bool ValidateItem()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void InsertDoctor()
        {
            try
            {
                _DoctorBOL.DoctorCode = doctorCodeTextBox.Text;
                _DoctorBOL.MedicalCode = (int)medicalCodeNumericEditBox.Value;
                _DoctorBOL.FirstName = firstNametextBox.Text;
                _DoctorBOL.LastName = lastNameTextBox.Text;
                _DoctorBOL.Gender = maleRadioButton.Checked;
                _DoctorBOL.SpecialistId = (short)((ListItem)specialistComboBox.SelectedItem).Id;
                _DoctorBLL.Insert(_DoctorBOL);
                FillDoctorGridEx();
                SetDoctorUpdateVisibility(false);
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
            if (ValidateItem())
            {
                DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
                if (_DialogResult == DialogResult.OK)
                    UpdateDoctor();
            }
        }
        private void UpdateDoctor()
        {
            try
            {
                _DoctorBOL.DoctorCode = doctorCodeTextBox.Text;
                _DoctorBOL.MedicalCode = (int)medicalCodeNumericEditBox.Value;
                _DoctorBOL.FirstName = firstNametextBox.Text;
                _DoctorBOL.LastName = lastNameTextBox.Text;
                _DoctorBOL.Gender = maleRadioButton.Checked;
                _DoctorBOL.SpecialistId = (short)((ListItem)specialistComboBox.SelectedItem).Id;
                _DoctorBLL.Update(_DoctorBOL);
                FillDoctorGridEx();
                SetDoctorUpdateVisibility(false);
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
                DeleteDoctor();
        }
        private void DeleteDoctor()
        {
            try
            {
                _DoctorBLL.Delete(_DoctorBOL);
                FillDoctorGridEx();
                SetDoctorUpdateVisibility(false);
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
        private void setFarsiKeyboard_Enter(object sender, EventArgs e)
        {
            try
            {
                KeyboardControler.SetFarsiKeyboard();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void DoctorUI_KeyDown(object sender, KeyEventArgs e)
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
