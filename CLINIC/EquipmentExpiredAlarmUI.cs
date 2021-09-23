using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjectLayer;
using BusinessLogicLayer;

namespace UserInterface
{
    public partial class EquipmentExpiredAlarmUI : Form
    {        
        EquipmentBLL _EquipmentBLL = new EquipmentBLL();
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public EquipmentExpiredAlarmUI()
        {
            InitializeComponent();
            FillAlaramGridEX();
        }
        private void FillAlaramGridEX()
        {
            alarmGridEX.ClearItems();
            try
            {
                EquipmentBOL[] _EquipmentBOL = _EquipmentBLL.SelectExpiredAlarm();
                if (_EquipmentBOL != null)
                {
                    for (int index = 0; index < _EquipmentBOL.Length; index++)
                        alarmGridEX.AddItem(_EquipmentBOL[index].EquipmentId, _EquipmentBOL[index].EquipmentTitle);
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void EquipmentExpiredAlarmUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
    }
}
