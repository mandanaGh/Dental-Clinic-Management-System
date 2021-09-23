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
    using System.Globalization;
    using DataConvertor;

    public partial class ShowServiceTypeUI : Form
    {
        ServiceTypeBLL _ServiceTypeBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;
        public ShowServiceTypeUI(AccessMode accessMode)
        {
            InitializeComponent();
            newServiceTypeButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _ServiceTypeBLL = new ServiceTypeBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                ServiceTypeBOL[] ServiceTypeRecords = _ServiceTypeBLL.Select();
                ServiceTypeDataGridView.Rows.Clear();
                if (ServiceTypeRecords != null)
                    for (int index = 0; index < ServiceTypeRecords.Length; index++)
                    {
                        ServiceTypeDataGridView.Rows.Add();
                        DataGridViewRow row = ServiceTypeDataGridView.Rows[index];
                        row.Cells["serviceTypeId"].Value = ServiceTypeRecords[index].ServiceTypeId;
                        row.Cells["serviceTypeTitle"].Value = ServiceTypeRecords[index].ServiceTypeTitle;
                        row.Cells["price"].Value = ServiceTypeRecords[index].Price;
                        row.Cells["session"].Value = ServiceTypeRecords[index].Session;
                        row.Cells["serviceTypeCode"].Value = ServiceTypeRecords[index].ServiceTypeCode;
                        row.Cells["nextRefrence"].Value = ServiceTypeRecords[index].NextRefrence;
                        row.Cells["description"].Value = ServiceTypeRecords[index].Description;
                        row.Cells["isLaboratory"].Value = ServiceTypeRecords[index].IsLaboratory;                        
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ServiceTypeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short serviceTypeId = Convert.ToInt16(ServiceTypeDataGridView.Rows[selectedIndex].Cells["serviceTypeId"].Value);
            string serviceTypeTitle = (ServiceTypeDataGridView.Rows[selectedIndex].Cells["serviceTypeTitle"].Value == null ? null : ServiceTypeDataGridView.Rows[selectedIndex].Cells["serviceTypeTitle"].Value.ToString());                
            long? price = DataConvertor.ConvertToLong(ServiceTypeDataGridView.Rows[selectedIndex].Cells["price"].Value);
            short? session = DataConvertor.ConvertToShort(ServiceTypeDataGridView.Rows[selectedIndex].Cells["session"].Value);
            string serviceTypeCode = (ServiceTypeDataGridView.Rows[selectedIndex].Cells["serviceTypeCode"].Value == null ? null : ServiceTypeDataGridView.Rows[selectedIndex].Cells["serviceTypeCode"].Value.ToString());                                
            short? nextRefrence = DataConvertor.ConvertToShort(ServiceTypeDataGridView.Rows[selectedIndex].Cells["nextRefrence"].Value);
            string description = (ServiceTypeDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : ServiceTypeDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            bool isLaboratory = DataConvertor.ConvertToBoolean(ServiceTypeDataGridView.Rows[selectedIndex].Cells["isLaboratory"].Value);
            ServiceTypeBOL _ServiceTypeBOL = new ServiceTypeBOL(serviceTypeId, serviceTypeTitle, price, session, serviceTypeCode, nextRefrence,description,isLaboratory);
            new EditServiceTypeUI(_ServiceTypeBOL).ShowDialog();
            fillDataGridView();
        }
        private void ServiceTypedataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (ServiceTypeDataGridView.Rows.Count != 0)
                    ItemSelected(ServiceTypeDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newServiceTypeButton_Click(object sender, EventArgs e)
        {
            new EditServiceTypeUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowServiceType_KeyDown(object sender, KeyEventArgs e)
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