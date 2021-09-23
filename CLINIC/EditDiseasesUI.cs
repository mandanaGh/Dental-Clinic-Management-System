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

    public partial class EditDiseasesUI : Form
    {
        private DiseasesBLL _DiseasesBLL;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
        string UpdateText;
        string DeleteText;
        string UpdateConfirmation;
        string DeleteConfirmation;

        public EditDiseasesUI()
        {
            InitializeComponent();
            editButton.Text = _ResourceManager.GetString("CreateButtonText");
            this.Text = _ResourceManager.GetString("AddNewDiseases");
            diseasesTitleTextBox.Focus();
            deleteButton.Visible = false;
            formMode = FormMode.Insert;
            _DiseasesBLL = new DiseasesBLL();
            getMaxDiseasesId();
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
        private void getMaxDiseasesId()
        {
            diseasesIdTextBox.Text = _DiseasesBLL.SelectMaxId().ToString();
        }
        public EditDiseasesUI(DiseasesBOL _DiseasesBOL)
        {
            InitializeComponent();
            formMode = FormMode.Update;
            _DiseasesBLL = new DiseasesBLL();
            fillTextBoxes(_DiseasesBOL);
            diseasesTitleTextBox.Focus();
        }
        private void fillTextBoxes(DiseasesBOL _DiseasesBOL)
        {
            diseasesIdTextBox.Text = _DiseasesBOL.DiseasesId.ToString();
            diseasesTitleTextBox.Text = _DiseasesBOL.DiseasesTitle;
            isDangerousCheckBox.Checked = _DiseasesBOL.IsDangerous;
            descriptionTextBox.Text = _DiseasesBOL.Description;
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
            short? diseasesId;
            try
            {
                diseasesId = Convert.ToInt16(diseasesIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string diseasesTitle = diseasesTitleTextBox.Text;
            bool isDangerous = isDangerousCheckBox.Checked;
            string description = descriptionTextBox.Text;
            DiseasesBOL _DiseasesBOL = new DiseasesBOL(diseasesId, diseasesTitle, isDangerous, description);
            if (formMode == FormMode.Insert)
                _DiseasesBLL.Insert(_DiseasesBOL);
            else
                _DiseasesBLL.Update(_DiseasesBOL);
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
                short diseasesId = Convert.ToInt16(diseasesIdTextBox.Text);
                DiseasesBOL _DiseasesBOL = new DiseasesBOL(diseasesId, null,false, null);
                _DiseasesBLL.Delete(_DiseasesBOL);
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