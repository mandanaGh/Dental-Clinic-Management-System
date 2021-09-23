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

    public partial class ShowAppointmentTypeUI : Form
    {
        AppointmentTypeBLL _AppointmentTypeBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;        
        public ShowAppointmentTypeUI(AccessMode accessMode)
        {
            InitializeComponent();
            newAppointmentTypeButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _AppointmentTypeBLL = new AppointmentTypeBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                AppointmentTypeBOL[] AppointmentTypeRecords = _AppointmentTypeBLL.Select();
                AppointmentTypeDataGridView.Rows.Clear();
                if (AppointmentTypeRecords != null)
                    for (int index = 0; index < AppointmentTypeRecords.Length; index++)
                    {
                        AppointmentTypeDataGridView.Rows.Add();
                        DataGridViewRow row = AppointmentTypeDataGridView.Rows[index];
                        row.Cells["appointmentTypeId"].Value = AppointmentTypeRecords[index].AppointmentTypeId;
                        row.Cells["appointmentTypeTitle"].Value = AppointmentTypeRecords[index].AppointmentTypeTitle;
                        row.Cells["description"].Value = AppointmentTypeRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void AppointmentTypeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short appointmentTypeId = Convert.ToInt16(AppointmentTypeDataGridView.Rows[selectedIndex].Cells["appointmentTypeId"].Value);
            string appointmentTypeTitle = (AppointmentTypeDataGridView.Rows[selectedIndex].Cells["appointmentTypeTitle"].Value == null ? null : AppointmentTypeDataGridView.Rows[selectedIndex].Cells["appointmentTypeTitle"].Value.ToString());
            string description = (AppointmentTypeDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : AppointmentTypeDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            AppointmentTypeBOL _AppointmentTypeBOL = new AppointmentTypeBOL(appointmentTypeId, appointmentTypeTitle, description);
            new EditAppointmentTypeUI(_AppointmentTypeBOL).ShowDialog();
            fillDataGridView();
        }
        private void AppointmentTypedataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (AppointmentTypeDataGridView.Rows.Count != 0)
                    ItemSelected(AppointmentTypeDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newAppointmentTypeButton_Click(object sender, EventArgs e)
        {
            new EditAppointmentTypeUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowAppointmentType_KeyDown(object sender, KeyEventArgs e)
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