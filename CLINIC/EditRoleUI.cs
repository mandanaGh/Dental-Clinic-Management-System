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

    public partial class EditRoleUI : Form
    {
        private RoleBLL _RoleBLL;
        private ResourceManager _ResourceManager= new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private FormMode formMode;
         string UpdateText;
         string DeleteText;
         string UpdateConfirmation;
         string DeleteConfirmation;

         public EditRoleUI()
         {
             InitializeComponent();
             editButton.Text = _ResourceManager.GetString("CreateButtonText");
             this.Text = _ResourceManager.GetString("AddNewRole");
             roleTitleTextBox.Focus();
             deleteButton.Visible = false;
             formMode = FormMode.Insert;
             _RoleBLL = new RoleBLL();
             getMaxRoleId();
         }
         public EditRoleUI(RoleBOL _RoleBOL)
         {
             InitializeComponent();
             formMode = FormMode.Update;
             roleTitleTextBox.Focus();
             _RoleBLL = new RoleBLL();
             fillTextBoxes(_RoleBOL);
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
        private void getMaxRoleId()
        {
            roleIdTextBox.Text = _RoleBLL.SelectMaxId().ToString();
        }
        private void fillTextBoxes(RoleBOL _RoleBOL)
        {
            roleIdTextBox.Text = _RoleBOL.RoleId.ToString();
            roleTitleTextBox.Text = _RoleBOL.RoleTitle;
            descriptionTextBox.Text = _RoleBOL.Description;
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
            short? roleId;
            try
            {
                roleId = Convert.ToInt16(roleIdTextBox.Text);
            }
            catch
            {
                throw new Exception("Code is not valid");
            }
            string roleTitle = roleTitleTextBox.Text;
            string description = descriptionTextBox.Text;
            RoleBOL _RoleBOL = new RoleBOL(roleId, roleTitle, description);
            if (formMode == FormMode.Insert)
                _RoleBLL.Insert(_RoleBOL);
            else
                _RoleBLL.Update(_RoleBOL);
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
                short roleId = Convert.ToInt16(roleIdTextBox.Text);
                RoleBOL _RoleBOL = new RoleBOL(roleId, null, null);
                _RoleBLL.Delete(_RoleBOL);
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