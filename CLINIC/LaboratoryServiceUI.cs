using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessObjectLayer;
    using BusinessLogicLayer;
    using DataConvertor;
    using JntMsgBox;
    using ComplexDataType;

    public partial class LaboratoryServiceUI : Form
    {
        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        public string PatientName;
        public string ServiceTypeTitle;
        public int ServiceId;
        LaboratoryServiceBLL _LaboratoryServiceBLL = new LaboratoryServiceBLL();
        LaboratoryServiceBOL _LaboratoryServiceBOL = new LaboratoryServiceBOL();
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        char[] spliter = { ';', ':' };
        string checkBoxName = "checkBox";
        string Tooth;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();

        public LaboratoryServiceUI()
        {
            InitializeComponent();
            dateTimePicker.SelectedDateTime = DateTime.Today;
        }
        private void LoadLaboratoryService()
        {
            _LaboratoryServiceBOL = _LaboratoryServiceBLL.Select(ServiceId);
            if (_LaboratoryServiceBOL != null)
            {
                ListItem _LaboratoryListItem = new ListItem(_LaboratoryServiceBOL.LaboratoryId, string.Empty);
                laboratoryComboBox.SelectedIndex = ComboBoxSelectedIndex(laboratoryComboBox, _LaboratoryListItem);
                ListItem _LaboratoryStateListItem = new ListItem(_LaboratoryServiceBOL.LaboratoryStateId, string.Empty);
                laboratoryStateComboBox.SelectedIndex = ComboBoxSelectedIndex(laboratoryStateComboBox, _LaboratoryStateListItem);
                ListItem _ToothColorListItem = new ListItem(_LaboratoryServiceBOL.ToothColorId, string.Empty);
                toothColorComboBox.SelectedIndex = ComboBoxSelectedIndex(toothColorComboBox, _ToothColorListItem);
                descriptionTextBox.Text = _LaboratoryServiceBOL.Description;
                dateTimePicker.SelectedDateTime = _LaboratoryServiceBOL.Date;
                ToothCheckBoxCheck(_LaboratoryServiceBOL.Tooth);
            }
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
        private void FillInfo()
        {
            LaboratoryComboBoxBind();
            ToothColorComboBoxBind();
            LaboratoryStateComboBoxBind();
            patientNameTextBox.Text = PatientName;
            serviceTypeTitleTextBox.Text = ServiceTypeTitle;
        }
        private bool ValidateItem()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void InsertUpdateLaboratoryService()
        {
            try
            {
                if (_LaboratoryServiceBOL == null)
                    _LaboratoryServiceBOL = new LaboratoryServiceBOL();
                _LaboratoryServiceBOL.LaboratoryId = (short)((ListItem)laboratoryComboBox.SelectedItem).Id;
                _LaboratoryServiceBOL.ServiceId = ServiceId;
                _LaboratoryServiceBOL.LaboratoryStateId = (short)((ListItem)laboratoryStateComboBox.SelectedItem).Id;
                _LaboratoryServiceBOL.ToothColorId = (short)((ListItem)toothColorComboBox.SelectedItem).Id;
                _LaboratoryServiceBOL.Date = dateTimePicker.SelectedDateTime;
                _LaboratoryServiceBOL.Description = descriptionTextBox.Text;
                _LaboratoryServiceBOL.Tooth = SetTooth();
                _LaboratoryServiceBLL.InsertUpdate(_LaboratoryServiceBOL);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private string SetTooth()
        {
            Tooth = string.Empty;
            try
            {
                for (int i = 0; i < toothPanel.Controls.Count; i++)
                {
                    if ("CheckBox" == toothPanel.Controls[i].GetType().Name)
                        if (((CheckBox)(toothPanel.Controls[i])).Checked)
                            if (((CheckBox)(toothPanel.Controls[i])).Name.StartsWith(checkBoxName))
                            {
                                string toothId = string.Format("{0};", ((CheckBox)(toothPanel.Controls[i])).Name.Replace(checkBoxName, string.Empty));
                                Tooth += toothId;
                            }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            return Tooth;
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                InsertUpdateLaboratoryService();
                closeForm();
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
        private void LaboratoryService_Load(object sender, EventArgs e)
        {
            FillInfo();
            LoadLaboratoryService();
        }
        private void ToothCheckBoxCheck(string Tooth)
        {
            try
            {
                string[] toothSet = Tooth.Split(spliter[0]);
                if (toothSet.Length > 0)
                {
                    foreach (string item in toothSet)
                        if (item != string.Empty && item != null)
                        {
                            string CheckBoxName = string.Format("{0}{1}", checkBoxName, item);
                            ((CheckBox)(toothPanel.Controls.Find(CheckBoxName, false)[0])).Checked = true;
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
        private void downCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[16];
            int j = 0;
            for (int i = 17; i <= 32; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downCheckBox.Checked);
        }
        private void upCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[16];
            int j = 0;
            for (int i = 1; i <= 16; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upCheckBox.Checked);
        }
        private void upLeftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 1; i <= 8; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upLeftCheckBox.Checked);
        }
        private void upRightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 9; i <= 16; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upRightCheckBox.Checked);
        }
        private void downRightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 17; i <= 24; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downRightCheckBox.Checked);
        }
        private void downLeftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[8];
            int j = 0;
            for (int i = 25; i <= 32; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downLeftCheckBox.Checked);
        }
        private void down2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[10];
            int j = 0;
            for (int i = 43; i <= 52; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, down2CheckBox.Checked);
        }
        private void up2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[10];
            int j = 0;
            for (int i = 33; i <= 42; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, up2CheckBox.Checked);
        }
        private void upLeft2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 38; i <= 42; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upLeft2CheckBox.Checked);
        }
        private void upRight2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 33; i <= 37; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, upRight2CheckBox.Checked);
        }
        private void downRight2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 48; i <= 52; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downRight2CheckBox.Checked);
        }
        private void downLeft2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int[] checkBoxList = new int[5];
            int j = 0;
            for (int i = 43; i <= 47; i++, j++)
                checkBoxList[j] = i;
            SetCheckBoxCheck(checkBoxList, downLeft2CheckBox.Checked);
        }
        void SetCheckBoxCheck(int[] checkBoxList, bool Checked)
        {
            string _CheckBoxName;
            for (int i = 0; i < checkBoxList.Length; i++)
            {
                _CheckBoxName = string.Format("{0}{1}", checkBoxName, checkBoxList[i]);
                ((CheckBox)(toothPanel.Controls[_CheckBoxName])).Checked = Checked;
            }
        }
        private void LaboratoryServiceUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void LaboratoryComboBoxBind()
        {
            try
            {
                LaboratoryBOL[] LaboratoryRecords = new LaboratoryBLL().SelectComboBox();
                laboratoryComboBox.Items.Clear();
                if (LaboratoryRecords != null)
                {
                    for (int index = 0; index < LaboratoryRecords.Length; index++)
                    {
                        laboratoryComboBox.Items.Add(new ListItem(LaboratoryRecords[index].LaboratoryId, LaboratoryRecords[index].LaboratoryTitle));
                    }
                    laboratoryComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LaboratoryStateComboBoxBind()
        {
            try
            {
                LaboratoryStateBOL[] LaboratoryStateRecords = new LaboratoryStateBLL().SelectComboBox();
                laboratoryStateComboBox.Items.Clear();
                if (LaboratoryStateRecords != null)
                {
                    for (int index = 0; index < LaboratoryStateRecords.Length; index++)
                    {
                        laboratoryStateComboBox.Items.Add(new ListItem(LaboratoryStateRecords[index].LaboratoryStateId, LaboratoryStateRecords[index].LaboratoryStateTitle));
                    }
                    laboratoryStateComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ToothColorComboBoxBind()
        {
            try
            {
                ToothColorBOL[] ToothColorBOLs = new ToothColorBLL().SelectComboBox();
                toothColorComboBox.Items.Clear();
                if (ToothColorBOLs != null)
                {
                    for (int index = 0; index < ToothColorBOLs.Length; index++)
                        toothColorComboBox.Items.Add(new ListItem(ToothColorBOLs[index].ToothColorId, ToothColorBOLs[index].ToothColorTitle));
                    toothColorComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            LoadLaboratoryService();
        }
    }
}
