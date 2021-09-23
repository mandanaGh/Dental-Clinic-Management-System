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


    public partial class ShowUserUI : Form
    {
        UserBLL _UserBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowUserUI(AccessMode accessMode)
        {
            InitializeComponent();
            newUserButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _UserBLL = new UserBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                UserBOL[] _UserBOLs = _UserBLL.Select();
                usersDataGridView.Rows.Clear();
                for (int index = 0; index < _UserBOLs.Length; index++)
                {
                    usersDataGridView.Rows.Add();
                    DataGridViewRow row = usersDataGridView.Rows[index];
                    row.Cells["userId"].Value = _UserBOLs[index].UserId;
                    row.Cells["userName"].Value = _UserBOLs[index].UserName;                    
                    row.Cells["roleId"].Value = _UserBOLs[index].RoleId;
                    row.Cells["roleTitle"].Value = _UserBOLs[index].RoleTitle;
                    row.Cells["password"].Value = _UserBOLs[index].Password;
                    row.Cells["isLocked"].Value = _UserBOLs[index].IsLocked;
                    row.Cells["description"].Value = _UserBOLs[index].Description;
                }
                usersDataGridView.Focus();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void newUserButton_Click(object sender, EventArgs e)
        {
            new EditUserUI().ShowDialog();
            fillDataGridView();
        }
        private void usersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            messageTitleLabel.Text = string.Empty;
            if (e.RowIndex != -1 && pageAccess == AccessMode.Complete)
                ItemSelected(e.RowIndex);
            if (pageAccess != AccessMode.Complete)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ItemSelected(int selectedIndex)
        {
            short userId = Convert.ToInt16(usersDataGridView.Rows[selectedIndex].Cells["userId"].Value);
            string userName = usersDataGridView.Rows[selectedIndex].Cells["userName"].Value.ToString();
            short roleId = Convert.ToInt16(usersDataGridView.Rows[selectedIndex].Cells["roleId"].Value);
            string roleTitle = usersDataGridView.Rows[selectedIndex].Cells["roleTitle"].Value.ToString();
            bool isLocked = Convert.ToBoolean(usersDataGridView.Rows[selectedIndex].Cells["isLocked"].Value);
            string description = (usersDataGridView.Rows[selectedIndex].Cells["description"].Value == null? string.Empty:usersDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            UserBOL _UserBOL = new UserBOL(userId,userName,null,null,roleId,roleTitle,description,isLocked);
            new EditUserUI(_UserBOL).ShowDialog();
            fillDataGridView();
        }
        private void usersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (usersDataGridView.Rows.Count != 0)
                    ItemSelected(usersDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void ShowUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void messageTitleLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
        }
    }
}