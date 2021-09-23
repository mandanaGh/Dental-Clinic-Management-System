using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    using ComplexDataType;
    using JntMsgBox;

    public partial class EditEquipmentUI : Form
    {
        private EquipmentBLL _EquipmentBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditEquipmentUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewEquipment");
            equipmentTitleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _EquipmentBLL = new EquipmentBLL();
            getMaxEquipmentId();
            expiredPersianDateTimePicker.SelectedDateTime = DateTime.Today;
        }
        public EditEquipmentUI(EquipmentBOL _EquipmentBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            equipmentTitleTextBox.Focus();
            _EquipmentBLL = new EquipmentBLL();
            FillEquipment(_EquipmentBOL);            
        }
        private void SetResourceManager()
        {
            try
            {
                UpdateText = _ResourceManager.GetString("Update");
                DeleteText = _ResourceManager.GetString("Delete");
                UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
                DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void getMaxEquipmentId()
        {
            equipmentIdTextBox.Text = _EquipmentBLL.SelectMaxId().ToString();
        }
        private void FillEquipment(EquipmentBOL _EquipmentBOL)
        {
            equipmentIdTextBox.Text = _EquipmentBOL.EquipmentId.ToString();
            equipmentTitleTextBox.Text = _EquipmentBOL.EquipmentTitle;
            countNumericEditBox.Value = _EquipmentBOL.Count;
            expiredPersianDateTimePicker.SelectedDateTime = _EquipmentBOL.ExpiredDate;
            expiredDateTimePicker.Value = _EquipmentBOL.ExpiredDate;
            descriptionTextBox.Text = _EquipmentBOL.Description;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if(ValidateItem()) 
                GetEditConfirmtion();
        }
        private bool ValidateItem()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void GetEditConfirmtion()
        {
            try
            {
                if (formMode == FormMode.Update)
                {
                    SetResourceManager();
                    JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                    DialogResult result = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.YesNo);
                    if (result == DialogResult.No)
                        return;
                }
                Edit();
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            finally { }
        }
        private void Edit()
        {
            short? equipmentId;
            try
            {
                equipmentId= Convert.ToInt16(equipmentIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string equipmentTitle = equipmentTitleTextBox.Text;
            int count = Convert.ToInt32(countNumericEditBox.Value);
            DateTime expiredDate = expiredPersianDateTimePicker.SelectedDateTime;
            string description = descriptionTextBox.Text;
            EquipmentBOL _EquipmentBOL = new EquipmentBOL(equipmentId,equipmentTitle,count,expiredDate,description);
            if (formMode == FormMode.Insert)
                _EquipmentBLL.Insert(_EquipmentBOL);
            else
                _EquipmentBLL.Update(_EquipmentBOL);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            GetDeleteConfirmtion();
        }
        private void GetDeleteConfirmtion()
        {
            try
            {
                SetResourceManager();
                JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                DialogResult result = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.YesNo);
                if (result == DialogResult.No)
                    return;
                short equipmentId = Convert.ToInt16(equipmentIdTextBox.Text);
                EquipmentBOL _EquipmentBOL = new EquipmentBOL(equipmentId, null,0,DateTime.Now, null);
                _EquipmentBLL.Delete(_EquipmentBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            finally { }
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
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
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }        
        private void expiredDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            expiredPersianDateTimePicker.SelectedDateTime = expiredDateTimePicker.Value;
        }
        private void expiredPersianDateTimePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            expiredDateTimePicker.Value = expiredPersianDateTimePicker.SelectedDateTime;
        }
    }
}