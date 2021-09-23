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
    using DataConvertor;
    public partial class DoctorLOV : Form
    {
        
        private DoctorBOL _DoctorBOL;
        private DoctorBLL _DoctorBLL;
        public short DoctorID;
        public string DoctorName;
        public int MedicalCode;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        public DoctorLOV()
        {
            InitializeComponent();
            _DoctorBOL = new DoctorBOL();
            _DoctorBLL = new DoctorBLL();
            acceptButton.Visible = false;            
        }
        private void FillDoctorGridEx()
        {
            doctorGridEX.ClearItems();
            try
            {
                DoctorBOL[] _DoctorBOL = _DoctorBLL.Select();
                if (_DoctorBOL != null)
                    for (int index = 0; index < _DoctorBOL.Length; index++)
                        doctorGridEX.AddItem(_DoctorBOL[index].DoctorId, _DoctorBOL[index].FirstName, _DoctorBOL[index].LastName, _DoctorBOL[index].Gender, _DoctorBOL[index].DoctorCode, _DoctorBOL[index].MedicalCode, _DoctorBOL[index].SpecialistId, _DoctorBOL[index].SpecialistTitle);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void noticeLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                noticeLabel.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            _DoctorBOL.DoctorId = -1;
            _DoctorBOL.DoctorName = String.Empty;
            _DoctorBOL.MedicalCode = MedicalCode;
            this.Close();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            DoctorID = (short)_DoctorBOL.DoctorId;
            DoctorName = string.Format("{0} {1}", _DoctorBOL.FirstName, _DoctorBOL.LastName);
            MedicalCode = (int)_DoctorBOL.MedicalCode;
            this.Close();
        }
        private void doctorGridEX_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (doctorGridEX.CurrentRow.RowIndex > -1)
                {
                    _DoctorBOL.DoctorId = (short)(doctorGridEX.CurrentRow.Cells["DOCTORID"].Value);
                    _DoctorBOL.FirstName = DataConvertor.ConvertToString(doctorGridEX.CurrentRow.Cells["FIRSTNAME"].Value);
                    _DoctorBOL.LastName = DataConvertor.ConvertToString(doctorGridEX.CurrentRow.Cells["LASTNAME"].Value);
                    _DoctorBOL.MedicalCode = DataConvertor.ConvertToInt(doctorGridEX.CurrentRow.Cells["MEDICALCODE"].Value);
                    doctorNameTextBox.Text = string.Format("{0} {1}", _DoctorBOL.FirstName, _DoctorBOL.LastName);
                    acceptButton.Visible = true;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void DoctorLOV_Load(object sender, EventArgs e)
        {
            FillDoctorGridEx();
        }
        private void DoctorLOV_KeyDown(object sender, KeyEventArgs e)
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
