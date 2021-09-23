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

    public partial class PrescriptionListReport : Form
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;

        public PrescriptionListReport()
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

                prescriptionListReportViewer.LocalReport.ReportEmbeddedResource = "UserInterface.Report.PrescriptionListReport.rdlc";
                ReportParameter[] parameter = new ReportParameter[4];
                parameter[0] = new ReportParameter("FromDate", DataConvertor.ConvertToPersianDate(fromDateTimePicker.SelectedDateTime));
                parameter[1] = new ReportParameter("ToDate", DataConvertor.ConvertToPersianDate(toDateTimePicker.SelectedDateTime));
                parameter[2] = new ReportParameter("InsuranceTypeTitle", _InsuranceTypeBOL.InsuranceTypeTitle);
                parameter[3] = new ReportParameter("Percent", _InsuranceTypeBOL.Percent.ToString());
                prescriptionListReportViewer.LocalReport.SetParameters(parameter);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void PrescriptionListReport_Load(object sender, EventArgs e)
        {
            this.prescriptionListReportViewer.RefreshReport();
            InsuranceTypeComboBoxBind();
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
        private void reportButton_Click(object sender, EventArgs e)
        {
            if (ValidateReport())
                LoadPrescriptionListReport();
        }
        private void LoadPrescriptionListReport()
        {
            try
            {
                InitializeReportViewer();
                prescriptionListReportViewer.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource();
                BindingSource reportBindingSource = new BindingSource();
                List<PrescriptionListReportItemsBOL> _PrescriptionListReportBOLs = new List<PrescriptionListReportItemsBOL>();
                PrescriptionListReportFilterBOL _PrescriptionListReportBOL = new PrescriptionListReportFilterBOL((short)(((ListItem)insuranceTypeComboBox.SelectedItem).Id), fromDateTimePicker.SelectedDateTime, toDateTimePicker.SelectedDateTime);
                PrescriptionListReportBLL _PrescriptionListReportBLL = new PrescriptionListReportBLL();
                _PrescriptionListReportBOLs = _PrescriptionListReportBLL.Select(_PrescriptionListReportBOL);
                reportDataSource.Name = "BusinessObjectLayer_PrescriptionListReportItemsBOL";
                reportDataSource.Value = reportBindingSource;
                prescriptionListReportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportBindingSource.DataSource = _PrescriptionListReportBOLs;
                prescriptionListReportViewer.RefreshReport();
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
        private void prescriptionListReportViewer_Load(object sender, EventArgs e)
        {
            prescriptionListReportViewer.ProcessingMode = ProcessingMode.Local;
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
        private void PrescriptionListReport_KeyDown(object sender, KeyEventArgs e)
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
