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

    public partial class ShowInsuranceTypeUI : Form
    {
        InsuranceTypeBLL _InsuranceTypeBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowInsuranceTypeUI(AccessMode accessMode)
        {
            InitializeComponent();
            newInsuranceTypeButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _InsuranceTypeBLL = new InsuranceTypeBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                InsuranceTypeBOL[] InsuranceTypeRecords = _InsuranceTypeBLL.Select();
                InsuranceTypeDataGridView.Rows.Clear();
                if (InsuranceTypeRecords != null)
                    for (int index = 0; index < InsuranceTypeRecords.Length; index++)
                    {
                        InsuranceTypeDataGridView.Rows.Add();
                        DataGridViewRow row = InsuranceTypeDataGridView.Rows[index];
                        row.Cells["insuranceTypeId"].Value = InsuranceTypeRecords[index].InsuranceTypeId;
                        row.Cells["insuranceTypeTitle"].Value = InsuranceTypeRecords[index].InsuranceTypeTitle;
                        row.Cells["percent"].Value = InsuranceTypeRecords[index].Percent;
                        row.Cells["description"].Value = InsuranceTypeRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsuranceTypeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short insuranceTypeId = Convert.ToInt16(InsuranceTypeDataGridView.Rows[selectedIndex].Cells["insuranceTypeId"].Value);
            string insuranceTypeTitle = (InsuranceTypeDataGridView.Rows[selectedIndex].Cells["insuranceTypeTitle"].Value == null ? null : InsuranceTypeDataGridView.Rows[selectedIndex].Cells["insuranceTypeTitle"].Value.ToString());
            decimal percent = Convert.ToDecimal(InsuranceTypeDataGridView.Rows[selectedIndex].Cells["percent"].Value == null ? null : InsuranceTypeDataGridView.Rows[selectedIndex].Cells["percent"].Value);
            string description = (InsuranceTypeDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : InsuranceTypeDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());            
            InsuranceTypeBOL insuranceTypeRecord = new InsuranceTypeBOL(insuranceTypeId, insuranceTypeTitle, percent, description);
            new EditInsuranceTypeUI(insuranceTypeRecord).ShowDialog();
            fillDataGridView();
        }
        private void InsuranceTypedataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (InsuranceTypeDataGridView.Rows.Count != 0)
                    ItemSelected(InsuranceTypeDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newInsuranceTypeButton_Click(object sender, EventArgs e)
        {
            new EditInsuranceTypeUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowInsuranceType_KeyDown(object sender, KeyEventArgs e)
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