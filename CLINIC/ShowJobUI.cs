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

    public partial class ShowJobUI : Form
    {
        JobBLL _JobBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode _AccessMode;
        public ShowJobUI(AccessMode accessMode)
        {
            InitializeComponent();
            newJobButton.Enabled = (accessMode != AccessMode.Read);
            _AccessMode = accessMode;
            _JobBLL = new JobBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                JobBOL[] JobRecords = _JobBLL.Select();
                JobDataGridView.Rows.Clear();
                if (JobRecords != null)
                    for (int index = 0; index < JobRecords.Length; index++)
                    {
                        JobDataGridView.Rows.Add();
                        DataGridViewRow row = JobDataGridView.Rows[index];
                        row.Cells["jabId"].Value = JobRecords[index].JobId;
                        row.Cells["jabTitle"].Value = JobRecords[index].JobTitle;
                        row.Cells["description"].Value = JobRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void JobDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            messageTitleLabel.Text = string.Empty;
            if (e.RowIndex != -1 && _AccessMode == AccessMode.Complete)
                ItemSelected(e.RowIndex);
            if (_AccessMode != AccessMode.Complete)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ItemSelected(int selectedIndex)
        {
            short jabId = Convert.ToInt16(JobDataGridView.Rows[selectedIndex].Cells["jabId"].Value);
            string jabTitle = (JobDataGridView.Rows[selectedIndex].Cells["jabTitle"].Value == null ? null : JobDataGridView.Rows[selectedIndex].Cells["jabTitle"].Value.ToString());
            string description = (JobDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : JobDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            JobBOL _JobBOL = new JobBOL(jabId, jabTitle, description);
            new EditJobUI(_JobBOL).ShowDialog();
            fillDataGridView();
        }
        private void JobdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (JobDataGridView.Rows.Count != 0)
                    ItemSelected(JobDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newJobButton_Click(object sender, EventArgs e)
        {
            new EditJobUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowJob_KeyDown(object sender, KeyEventArgs e)
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