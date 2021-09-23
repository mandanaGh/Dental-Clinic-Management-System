using System;
using System.Drawing;
using System.Windows.Forms;
using ComplexDataType;
using System.Resources;
using BusinessObjectLayer;
using System.Reflection;
using BusinessLogicLayer;
using JntMsgBox;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Security.AccessControl;

namespace UserInterface
{
    using DataConvertor;

    public partial class EditPatientUI : Form
    {
        FormMode _FormMode = FormMode.Insert;
        FormMode _ImageFormMode = FormMode.Insert;
        FormMode _ServiceFormMode = FormMode.Insert;
        FormMode _RecieveFormMode = FormMode.Insert;
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        PatientBLL _PatientBLL = new PatientBLL();
        PatientBOL _PatientBOL = new PatientBOL();
        ImageBLL _ImageBLL = new ImageBLL();
        ImageBOL _ImageBOL = new ImageBOL();
        ServiceBLL _ServiceBLL = new ServiceBLL();
        ServiceBOL _ServiceBOL = new ServiceBOL();
        RecieveBLL _RecieveBLL = new RecieveBLL();
        RecieveBOL _RecieveBOL = new RecieveBOL();
        string CancelText;
        string UpdateText;
        string InsertText;
        string DeleteText;
        string AccessText;
        string UpdateConfirmation;
        string DeleteConfirmation;
        string AccessConfirmation;
        string Successed;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        AccessMode _AccessMode;
        Hashtable ToothColor;
        string checkBoxName = "checkBox";
        char[] spliter = { ';', ':' };
        public EditPatientUI()
        {
            InitializeComponent();
            datePersianDateTimePicker.SelectedDateTime = birthdayPersianDateTimePicker.SelectedDateTime = expiredPersianDateTimePicker.SelectedDateTime = servicePersianDateTimePicker.SelectedDateTime = recievePersianDateTimePicker.SelectedDateTime = DateTime.Today;
            ComboBoxBind();
            _FormMode = FormMode.Insert;
            SetPatientUpdateVisibility(false);
            patientCodeNumericEditBox.Focus();
            patientCodeNumericEditBox.Text = _PatientBLL.SelectMaxId().ToString();
        }
        public EditPatientUI(PatientBOL patientBOL, AccessMode accessMode)
        {
            InitializeComponent();
            servicePersianDateTimePicker.SelectedDateTime = recievePersianDateTimePicker.SelectedDateTime = DateTime.Today;
            ComboBoxBind();
            LoadPatientInfo(patientBOL, accessMode);
        }
        private void LoadPatientInfo(PatientBOL patientBOL, AccessMode accessMode)
        {
            _FormMode = FormMode.Update;
            _AccessMode = accessMode;
            _PatientBOL = patientBOL;
            _PatientBLL = new PatientBLL();
            nationalCodeMaskedTextBox.Focus();
            SetPatientUpdateVisibility(true);
            LoadPatient();     
            mainTab.SelectedTab = infoUITabPage;
        }
        private void ComboBoxBind()
        {
            SetResourceManager();
            DiseasesCheckedListBoxBind();
            InsuranceTypeComboBoxBind();
            JobComboBoxBind();
            ServiceTypeComboBoxBind();
        }
        private void SetAccess()
        {
            if ((_FormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
             || (_FormMode == FormMode.Update && _AccessMode == AccessMode.Read)
             || (_FormMode == FormMode.Insert && _AccessMode == AccessMode.Read))
                SetEnabled(false);
            requieredValidationProvider.ValidationMessages(false);
        }
        private void SetEnabled(bool enabled)
        {
            if (_FormMode == FormMode.Update && !enabled)
                updateButton.Enabled = deleteButton.Enabled = enabled;
            else if (_FormMode == FormMode.Insert && !enabled)
                insertCancelButton.Enabled = enabled;
            infoGroupBox.Enabled = addressGroupBox.Enabled = insuranceGroupBox.Enabled = otherGroupBox.Enabled = diseasesGroupBox.Enabled =
            toothPanel.Enabled = toothAcceptButton.Enabled =
            enabled;
        }
        private void DiseasesCheckedListBoxBind()
        {
            try
            {
                DiseasesBOL[] _DiseasesBOL = new DiseasesBLL().Select();
                diseasesCheckedListBox.Items.Clear();
                if (_DiseasesBOL != null)
                    for (int index = 0; index < _DiseasesBOL.Length; index++)
                    {
                        diseasesCheckedListBox.Items.Add(new ListItem(_DiseasesBOL[index].DiseasesId, _DiseasesBOL[index].DiseasesTitle), false);
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsuranceTypeComboBoxBind()
        {
            try
            {
                InsuranceTypeBOL[] InsuranceTypeRecords = new InsuranceTypeBLL().SelectComboBox();
                insuranceTypeComboBox.Items.Clear();
                if (InsuranceTypeRecords != null)
                    for (int index = 0; index < InsuranceTypeRecords.Length; index++)
                    {
                        insuranceTypeComboBox.Items.Add(new ListItem(InsuranceTypeRecords[index].InsuranceTypeId, InsuranceTypeRecords[index].InsuranceTypeTitle));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void JobComboBoxBind()
        {
            try
            {
                JobBOL[] JobRecords = new JobBLL().SelectComboBox();
                jobComboBox.Items.Clear();
                if (JobRecords != null)
                {
                    for (int index = 0; index < JobRecords.Length; index++)
                    {
                        jobComboBox.Items.Add(new ListItem(JobRecords[index].JobId, JobRecords[index].JobTitle));
                    }
                    if (jobComboBox.Items.Count > -1)
                        jobComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ServiceTypeComboBoxBind()
        {
            try
            {
                ServiceTypeBOL[] ServiceTypeRecords = new ServiceTypeBLL().SelectComboBox();
                serviceTypeComboBox.Items.Clear();
                if (ServiceTypeRecords != null)
                    for (int index = 0; index < ServiceTypeRecords.Length; index++)
                    {
                        serviceTypeComboBox.Items.Add(new ListItem(ServiceTypeRecords[index].ServiceTypeId, ServiceTypeRecords[index].ServiceTypeTitle));
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
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
        private void SetImageUpdateVisibility(bool visibility)
        {
            imageTitleTextBox.Text = imagePathTextBox.Text = imageDescriptionTextBox.Text = string.Empty;
            imageDeleteGlassButton.Visible = imageUpdateGlassButton.Visible = visibility;
            imageInsertUpdateGlassButton.Enabled = imageUiGroupBox.Enabled = true;
            if (visibility)
            {
                imageInsertUpdateGlassButton.Text = CancelText;
                _ImageFormMode = FormMode.Update;
            }
            else
            {
                imageInsertUpdateGlassButton.Text = InsertText;
                _ImageFormMode = FormMode.Insert;
            }
            SetImageAccess();
        }
        private void SetImageAccess()
        {
            if (_ImageFormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
                imageUpdateGlassButton.Enabled = imageDeleteGlassButton.Enabled = imageUiGroupBox.Enabled = false;
            if (_ImageFormMode == FormMode.Update && _AccessMode == AccessMode.Read)
                imageUpdateGlassButton.Enabled = imageDeleteGlassButton.Enabled = imageUiGroupBox.Enabled = false;
            if (_ImageFormMode == FormMode.Insert && _AccessMode == AccessMode.Read)
                imageInsertUpdateGlassButton.Enabled = imageUiGroupBox.Enabled = false;
            imageRequiredValidationProvider.ValidationMessages(false);
        }
        private void FillImageGridEX()
        {
            try
            {
                ImageBOL[] _ImageBOL = _ImageBLL.Select((int)_PatientBOL.PatientId);
                imagegridEX.ClearItems();
                if (_ImageBOL != null)
                    for (int index = 0; index < _ImageBOL.Length; index++)
                        imagegridEX.AddItem(_ImageBOL[index].ImageId, _ImageBOL[index].ImageTitle, _ImageBOL[index].ImagePath, _ImageBOL[index].Description);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadPatient()
        {
            try
            {
                patientCodeNumericEditBox.Text = _PatientBOL.PatientCode.ToString();
                nationalCodeMaskedTextBox.Text = _PatientBOL.NationalCode.ToString();
                firstNametextBox.Text = _PatientBOL.FirstName;
                lastNameTextBox.Text = _PatientBOL.LastName;
                maleRadioButton.Checked = _PatientBOL.Gender;
                telMaskedTextBox.Text = _PatientBOL.Tel;
                mobileMaskedTextBox.Text = _PatientBOL.Mobile;
                addressTextBox.Text = _PatientBOL.Address;
                ListItem _ListItem = new ListItem(_PatientBOL.InsuranceTypeId, _PatientBOL.InsuranceTypeTitle);
                insuranceTypeComboBox.SelectedIndex = ComboBoxSelectedIndex(insuranceTypeComboBox, _ListItem);
                ListItem _JobListItem = new ListItem(_PatientBOL.JobId, _PatientBOL.JobTitle);
                jobComboBox.SelectedIndex = ComboBoxSelectedIndex(jobComboBox, _JobListItem);
                if (jobComboBox.SelectedIndex == -1 && jobComboBox.Items.Count > -1)
                    jobComboBox.SelectedIndex = 0;
                if (_PatientBOL.Birthday != null)
                    birthdayPersianDateTimePicker.SelectedDateTime = (DateTime)_PatientBOL.Birthday;
                if (_PatientBOL.ExpiredDate != null)
                    expiredPersianDateTimePicker.SelectedDateTime = (DateTime)_PatientBOL.ExpiredDate;
                insuranceCodeNumericEditBox.Text = _PatientBOL.InsuranceCode.ToString();
                maleRadioButton.Checked = _PatientBOL.Gender;
                femaleRadioButton.Checked = !_PatientBOL.Gender;
                singleRadioButton.Checked = !_PatientBOL.Married;
                marriedRadioButton.Checked = _PatientBOL.Married;
                nationalCodeMaskedTextBox.Text = _PatientBOL.NationalCode;
                dragYesRadioButton.Checked = _PatientBOL.IsUseSpecialDrag;
                dragNoRadioButton.Checked = !_PatientBOL.IsUseSpecialDrag;
                pregnantYesRadioButton.Checked = _PatientBOL.IsPregnant;
                pregnantNoRadioButton.Checked = !_PatientBOL.IsPregnant;
                underYesRadioButton.Checked = _PatientBOL.IsUnderPhysician;
                underNoRadioButton.Checked = !_PatientBOL.IsUnderPhysician;
                physicianDescriptionTextBox.Text = _PatientBOL.PhysicianDescription;
                if (_PatientBOL.Date != null)
                    datePersianDateTimePicker.SelectedDateTime = (DateTime)_PatientBOL.Date;
                isPenCheckBox.Checked = _PatientBOL.IsPenAlergic;
                isAspirinCheckBox.Checked = _PatientBOL.IsAsprinAlergic;
                isOutDragCheckBox.Checked = _PatientBOL.IsOutDragAlergic;
                isOtherCheckBox.Checked = _PatientBOL.IsOtherAlergic;
                relevantNameTextBox.Text = _PatientBOL.RelevantName;
                descriptionTextBox.Text = _PatientBOL.Description;
                isNotNormalCheckBox.Checked = !_PatientBOL.IsNormal;
                LoadDiseases();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadDiseases()
        {
            try
            {
                PatientDiseasesBOL _PatientDiseasesBOL = new PatientDiseasesBOL(null, _PatientBOL.PatientId);
                PatientDiseasesBOL[] _PatientDiseasesBOLs = new PatientDiseasesBLL().Select(_PatientDiseasesBOL);
                if (_PatientDiseasesBOLs != null)
                {
                    int indexOfItem = -1;
                    for (int index = 0; index < _PatientDiseasesBOLs.Length; index++)
                    {
                        ListItem _ListItem = new ListItem(_PatientDiseasesBOLs[index].DiseasesId, string.Empty);
                        indexOfItem = CheckBoxListSelectedIndex(diseasesCheckedListBox, _ListItem);
                        if (indexOfItem > -1)
                            diseasesCheckedListBox.SetItemChecked(indexOfItem, true);
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private int CheckBoxListSelectedIndex(CheckedListBox _CheckedListBox, ListItem _ListItem)
        {
            for (int index = 0; index < _CheckedListBox.Items.Count; index++)
            {
                if (((ListItem)_CheckedListBox.Items[index]).Id == _ListItem.Id)
                    return index;
            }
            return -1;
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
        private void SetPatientUpdateVisibility(bool visibility)
        {
            try
            {
                if (ToothColor != null)
                    ToothColor.Clear();
                deleteButton.Visible = visibility;
                updateButton.Visible = visibility;
                nationalCodeMaskedTextBox.Text = firstNametextBox.Text = lastNameTextBox.Text = nationalCodeMaskedTextBox.Text = telMaskedTextBox.Text = mobileMaskedTextBox.Text = insuranceCodeNumericEditBox.Text = relevantNameTextBox.Text = addressTextBox.Text = string.Empty;
                physicianDescriptionTextBox.Text = descriptionTextBox.Text = string.Empty;
                isPenCheckBox.Checked = isAspirinCheckBox.Checked = isOtherCheckBox.Checked = isOutDragCheckBox.Checked = isNotNormalCheckBox.Checked = false;
                IEnumerator _IEnumerator = diseasesCheckedListBox.CheckedIndices.GetEnumerator();
                while (_IEnumerator.MoveNext() != false)
                    diseasesCheckedListBox.SetItemChecked((int)_IEnumerator.Current, false);
                datePersianDateTimePicker.SelectedDateTime = expiredPersianDateTimePicker.SelectedDateTime = birthdayPersianDateTimePicker.SelectedDateTime = DateTime.Now;
                if (insuranceTypeComboBox.Items.Count > -1)
                    insuranceTypeComboBox.SelectedIndex = 0;
                if (jobComboBox.Items.Count > -1)
                    jobComboBox.SelectedIndex = 0;
                singleRadioButton.Checked = maleRadioButton.Checked = pregnantNoRadioButton.Checked = underNoRadioButton.Checked = dragNoRadioButton.Checked = true;
                marriedRadioButton.Checked = femaleRadioButton.Checked = pregnantYesRadioButton.Checked = underYesRadioButton.Checked = dragYesRadioButton.Checked = false;
                insertCancelButton.Enabled =
                infoGroupBox.Enabled = addressGroupBox.Enabled = insuranceGroupBox.Enabled = otherGroupBox.Enabled = diseasesGroupBox.Enabled =
                toothPanel.Enabled = toothAcceptButton.Enabled = true;
                for (int i = 0; i < toothPanel.Controls.Count; i++)
                {
                    if (toothPanel.Controls[i].GetType().Name == "CheckBox")
                        ((CheckBox)(toothPanel.Controls[i])).Checked = false;
                }
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
                imageUITabPage.TabVisible = recieveUITabPage.TabVisible = serviceUITabPage.TabVisible = toothColorUITabPage.TabVisible = visibility;
                SetAccess();
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
                {
                    if (ValidateItem())
                        InsertPatient();
                }
                else
                    LoadPatient();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private bool ValidateItem()
        {
            if (patientCodeNumericEditBox.Text == string.Empty)
                patientCodeNumericEditBox.Focus();
            else if (insuranceCodeNumericEditBox.Text == string.Empty)
                insuranceCodeNumericEditBox.Focus();
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void InsertPatient()
        {
            try
            {
                _PatientBOL.PatientId = new PatientBLL().SelectMaxId();
                _PatientBOL.PatientCode = DataConvertor.ConvertToInt(patientCodeNumericEditBox.Text);
                //todo: can be insert the date if insert all data change to today date
                _PatientBOL.Date = datePersianDateTimePicker.SelectedDateTime;
                _PatientBOL.FirstName = firstNametextBox.Text;
                _PatientBOL.LastName = lastNameTextBox.Text;
                _PatientBOL.Gender = maleRadioButton.Checked;
                _PatientBOL.Birthday = birthdayPersianDateTimePicker.SelectedDateTime;
                _PatientBOL.NationalCode = nationalCodeMaskedTextBox.Text;
                _PatientBOL.Married = marriedRadioButton.Checked;
                _PatientBOL.RelevantName = relevantNameTextBox.Text;
                _PatientBOL.Tel = telMaskedTextBox.Text;
                _PatientBOL.Mobile = mobileMaskedTextBox.Text;
                _PatientBOL.Address = addressTextBox.Text;
                _PatientBOL.InsuranceTypeId = ((ListItem)insuranceTypeComboBox.SelectedItem).Id;
                _PatientBOL.JobId = ((ListItem)jobComboBox.SelectedItem).Id;
                _PatientBOL.ExpiredDate = expiredPersianDateTimePicker.SelectedDateTime;
                _PatientBOL.InsuranceCode = DataConvertor.ConvertToString(insuranceCodeNumericEditBox.Text);
                _PatientBOL.Married = marriedRadioButton.Checked;
                _PatientBOL.NationalCode = nationalCodeMaskedTextBox.Text;
                _PatientBOL.IsUseSpecialDrag = dragYesRadioButton.Checked;
                _PatientBOL.IsPregnant = pregnantYesRadioButton.Checked;
                _PatientBOL.IsUnderPhysician = underYesRadioButton.Checked;
                _PatientBOL.PhysicianDescription = physicianDescriptionTextBox.Text;
                _PatientBOL.Date = datePersianDateTimePicker.SelectedDateTime;
                _PatientBOL.IsPenAlergic = isPenCheckBox.Checked;
                _PatientBOL.IsAsprinAlergic = isAspirinCheckBox.Checked;
                _PatientBOL.IsOutDragAlergic = isOutDragCheckBox.Checked;
                _PatientBOL.IsOtherAlergic = isOtherCheckBox.Checked;
                _PatientBOL.RelevantName = relevantNameTextBox.Text;
                _PatientBOL.Description = descriptionTextBox.Text;
                _PatientBOL.IsNormal = !isNotNormalCheckBox.Checked;
                _PatientBLL.Insert(_PatientBOL, SetPatientDiseases());
                LoadPatientInfo(_PatientBOL, _AccessMode);
                _JntMsgBoxFarsi.Show(Successed, InsertText, JntStyle.OkCancel);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CloseForm()
        {
            this.Close();
        }
        private List<PatientDiseasesBOL> SetPatientDiseases()
        {
            List<PatientDiseasesBOL> _PatientDiseasesBOLs = new List<PatientDiseasesBOL>();
            IEnumerator _IEnumerator = diseasesCheckedListBox.CheckedItems.GetEnumerator();
            while (_IEnumerator.MoveNext() != false)
            {
                short? DiseasesId = ((ListItem)_IEnumerator.Current).Id;
                _PatientDiseasesBOLs.Add(new PatientDiseasesBOL(DiseasesId, _PatientBOL.PatientId));
            }
            return _PatientDiseasesBOLs;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
                if (_DialogResult == DialogResult.OK)
                    UpdatePatient();
            }
        }
        private void UpdatePatient()
        {
            try
            {
                _PatientBOL.PatientCode = DataConvertor.ConvertToInt(patientCodeNumericEditBox.Text);
                //todo: can be insert the date if insert all data change to today date
                _PatientBOL.Date = datePersianDateTimePicker.SelectedDateTime;
                _PatientBOL.FirstName = firstNametextBox.Text;
                _PatientBOL.LastName = lastNameTextBox.Text;
                _PatientBOL.Gender = maleRadioButton.Checked;
                _PatientBOL.Birthday = birthdayPersianDateTimePicker.SelectedDateTime;
                _PatientBOL.NationalCode = nationalCodeMaskedTextBox.Text;
                _PatientBOL.Married = marriedRadioButton.Checked;
                _PatientBOL.RelevantName = relevantNameTextBox.Text;
                _PatientBOL.Tel = telMaskedTextBox.Text;
                _PatientBOL.Mobile = mobileMaskedTextBox.Text;
                _PatientBOL.Address = addressTextBox.Text;
                _PatientBOL.InsuranceTypeId = ((ListItem)insuranceTypeComboBox.SelectedItem).Id;
                _PatientBOL.JobId = ((ListItem)jobComboBox.SelectedItem).Id;
                _PatientBOL.ExpiredDate = expiredPersianDateTimePicker.SelectedDateTime;
                _PatientBOL.InsuranceCode = DataConvertor.ConvertToString(insuranceCodeNumericEditBox.Text);
                _PatientBOL.Married = marriedRadioButton.Checked;
                _PatientBOL.NationalCode = nationalCodeMaskedTextBox.Text;
                _PatientBOL.IsUseSpecialDrag = dragYesRadioButton.Checked;
                _PatientBOL.IsPregnant = pregnantYesRadioButton.Checked;
                _PatientBOL.IsUnderPhysician = underYesRadioButton.Checked;
                _PatientBOL.PhysicianDescription = physicianDescriptionTextBox.Text;
                _PatientBOL.Date = datePersianDateTimePicker.SelectedDateTime;
                _PatientBOL.IsPenAlergic = isPenCheckBox.Checked;
                _PatientBOL.IsAsprinAlergic = isAspirinCheckBox.Checked;
                _PatientBOL.IsOutDragAlergic = isOutDragCheckBox.Checked;
                _PatientBOL.IsOtherAlergic = isOtherCheckBox.Checked;
                _PatientBOL.RelevantName = relevantNameTextBox.Text;
                _PatientBOL.Description = descriptionTextBox.Text;
                _PatientBOL.IsNormal = !isNotNormalCheckBox.Checked;
                _PatientBLL.Update(_PatientBOL, SetPatientDiseases());
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeletePatient();
        }
        private void DeletePatient()
        {
            try
            {
                _PatientBLL.Delete(_PatientBOL);
                string ImagePath = GetImagePath();
                if (Directory.Exists(ImagePath))
                    Directory.Delete(ImagePath, true);
                CloseForm();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        string GetImagePath()
        {
            return string.Format("{0}{1}\\{2}", ServerBLL.GetServerPath(), ServerBLL.GetStringValue("ImagePath"), _PatientBOL.PatientId);
        }
        private void imageDeleteGlassButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeleteImage();
        }
        private void DeleteImage()
        {
            try
            {
                _ImageBLL.Delete(_ImageBOL);
                SetImageUpdateVisibility(false);
                FillImageGridEX();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void imageUpdateGlassButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK && ValidateImageItem())
                UpdateImage();
        }
        private void UpdateImage()
        {
            try
            {
                _ImageBOL.ImageTitle = imageTitleTextBox.Text;
                _ImageBOL.ImagePath = SetImagePath(imagePathTextBox.Text);
                _ImageBOL.Description = descriptionTextBox.Text;
                if (_ImageBOL.ImagePath != string.Empty)
                {
                    _ImageBLL.Update(_ImageBOL);
                    SetImageUpdateVisibility(false);
                    FillImageGridEX();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void imageInsertUpdateGlassButton_Click(object sender, EventArgs e)
        {
            if (_ImageFormMode == FormMode.Insert && ValidateImageItem())
                InsertImage();
            if (_ImageFormMode == FormMode.Update)
                SetImageUpdateVisibility(false);
        }
        private bool ValidateImageItem()
        {
            imageRequiredValidationProvider.ValidationMessages(!imageRequiredValidationProvider.Validate());
            return imageRequiredValidationProvider.Validate();
        }
        private void InsertImage()
        {
            try
            {
                _ImageBOL.PatientId = (int)_PatientBOL.PatientId;
                _ImageBOL.ImageTitle = imageTitleTextBox.Text;
                _ImageBOL.ImagePath = SetImagePath(imagePathTextBox.Text);
                _ImageBOL.Description = imageDescriptionTextBox.Text;
                if (_ImageBOL.ImagePath != string.Empty)
                {
                    _ImageBLL.Insert(_ImageBOL);
                    SetImageUpdateVisibility(false);
                    FillImageGridEX();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private string SetImagePath(string imagePath)
        {
            try
            {
                string DefaultImagePath = GetImagePath();
                if (Directory.Equals(DefaultImagePath, imagePath))
                    return imagePath;
                if (!Directory.Exists(DefaultImagePath))
                    Directory.CreateDirectory(DefaultImagePath);
                Directory.GetParent(DefaultImagePath).Attributes |= FileAttributes.ReadOnly;
                Directory.GetParent(DefaultImagePath).Attributes |= FileAttributes.Hidden;
                imagePath = imagePath.Replace("\\", @"/");
                string filePath = FilePath(imagePath, DefaultImagePath);
                if (imagePath != filePath)
                    File.Copy(imagePath, filePath);
                return filePath.Replace("\\", @"/");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
                return string.Empty;
            }
        }
        private string FilePath(string imagePath, string DefaultImagePath)
        {
            return DefaultImagePath + imagePath.Remove(0, imagePath.LastIndexOf(@"/"));
        }
        private void browserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = GetImagePath();
                if (!Directory.Exists(ImagePath))
                    Directory.CreateDirectory(ImagePath);
                OpenFileDialog _OpenFileDialog = new OpenFileDialog();
                _OpenFileDialog.DefaultExt = "jpg";
                _OpenFileDialog.InitialDirectory = ImagePath;
                _OpenFileDialog.Filter = "Images (*.bmp;*.jpg;*.gif)|*.jpg;*.bmp;*.gif|All Files (*.*)|*.*";
                DialogResult _DialogResult = _OpenFileDialog.ShowDialog();
                if (_DialogResult == DialogResult.No)
                    return;
                imagePathTextBox.Text = _OpenFileDialog.FileName;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void imagegridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (imagegridEX.CurrentRow != null)
                    if (imagegridEX.CurrentRow.RowIndex > -1)
                    {
                        SetImageUpdateVisibility(true);
                        LoadImage();
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadImage()
        {
            try
            {
                _ImageBOL.PatientId = (int)_PatientBOL.PatientId;
                _ImageBOL.ImageId = DataConvertor.ConvertToLong(imagegridEX.CurrentRow.Cells["IMAGEID"].Value);
                _ImageBOL.ImageTitle = DataConvertor.ConvertToString(imagegridEX.CurrentRow.Cells["IMAGETITLE"].Value);
                _ImageBOL.ImagePath = DataConvertor.ConvertToString(imagegridEX.CurrentRow.Cells["IMAGEPATH"].Value);
                _ImageBOL.Description = DataConvertor.ConvertToString(imagegridEX.CurrentRow.Cells["DESCRIPTION"].Value);
                imageTitleTextBox.Text = _ImageBOL.ImageTitle;
                imagePathTextBox.Text = _ImageBOL.ImagePath;
                imageDescriptionTextBox.Text = _ImageBOL.Description;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void imagegridEX_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            string ImagePath = DataConvertor.ConvertToString(imagegridEX.CurrentRow.Cells["IMAGEPATH"].Value);
            if (File.Exists(ImagePath))
                Process.Start("explorer.exe", ImagePath.Replace("/", @"\"));
            else
                _JntMsgBoxFarsi.Show(AccessConfirmation, AccessText, JntStyle.OkCancel);
        }
        private void serviceGridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (serviceGridEX.CurrentRow != null)
                    if (serviceGridEX.CurrentRow.RowIndex > -1)
                    {
                        SetServiceUpdateVisibility(true);
                        LoadService();
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void SetServiceUpdateVisibility(bool visibility)
        {
            if (serviceTypeComboBox.Items.Count > -1)
                serviceTypeComboBox.SelectedIndex = 0;
            servicePersianDateTimePicker.SelectedDateTime = DateTime.Now;
            isFinishedCheckBox.Checked = false;
            discountNumericEditBox.Text = "0";
            serviceDeleteButton.Visible = serviceUpdateButton.Visible = serviceHistoryButton.Visible = laboratoryButton.Visible = visibility;
            serviceInsertCancelButton.Enabled = serviceUiGroupBox.Enabled = true;
            serviceTypePriceTextEdit.Text = string.Empty;
            if (visibility)
            {
                isFinishedCheckBox.Visible = true;
                serviceInsertCancelButton.Text = CancelText;
                _ServiceFormMode = FormMode.Update;
            }
            else
            {
                isFinishedCheckBox.Visible = false;
                serviceInsertCancelButton.Text = InsertText;
                _ServiceFormMode = FormMode.Insert;
            }
            SetServiceAccess();
        }
        private void SetServiceAccess()
        {
            serviceUpdateButton.Enabled = serviceDeleteButton.Enabled = serviceUiGroupBox.Enabled = (_PatientBOL.ExpiredDate >= DateTime.Now);
            if (_ServiceFormMode == FormMode.Insert)
                serviceInsertCancelButton.Enabled = (_PatientBOL.ExpiredDate >= DateTime.Now);
            else
                serviceInsertCancelButton.Enabled = true;
            if (_ServiceFormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
                serviceUpdateButton.Enabled = serviceDeleteButton.Enabled = serviceUiGroupBox.Enabled = false;
            if (_ServiceFormMode == FormMode.Update && _AccessMode == AccessMode.Read)
                serviceUpdateButton.Enabled = serviceDeleteButton.Enabled = serviceUiGroupBox.Enabled = false;
            if (_ServiceFormMode == FormMode.Insert && _AccessMode == AccessMode.Read)
                serviceInsertCancelButton.Enabled = serviceUiGroupBox.Enabled = false;
            serviceRequiredValidationProvider.ValidationMessages(false);

        }
        private void LoadService()
        {
            try
            {
                _ServiceBOL.PatientId = (int)_PatientBOL.PatientId;
                _ServiceBOL.ServiceId = (int)(serviceGridEX.CurrentRow.Cells["SERVICEID"].Value);
                _ServiceBOL.ServiceTypeId = (short)(serviceGridEX.CurrentRow.Cells["SERVICETYPEID"].Value);
                _ServiceBOL.ServiceTypeTitle = DataConvertor.ConvertToString(serviceGridEX.CurrentRow.Cells["SERVICETYPETITLE"].Value);
                _ServiceBOL.IsLaboratory = DataConvertor.ConvertToBoolean(serviceGridEX.CurrentRow.Cells["ISLABORATORY"].Value);
                _ServiceBOL.IsFinished = DataConvertor.ConvertToBoolean(serviceGridEX.CurrentRow.Cells["ISFINISHED"].Value);
                _ServiceBOL.Date = (DateTime)(serviceGridEX.CurrentRow.Cells["Date"].Value);
                _ServiceBOL.Discount = (decimal)(serviceGridEX.CurrentRow.Cells["DISCOUNT"].Value);
                _ServiceBOL.Price = (long)(serviceGridEX.CurrentRow.Cells["PRICE"].Value);
                servicePersianDateTimePicker.SelectedDateTime = _ServiceBOL.Date;
                discountNumericEditBox.Text = DataConvertor.ConvertToString(_ServiceBOL.Discount);
                isFinishedCheckBox.Checked = _ServiceBOL.IsFinished;
                ListItem _ListItem = new ListItem(_ServiceBOL.ServiceTypeId, _ServiceBOL.ServiceTypeTitle);
                serviceTypeComboBox.SelectedIndex = ComboBoxSelectedIndex(serviceTypeComboBox, _ListItem);
                serviceTypePriceTextEdit.Text = _ServiceBOL.Price.ToString();
                IsFinishEnabeled();
                IsLaboratoryVisibeled();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void IsLaboratoryVisibeled()
        {
            try
            {
                laboratoryButton.Visible = _ServiceBOL.IsLaboratory;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void IsFinishEnabeled()
        {
            try
            {
                int Count = new ServiceHistoryBLL().SelectCount(_ServiceBOL.ServiceId);
                isFinishedCheckBox.Enabled = (Count > 0);
                //serviceHistoryButton.Enabled = !_ServiceBOL.IsFinished;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void DeleteService()
        {
            try
            {
                _ServiceBLL.Delete(_ServiceBOL);
                SetServiceUpdateVisibility(false);
                FillServiceGridEX();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private bool ValidateServiceItem()
        {
            serviceRequiredValidationProvider.ValidationMessages(!serviceRequiredValidationProvider.Validate());
            return serviceRequiredValidationProvider.Validate();
        }
        private void InsertService()
        {
            try
            {
                _ServiceBOL.Discount = Convert.ToDecimal(discountNumericEditBox.Text);
                if (_ServiceBOL.Discount > 100)
                {
                    _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("Percent"));
                    noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                    noticeLabel.Text = _ExceptionHandlerBOL.Title;
                }
                else
                {
                    _ServiceBOL.PatientId = (int)_PatientBOL.PatientId;
                    _ServiceBOL.ServiceTypeId = (short)((ListItem)serviceTypeComboBox.SelectedItem).Id;
                    _ServiceBOL.Date = servicePersianDateTimePicker.SelectedDateTime;
                    _ServiceBOL.Price = Convert.ToInt64(serviceTypePriceTextEdit.Text); 
                    _ServiceBLL.Insert(_ServiceBOL);
                    SetServiceUpdateVisibility(false);
                    FillServiceGridEX();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void serviceUpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateServiceItem())
            {
                DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
                if (_DialogResult == DialogResult.OK)
                    UpdateService();
            }
        }
        private void UpdateService()
        {
            try
            {
                 _ServiceBOL.Discount = Convert.ToDecimal(discountNumericEditBox.Text);
                 if (_ServiceBOL.Discount > 100)
                 {
                     _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("Percent"));
                     noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                     noticeLabel.Text = _ExceptionHandlerBOL.Title;
                 }
                 else
                 {
                     _ServiceBOL.PatientId = (int)_PatientBOL.PatientId;
                     _ServiceBOL.ServiceTypeId = (short)((ListItem)serviceTypeComboBox.SelectedItem).Id;
                     _ServiceBOL.IsFinished = isFinishedCheckBox.Checked;
                     _ServiceBOL.Date = servicePersianDateTimePicker.SelectedDateTime;
                     _ServiceBOL.Price = Convert.ToInt64(serviceTypePriceTextEdit.Text);
                     _ServiceBLL.Update(_ServiceBOL);                     
                     FillServiceGridEX();
                     SetServiceUpdateVisibility(false);
                 }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void serviceDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeleteService();
        }
        private void FillServiceGridEX()
        {
            try
            {
                ServiceBOL[] _ServiceBOL = _ServiceBLL.Select((int)_PatientBOL.PatientId);
                serviceGridEX.ClearItems();
                if (_ServiceBOL != null)
                    for (int index = 0; index < _ServiceBOL.Length; index++)
                        serviceGridEX.AddItem(_ServiceBOL[index].ServiceId, _ServiceBOL[index].ServiceTypeId, _ServiceBOL[index].ServiceTypeTitle, _ServiceBOL[index].IsLaboratory, _ServiceBOL[index].PatientId, _ServiceBOL[index].IsFinished, _ServiceBOL[index].Date, DataConvertor.ConvertToPersianDate(_ServiceBOL[index].Date), _ServiceBOL[index].Discount,_ServiceBOL[index].Price);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void serviceInsertCancelButton_Click(object sender, EventArgs e)
        {
            if (_ServiceFormMode == FormMode.Insert)
                if (ValidateServiceItem())
                    InsertService();
            if (_ServiceFormMode == FormMode.Update || _ServiceFormMode == FormMode.Update)
                SetServiceUpdateVisibility(false);
        }
        private void recieveDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(DeleteConfirmation, DeleteText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                DeleteRecieve();
        }
        private void recieveUpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult _DialogResult = _JntMsgBoxFarsi.Show(UpdateConfirmation, UpdateText, JntStyle.OkCancel);
            if (_DialogResult == DialogResult.OK)
                UpdateRecieve();
        }
        private void recieveInsertCancelButton_Click(object sender, EventArgs e)
        {
            if (_RecieveFormMode == FormMode.Insert)
                InsertRecieve();
            if (_RecieveFormMode == FormMode.Update || _RecieveFormMode == FormMode.Update)
                SetRecieveUpdateVisibility(false);
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
        private void SetRecieveUpdateVisibility(bool visibility)
        {
            recievePersianDateTimePicker.SelectedDateTime = DateTime.Now;
            isInputCheckBox.Checked = false;
            priceNumericEditBox.Text = "0";
            recieveDeleteButton.Visible = recieveUpdateButton.Visible = visibility;
            recieveInsertCancelButton.Enabled = recieveGroupBox.Enabled = true;
            if (visibility)
            {
                recieveInsertCancelButton.Text = CancelText;
                _RecieveFormMode = FormMode.Update;
            }
            else
            {
                recieveInsertCancelButton.Text = InsertText;
                _RecieveFormMode = FormMode.Insert;
            }
            SetRecieveAccess();
        }
        private void SetRecieveAccess()
        {
            if (_RecieveFormMode == FormMode.Update && _AccessMode == AccessMode.Insert)
                recieveUpdateButton.Enabled = recieveDeleteButton.Enabled = recieveGroupBox.Enabled = false;
            if (_RecieveFormMode == FormMode.Update && _AccessMode == AccessMode.Read)
                recieveUpdateButton.Enabled = recieveDeleteButton.Enabled = recieveGroupBox.Enabled = false;
            if (_RecieveFormMode == FormMode.Insert && _AccessMode == AccessMode.Read)
                recieveInsertCancelButton.Enabled = recieveGroupBox.Enabled = false;
        }
        private void recieveGridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (recieveGridEX.CurrentRow != null)
                    if (recieveGridEX.CurrentRow.RowIndex > -1)
                    {
                        SetRecieveUpdateVisibility(true);
                        LoadRecieve();
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LoadRecieve()
        {
            try
            {
                _RecieveBOL.PatientId = (int)_PatientBOL.PatientId;
                _RecieveBOL.RecieveId = (int)(recieveGridEX.CurrentRow.Cells["RecieveId"].Value);
                _RecieveBOL.IsInput = DataConvertor.ConvertToBoolean(recieveGridEX.CurrentRow.Cells["IsInput"].Value);
                _RecieveBOL.Date = (DateTime)(recieveGridEX.CurrentRow.Cells["Date"].Value);
                _RecieveBOL.Price = (long)(recieveGridEX.CurrentRow.Cells["Price"].Value);
                recievePersianDateTimePicker.SelectedDateTime = _RecieveBOL.Date;
                priceNumericEditBox.Text = DataConvertor.ConvertToString(_RecieveBOL.Price);
                isInputCheckBox.Checked = _RecieveBOL.IsInput;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void DeleteRecieve()
        {
            try
            {
                _RecieveBLL.Delete(_RecieveBOL);
                SetRecieveUpdateVisibility(false);
                FillRecieveGridEX();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsertRecieve()
        {
            try
            {
                _RecieveBOL.PatientId = (int)_PatientBOL.PatientId;
                _RecieveBOL.IsInput = isInputCheckBox.Checked;
                _RecieveBOL.Date = recievePersianDateTimePicker.SelectedDateTime;
                _RecieveBOL.Price = Convert.ToInt64(priceNumericEditBox.Text);
                _RecieveBLL.Insert(_RecieveBOL);
                SetRecieveUpdateVisibility(false);
                FillRecieveGridEX();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void UpdateRecieve()
        {
            try
            {
                _RecieveBOL.PatientId = (int)_PatientBOL.PatientId;
                _RecieveBOL.IsInput = isInputCheckBox.Checked;
                _RecieveBOL.Date = recievePersianDateTimePicker.SelectedDateTime;
                _RecieveBOL.Price = Convert.ToInt64(priceNumericEditBox.Text);
                _RecieveBLL.Update(_RecieveBOL);
                SetRecieveUpdateVisibility(false);
                FillRecieveGridEX();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void FillRecieveGridEX()
        {
            try
            {
                RecieveBOL[] _RecieveBOL = _RecieveBLL.Select((int)_PatientBOL.PatientId);
                recieveGridEX.ClearItems();
                if (_RecieveBOL != null)
                    for (int index = 0; index < _RecieveBOL.Length; index++)
                        recieveGridEX.AddItem(_RecieveBOL[index].RecieveId, _RecieveBOL[index].PatientId, _RecieveBOL[index].Date, DataConvertor.ConvertToPersianDate(_RecieveBOL[index].Date), _RecieveBOL[index].Price, _RecieveBOL[index].IsInput);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void serviceHistoryUIButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowServiceHistory();
                SetServiceUpdateVisibility(true);
                LoadService();                
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowServiceHistory()
        {
            try
            {            
                    AccessMode accessMode = GetAccessMode("ServiceHistory");
                    if (accessMode == AccessMode.NoAccess)
                        return;
                    if (_PatientBOL.ExpiredDate < DateTime.Now || _ServiceBOL.IsFinished)                
                        accessMode = AccessMode.Read;
                    ServiceHistoryUI _ServiceHistory = new ServiceHistoryUI(accessMode);
                    _ServiceHistory.ServiceId = _ServiceBOL.ServiceId;
                    _ServiceHistory.ServiceTypeTitle = _ServiceBOL.ServiceTypeTitle;
                    _ServiceHistory.PatientName = string.Format("{0} {1}", _PatientBOL.FirstName, _PatientBOL.LastName);
                    _ServiceHistory.ShowDialog();             
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private AccessMode GetAccessMode(string pageTitle)
        {
            noticeLabel.Text = string.Empty;
            AccessMode accessMode = AccessBLL.GetAccessMode(pageTitle, UserProfile.RoleId);
            if (accessMode == AccessMode.NoAccess)
            {
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ResourceManager.GetString("NoAccess");
            }
            return accessMode;
        }
        private void colorContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                foreach (ToolStripMenuItem _ToolStripMenuItem in colorContextMenuStrip.Items)
                    _ToolStripMenuItem.Checked = false;
                ((ToolStripMenuItem)(e.ClickedItem)).Checked = true;
                if (((ToolStripMenuItem)(e.ClickedItem)).Checked)
                {
                    CheckBox _CheckBox = colorContextMenuStrip.SourceControl as CheckBox;
                    if (ToothColor.Contains(_CheckBox.Name.Remove(0, checkBoxName.Length)))
                        ToothColor[_CheckBox.Name.Remove(0, checkBoxName.Length)] = ((ToolStripMenuItem)(e.ClickedItem)).Name;
                    else
                    {
                        ToothColor.Add(_CheckBox.Name.Remove(0, checkBoxName.Length), ((ToolStripMenuItem)(e.ClickedItem)).Name);
                        _CheckBox.Checked = true;
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void mainTab_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (mainTab.SelectedTab == toothColorUITabPage)
            {
                ColorContextMenuStripBind();
                PatientToothColorBind();
            }
            else if (mainTab.SelectedTab == serviceUITabPage)
            {
                FillServiceGridEX();
                SetServiceUpdateVisibility(false);
            }
            else if (mainTab.SelectedTab == imageUITabPage)
            {
                FillImageGridEX();
                SetImageUpdateVisibility(false);
            }
            else if (mainTab.SelectedTab == recieveUITabPage)
            {
                FillRecieveGridEX();
                SetRecieveUpdateVisibility(false);
            }
        }
        private void PatientToothColorBind()
        {
            try
            {
                ToothColor = new Hashtable();
                string toothColor = _PatientBLL.Select((int)_PatientBOL.PatientId);
                if (toothColor != string.Empty && toothColor != null)
                {
                    string[] colorSet = toothColor.Split(spliter[0]);
                    if (colorSet.Length > 0)
                    {
                        string[] color;
                        foreach (string item in colorSet)
                            if (item != string.Empty && item != null)
                            {
                                color = item.Split(spliter[1]);
                                if (color.Length == 2)
                                    ToothColor.Add(color[0], color[1]);
                            }
                        if (ToothColor.Count > 0)
                            ToothCheckBoxCheck();
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ToothCheckBoxCheck()
        {
            try
            {
                for (int i = 0; i < toothPanel.Controls.Count; i++)
                {
                    if ("CheckBox" == toothPanel.Controls[i].GetType().Name)
                        ((CheckBox)(toothPanel.Controls[i])).Checked = false;
                }
                foreach (DictionaryEntry _DictionaryEntry in ToothColor)
                    ((CheckBox)(toothPanel.Controls[checkBoxName + _DictionaryEntry.Key.ToString()])).Checked = true;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ColorContextMenuStripBind()
        {
            try
            {
                ToothColorBOL[] ToothColorBOLs = new ToothColorBLL().Select();
                colorContextMenuStrip.Items.Clear();
                if (ToothColorBOLs != null)
                    for (int index = 0; index < ToothColorBOLs.Length; index++)
                    {
                        ToolStripMenuItem _ToolStripMenuItem = new ToolStripMenuItem(ToothColorBOLs[index].ToothColorTitle, null, null, ToothColorBOLs[index].ToothColorId.ToString());
                        colorContextMenuStrip.Items.Add(_ToolStripMenuItem);
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void colorContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                for (int index = 0; index < colorContextMenuStrip.Items.Count; index++)
                    ((ToolStripMenuItem)(colorContextMenuStrip.Items[index])).Checked = false;
                CheckBox _CheckBox = colorContextMenuStrip.SourceControl as CheckBox;
                if (_CheckBox.Checked)
                    if (ToothColor[_CheckBox.Name.Remove(0, checkBoxName.Length)] != null)
                        ((ToolStripMenuItem)(colorContextMenuStrip.Items[ToothColor[_CheckBox.Name.Remove(0, checkBoxName.Length)].ToString()])).Checked = true;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ResourceManager.GetString("DeletedColor");
            }
        }
        private void serviceGridEX_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            if (serviceHistoryButton.Enabled)
            {
                ShowServiceHistory();
                SetServiceUpdateVisibility(true);
                LoadService();
            }
        }
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pregnantPanel.Visible = !maleRadioButton.Checked;
        }
        private void cancelColorButton_Click(object sender, EventArgs e)
        {
            PatientToothColorBind();
        }
        private void toothAcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string toothColor = string.Empty;
                foreach (DictionaryEntry _DictionaryEntry in ToothColor)
                    if (((CheckBox)(toothPanel.Controls[checkBoxName + _DictionaryEntry.Key.ToString()])).Checked)
                        toothColor += string.Format("{0}{1}{2}{3}", _DictionaryEntry.Key, spliter[1].ToString(), _DictionaryEntry.Value, spliter[0]);
                _PatientBLL.Update(_PatientBOL, toothColor);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EditPatientUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }
        private void laboratoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLaboratoryService();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowLaboratoryService()
        {
            try
            {
                if (!_ServiceBOL.IsFinished)
                {
                    AccessMode accessMode = GetAccessMode("LaboratoryService");
                    if (accessMode != AccessMode.Complete)
                        return;
                    LaboratoryServiceUI _LaboratoryService = new LaboratoryServiceUI();
                    _LaboratoryService.ServiceId = _ServiceBOL.ServiceId;
                    _LaboratoryService.ServiceTypeTitle = _ServiceBOL.ServiceTypeTitle;
                    _LaboratoryService.PatientName = string.Format("{0} {1}", _PatientBOL.FirstName, _PatientBOL.LastName);
                    _LaboratoryService.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void imageTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            imageRequiredValidationProvider.ValidationMessages(false);
        }
        private void SetFarsiKeyboard_Enter(object sender, EventArgs e)
        {
            try
            {
                KeyboardControler.SetFarsiKeyboard();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void serviceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_ServiceFormMode == FormMode.Insert && serviceTypeComboBox.SelectedIndex> 0)            
              serviceTypePriceTextEdit.Text =new ServiceTypeBLL().SelectServiceTypePrice(new ServiceTypeBOL((short)((ListItem)serviceTypeComboBox.SelectedItem).Id)).ToString();
        }
    }
}
