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

    public partial class EditServiceTypeUI : Form
    {
        private ServiceTypeBLL _ServiceTypeBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditServiceTypeUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewServiceType");
            serviceTypeTitleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _ServiceTypeBLL = new ServiceTypeBLL();
            getMaxServiceTypeId();
        }
        public EditServiceTypeUI(ServiceTypeBOL _ServiceTypeBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            serviceTypeTitleTextBox.Focus();
            _ServiceTypeBLL = new ServiceTypeBLL();
            FillServiceType(_ServiceTypeBOL);
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
        private void getMaxServiceTypeId()
        {
            serviceTypeIdTextBox.Text =serviceTypeCodeTextBox.Text= _ServiceTypeBLL.SelectMaxId().ToString();
        }
        private void FillServiceType(ServiceTypeBOL _ServiceTypeBOL)
        {
            serviceTypeIdTextBox.Text = _ServiceTypeBOL.ServiceTypeId.ToString();
            serviceTypeTitleTextBox.Text = _ServiceTypeBOL.ServiceTypeTitle;
            serviceTypeCodeTextBox.Text = _ServiceTypeBOL.ServiceTypeCode;
            sessionNumericEditBox.Value = _ServiceTypeBOL.Session;
            nextRefrenceNumericEditBox.Value = _ServiceTypeBOL.NextRefrence;
            priceNumericEditBox.Text = _ServiceTypeBOL.Price.ToString();
            descriptionTextBox.Text = _ServiceTypeBOL.Description;
            isLaboratoryCheckBox.Checked = _ServiceTypeBOL.IsLaboratory;
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
            short? serviceTypeId;
            try
            {
                serviceTypeId = Convert.ToInt16(serviceTypeIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string serviceTypeTitle = serviceTypeTitleTextBox.Text;
            string serviceTypeCode = serviceTypeCodeTextBox.Text;
            long price = Convert.ToInt64(priceNumericEditBox.Value);
            short session = Convert.ToInt16(sessionNumericEditBox.Value);
            short nextRefrence = Convert.ToInt16(nextRefrenceNumericEditBox.Value);
            string description = descriptionTextBox.Text;
            bool isLaboratory = isLaboratoryCheckBox.Checked;
            ServiceTypeBOL _ServiceTypeBOL = new ServiceTypeBOL(serviceTypeId, serviceTypeTitle, price, session, serviceTypeCode, nextRefrence, description,isLaboratory);
            if (formMode == FormMode.Insert)
                _ServiceTypeBLL.Insert(_ServiceTypeBOL);
            else
                _ServiceTypeBLL.Update(_ServiceTypeBOL);
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
                short serviceTypeId = Convert.ToInt16(serviceTypeIdTextBox.Text);
                ServiceTypeBOL _ServiceTypeBOL = new ServiceTypeBOL(serviceTypeId);
                _ServiceTypeBLL.Delete(_ServiceTypeBOL);
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