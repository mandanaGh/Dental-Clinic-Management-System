namespace UserInterface.Report
{
    partial class PrescriptionListReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionListReport));
            Noogen.Validation.ValidationRule validationRule1 = new Noogen.Validation.ValidationRule();
            this.label28 = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.insuranceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.reportButton = new Janus.Windows.EditControls.UIButton();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.label9 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.prescriptionListReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toDateTimePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.fromDateTimePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(389, 15);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 13);
            this.label28.TabIndex = 165;
            this.label28.Text = "از تاریخ:";
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(231, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "تا تاریخ:";
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // insuranceTypeComboBox
            // 
            this.insuranceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insuranceTypeComboBox.FormattingEnabled = true;
            this.insuranceTypeComboBox.Location = new System.Drawing.Point(437, 11);
            this.insuranceTypeComboBox.Name = "insuranceTypeComboBox";
            this.insuranceTypeComboBox.Size = new System.Drawing.Size(189, 21);
            this.insuranceTypeComboBox.TabIndex = 0;
            validationRule1.ErrorMessage = "داده اجباری";
            validationRule1.InitialValue = "[انتخاب کنید]";
            validationRule1.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.insuranceTypeComboBox, validationRule1);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(12, 10);
            this.reportButton.Name = "reportButton";
            this.reportButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "مشاهده";
            this.reportButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 498);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(709, 23);
            // 
            // 
            // 
            this.mainRibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000;
            this.mainRibbonStatusBar.SuperTipComponent.ImageList = null;
            this.mainRibbonStatusBar.TabIndex = 173;
            this.mainRibbonStatusBar.Text = "ribbonStatusBar1";
            this.mainRibbonStatusBar.UseCompatibleTextRendering = false;
            // 
            // noticeLabel
            // 
            this.noticeLabel.AllowAddToQuickAccessBar = true;
            this.noticeLabel.ForegroundStyle.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Key = "noticeLabel";
            this.noticeLabel.Name = "labelCommand1";
            this.noticeLabel.Text = "";
            this.noticeLabel.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.noticeLabel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(632, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 177;
            this.label9.Text = "نوع بيمه:";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiGroupBox1.Controls.Add(this.prescriptionListReportViewer);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 45);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.uiGroupBox1.Size = new System.Drawing.Size(677, 438);
            this.uiGroupBox1.TabIndex = 175;
            this.uiGroupBox1.Text = "لیست ارسالی نسخ مربوط به بیماران محترم";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // prescriptionListReportViewer
            // 
            this.prescriptionListReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionListReportViewer.LocalReport.ReportEmbeddedResource = "";
            this.prescriptionListReportViewer.Location = new System.Drawing.Point(13, 27);
            this.prescriptionListReportViewer.Name = "prescriptionListReportViewer";
            this.prescriptionListReportViewer.Size = new System.Drawing.Size(651, 398);
            this.prescriptionListReportViewer.TabIndex = 175;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(120, 11);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.toDateTimePicker.TabIndex = 189;
            this.toDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(278, 11);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.fromDateTimePicker.TabIndex = 188;
            this.fromDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // PrescriptionListReport
            // 
            this.AcceptButton = this.reportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(709, 521);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.insuranceTypeComboBox);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label28);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PrescriptionListReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PrescriptionListReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrescriptionListReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.Label label1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private Janus.Windows.EditControls.UIButton reportButton;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox insuranceTypeComboBox;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer prescriptionListReportViewer;
        private FarsiLibrary.Win.Controls.FADatePicker toDateTimePicker;
        private FarsiLibrary.Win.Controls.FADatePicker fromDateTimePicker;
    }
}