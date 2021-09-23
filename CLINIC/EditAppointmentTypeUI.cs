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

    public partial class EditAppointmentTypeUI : Form
    {
        private AppointmentTypeBLL _AppointmentTypeBLL;
        private ResourceManager _ResourceManager= new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
         string UpdateText;
         string DeleteText;
         string UpdateConfirmation;
         string DeleteConfirmation;

         public EditAppointmentTypeUI()
         {
             InitializeComponent();
             appointmentTypeTitleTextBox.Focus();
             deleteButton.Visible = false;
             formMode = FormMode.Insert;
             _AppointmentTypeBLL = new AppointmentTypeBLL();
             getMaxAppointmentTypeId();
             SetResourceManager();
         }
         public EditAppointmentTypeUI(AppointmentTypeBOL _AppointmentTypeBOL)
         {
             InitializeComponent();
             formMode = FormMode.Update;
             appointmentTypeTitleTextBox.Focus();
             _AppointmentTypeBLL = new AppointmentTypeBLL();
             fillTextBoxes(_AppointmentTypeBOL);
             SetResourceManager();
         }
        private void SetResourceManager()
        {
            try
            {
                UpdateText = _ResourceManager.GetString("Update");
                DeleteText = _ResourceManager.GetString("Delete");
                UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
                DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
                editButton.Text = _ResourceManager.GetString("CreateButtonText");
                this.Text = _ResourceManager.GetString("AddNewAppointmentType");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void getMaxAppointmentTypeId()
        {
            appointmentTypeIdTextBox.Text = _AppointmentTypeBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(AppointmentTypeBOL _AppointmentTypeBOL)
        {
            appointmentTypeIdTextBox.Text = _AppointmentTypeBOL.AppointmentTypeId.ToString();
            appointmentTypeTitleTextBox.Text = _AppointmentTypeBOL.AppointmentTypeTitle;
            descriptionTextBox.Text = _AppointmentTypeBOL.Description;
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
            short? appointmentTypeId;
            try
            {
                appointmentTypeId = Convert.ToInt16(appointmentTypeIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string appointmentTypeTitle = appointmentTypeTitleTextBox.Text;
            string description = descriptionTextBox.Text;
            AppointmentTypeBOL _AppointmentTypeBOL = new AppointmentTypeBOL(appointmentTypeId, appointmentTypeTitle, description);
            if (formMode == FormMode.Insert)
                _AppointmentTypeBLL.Insert(_AppointmentTypeBOL);
            else
                _AppointmentTypeBLL.Update(_AppointmentTypeBOL);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            GetDeleteConfirmtion();
        }
        private void GetDeleteConfirmtion()
        {
            try
            {
                JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
                DialogResult result = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.YesNo);
                if (result == DialogResult.No)
                    return;
                short appointmentTypeId = Convert.ToInt16(appointmentTypeIdTextBox.Text);
                AppointmentTypeBOL _AppointmentTypeBOL = new AppointmentTypeBOL(appointmentTypeId, null, null);
                _AppointmentTypeBLL.Delete(_AppointmentTypeBOL);
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
    }
}