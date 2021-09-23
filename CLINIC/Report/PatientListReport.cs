using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UserInterface.Report
{
    using DataConvertor;
    using BusinessLogicLayer;
    using BusinessObjectLayer;

    public partial class PatientListReport : Form
    {
        private DoctorBOL _DoctorBOL = new DoctorBOL();
        ExceptionHandlerBOL _ExceptionHandlerBOL;

        public PatientListReport()
        {
            InitializeComponent();
            fromDateTimePicker.SelectedDateTime = toDateTimePicker.SelectedDateTime = DateTime.Today;
        }
        private void InitializeReportViewer()
        {
            try
            {
                InsuranceTypeBOL _InsuranceTypeBOL = new InsuranceTypeBOL(((ListItem)insuranceTypeComboBox.SelectedItem).Id, ((ListItem)insuranceTypeComboBox.SelectedItem).Value);
                _InsuranceTypeBOL.Percent = new InsuranceTypeBLL().GetPercent(_InsuranceTypeBOL);

                patientListReportViewer.LocalReport.ReportEmbeddedResource = "UserInterface.Report.PatientListReport.rdlc";
                ReportParameter[] parameter = new ReportParameter[5];
                parameter[0] = new ReportParameter("FromDate", DataConvertor.ConvertToPersianDate(fromDateTimePicker.SelectedDateTime));
                parameter[1] = new ReportParameter("ToDate", DataConvertor.ConvertToPersianDate(toDateTimePicker.SelectedDateTime));
                parameter[2] = new ReportParameter("InsuranceTypeTitle", _InsuranceTypeBOL.InsuranceTypeTitle);
                parameter[3] = new ReportParameter("Percent", _InsuranceTypeBOL.Percent.ToString());
                parameter[4] = new ReportParameter("DoctorName", _DoctorBOL.DoctorName);
                patientListReportViewer.LocalReport.SetParameters(parameter);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void PatientListReport_Load(object sender, EventArgs e)
        {
            this.patientListReportViewer.RefreshReport();
            InsuranceTypeComboBoxBind();
        }
        private void doctorLOVButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorLOV _DoctorLOV = new DoctorLOV();
                if (_DoctorLOV.ShowDialog() == DialogResult.OK)
                {
                    _DoctorBOL = new DoctorBOL(_DoctorLOV.DoctorID, _DoctorLOV.DoctorName, _DoctorLOV.MedicalCode);
                    if (_DoctorBOL.DoctorId > 0)
                        doctorNameTextBox.Text = _DoctorBOL.DoctorName;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            if (ValidateReport())
                LoadPatientListReport();
        }
        private void LoadPatientListReport()
        {
            try
            {
                InitializeReportViewer();
                patientListReportViewer.LocalReport.DataSources.Clear();
                PatientListReportFilterBOL PatientListReportFilterBOL = new PatientListReportFilterBOL((short)((ListItem)insuranceTypeComboBox.SelectedItem).Id, _DoctorBOL.DoctorId, fromDateTimePicker.SelectedDateTime, toDateTimePicker.SelectedDateTime);
                PatientListReportBLL _PatientListReportBLL = new PatientListReportBLL();

                ReportDataSource patientListReportDataSource = new ReportDataSource();
                BindingSource patientListReportBindingSource = new BindingSource();
                List<PatientListReportItemsBOL> patientListReportItemsBOL = new List<PatientListReportItemsBOL>();
                patientListReportItemsBOL = _PatientListReportBLL.Select(PatientListReportFilterBOL);
                patientListReportDataSource.Name = "BusinessObjectLayer_PatientListReportItemsBOL";
                patientListReportDataSource.Value = patientListReportBindingSource;
                patientListReportViewer.LocalReport.DataSources.Add(patientListReportDataSource);
                patientListReportBindingSource.DataSource = patientListReportItemsBOL;

                ReportDataSource patientListReportPatientDataSource = new ReportDataSource();
                BindingSource patientListReportPatientBindingSource = new BindingSource();
                List<PatientListReportPatientBOL> patientListReportNormalPatientBOL = new List<PatientListReportPatientBOL>();
                patientListReportNormalPatientBOL = _PatientListReportBLL.SelectServiceCount(PatientListReportFilterBOL);
                patientListReportPatientDataSource.Name = "BusinessObjectLayer_PatientListReportPatientBOL";
                patientListReportPatientDataSource.Value = patientListReportPatientBindingSource;
                patientListReportViewer.LocalReport.DataSources.Add(patientListReportPatientDataSource);
                patientListReportPatientBindingSource.DataSource = patientListReportNormalPatientBOL;

                patientListReportViewer.RefreshReport();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void InsuranceTypeComboBoxBind()
        {
            try
            {
                InsuranceTypeBOL[] InsuranceTypeRecords = new InsuranceTypeBLL().SelectComboBox();
                insuranceTypeComboBox.Items.Clear();
                if (InsuranceTypeRecords != null)
                {
                    for (int index = 0; index < InsuranceTypeRecords.Length; index++)
                    {
                        insuranceTypeComboBox.Items.Add(new ListItem(InsuranceTypeRecords[index].InsuranceTypeId, InsuranceTypeRecords[index].InsuranceTypeTitle));
                    }
                    insuranceTypeComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private bool ValidateReport()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void patientListReportViewer_Load(object sender, EventArgs e)
        {
            patientListReportViewer.ProcessingMode = ProcessingMode.Local;            
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
        private void PatientListReport_KeyDown(object sender, KeyEventArgs e)
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
