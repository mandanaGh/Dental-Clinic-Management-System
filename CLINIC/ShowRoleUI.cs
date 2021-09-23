using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;

    public partial class ShowRoleUI : Form
    {
        RoleBLL _RoleBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowRoleUI(AccessMode accessMode)
        {
            InitializeComponent();
            newRoleButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _RoleBLL = new RoleBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                RoleBOL[] RoleRecords = _RoleBLL.Select();
                RoleDataGridView.Rows.Clear();
                if (RoleRecords != null)
                    for (int index = 0; index < RoleRecords.Length; index++)
                    {
                        RoleDataGridView.Rows.Add();
                        DataGridViewRow row = RoleDataGridView.Rows[index];
                        row.Cells["roleId"].Value = RoleRecords[index].RoleId;
                        row.Cells["roleTitle"].Value = RoleRecords[index].RoleTitle;
                        row.Cells["description"].Value = RoleRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void RoleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short roleId = Convert.ToInt16(RoleDataGridView.Rows[selectedIndex].Cells["roleId"].Value);
            string roleTitle = (RoleDataGridView.Rows[selectedIndex].Cells["roleTitle"].Value == null ? null : RoleDataGridView.Rows[selectedIndex].Cells["roleTitle"].Value.ToString());
            string description = (RoleDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : RoleDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            RoleBOL _RoleBOL = new RoleBOL(roleId, roleTitle, description);
            new EditRoleUI(_RoleBOL).ShowDialog();
            fillDataGridView();
        }
        private void RoledataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (RoleDataGridView.Rows.Count != 0)
                    ItemSelected(RoleDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newRoleButton_Click(object sender, EventArgs e)
        {
            new EditRoleUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowRole_KeyDown(object sender, KeyEventArgs e)
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