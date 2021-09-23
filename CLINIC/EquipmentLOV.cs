using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;
    using DataConvertor;
    public partial class EquipmentLOV : Form
    {
        private EquipmentBOL _EquipmentBOL;
        private EquipmentBLL _EquipmentBLL;
        public short EquipmentID;
        public string EquipmentTitle;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public EquipmentLOV()
        {
            InitializeComponent();
            _EquipmentBLL = new EquipmentBLL();
            _EquipmentBOL = new EquipmentBOL();
            fillDataGridView();
            acceptButton.Visible = false;
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
                noticeLabel.ForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            _EquipmentBOL.EquipmentId = -1;
            _EquipmentBOL.EquipmentTitle = String.Empty;
            this.Close();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            EquipmentID =(short)_EquipmentBOL.EquipmentId;
            EquipmentTitle =_EquipmentBOL.EquipmentTitle;
            this.Close();
        }
        private void EquipmentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            _EquipmentBOL.EquipmentId = Convert.ToInt16(EquipmentDataGridView.Rows[selectedIndex].Cells["equipmentId"].Value);
            _EquipmentBOL.EquipmentTitle = (EquipmentDataGridView.Rows[selectedIndex].Cells["equipmentTitle"].Value == null ? null : EquipmentDataGridView.Rows[selectedIndex].Cells["equipmentTitle"].Value.ToString());
            equipmentTitleTextBox.Text = _EquipmentBOL.EquipmentTitle;
            acceptButton.Visible = true;
        }
        private void noticeLabel_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                noticeLabel.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }
    }
}
