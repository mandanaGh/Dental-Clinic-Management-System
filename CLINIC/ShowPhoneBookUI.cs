using System;
using System.Drawing;
using System.Windows.Forms;
using ComplexDataType;
using System.Resources;
using BusinessObjectLayer;
using System.Reflection;
using BusinessLogicLayer;
using JntMsgBox;

namespace UserInterface
{
    using DataConvertor;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using BusinessLogicLayer;
    using System.Diagnostics;
    using System.Security.AccessControl;

    public partial class ShowPhoneBookUI : Form
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        PhoneBookBLL _PhoneBookBLL;
        private AccessMode _AccessMode;
        string DangerousConfirmation;
        string DangerousText;
        private ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
        private void SetResourceManager()
        {
            try
            {
                DangerousText = _ResourceManager.GetString("Dangerous");
                DangerousConfirmation = _ResourceManager.GetString("DangerousConfirmation");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        public ShowPhoneBookUI(AccessMode accessMode)
        {
            InitializeComponent();
            SetResourceManager();
            _AccessMode = accessMode;
            newPhoneBookButton.Enabled = (accessMode != AccessMode.Read);
            _PhoneBookBLL = new PhoneBookBLL();
            FillPhoneBookGridEx();
        }
        private void FillPhoneBookGridEx()
        {
            try
            {
                PhoneBookBOL[] _PhoneBookBOL = _PhoneBookBLL.Select();
                phoneBookGridEX.ClearItems();
                if (_PhoneBookBOL != null)
                {
                    for (int index = 0; index < _PhoneBookBOL.Length; index++)
                        phoneBookGridEX.AddItem(_PhoneBookBOL[index].PhoneBookId, string.Format("{0} {1} {2}", _PhoneBookBOL[index].SubjectTitle, _PhoneBookBOL[index].Name1, _PhoneBookBOL[index].Name2), _PhoneBookBOL[index].Name1, _PhoneBookBOL[index].Name2, _PhoneBookBOL[index].Address1, _PhoneBookBOL[index].Address2, _PhoneBookBOL[index].Fax1, _PhoneBookBOL[index].Fax2, _PhoneBookBOL[index].Tel1, _PhoneBookBOL[index].Tel2, _PhoneBookBOL[index].Mobile1, _PhoneBookBOL[index].Mobile2, _PhoneBookBOL[index].SubjectID, _PhoneBookBOL[index].SubjectTitle, _PhoneBookBOL[index].Email, _PhoneBookBOL[index].CityID, _PhoneBookBOL[index].CityTitle);
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void newPhoneBookButton_Click(object sender, EventArgs e)
        {
            new EditPhoneBookUI().ShowDialog();
            FillPhoneBookGridEx();
        }
        private void phoneBookGridEX_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                noticeLabel.Text = string.Empty;
                if (_AccessMode != AccessMode.NoAccess)
                {
                    if (phoneBookGridEX.CurrentRow != null)
                        if (phoneBookGridEX.CurrentRow.RowIndex > -1)
                            if (phoneBookGridEX.CurrentRow.Group == null)
                                ItemSelected();
                }
                else
                {
                    _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                    noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                    noticeLabel.Text = _ExceptionHandlerBOL.Title;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ShowPhoneBookUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
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
        private void phoneBookGridEX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (phoneBookGridEX.RowCount != 0)
                    ItemSelected();
        }
        private void ItemSelected()
        {
            try
            {
                PhoneBookBOL _PhoneBookBOL = new PhoneBookBOL();
                _PhoneBookBOL.PhoneBookId = DataConvertor.ConvertToInt(phoneBookGridEX.CurrentRow.Cells["PHONEBOOKID"].Value);
                _PhoneBookBOL.Name1 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["name1"].Value);
                _PhoneBookBOL.Name2 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Name2"].Value);
                _PhoneBookBOL.Address1 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Address1"].Value);
                _PhoneBookBOL.Address2 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Address2"].Value);
                _PhoneBookBOL.Fax1 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Fax1"].Value);
                _PhoneBookBOL.Fax2 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Fax2"].Value);
                _PhoneBookBOL.Tel1 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Tel1"].Value);
                _PhoneBookBOL.Tel2 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Tel2"].Value);
                _PhoneBookBOL.Mobile1 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Mobile1"].Value);
                _PhoneBookBOL.Mobile2 = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Mobile2"].Value);
                _PhoneBookBOL.SubjectID = Convert.ToInt16(phoneBookGridEX.CurrentRow.Cells["SubjectID"].Value);
                _PhoneBookBOL.SubjectTitle = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["SubjectTitle"].Value);
                _PhoneBookBOL.Email = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["Email"].Value);
                _PhoneBookBOL.CityID = DataConvertor.ConvertToShort(phoneBookGridEX.CurrentRow.Cells["CityID"].Value);
                _PhoneBookBOL.CityTitle = DataConvertor.ConvertToString(phoneBookGridEX.CurrentRow.Cells["CityTitle"].Value);
                new EditPhoneBookUI(_PhoneBookBOL, _AccessMode).ShowDialog();
                FillPhoneBookGridEx();
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
