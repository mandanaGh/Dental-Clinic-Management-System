namespace UserInterface
{
    partial class DoctorUI
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
            Janus.Windows.GridEX.GridEXLayout doctorGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorUI));
            Noogen.Validation.ValidationRule validationRule4 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule3 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule2 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule1 = new Noogen.Validation.ValidationRule();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.doctorGridEX = new Janus.Windows.GridEX.GridEX();
            this.insertCancelButton = new Janus.Windows.EditControls.UIButton();
            this.updateButton = new Janus.Windows.EditControls.UIButton();
            this.deleteButton = new Janus.Windows.EditControls.UIButton();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.specialistComboBox = new System.Windows.Forms.ComboBox();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medicalCodeNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.docotruiGroupBox = new Janus.Windows.EditControls.UIGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridEX)).BeginInit();
            this.genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docotruiGroupBox)).BeginInit();
            this.docotruiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // doctorGridEX
            // 
            this.doctorGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.doctorGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.doctorGridEX.BuiltInTextsData = resources.GetString("doctorGridEX.BuiltInTextsData");
            doctorGridEX_DesignTimeLayout.LayoutString = resources.GetString("doctorGridEX_DesignTimeLayout.LayoutString");
            this.doctorGridEX.DesignTimeLayout = doctorGridEX_DesignTimeLayout;
            this.doctorGridEX.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.doctorGridEX.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.doctorGridEX.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.doctorGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.doctorGridEX.Location = new System.Drawing.Point(0, 0);
            this.doctorGridEX.Name = "doctorGridEX";
            this.doctorGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.doctorGridEX.Size = new System.Drawing.Size(612, 314);
            this.doctorGridEX.TabIndex = 1;
            this.doctorGridEX.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.doctorGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.doctorGridEX.SelectionChanged += new System.EventHandler(this.doctorGridEX_SelectionChanged);
            // 
            // insertCancelButton
            // 
            this.insertCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertCancelButton.Location = new System.Drawing.Point(12, 413);
            this.insertCancelButton.Name = "insertCancelButton";
            this.insertCancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.insertCancelButton.Size = new System.Drawing.Size(75, 23);
            this.insertCancelButton.TabIndex = 5;
            this.insertCancelButton.Text = "ايجاد";
            this.insertCancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.insertCancelButton.Click += new System.EventHandler(this.insertCancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateButton.Location = new System.Drawing.Point(93, 413);
            this.updateButton.Name = "updateButton";
            this.updateButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "ويرايش";
            this.updateButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(174, 413);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حذف";
            this.deleteButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 445);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(612, 23);
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
            this.noticeLabel.Name = "labelCommand1";
            this.noticeLabel.Text = "";
            this.noticeLabel.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.noticeLabel_Click);
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // specialistComboBox
            // 
            this.specialistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialistComboBox.FormattingEnabled = true;
            this.specialistComboBox.Location = new System.Drawing.Point(389, 48);
            this.specialistComboBox.MaxDropDownItems = 5;
            this.specialistComboBox.Name = "specialistComboBox";
            this.specialistComboBox.Size = new System.Drawing.Size(106, 21);
            this.specialistComboBox.TabIndex = 4;
            validationRule4.ErrorMessage = "داده اجباری";
            validationRule4.InitialValue = "[انتخاب کنید]";
            validationRule4.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.specialistComboBox, validationRule4);
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Location = new System.Drawing.Point(389, 21);
            this.firstNametextBox.MaxLength = 32;
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(106, 21);
            this.firstNametextBox.TabIndex = 1;
            validationRule3.ErrorMessage = "داده اجباری";
            validationRule3.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.firstNametextBox, validationRule3);
            this.firstNametextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(185, 20);
            this.lastNameTextBox.MaxLength = 32;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(106, 21);
            this.lastNameTextBox.TabIndex = 2;
            validationRule2.ErrorMessage = "داده اجباری";
            validationRule2.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.lastNameTextBox, validationRule2);
            this.lastNameTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // doctorCodeTextBox
            // 
            this.doctorCodeTextBox.Location = new System.Drawing.Point(6, 49);
            this.doctorCodeTextBox.MaxLength = 32;
            this.doctorCodeTextBox.Name = "doctorCodeTextBox";
            this.doctorCodeTextBox.Size = new System.Drawing.Size(106, 21);
            this.doctorCodeTextBox.TabIndex = 6;
            validationRule1.ErrorMessage = "داده اجباری";
            validationRule1.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.doctorCodeTextBox, validationRule1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(131, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 187;
            this.label4.Text = "جنسیت:";
            // 
            // genderPanel
            // 
            this.genderPanel.BackColor = System.Drawing.Color.Transparent;
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(6, 21);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(108, 21);
            this.genderPanel.TabIndex = 3;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(18, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(36, 17);
            this.femaleRadioButton.TabIndex = 2;
            this.femaleRadioButton.Text = "زن";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(64, 2);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(41, 17);
            this.maleRadioButton.TabIndex = 1;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "مرد";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(555, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 182;
            this.label1.Text = "نام:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(310, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 185;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(507, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 188;
            this.label3.Text = "عنوان تخصص:";
            // 
            // medicalCodeNumericEditBox
            // 
            this.medicalCodeNumericEditBox.Location = new System.Drawing.Point(185, 48);
            this.medicalCodeNumericEditBox.Name = "medicalCodeNumericEditBox";
            this.medicalCodeNumericEditBox.Size = new System.Drawing.Size(106, 21);
            this.medicalCodeNumericEditBox.TabIndex = 5;
            this.medicalCodeNumericEditBox.Text = "0";
            this.medicalCodeNumericEditBox.Value = 0;
            this.medicalCodeNumericEditBox.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(294, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 189;
            this.label10.Text = "کد نظام پزشکی:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(124, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 191;
            this.label5.Text = "کد پزشک:";
            // 
            // docotruiGroupBox
            // 
            this.docotruiGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.docotruiGroupBox.Controls.Add(this.label5);
            this.docotruiGroupBox.Controls.Add(this.doctorCodeTextBox);
            this.docotruiGroupBox.Controls.Add(this.label10);
            this.docotruiGroupBox.Controls.Add(this.medicalCodeNumericEditBox);
            this.docotruiGroupBox.Controls.Add(this.label3);
            this.docotruiGroupBox.Controls.Add(this.label2);
            this.docotruiGroupBox.Controls.Add(this.lastNameTextBox);
            this.docotruiGroupBox.Controls.Add(this.label1);
            this.docotruiGroupBox.Controls.Add(this.genderPanel);
            this.docotruiGroupBox.Controls.Add(this.label4);
            this.docotruiGroupBox.Controls.Add(this.firstNametextBox);
            this.docotruiGroupBox.Controls.Add(this.specialistComboBox);
            this.docotruiGroupBox.Location = new System.Drawing.Point(12, 320);
            this.docotruiGroupBox.Name = "docotruiGroupBox";
            this.docotruiGroupBox.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.docotruiGroupBox.Size = new System.Drawing.Size(588, 85);
            this.docotruiGroupBox.TabIndex = 2;
            this.docotruiGroupBox.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // DoctorUI
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(612, 468);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.docotruiGroupBox);
            this.Controls.Add(this.doctorGridEX);
            this.Controls.Add(this.insertCancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 500);
            this.MinimumSize = new System.Drawing.Size(620, 500);
            this.Name = "DoctorUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پزشک";
            this.Load += new System.EventHandler(this.DoctorUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoctorUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridEX)).EndInit();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docotruiGroupBox)).EndInit();
            this.docotruiGroupBox.ResumeLayout(false);
            this.docotruiGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.GridEX.GridEX doctorGridEX;
        private Janus.Windows.EditControls.UIButton insertCancelButton;
        private Janus.Windows.EditControls.UIButton updateButton;
        private Janus.Windows.EditControls.UIButton deleteButton;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private Janus.Windows.EditControls.UIGroupBox docotruiGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doctorCodeTextBox;
        private System.Windows.Forms.Label label10;
        private Janus.Windows.GridEX.EditControls.NumericEditBox medicalCodeNumericEditBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.ComboBox specialistComboBox;
    }
}