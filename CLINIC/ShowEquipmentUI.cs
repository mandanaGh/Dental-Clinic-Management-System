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
    using DataConvertor;

    public partial class ShowEquipmentUI : Form
    {
        EquipmentBLL _EquipmentBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;        
        public ShowEquipmentUI(AccessMode accessMode)
        {
            InitializeComponent();
            newEquipmentButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _EquipmentBLL = new EquipmentBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                EquipmentBOL[] EquipmentRecords = _EquipmentBLL.Select();
                EquipmentDataGridView.Rows.Clear();
                if (EquipmentRecords != null)
                    for (int index = 0; index < EquipmentRecords.Length; index++)
                    {
                        EquipmentDataGridView.Rows.Add();
                        DataGridViewRow row = EquipmentDataGridView.Rows[index];
                        row.Cells["equipmentId"].Value = EquipmentRecords[index].EquipmentId;
                        row.Cells["equipmentTitle"].Value = EquipmentRecords[index].EquipmentTitle;
                        row.Cells["count"].Value = EquipmentRecords[index].Count;
                        row.Cells["expiredDate"].Value = Convert.ToDateTime(EquipmentRecords[index].ExpiredDate);
                        row.Cells["persianExpiredDate"].Value = DataConvertor.ConvertToPersianDate(EquipmentRecords[index].ExpiredDate);
                        row.Cells["description"].Value = EquipmentRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EquipmentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            short equipmentId = Convert.ToInt16(EquipmentDataGridView.Rows[selectedIndex].Cells["equipmentId"].Value);
            string equipmentTitle = (EquipmentDataGridView.Rows[selectedIndex].Cells["equipmentTitle"].Value == null ? null : EquipmentDataGridView.Rows[selectedIndex].Cells["equipmentTitle"].Value.ToString());
            string description = (EquipmentDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : EquipmentDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            int count = Convert.ToInt32(EquipmentDataGridView.Rows[selectedIndex].Cells["count"].Value);
            DateTime expiredDate = Convert.ToDateTime(EquipmentDataGridView.Rows[selectedIndex].Cells["expiredDate"].Value);
            EquipmentBOL _EquipmentBOL = new EquipmentBOL(equipmentId,equipmentTitle,count,expiredDate,description);
            new EditEquipmentUI(_EquipmentBOL).ShowDialog();
            fillDataGridView();
        }
        private void EquipmentdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (EquipmentDataGridView.Rows.Count != 0)
                    ItemSelected(EquipmentDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newEquipmentButton_Click(object sender, EventArgs e)
        {
            new EditEquipmentUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowEquipment_KeyDown(object sender, KeyEventArgs e)
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