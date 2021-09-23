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

    public partial class UserLogin : Form
    {
        private int incorrectTimes = 0;
        private int loginTimes = 0;
        private string lastUserName = string.Empty;
        UserBLL _UserBLL = new UserBLL();
        UserBOL _UserBOL = new UserBOL();
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        private ExceptionHandlerBOL _ExceptionHandlerBOL;

        public UserLogin()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(ValidateItem())
            LoginUser();
        }
        private bool ValidateItem()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void LoginUser()
        {
            _UserBOL.UserName = userNameTextBox.Text.ToString();
            _UserBOL.Password = Encryptor.EncryptedString(passwordTextBox.Text.ToString());
            try
            {               
                if (incorrectTimes > 10)
                {
                    _UserBOL.IsLocked = true;
                    _UserBLL.LockUser(_UserBOL);                    
                    incorrectTimes++;
                    return;
                }
                bool isValidUser = _UserBLL.CheckUserValid(_UserBOL);                                
                if (isValidUser)
                {
                    bool isUserLock = _UserBLL.CheckUserLock(_UserBOL);
                    if (isUserLock)
                        noticeLabel.Text = _ResourceManager.GetString("UserIsLock");
                    else
                    {                        
                        officeFormAdorner1.Form.Hide();
                        _UserBLL.LoadUserProfile(_UserBOL);
                        new MenuUI().ShowDialog();
                    }
                }
                else
                {
                    incorrectTimes++;
                    if (lastUserName == passwordTextBox.Text.ToUpper())
                        loginTimes++;
                    else
                    {
                        lastUserName = passwordTextBox.Text.ToUpper();
                        loginTimes = 1;
                    }
                    if (loginTimes > 3)
                    {
                        _UserBOL.IsLocked = true;
                        _UserBLL.LockUser(_UserBOL);
                    }
                    noticeLabel.Text = _ResourceManager.GetString("IncorrectUser");
                    passwordTextBox.Focus();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                SetExceptionMessage(_ExceptionHandlerBOL);
            }
        }
        private void SetExceptionMessage(ExceptionHandlerBOL _ExceptionHandlerBOL)
        {
            noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
            noticeLabel.Text = _ExceptionHandlerBOL.Title;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void textBoxes_Leave(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL == null)
                noticeLabel.Text = string.Empty;
        }
        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL == null)
                noticeLabel.Text = string.Empty;
        }
        private void setEnglishKeyboard_Enter(object sender, EventArgs e)
        {
            try
            {
                KeyboardControler.SetEnglishKeyboard();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                SetExceptionMessage(_ExceptionHandlerBOL);        
            }
        }
        private void noticeLabel_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                noticeLabel.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }
    }
}