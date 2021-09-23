namespace UserInterface.Report
{
    partial class CostReport
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
            Noogen.Validation.ValidationRule validationRule5 = new Noogen.Validation.ValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostReport));
            Noogen.Validation.ValidationRule validationRule6 = new Noogen.Validation.ValidationRule();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.insuranceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.reportButton = new Janus.Windows.EditControls.UIButton();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bankTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doctorLOVButton = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.costReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fromDateTimePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.toDateTimePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(193, 11);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.ReadOnly = true;
            this.doctorNameTextBox.Size = new System.Drawing.Size(284, 21);
            this.doctorNameTextBox.TabIndex = 1;
            validationRule5.ErrorMessage = "داده اجباری";
            validationRule5.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.doctorNameTextBox, validationRule5);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(497, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 13);
            this.label29.TabIndex = 166;
            this.label29.Text = "خانم/آقای دکتر:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(338, 41);
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
            this.label1.Location = new System.Drawing.Point(134, 41);
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
            this.insuranceTypeComboBox.Location = new System.Drawing.Point(584, 11);
            this.insuranceTypeComboBox.Name = "insuranceTypeComboBox";
            this.insuranceTypeComboBox.Size = new System.Drawing.Size(118, 21);
            this.insuranceTypeComboBox.TabIndex = 0;
            validationRule6.ErrorMessage = "داده اجباری";
            validationRule6.InitialValue = "[انتخاب کنید]";
            validationRule6.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.insuranceTypeComboBox, validationRule6);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(12, 63);
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
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 522);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(786, 23);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(729, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 174;
            this.label2.Text = "استان:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(543, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 175;
            this.label3.Text = "شهر:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(584, 37);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(118, 21);
            this.areaTextBox.TabIndex = 2;
            this.areaTextBox.Text = "مرکزی";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(386, 37);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(91, 21);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.Text = "اراک";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(193, 63);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(105, 21);
            this.accountNumberTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(304, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 178;
            this.label4.Text = "شماره حساب:";
            // 
            // bankTextBox
            // 
            this.bankTextBox.Location = new System.Drawing.Point(584, 63);
            this.bankTextBox.Name = "bankTextBox";
            this.bankTextBox.Size = new System.Drawing.Size(118, 21);
            this.bankTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(737, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 180;
            this.label5.Text = "بانک:";
            // 
            // branchTextBox
            // 
            this.branchTextBox.Location = new System.Drawing.Point(386, 63);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(91, 21);
            this.branchTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(538, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 182;
            this.label6.Text = "شعبه:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(719, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 185;
            this.label9.Text = "نوع بيمه:";
            // 
            // doctorLOVButton
            // 
            this.doctorLOVButton.Location = new System.Drawing.Point(160, 9);
            this.doctorLOVButton.Name = "doctorLOVButton";
            this.doctorLOVButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.doctorLOVButton.Size = new System.Drawing.Size(27, 23);
            this.doctorLOVButton.TabIndex = 186;
            this.doctorLOVButton.Text = "...";
            this.doctorLOVButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.doctorLOVButton.Click += new System.EventHandler(this.doctorLOVButton_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.costReportViewer);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 93);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.uiGroupBox1.Size = new System.Drawing.Size(762, 421);
            this.uiGroupBox1.TabIndex = 175;
            this.uiGroupBox1.Text = "فرم درخواست هزینه خدمات درمانی در مراکز مستقل(دندانپزشک عمومی)";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // costReportViewer
            // 
            this.costReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costReportViewer.LocalReport.ReportEmbeddedResource = "";
            this.costReportViewer.Location = new System.Drawing.Point(13, 27);
            this.costReportViewer.Name = "costReportViewer";
            this.costReportViewer.Size = new System.Drawing.Size(736, 381);
            this.costReportViewer.TabIndex = 175;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(193, 37);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.fromDateTimePicker.TabIndex = 176;
            this.fromDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(12, 37);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.toDateTimePicker.TabIndex = 187;
            this.toDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // CostReport
            // 
            this.AcceptButton = this.reportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(786, 545);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.doctorLOVButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.insuranceTypeComboBox);
            this.Controls.Add(this.branchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bankTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CostReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CostReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CostReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.Label label1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private Janus.Windows.EditControls.UIButton reportButton;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bankTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox insuranceTypeComboBox;
        private Janus.Windows.EditControls.UIButton doctorLOVButton;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer costReportViewer;
        private FarsiLibrary.Win.Controls.FADatePicker fromDateTimePicker;
        private FarsiLibrary.Win.Controls.FADatePicker toDateTimePicker;
    }
}