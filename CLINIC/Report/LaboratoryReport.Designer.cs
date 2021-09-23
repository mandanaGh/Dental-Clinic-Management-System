namespace UserInterface.Report
{
    partial class LaboratoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratoryReport));
            Noogen.Validation.ValidationRule validationRule3 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule4 = new Noogen.Validation.ValidationRule();
            this.label28 = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.laboratoryStateComboBox = new System.Windows.Forms.ComboBox();
            this.laboratoryComboBox = new System.Windows.Forms.ComboBox();
            this.reportButton = new Janus.Windows.EditControls.UIButton();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.laboratoryReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label28.Location = new System.Drawing.Point(274, 16);
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
            this.label1.Location = new System.Drawing.Point(116, 16);
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
            // laboratoryStateComboBox
            // 
            this.laboratoryStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laboratoryStateComboBox.FormattingEnabled = true;
            this.laboratoryStateComboBox.Location = new System.Drawing.Point(322, 12);
            this.laboratoryStateComboBox.Name = "laboratoryStateComboBox";
            this.laboratoryStateComboBox.Size = new System.Drawing.Size(143, 21);
            this.laboratoryStateComboBox.TabIndex = 197;
            validationRule3.ErrorMessage = "داده اجباری";
            validationRule3.InitialValue = "[انتخاب کنید]";
            validationRule3.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.laboratoryStateComboBox, validationRule3);
            // 
            // laboratoryComboBox
            // 
            this.laboratoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laboratoryComboBox.FormattingEnabled = true;
            this.laboratoryComboBox.Location = new System.Drawing.Point(558, 12);
            this.laboratoryComboBox.Name = "laboratoryComboBox";
            this.laboratoryComboBox.Size = new System.Drawing.Size(143, 21);
            this.laboratoryComboBox.TabIndex = 195;
            validationRule4.ErrorMessage = "داده اجباری";
            validationRule4.InitialValue = "[انتخاب کنید]";
            validationRule4.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.laboratoryComboBox, validationRule4);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(12, 38);
            this.reportButton.Name = "reportButton";
            this.reportButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "مشاهده";
            this.reportButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 492);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(762, 23);
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
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiGroupBox1.Controls.Add(this.laboratoryReportViewer);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 67);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.uiGroupBox1.Size = new System.Drawing.Size(733, 405);
            this.uiGroupBox1.TabIndex = 175;
            this.uiGroupBox1.Text = "لیست سفارشات ارسالی به لابراتوار";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // laboratoryReportViewer
            // 
            this.laboratoryReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laboratoryReportViewer.LocalReport.ReportEmbeddedResource = "";
            this.laboratoryReportViewer.Location = new System.Drawing.Point(13, 27);
            this.laboratoryReportViewer.Name = "laboratoryReportViewer";
            this.laboratoryReportViewer.Size = new System.Drawing.Size(707, 365);
            this.laboratoryReportViewer.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(471, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 198;
            this.label5.Text = "وضعیت لابراتوار:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(707, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 196;
            this.label9.Text = "لابراتوار:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.toDateTimePicker.TabIndex = 200;
            this.toDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(170, 12);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.fromDateTimePicker.TabIndex = 199;
            this.fromDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // LaboratoryReport
            // 
            this.AcceptButton = this.reportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(762, 515);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.laboratoryStateComboBox);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.laboratoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label28);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LaboratoryReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LaboratoryReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaboratoryReport_KeyDown);
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
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer laboratoryReportViewer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox laboratoryStateComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox laboratoryComboBox;
        private FarsiLibrary.Win.Controls.FADatePicker toDateTimePicker;
        private FarsiLibrary.Win.Controls.FADatePicker fromDateTimePicker;
    }
}