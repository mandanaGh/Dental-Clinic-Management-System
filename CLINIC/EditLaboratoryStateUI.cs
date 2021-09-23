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

    public partial class EditLaboratoryStateUI : Form
    {
        private LaboratoryStateBLL _LaboratoryStateBLL;
        private ResourceManager _ResourceManager= new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
         string UpdateText;
         string DeleteText;
         string UpdateConfirmation;
         string DeleteConfirmation;

         public EditLaboratoryStateUI()
         {
             InitializeComponent();
             editButton.Text = _ResourceManager.GetString("CreateButtonText");
             this.Text = _ResourceManager.GetString("AddNewLaboratoryState");
             laboratoryStateTitleTextBox.Focus();
             deleteButton.Visible = false;
             formMode = FormMode.Insert;
             _LaboratoryStateBLL = new LaboratoryStateBLL();
             getMaxLaboratoryStateId();
         }
         public EditLaboratoryStateUI(LaboratoryStateBOL _LaboratoryStateBOL)
         {
             InitializeComponent();
             formMode = FormMode.Update;
             laboratoryStateTitleTextBox.Focus();
             _LaboratoryStateBLL = new LaboratoryStateBLL();
             fillTextBoxes(_LaboratoryStateBOL);
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
        private void getMaxLaboratoryStateId()
        {
            laboratoryStateIdTextBox.Text = _LaboratoryStateBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(LaboratoryStateBOL _LaboratoryStateBOL)
        {
            laboratoryStateIdTextBox.Text = _LaboratoryStateBOL.LaboratoryStateId.ToString();
            laboratoryStateTitleTextBox.Text = _LaboratoryStateBOL.LaboratoryStateTitle;
            descriptionTextBox.Text = _LaboratoryStateBOL.Description;
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
            short? laboratoryStateId;
            try
            {
                laboratoryStateId = Convert.ToInt16(laboratoryStateIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string laboratoryStateTitle = laboratoryStateTitleTextBox.Text;
            string description = descriptionTextBox.Text;
            LaboratoryStateBOL _LaboratoryStateBOL = new LaboratoryStateBOL(laboratoryStateId, laboratoryStateTitle, description);
            if (formMode == FormMode.Insert)
                _LaboratoryStateBLL.Insert(_LaboratoryStateBOL);
            else
                _LaboratoryStateBLL.Update(_LaboratoryStateBOL);
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
                short laboratoryStateId = Convert.ToInt16(laboratoryStateIdTextBox.Text);
                LaboratoryStateBOL _LaboratoryStateBOL = new LaboratoryStateBOL(laboratoryStateId, null, null);
                _LaboratoryStateBLL.Delete(_LaboratoryStateBOL);
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