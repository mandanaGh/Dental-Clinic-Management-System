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

    public partial class EditPhoneBookUI : Form
    {
        PhoneBookBLL _PhoneBookBLL = new PhoneBookBLL();
        PhoneBookBOL _PhoneBookBOL = new PhoneBookBOL();
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        FormMode _FormMode = FormMode.Insert;
        string CancelText;
        string UpdateText;
        string InsertText;
        string DeleteText;
        string AccessText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        string AccessConfirmation;
        string Successed;
        AccessMode _AccessMode;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();

        private void SetResourceManager()
        {
            CancelText = _ResourceManager.GetString("Cancel");
            UpdateText = _ResourceManager.GetString("Update");
            InsertText = _ResourceManager.GetString("Insert");
            DeleteText = _ResourceManager.GetString("Delete");
            AccessText = _ResourceManager.GetString("Access");
            UpdateConfirmation = _ResourceManager.GetString("UpdateConfirmation");
            DeleteConfirmation = _ResourceManager.GetString("DeleteConfirmation");
            AccessConfirmation = _ResourceManager.GetString("AccessConfirmation");
            Successed = _ResourceManager.GetString("Successed");
        }
        public EditPhoneBookUI()
        {
            InitializeComponent();
            ComboBoxBind();
            _FormMode = FormMode.Insert;
            SetPhoneBookUpdateVisibility(false);
        }
        private void SetPhoneBookUpdateVisibility(bool visibility)
        {
            try
            {

                deleteButton.Visible = visibility;
                updateButton.Visible = visibility;
                insertCancelButton.Enabled =
                infoGroupBox.Enabled = addressGroupBox.Enabled = addressGroupBox.Enabled = true;
                if (visibility)
                {
                    insertCancelButton.Text = CancelText;
                    _FormMode = FormMode.Update;
                }
                else
                {
                    insertCancelButton.Text = InsertText;
                    _FormMode = FormMode.Insert;
                }
                SetAccess();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public EditPhoneBookUI(PhoneBookBOL phoneBookBOL, AccessMode accessMode)
        {
            InitializeComponent();
            ComboBoxBind();
            _AccessMode = accessMode;
            _FormMode = FormMode.Update;
            _PhoneBookBOL = phoneBookBOL;
            LoadPhoneBook();
        }
        private void ComboBoxBind()
        {
            SetResourceManager();
            SubjectComboBoxBind();
            CityComboBoxBind();
        }
        private void SetAccess()
        {
            if ((_FormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
             || (_FormMode == FormMode.Update && _AccessMode == AccessMode.Read)
             || (_FormMode == FormMode.Insert && _AccessMode == AccessMode.Read))
                SetEnabled(false);   
        }
        private void SetEnabled(bool enabled)
        {
            if (_FormMode == FormMode.Update && !enabled)
                updateButton.Enabled = deleteButton.Enabled = enabled;
            else if (_FormMode == FormMode.Insert && !enabled)
                insertCancelButton.Enabled = enabled;
            infoGroupBox.Enabled = callGroupBox.Enabled = addressGroupBox.Enabled = enabled;
        }
        private void SubjectComboBoxBind()
        {
            try
            {
                SubjectBOL[] SubjectRecords = new SubjectBLL().SelectComboBox();
                subjectComboBox.Items.Clear();
                if (SubjectRecords != null)
                {
                    for (int index = 0; index < SubjectRecords.Length; index++)
                        subjectComboBox.Items.Add(new ListItem(SubjectRecords[index].SubjectId, SubjectRecords[index].SubjectTitle));
                    subjectComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CityComboBoxBind()
        {
            try
            {
                CityBOL[] CityRecords = new CityBLL().SelectComboBox();
                cityComboBox.Items.Clear();
                if (CityRecords != null)
                {
                    for (int index = 0; index < CityRecords.Length; index++)
                        cityComboBox.Items.Add(new ListItem(CityRecords[index].CityId, CityRecords[index].CityTitle));
                    cityComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadPhoneBook()
        {
            SetPhoneBookUpdateVisibility(true);
            ListItem _ListItem = new ListItem(_PhoneBookBOL.SubjectID, _PhoneBookBOL.SubjectTitle);
            subjectComboBox.SelectedIndex = ComboBoxSelectedIndex(subjectComboBox, _ListItem);
            if (subjectComboBox.SelectedIndex == -1 && subjectComboBox.Items.Count > -1)
                subjectComboBox.SelectedIndex = 0;
            name1TextBox.Text = _PhoneBookBOL.Name1;
            name2TextBox.Text = _PhoneBookBOL.Name2;
            tel1TextEdit.Text = _PhoneBookBOL.Tel1;
            tel2TextEdit.Text = _PhoneBookBOL.Tel2;
            fax1TextEdit.Text = _PhoneBookBOL.Fax1;
            fax2TextEdit.Text = _PhoneBookBOL.Fax2;
            mobile1TextEdit.Text = _PhoneBookBOL.Mobile1;
            mobile2TextEdit.Text = _PhoneBookBOL.Mobile2;
            EmailMaskedTextBox.Text = _PhoneBookBOL.Email;
            ListItem _CityListItem = new ListItem(_PhoneBookBOL.CityID, _PhoneBookBOL.CityTitle);
            cityComboBox.SelectedIndex = ComboBoxSelectedIndex(cityComboBox, _CityListItem);
            if (cityComboBox.SelectedIndex == -1 && cityComboBox.Items.Count > -1)
                cityComboBox.SelectedIndex = 0;
            address1TextBox.Text = _PhoneBookBOL.Address1;
            address2TextBox.Text = _PhoneBookBOL.Address2;
        }
        private int ComboBoxSelectedIndex(ComboBox _ComboBox, ListItem _ListItem)
        {
            for (int index = 0; index < _ComboBox.Items.Count; index++)
            {
                if (((ListItem)_ComboBox.Items[index]).Id == _ListItem.Id)
                    return index;
            }
            return -1;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }       
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeletePhoneBook();
        }
        private void DeletePhoneBook()
        {
            try
            {
                _PhoneBookBLL.Delete(_PhoneBookBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
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
                _PhoneBookBLL.Delete(new PhoneBookBOL((int)_PhoneBookBOL.PhoneBookId));
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
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
        private void EditPhoneBookUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
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
        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                UpdatePhoneBook();
        }
        private void UpdatePhoneBook()
        {
            try
            {
                _PhoneBookBOL.SubjectID = ((ListItem)subjectComboBox.SelectedItem).Id;                
                _PhoneBookBOL.Name1 = name1TextBox.Text;
                _PhoneBookBOL.Name2 = name2TextBox.Text;
                _PhoneBookBOL.Tel1 = tel1TextEdit.Text;
                _PhoneBookBOL.Tel2 = tel2TextEdit.Text;
                _PhoneBookBOL.Fax1 = fax1TextEdit.Text;
                _PhoneBookBOL.Fax2 = fax2TextEdit.Text;
                _PhoneBookBOL.Mobile1 = mobile1TextEdit.Text;
                _PhoneBookBOL.Mobile2 = mobile2TextEdit.Text;
                _PhoneBookBOL.Address1 = address1TextBox.Text;
                _PhoneBookBOL.Address2 = address2TextBox.Text;
                _PhoneBookBOL.Email = EmailMaskedTextBox.Text;
                _PhoneBookBOL.CityID = ((ListItem)cityComboBox.SelectedItem).Id;
                _PhoneBookBLL.Update(_PhoneBookBOL);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void insertCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_FormMode == FormMode.Insert)
                    InsertPhoneBook();
                else
                    LoadPhoneBook();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertPhoneBook()
        {
            try
            {
                _PhoneBookBOL.SubjectID = ((ListItem)subjectComboBox.SelectedItem).Id;
                _PhoneBookBOL.Name1 = name1TextBox.Text;
                _PhoneBookBOL.Name2 = name2TextBox.Text;
                _PhoneBookBOL.Tel1 = tel1TextEdit.Text;
                _PhoneBookBOL.Tel2 = tel2TextEdit.Text;
                _PhoneBookBOL.Fax1 = fax1TextEdit.Text;
                _PhoneBookBOL.Fax2 = fax2TextEdit.Text;
                _PhoneBookBOL.Mobile1 = mobile1TextEdit.Text;
                _PhoneBookBOL.Mobile2 = mobile2TextEdit.Text;
                _PhoneBookBOL.Address1 = address1TextBox.Text;
                _PhoneBookBOL.Address2 = address2TextBox.Text;
                _PhoneBookBOL.Email = EmailMaskedTextBox.Text;
                _PhoneBookBOL.CityID = ((ListItem)cityComboBox.SelectedItem).Id;
                _PhoneBookBLL.Insert(_PhoneBookBOL);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
    }
}