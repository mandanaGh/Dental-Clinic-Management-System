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

    public partial class ShowLaboratoryUI : Form
    {
        LaboratoryBLL _LaboratoryBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowLaboratoryUI(AccessMode accessMode)
        {
            InitializeComponent();
            newLaboratoryButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _LaboratoryBLL = new LaboratoryBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                LaboratoryBOL[] LaboratoryRecords = _LaboratoryBLL.Select();
                LaboratoryDataGridView.Rows.Clear();
                if (LaboratoryRecords != null)
                    for (int index = 0; index < LaboratoryRecords.Length; index++)
                    {
                        LaboratoryDataGridView.Rows.Add();
                        DataGridViewRow row = LaboratoryDataGridView.Rows[index];
                        row.Cells["laboratoryId"].Value = LaboratoryRecords[index].LaboratoryId;
                        row.Cells["laboratoryTitle"].Value = LaboratoryRecords[index].LaboratoryTitle;
                        row.Cells["address"].Value = LaboratoryRecords[index].Address;
                        row.Cells["tel"].Value = LaboratoryRecords[index].Tel;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LaboratoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short laboratoryId = Convert.ToInt16(LaboratoryDataGridView.Rows[selectedIndex].Cells["laboratoryId"].Value);
            string laboratoryTitle = (LaboratoryDataGridView.Rows[selectedIndex].Cells["laboratoryTitle"].Value == null ? null : LaboratoryDataGridView.Rows[selectedIndex].Cells["laboratoryTitle"].Value.ToString());
            string address = (LaboratoryDataGridView.Rows[selectedIndex].Cells["address"].Value == null ? null : LaboratoryDataGridView.Rows[selectedIndex].Cells["address"].Value.ToString());
            string tel = (LaboratoryDataGridView.Rows[selectedIndex].Cells["tel"].Value == null ? null : LaboratoryDataGridView.Rows[selectedIndex].Cells["tel"].Value.ToString());
            LaboratoryBOL _LaboratoryBOL = new LaboratoryBOL(laboratoryId, laboratoryTitle, address, tel);
            new EditLaboratoryUI(_LaboratoryBOL).ShowDialog();
            fillDataGridView();
        }
        private void LaboratorydataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (LaboratoryDataGridView.Rows.Count != 0)
                    ItemSelected(LaboratoryDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newLaboratoryButton_Click(object sender, EventArgs e)
        {
            new EditLaboratoryUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowLaboratory_KeyDown(object sender, KeyEventArgs e)
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