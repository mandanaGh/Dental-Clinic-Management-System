namespace UserInterface
{
    partial class EditEquipmentUI
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
            Noogen.Validation.ValidationRule validationRule2 = new Noogen.Validation.ValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEquipmentUI));
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.expiredPersianDateTimePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.expiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.equipmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.EquipmentTitleLabel = new System.Windows.Forms.Label();
            this.EquipmentIdLabel = new System.Windows.Forms.Label();
            this.equipmentIdTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.editButton = new Janus.Windows.EditControls.UIButton();
            this.deleteButton = new Janus.Windows.EditControls.UIButton();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 95);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(299, 53);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.noticeLabel.Location = new System.Drawing.Point(266, 179);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(135, 23);
            this.noticeLabel.TabIndex = 6;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.expiredPersianDateTimePicker);
            this.groupBox.Controls.Add(this.expiredDateTimePicker);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.countNumericEditBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.descriptionTextBox);
            this.groupBox.Controls.Add(this.descriptionLabel);
            this.groupBox.Controls.Add(this.equipmentTitleTextBox);
            this.groupBox.Controls.Add(this.EquipmentTitleLabel);
            this.groupBox.Controls.Add(this.EquipmentIdLabel);
            this.groupBox.Controls.Add(this.equipmentIdTextBox);
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 162);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // expiredPersianDateTimePicker
            // 
            this.expiredPersianDateTimePicker.Location = new System.Drawing.Point(204, 68);
            this.expiredPersianDateTimePicker.Name = "expiredPersianDateTimePicker";
            this.expiredPersianDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expiredPersianDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.expiredPersianDateTimePicker.TabIndex = 13;
            this.expiredPersianDateTimePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.expiredPersianDateTimePicker.SelectedDateTimeChanged += new System.EventHandler(this.expiredPersianDateTimePicker_SelectedDateTimeChanged);
            // 
            // expiredDateTimePicker
            // 
            this.expiredDateTimePicker.Location = new System.Drawing.Point(6, 68);
            this.expiredDateTimePicker.Name = "expiredDateTimePicker";
            this.expiredDateTimePicker.Size = new System.Drawing.Size(92, 21);
            this.expiredDateTimePicker.TabIndex = 4;
            this.expiredDateTimePicker.ValueChanged += new System.EventHandler(this.expiredDateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(100, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "تاریخ انقضا میلادی:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(319, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "تاريخ انقضاء :";
            // 
            // countNumericEditBox
            // 
            this.countNumericEditBox.Location = new System.Drawing.Point(7, 13);
            this.countNumericEditBox.MaxLength = 9;
            this.countNumericEditBox.Name = "countNumericEditBox";
            this.countNumericEditBox.Size = new System.Drawing.Size(91, 21);
            this.countNumericEditBox.TabIndex = 1;
            this.countNumericEditBox.Text = "0";
            this.countNumericEditBox.Value = 0;
            this.countNumericEditBox.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(161, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "تعداد :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(332, 98);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "توضیحات :";
            // 
            // equipmentTitleTextBox
            // 
            this.equipmentTitleTextBox.Location = new System.Drawing.Point(6, 41);
            this.equipmentTitleTextBox.MaxLength = 128;
            this.equipmentTitleTextBox.Name = "equipmentTitleTextBox";
            this.equipmentTitleTextBox.Size = new System.Drawing.Size(299, 21);
            this.equipmentTitleTextBox.TabIndex = 2;
            validationRule2.ErrorMessage = "داده اجباری";
            validationRule2.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.equipmentTitleTextBox, validationRule2);
            this.equipmentTitleTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // EquipmentTitleLabel
            // 
            this.EquipmentTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.EquipmentTitleLabel.Location = new System.Drawing.Point(319, 44);
            this.EquipmentTitleLabel.Name = "EquipmentTitleLabel";
            this.EquipmentTitleLabel.Size = new System.Drawing.Size(67, 13);
            this.EquipmentTitleLabel.TabIndex = 6;
            this.EquipmentTitleLabel.Text = "نام تجهيزات :";
            // 
            // EquipmentIdLabel
            // 
            this.EquipmentIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.EquipmentIdLabel.Location = new System.Drawing.Point(321, 17);
            this.EquipmentIdLabel.Name = "EquipmentIdLabel";
            this.EquipmentIdLabel.Size = new System.Drawing.Size(65, 13);
            this.EquipmentIdLabel.TabIndex = 5;
            this.EquipmentIdLabel.Text = "کد تجهيزات :";
            // 
            // equipmentIdTextBox
            // 
            this.equipmentIdTextBox.AcceptsReturn = true;
            this.equipmentIdTextBox.Enabled = false;
            this.equipmentIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equipmentIdTextBox.Location = new System.Drawing.Point(205, 13);
            this.equipmentIdTextBox.Name = "equipmentIdTextBox";
            this.equipmentIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equipmentIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.equipmentIdTextBox.TabIndex = 0;
            this.equipmentIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(10, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.cancelButton.Size = new System.Drawing.Size(78, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(95, 179);
            this.editButton.Name = "editButton";
            this.editButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.editButton.Size = new System.Drawing.Size(78, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "ویرایش";
            this.editButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(180, 179);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.deleteButton.Size = new System.Drawing.Size(78, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // EditEquipmentUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(413, 211);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditEquipmentUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش تجهيزات";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox equipmentTitleTextBox;
        private System.Windows.Forms.Label EquipmentTitleLabel;
        private System.Windows.Forms.Label EquipmentIdLabel;
        private System.Windows.Forms.TextBox equipmentIdTextBox;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private Janus.Windows.EditControls.UIButton  editButton;
        private Janus.Windows.EditControls.UIButton  deleteButton;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.NumericEditBox countNumericEditBox;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker expiredDateTimePicker;
        private FarsiLibrary.Win.Controls.FADatePicker expiredPersianDateTimePicker;
    }
}