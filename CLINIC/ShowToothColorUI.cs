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

    public partial class ShowToothColorUI : Form
    {
        ToothColorBLL _ToothColorBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowToothColorUI(AccessMode accessMode)
        {
            InitializeComponent();
            newToothColorButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _ToothColorBLL = new ToothColorBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                ToothColorBOL[] ToothColorRecords = _ToothColorBLL.Select();
                ToothColorDataGridView.Rows.Clear();
                if (ToothColorRecords != null)
                    for (int index = 0; index < ToothColorRecords.Length; index++)
                    {
                        ToothColorDataGridView.Rows.Add();
                        DataGridViewRow row = ToothColorDataGridView.Rows[index];
                        row.Cells["toothColorId"].Value = ToothColorRecords[index].ToothColorId;
                        row.Cells["toothColorTitle"].Value = ToothColorRecords[index].ToothColorTitle;
                        row.Cells["description"].Value = ToothColorRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ToothColorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short toothColorId = Convert.ToInt16(ToothColorDataGridView.Rows[selectedIndex].Cells["toothColorId"].Value);
            string toothColorTitle = (ToothColorDataGridView.Rows[selectedIndex].Cells["toothColorTitle"].Value == null ? null : ToothColorDataGridView.Rows[selectedIndex].Cells["toothColorTitle"].Value.ToString());
            string description = (ToothColorDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : ToothColorDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            ToothColorBOL _ToothColorBOL = new ToothColorBOL(toothColorId, toothColorTitle, description);
            new EditToothColorUI(_ToothColorBOL).ShowDialog();
            fillDataGridView();
        }
        private void ToothColordataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (ToothColorDataGridView.Rows.Count != 0)
                    ItemSelected(ToothColorDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newToothColorButton_Click(object sender, EventArgs e)
        {
            new EditToothColorUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowToothColor_KeyDown(object sender, KeyEventArgs e)
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