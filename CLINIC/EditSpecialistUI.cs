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

    public partial class EditSpecialistUI : Form
    {
        private SpecialistBLL _SpecialistBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditSpecialistUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewSpecialist");
            specialistTitleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _SpecialistBLL = new SpecialistBLL();
            getMaxSpecialistId();
        }
        public EditSpecialistUI(SpecialistBOL _SpecialistBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            specialistTitleTextBox.Focus();
            _SpecialistBLL = new SpecialistBLL();
            fillTextBoxes(_SpecialistBOL);
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
        private void getMaxSpecialistId()
        {
            specialistIdTextBox.Text = _SpecialistBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(SpecialistBOL _SpecialistBOL)
        {
            specialistIdTextBox.Text = _SpecialistBOL.SpecialistId.ToString();
            specialistTitleTextBox.Text = _SpecialistBOL.SpecialistTitle;
            descriptionTextBox.Text = _SpecialistBOL.Description;
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
            short? specialistId;
            try
            {
                specialistId = Convert.ToInt16(specialistIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string specialistTitle = specialistTitleTextBox.Text;
            string description = descriptionTextBox.Text;
            SpecialistBOL _SpecialistBOL = new SpecialistBOL(specialistId, specialistTitle, description);
            if (formMode == FormMode.Insert)
                _SpecialistBLL.Insert(_SpecialistBOL);
            else
                _SpecialistBLL.Update(_SpecialistBOL);
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
                short specialistId = Convert.ToInt16(specialistIdTextBox.Text);
                SpecialistBOL _SpecialistBOL = new SpecialistBOL(specialistId, null, null);
                _SpecialistBLL.Delete(_SpecialistBOL);
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