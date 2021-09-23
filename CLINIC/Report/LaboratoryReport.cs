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

    public partial class LaboratoryReport : Form
    {
        private DoctorBOL _DoctorBOL = new DoctorBOL();
        ExceptionHandlerBOL _ExceptionHandlerBOL;

        public LaboratoryReport()
        {
            InitializeComponent();
            fromDateTimePicker.SelectedDateTime = toDateTimePicker.SelectedDateTime = DateTime.Today;
        }
        private void InitializeReportViewer()
        {
            try
            {
                LaboratoryBOL _LaboratoryBOL = new LaboratoryBOL(((ListItem)laboratoryComboBox.SelectedItem).Id, ((ListItem)laboratoryComboBox.SelectedItem).Value);
                LaboratoryStateBOL _LaboratoryStateBOL = new LaboratoryStateBOL(((ListItem)laboratoryStateComboBox.SelectedItem).Id, ((ListItem)laboratoryStateComboBox.SelectedItem).Value);
                                
                laboratoryReportViewer.LocalReport.ReportEmbeddedResource = "UserInterface.Report.LaboratoryReport.rdlc";
                ReportParameter[] parameter = new ReportParameter[4];                
                parameter[0] = new ReportParameter("FromDate", DataConvertor.ConvertToPersianDate(fromDateTimePicker.SelectedDateTime));
                parameter[1] = new ReportParameter("ToDate", DataConvertor.ConvertToPersianDate(toDateTimePicker.SelectedDateTime));
                parameter[2] = new ReportParameter("LaboratoryTitle", ((_LaboratoryBOL.LaboratoryId==null)?string.Empty:_LaboratoryBOL.LaboratoryTitle));
                parameter[3] = new ReportParameter("LaboratoryStateTitle", _LaboratoryStateBOL.LaboratoryStateTitle);                
                laboratoryReportViewer.LocalReport.SetParameters(parameter);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LaboratoryReport_Load(object sender, EventArgs e)
        {
            this.laboratoryReportViewer.RefreshReport();
            LaboratoryComboBoxBind();
            LaboratoryStateComboBoxBind();
        } 
        private void reportButton_Click(object sender, EventArgs e)
        {            
                LoadLaboratoryReport();
        }
        private void LoadLaboratoryReport()
        {
            try
            {
                InitializeReportViewer();
                laboratoryReportViewer.LocalReport.DataSources.Clear();
                LaboratoryReportFilterBOL _LaboratoryReportBOL = new LaboratoryReportFilterBOL((short?)((ListItem)laboratoryComboBox.SelectedItem).Id, (short?)((ListItem)laboratoryStateComboBox.SelectedItem).Id, fromDateTimePicker.SelectedDateTime, toDateTimePicker.SelectedDateTime);
                LaboratoryReportBLL _LaboratoryReportBLL = new LaboratoryReportBLL();

                ReportDataSource laboratoryReportDataSource = new ReportDataSource();
                BindingSource laboratoryReportBindingSource = new BindingSource();
                List<LaboratoryReportItemsBOL> laboratoryReportItemsBOL = new List<LaboratoryReportItemsBOL>();
                laboratoryReportItemsBOL = _LaboratoryReportBLL.Select(_LaboratoryReportBOL);
                laboratoryReportDataSource.Name = "BusinessObjectLayer_LaboratoryReportItemsBOL";
                laboratoryReportDataSource.Value = laboratoryReportBindingSource;
                laboratoryReportViewer.LocalReport.DataSources.Add(laboratoryReportDataSource);
                laboratoryReportBindingSource.DataSource = laboratoryReportItemsBOL;
                laboratoryReportViewer.RefreshReport();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }        
        private void laboratoryReportViewer_Load(object sender, EventArgs e)
        {
            laboratoryReportViewer.ProcessingMode = ProcessingMode.Local;            
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
        private void LaboratoryReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void LaboratoryComboBoxBind()
        {
            try
            {
                LaboratoryBOL[] LaboratoryRecords = new LaboratoryBLL().SelectComboBox();
                laboratoryComboBox.Items.Clear();
                if (LaboratoryRecords != null)
                {
                    for (int index = 0; index < LaboratoryRecords.Length; index++)
                    {
                        laboratoryComboBox.Items.Add(new ListItem(LaboratoryRecords[index].LaboratoryId, LaboratoryRecords[index].LaboratoryTitle));
                    }
                    laboratoryComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void LaboratoryStateComboBoxBind()
        {
            try
            {
                LaboratoryStateBOL[] LaboratoryStateRecords = new LaboratoryStateBLL().SelectComboBox();
                laboratoryStateComboBox.Items.Clear();
                if (LaboratoryStateRecords != null)
                {
                    for (int index = 0; index < LaboratoryStateRecords.Length; index++)
                    {
                        laboratoryStateComboBox.Items.Add(new ListItem(LaboratoryStateRecords[index].LaboratoryStateId, LaboratoryStateRecords[index].LaboratoryStateTitle));
                    }
                    laboratoryStateComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
    }
}
