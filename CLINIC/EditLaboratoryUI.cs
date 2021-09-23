using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using BusinessLogicLayer;
using BusinessObjectLayer;
using ComplexDataType;
using JntMsgBox;

namespace UserInterface
{
    public partial class EditLaboratoryUI : Form
    {
        private LaboratoryBLL _LaboratoryBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditLaboratoryUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewLaboratory");
            laboratoryTitleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _LaboratoryBLL = new LaboratoryBLL();
            getMaxLaboratoryId();
        }
        public EditLaboratoryUI(LaboratoryBOL _LaboratoryBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            laboratoryTitleTextBox.Focus();
            _LaboratoryBLL = new LaboratoryBLL();
            fillTextBoxes(_LaboratoryBOL);
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
        private void getMaxLaboratoryId()
        {
            laboratoryIdTextBox.Text = _LaboratoryBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(LaboratoryBOL _LaboratoryBOL)
        {
            laboratoryIdTextBox.Text = _LaboratoryBOL.LaboratoryId.ToString();
            laboratoryTitleTextBox.Text = _LaboratoryBOL.LaboratoryTitle;
            addressTextBox.Text = _LaboratoryBOL.Address;
            telMaskedTextBox.Text = _LaboratoryBOL.Tel;
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
            if (ValidateItem())
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
            short? laboratoryId;
            try
            {
                laboratoryId = Convert.ToInt16(laboratoryIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string laboratoryTitle = laboratoryTitleTextBox.Text;
            string address = addressTextBox.Text;
            string tel = telMaskedTextBox.Text;
            LaboratoryBOL _LaboratoryBOL = new LaboratoryBOL(laboratoryId, laboratoryTitle, address, tel);
            if (formMode == FormMode.Insert)
                _LaboratoryBLL.Insert(_LaboratoryBOL);
            else
                _LaboratoryBLL.Update(_LaboratoryBOL);
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
                short laboratoryId = Convert.ToInt16(laboratoryIdTextBox.Text);
                LaboratoryBOL _LaboratoryBOL = new LaboratoryBOL(laboratoryId, null, null,null);
                _LaboratoryBLL.Delete(_LaboratoryBOL);
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