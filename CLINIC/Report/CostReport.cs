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

    public partial class CostReport : Form
    {
        private DoctorBOL _DoctorBOL = new DoctorBOL();
        ExceptionHandlerBOL _ExceptionHandlerBOL;

        public CostReport()
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
                
                costReportViewer.LocalReport.ReportEmbeddedResource = "UserInterface.Report.CostReport.rdlc";
                ReportParameter[] parameter = new ReportParameter[12];
                parameter[0] = new ReportParameter("DoctorName", _DoctorBOL.DoctorName);
                parameter[1] = new ReportParameter("FromDate", DataConvertor.ConvertToPersianDate(fromDateTimePicker.SelectedDateTime));
                parameter[2] = new ReportParameter("ToDate", DataConvertor.ConvertToPersianDate(toDateTimePicker.SelectedDateTime));
                parameter[3] = new ReportParameter("MedicalCode", _DoctorBOL.MedicalCode.ToString());
                parameter[4] = new ReportParameter("Area", areaTextBox.Text);
                parameter[5] = new ReportParameter("City", cityTextBox.Text);
                parameter[6] = new ReportParameter("AccountNumber", accountNumberTextBox.Text);
                parameter[7] = new ReportParameter("Bank", bankTextBox.Text);
                parameter[8] = new ReportParameter("Branch", branchTextBox.Text);
                parameter[9] = new ReportParameter("InsuranceTypeId", _InsuranceTypeBOL.InsuranceTypeId.ToString());
                parameter[10] = new ReportParameter("InsuranceTypeTitle", _InsuranceTypeBOL.InsuranceTypeTitle);                
                parameter[11] = new ReportParameter("Percent", _InsuranceTypeBOL.Percent.ToString());
                costReportViewer.LocalReport.SetParameters(parameter);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void CostReport_Load(object sender, EventArgs e)
        {
            this.costReportViewer.RefreshReport();
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
                LoadCostReport();
        }
        private void LoadCostReport()
        {
            try
            {
                InitializeReportViewer();
                costReportViewer.LocalReport.DataSources.Clear();
                CostReportFilterBOL _CostReportBOL = new CostReportFilterBOL((short)((ListItem)insuranceTypeComboBox.SelectedItem).Id, _DoctorBOL.DoctorId, fromDateTimePicker.SelectedDateTime, toDateTimePicker.SelectedDateTime);
                CostReportBLL _CostReportBLL = new CostReportBLL();

                ReportDataSource costReportDataSource = new ReportDataSource();
                BindingSource costReportBindingSource = new BindingSource();
                List<CostReportItemsBOL> costReportItemsBOL = new List<CostReportItemsBOL>();
                costReportItemsBOL = _CostReportBLL.Select(_CostReportBOL);
                costReportDataSource.Name = "BusinessObjectLayer_CostReportItemsBOL";
                costReportDataSource.Value = costReportBindingSource;
                costReportViewer.LocalReport.DataSources.Add(costReportDataSource);
                costReportBindingSource.DataSource = costReportItemsBOL;

                ReportDataSource costReportNormalPatientDataSource = new ReportDataSource();
                BindingSource costReportNormalPatientBindingSource = new BindingSource();
                List<CostReportPatientBOL> costReportNormalPatientBOL = new List<CostReportPatientBOL>();
                costReportNormalPatientBOL = _CostReportBLL.Select(_CostReportBOL, true);
                costReportNormalPatientDataSource.Name = "BusinessObjectLayer_CostReportNormalPatientBOL";
                costReportNormalPatientDataSource.Value = costReportNormalPatientBindingSource;
                costReportViewer.LocalReport.DataSources.Add(costReportNormalPatientDataSource);
                costReportNormalPatientBindingSource.DataSource = costReportNormalPatientBOL;


                ReportDataSource costReportNotNormalPatientDataSource = new ReportDataSource();
                BindingSource costReportNotNormalPatientBindingSource = new BindingSource();
                List<CostReportPatientBOL> costReportNotNormalPatientBOL = new List<CostReportPatientBOL>();
                costReportNotNormalPatientBOL = _CostReportBLL.Select(_CostReportBOL, true);
                costReportNotNormalPatientDataSource.Name = "BusinessObjectLayer_CostReportNotNormalPatientBOL";
                costReportNotNormalPatientDataSource.Value = costReportNotNormalPatientBindingSource;
                costReportViewer.LocalReport.DataSources.Add(costReportNotNormalPatientDataSource);
                costReportNotNormalPatientBindingSource.DataSource = costReportNotNormalPatientBOL;

                costReportViewer.RefreshReport();
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
        private void costReportViewer_Load(object sender, EventArgs e)
        {
            costReportViewer.ProcessingMode = ProcessingMode.Local;            
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
        private void CostReport_KeyDown(object sender, KeyEventArgs e)
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
