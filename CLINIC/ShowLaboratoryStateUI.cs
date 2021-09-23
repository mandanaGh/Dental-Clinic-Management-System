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

    public partial class ShowLaboratoryStateUI : Form
    {
        LaboratoryStateBLL _LaboratoryStateBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowLaboratoryStateUI(AccessMode accessMode)
        {
            InitializeComponent();
            newLaboratoryStateButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _LaboratoryStateBLL = new LaboratoryStateBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                LaboratoryStateBOL[] LaboratoryStateRecords = _LaboratoryStateBLL.Select();
                LaboratoryStateDataGridView.Rows.Clear();
                if (LaboratoryStateRecords != null)
                    for (int index = 0; index < LaboratoryStateRecords.Length; index++)
                    {
                        LaboratoryStateDataGridView.Rows.Add();
                        DataGridViewRow row = LaboratoryStateDataGridView.Rows[index];
                        row.Cells["laboratoryStateId"].Value = LaboratoryStateRecords[index].LaboratoryStateId;
                        row.Cells["laboratoryStateTitle"].Value = LaboratoryStateRecords[index].LaboratoryStateTitle;
                        row.Cells["description"].Value = LaboratoryStateRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LaboratoryStateDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short laboratoryStateId = Convert.ToInt16(LaboratoryStateDataGridView.Rows[selectedIndex].Cells["laboratoryStateId"].Value);
            string laboratoryStateTitle = (LaboratoryStateDataGridView.Rows[selectedIndex].Cells["laboratoryStateTitle"].Value == null ? null : LaboratoryStateDataGridView.Rows[selectedIndex].Cells["laboratoryStateTitle"].Value.ToString());
            string description = (LaboratoryStateDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : LaboratoryStateDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            LaboratoryStateBOL _LaboratoryStateBOL = new LaboratoryStateBOL(laboratoryStateId, laboratoryStateTitle, description);
            new EditLaboratoryStateUI(_LaboratoryStateBOL).ShowDialog();
            fillDataGridView();
        }
        private void LaboratoryStatedataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (LaboratoryStateDataGridView.Rows.Count != 0)
                    ItemSelected(LaboratoryStateDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newLaboratoryStateButton_Click(object sender, EventArgs e)
        {
            new EditLaboratoryStateUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowLaboratoryState_KeyDown(object sender, KeyEventArgs e)
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