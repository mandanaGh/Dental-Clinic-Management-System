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

    public partial class EditInsuranceTypeUI : Form
    {
        private InsuranceTypeBLL _InsuranceTypeBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditInsuranceTypeUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewInsuranceType");
            insuranceTypeTitleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _InsuranceTypeBLL = new InsuranceTypeBLL();
            getMaxInsuranceTypeId();
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
        private void getMaxInsuranceTypeId()
        {
            insuranceTypeIdTextBox.Text = _InsuranceTypeBLL.SelectMaxId().ToString();
        }
        public EditInsuranceTypeUI(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            _InsuranceTypeBLL = new InsuranceTypeBLL();
            fillTextBoxes(_InsuranceTypeBOL);
            insuranceTypeTitleTextBox.Focus();
        }
        private void fillTextBoxes(InsuranceTypeBOL _InsuranceTypeBOL)
        {
            insuranceTypeIdTextBox.Text = _InsuranceTypeBOL.InsuranceTypeId.ToString();
            insuranceTypeTitleTextBox.Text = _InsuranceTypeBOL.InsuranceTypeTitle;
            percentNumericEditBox.Text = _InsuranceTypeBOL.Percent.ToString();
            descriptionTextBox.Text = _InsuranceTypeBOL.Description;
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
            decimal percent = Convert.ToDecimal(percentNumericEditBox.Value);
            if (percent > 100)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("Percent"));
                noticeLabel.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            else
            {
                short? insuranceTypeId;
                try
                {
                    insuranceTypeId = Convert.ToInt16(insuranceTypeIdTextBox.Text);
                }
                catch
                {
                    throw new Exception("Code is not valid");
                }
                string insuranceTypeTitle = insuranceTypeTitleTextBox.Text;
                string description = descriptionTextBox.Text;
                InsuranceTypeBOL _InsuranceTypeBOL = new InsuranceTypeBOL(insuranceTypeId, insuranceTypeTitle, percent, description);
                if (formMode == FormMode.Insert)
                    _InsuranceTypeBLL.Insert(_InsuranceTypeBOL);
                else
                    _InsuranceTypeBLL.Update(_InsuranceTypeBOL);
            }
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
                short insuranceTypeId = Convert.ToInt16(insuranceTypeIdTextBox.Text);
                InsuranceTypeBOL _InsuranceTypeBOL = new InsuranceTypeBOL(insuranceTypeId, null, 0 ,null);
                _InsuranceTypeBLL.Delete(_InsuranceTypeBOL);
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