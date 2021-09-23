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

    public partial class ShowSpecialistUI : Form
    {
        SpecialistBLL _SpecialistBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowSpecialistUI(AccessMode accessMode)
        {
            InitializeComponent();
            newSpecialistButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _SpecialistBLL = new SpecialistBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                SpecialistBOL[] SpecialistRecords = _SpecialistBLL.Select();
                SpecialistDataGridView.Rows.Clear();
                if (SpecialistRecords != null)
                    for (int index = 0; index < SpecialistRecords.Length; index++)
                    {
                        SpecialistDataGridView.Rows.Add();
                        DataGridViewRow row = SpecialistDataGridView.Rows[index];
                        row.Cells["specialistId"].Value = SpecialistRecords[index].SpecialistId;
                        row.Cells["specialistTitle"].Value = SpecialistRecords[index].SpecialistTitle;
                        row.Cells["description"].Value = SpecialistRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void SpecialistDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short specialistId = Convert.ToInt16(SpecialistDataGridView.Rows[selectedIndex].Cells["specialistId"].Value);
            string specialistTitle = (SpecialistDataGridView.Rows[selectedIndex].Cells["specialistTitle"].Value == null ? null : SpecialistDataGridView.Rows[selectedIndex].Cells["specialistTitle"].Value.ToString());
            string description = (SpecialistDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : SpecialistDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            SpecialistBOL _SpecialistBOL = new SpecialistBOL(specialistId, specialistTitle, description);
            new EditSpecialistUI(_SpecialistBOL).ShowDialog();
            fillDataGridView();
        }
        private void SpecialistdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (SpecialistDataGridView.Rows.Count != 0)
                    ItemSelected(SpecialistDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newSpecialistButton_Click(object sender, EventArgs e)
        {
            new EditSpecialistUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowSpecialist_KeyDown(object sender, KeyEventArgs e)
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