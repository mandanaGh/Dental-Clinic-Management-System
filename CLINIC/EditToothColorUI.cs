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

    public partial class EditToothColorUI : Form
    {
        private ToothColorBLL _ToothColorBLL;
        private ResourceManager _ResourceManager= new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
         string UpdateText;
         string DeleteText;
         string UpdateConfirmation;
         string DeleteConfirmation;

         public EditToothColorUI()
         {
             InitializeComponent();
             editButton.Text = _ResourceManager.GetString("CreateButtonText");
             this.Text = _ResourceManager.GetString("AddNewToothColor");
             toothColorTitleTextBox.Focus();
             deleteButton.Visible = false;
             formMode = FormMode.Insert;
             _ToothColorBLL = new ToothColorBLL();
             getMaxToothColorId();
         }
         public EditToothColorUI(ToothColorBOL _ToothColorBOL)
         {
             InitializeComponent();
             formMode = FormMode.Update;
             toothColorTitleTextBox.Focus();
             _ToothColorBLL = new ToothColorBLL();
             fillTextBoxes(_ToothColorBOL);
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
        private void getMaxToothColorId()
        {
            toothColorIdTextBox.Text = _ToothColorBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(ToothColorBOL _ToothColorBOL)
        {
            toothColorIdTextBox.Text = _ToothColorBOL.ToothColorId.ToString();
            toothColorTitleTextBox.Text = _ToothColorBOL.ToothColorTitle;
            descriptionTextBox.Text = _ToothColorBOL.Description;
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
            short? toothColorId;
            try
            {
                toothColorId = Convert.ToInt16(toothColorIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string toothColorTitle = toothColorTitleTextBox.Text;
            string description = descriptionTextBox.Text;
            ToothColorBOL _ToothColorBOL = new ToothColorBOL(toothColorId, toothColorTitle, description);
            if (formMode == FormMode.Insert)
                _ToothColorBLL.Insert(_ToothColorBOL);
            else
                _ToothColorBLL.Update(_ToothColorBOL);
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
                short toothColorId = Convert.ToInt16(toothColorIdTextBox.Text);
                ToothColorBOL _ToothColorBOL = new ToothColorBOL(toothColorId, null, null);
                _ToothColorBLL.Delete(_ToothColorBOL);
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