namespace UserInterface
{
    partial class EquipmentHistoryUI
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
            Janus.Windows.GridEX.GridEXLayout historyGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentHistoryUI));
            Noogen.Validation.ValidationRule validationRule1 = new Noogen.Validation.ValidationRule();
            this.historyGridEX = new Janus.Windows.GridEX.GridEX();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.equipmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.equipmentGroupBox = new Janus.Windows.EditControls.UIGroupBox();
            this.eqipmentLOVButton = new Janus.Windows.EditControls.UIButton();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isInputRadioButton = new System.Windows.Forms.RadioButton();
            this.isNotInputRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.countNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.insertCancelButton = new Janus.Windows.EditControls.UIButton();
            this.updateButton = new Janus.Windows.EditControls.UIButton();
            this.deleteButton = new Janus.Windows.EditControls.UIButton();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.ButtonCommand();
            this.datePersianDateTimePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGroupBox)).BeginInit();
            this.equipmentGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyGridEX
            // 
            this.historyGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.historyGridEX.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>برای گ" +
                "روه بندی فیلد ها را اینجا بکشید</GroupByBoxInfo></LocalizableData>";
            historyGridEX_DesignTimeLayout.LayoutString = resources.GetString("historyGridEX_DesignTimeLayout.LayoutString");
            this.historyGridEX.DesignTimeLayout = historyGridEX_DesignTimeLayout;
            this.historyGridEX.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.historyGridEX.Location = new System.Drawing.Point(0, 0);
            this.historyGridEX.Name = "historyGridEX";
            this.historyGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.historyGridEX.Size = new System.Drawing.Size(597, 233);
            this.historyGridEX.TabIndex = 0;
            this.historyGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.historyGridEX.SelectionChanged += new System.EventHandler(this.historyGridEX_SelectionChanged);
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // equipmentTitleTextBox
            // 
            this.equipmentTitleTextBox.Location = new System.Drawing.Point(263, 16);
            this.equipmentTitleTextBox.Name = "equipmentTitleTextBox";
            this.equipmentTitleTextBox.ReadOnly = true;
            this.equipmentTitleTextBox.Size = new System.Drawing.Size(235, 21);
            this.equipmentTitleTextBox.TabIndex = 2;
            validationRule1.ErrorMessage = "داده اجباري";
            validationRule1.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.equipmentTitleTextBox, validationRule1);
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // equipmentGroupBox
            // 
            this.equipmentGroupBox.Controls.Add(this.datePersianDateTimePicker);
            this.equipmentGroupBox.Controls.Add(this.eqipmentLOVButton);
            this.equipmentGroupBox.Controls.Add(this.label23);
            this.equipmentGroupBox.Controls.Add(this.panel1);
            this.equipmentGroupBox.Controls.Add(this.equipmentTitleTextBox);
            this.equipmentGroupBox.Controls.Add(this.label2);
            this.equipmentGroupBox.Controls.Add(this.countNumericEditBox);
            this.equipmentGroupBox.Controls.Add(this.label1);
            this.equipmentGroupBox.Controls.Add(this.label14);
            this.equipmentGroupBox.Location = new System.Drawing.Point(12, 239);
            this.equipmentGroupBox.Name = "equipmentGroupBox";
            this.equipmentGroupBox.Size = new System.Drawing.Size(573, 74);
            this.equipmentGroupBox.TabIndex = 1;
            // 
            // eqipmentLOVButton
            // 
            this.eqipmentLOVButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eqipmentLOVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.eqipmentLOVButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.eqipmentLOVButton.Location = new System.Drawing.Point(217, 15);
            this.eqipmentLOVButton.Name = "eqipmentLOVButton";
            this.eqipmentLOVButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.eqipmentLOVButton.Size = new System.Drawing.Size(32, 23);
            this.eqipmentLOVButton.TabIndex = 3;
            this.eqipmentLOVButton.Text = "...";
            this.eqipmentLOVButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.eqipmentLOVButton.Click += new System.EventHandler(this.equipmentLOVButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(384, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 99;
            this.label23.Text = "تاريخ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.isInputRadioButton);
            this.panel1.Controls.Add(this.isNotInputRadioButton);
            this.panel1.Location = new System.Drawing.Point(4, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 21);
            this.panel1.TabIndex = 6;
            // 
            // isInputRadioButton
            // 
            this.isInputRadioButton.AutoSize = true;
            this.isInputRadioButton.Location = new System.Drawing.Point(72, 2);
            this.isInputRadioButton.Name = "isInputRadioButton";
            this.isInputRadioButton.Size = new System.Drawing.Size(54, 17);
            this.isInputRadioButton.TabIndex = 0;
            this.isInputRadioButton.Text = "ورودي";
            this.isInputRadioButton.UseVisualStyleBackColor = true;
            // 
            // isNotInputRadioButton
            // 
            this.isNotInputRadioButton.AutoSize = true;
            this.isNotInputRadioButton.Checked = true;
            this.isNotInputRadioButton.Location = new System.Drawing.Point(3, 2);
            this.isNotInputRadioButton.Name = "isNotInputRadioButton";
            this.isNotInputRadioButton.Size = new System.Drawing.Size(60, 17);
            this.isNotInputRadioButton.TabIndex = 1;
            this.isNotInputRadioButton.TabStop = true;
            this.isNotInputRadioButton.Text = "خروجی";
            this.isNotInputRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(136, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "وضعيت ورودي/خروجی:";
            // 
            // countNumericEditBox
            // 
            this.countNumericEditBox.Location = new System.Drawing.Point(422, 45);
            this.countNumericEditBox.Name = "countNumericEditBox";
            this.countNumericEditBox.Size = new System.Drawing.Size(76, 21);
            this.countNumericEditBox.TabIndex = 4;
            this.countNumericEditBox.Text = "0";
            this.countNumericEditBox.Value = ((long)(0));
            this.countNumericEditBox.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(533, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "تعداد:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(530, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "عنوان:";
            // 
            // insertCancelButton
            // 
            this.insertCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.insertCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.insertCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.insertCancelButton.Location = new System.Drawing.Point(12, 327);
            this.insertCancelButton.Name = "insertCancelButton";
            this.insertCancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.insertCancelButton.Size = new System.Drawing.Size(75, 23);
            this.insertCancelButton.TabIndex = 4;
            this.insertCancelButton.Text = "ايجاد";
            this.insertCancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.insertCancelButton.Click += new System.EventHandler(this.insertCancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.updateButton.Location = new System.Drawing.Point(93, 327);
            this.updateButton.Name = "updateButton";
            this.updateButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "ويرايش";
            this.updateButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.deleteButton.Location = new System.Drawing.Point(174, 327);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "حذف";
            this.deleteButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 360);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(597, 23);
            // 
            // 
            // 
            this.mainRibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000;
            this.mainRibbonStatusBar.SuperTipComponent.ImageList = null;
            this.mainRibbonStatusBar.TabIndex = 149;
            this.mainRibbonStatusBar.Text = "ribbonStatusBar1";
            this.mainRibbonStatusBar.UseCompatibleTextRendering = false;
            // 
            // noticeLabel
            // 
            this.noticeLabel.AllowAddToQuickAccessBar = true;
            this.noticeLabel.ForegroundStyle.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Key = "noticeLabel";
            this.noticeLabel.Name = "buttonCommand1";
            this.noticeLabel.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.noticeLabel.Text = "";
            // 
            // datePersianDateTimePicker
            // 
            this.datePersianDateTimePicker.Location = new System.Drawing.Point(264, 44);
            this.datePersianDateTimePicker.Name = "datePersianDateTimePicker";
            this.datePersianDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.datePersianDateTimePicker.TabIndex = 102;
            this.datePersianDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // EquipmentHistoryUI
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.insertCancelButton;
            this.ClientSize = new System.Drawing.Size(597, 383);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.insertCancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.equipmentGroupBox);
            this.Controls.Add(this.historyGridEX);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EquipmentHistoryUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود / خروج تجهیزات";
            this.Load += new System.EventHandler(this.EquipmentHistoryUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EquipmentHistoryUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.historyGridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGroupBox)).EndInit();
            this.equipmentGroupBox.ResumeLayout(false);
            this.equipmentGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX historyGridEX;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.EditControls.UIButton insertCancelButton;
        private Janus.Windows.EditControls.UIButton updateButton;
        private Janus.Windows.EditControls.UIButton deleteButton;
        private Janus.Windows.EditControls.UIGroupBox equipmentGroupBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton isInputRadioButton;
        private System.Windows.Forms.RadioButton isNotInputRadioButton;
        private System.Windows.Forms.TextBox equipmentTitleTextBox;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.EditControls.NumericEditBox countNumericEditBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private Janus.Windows.EditControls.UIButton eqipmentLOVButton;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.ButtonCommand noticeLabel;
        private FarsiLibrary.Win.Controls.FADatePicker datePersianDateTimePicker;

    }
}