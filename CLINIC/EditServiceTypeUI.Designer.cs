namespace UserInterface
{
    partial class EditServiceTypeUI
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
            Noogen.Validation.ValidationRule validationRule3 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule4 = new Noogen.Validation.ValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServiceTypeUI));
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.isLaboratoryCheckBox = new System.Windows.Forms.CheckBox();
            this.priceNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceTypeCodeTextBox = new System.Windows.Forms.TextBox();
            this.nextRefrenceNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.serviceTypeTitleTextBox = new System.Windows.Forms.TextBox();
            this.ServiceTypeTitleLabel = new System.Windows.Forms.Label();
            this.ServiceTypeIdLabel = new System.Windows.Forms.Label();
            this.serviceTypeIdTextBox = new System.Windows.Forms.TextBox();
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
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 114);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(299, 53);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.noticeLabel.Location = new System.Drawing.Point(266, 195);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(135, 23);
            this.noticeLabel.TabIndex = 7;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.isLaboratoryCheckBox);
            this.groupBox.Controls.Add(this.priceNumericEditBox);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.serviceTypeCodeTextBox);
            this.groupBox.Controls.Add(this.nextRefrenceNumericEditBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.sessionNumericEditBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.descriptionTextBox);
            this.groupBox.Controls.Add(this.descriptionLabel);
            this.groupBox.Controls.Add(this.serviceTypeTitleTextBox);
            this.groupBox.Controls.Add(this.ServiceTypeTitleLabel);
            this.groupBox.Controls.Add(this.ServiceTypeIdLabel);
            this.groupBox.Controls.Add(this.serviceTypeIdTextBox);
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 178);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // isLaboratoryCheckBox
            // 
            this.isLaboratoryCheckBox.AutoSize = true;
            this.isLaboratoryCheckBox.Location = new System.Drawing.Point(2, 65);
            this.isLaboratoryCheckBox.Name = "isLaboratoryCheckBox";
            this.isLaboratoryCheckBox.Size = new System.Drawing.Size(100, 17);
            this.isLaboratoryCheckBox.TabIndex = 16;
            this.isLaboratoryCheckBox.Text = "مربوط به لابراتوار";
            this.isLaboratoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceNumericEditBox
            // 
            this.priceNumericEditBox.Location = new System.Drawing.Point(217, 88);
            this.priceNumericEditBox.Name = "priceNumericEditBox";
            this.priceNumericEditBox.Size = new System.Drawing.Size(85, 21);
            this.priceNumericEditBox.TabIndex = 3;
            this.priceNumericEditBox.Text = "0";
            this.priceNumericEditBox.Value = ((long)(0));
            this.priceNumericEditBox.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "هزينه :";
            // 
            // serviceTypeCodeTextBox
            // 
            this.serviceTypeCodeTextBox.Location = new System.Drawing.Point(217, 63);
            this.serviceTypeCodeTextBox.Name = "serviceTypeCodeTextBox";
            this.serviceTypeCodeTextBox.Size = new System.Drawing.Size(85, 21);
            this.serviceTypeCodeTextBox.TabIndex = 2;
            validationRule3.ErrorMessage = "داده اجباری";
            validationRule3.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.serviceTypeCodeTextBox, validationRule3);
            // 
            // nextRefrenceNumericEditBox
            // 
            this.nextRefrenceNumericEditBox.Location = new System.Drawing.Point(105, 63);
            this.nextRefrenceNumericEditBox.Name = "nextRefrenceNumericEditBox";
            this.nextRefrenceNumericEditBox.Size = new System.Drawing.Size(35, 21);
            this.nextRefrenceNumericEditBox.TabIndex = 5;
            this.nextRefrenceNumericEditBox.Text = "0";
            this.nextRefrenceNumericEditBox.Value = ((short)(0));
            this.nextRefrenceNumericEditBox.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "کد شناسایی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "مهلت مراجعه :";
            // 
            // sessionNumericEditBox
            // 
            this.sessionNumericEditBox.Location = new System.Drawing.Point(105, 90);
            this.sessionNumericEditBox.Name = "sessionNumericEditBox";
            this.sessionNumericEditBox.Size = new System.Drawing.Size(35, 21);
            this.sessionNumericEditBox.TabIndex = 4;
            this.sessionNumericEditBox.Text = "0";
            this.sessionNumericEditBox.Value = ((short)(0));
            this.sessionNumericEditBox.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "تعداد جلسات :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(334, 117);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "توضیحات :";
            // 
            // serviceTypeTitleTextBox
            // 
            this.serviceTypeTitleTextBox.Location = new System.Drawing.Point(3, 38);
            this.serviceTypeTitleTextBox.MaxLength = 128;
            this.serviceTypeTitleTextBox.Name = "serviceTypeTitleTextBox";
            this.serviceTypeTitleTextBox.Size = new System.Drawing.Size(299, 21);
            this.serviceTypeTitleTextBox.TabIndex = 1;
            validationRule4.ErrorMessage = "داده اجباری";
            validationRule4.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.serviceTypeTitleTextBox, validationRule4);
            this.serviceTypeTitleTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // ServiceTypeTitleLabel
            // 
            this.ServiceTypeTitleLabel.AutoSize = true;
            this.ServiceTypeTitleLabel.Location = new System.Drawing.Point(314, 42);
            this.ServiceTypeTitleLabel.Name = "ServiceTypeTitleLabel";
            this.ServiceTypeTitleLabel.Size = new System.Drawing.Size(74, 13);
            this.ServiceTypeTitleLabel.TabIndex = 6;
            this.ServiceTypeTitleLabel.Text = "عنوان خدمات :";
            // 
            // ServiceTypeIdLabel
            // 
            this.ServiceTypeIdLabel.AutoSize = true;
            this.ServiceTypeIdLabel.Location = new System.Drawing.Point(329, 17);
            this.ServiceTypeIdLabel.Name = "ServiceTypeIdLabel";
            this.ServiceTypeIdLabel.Size = new System.Drawing.Size(59, 13);
            this.ServiceTypeIdLabel.TabIndex = 5;
            this.ServiceTypeIdLabel.Text = "کد خدمات :";
            // 
            // serviceTypeIdTextBox
            // 
            this.serviceTypeIdTextBox.AcceptsReturn = true;
            this.serviceTypeIdTextBox.Enabled = false;
            this.serviceTypeIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serviceTypeIdTextBox.Location = new System.Drawing.Point(217, 13);
            this.serviceTypeIdTextBox.Name = "serviceTypeIdTextBox";
            this.serviceTypeIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serviceTypeIdTextBox.Size = new System.Drawing.Size(85, 21);
            this.serviceTypeIdTextBox.TabIndex = 0;
            this.serviceTypeIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(10, 195);
            this.cancelButton.Name = "cancelButton";
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
            this.editButton.Location = new System.Drawing.Point(95, 195);
            this.editButton.Name = "editButton";
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
            this.deleteButton.Location = new System.Drawing.Point(180, 195);
            this.deleteButton.Name = "deleteButton";
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
            // EditServiceTypeUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(413, 227);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditServiceTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش خدمات";
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
        private System.Windows.Forms.TextBox serviceTypeTitleTextBox;
        private System.Windows.Forms.Label ServiceTypeTitleLabel;
        private System.Windows.Forms.Label ServiceTypeIdLabel;
        private System.Windows.Forms.TextBox serviceTypeIdTextBox;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private Janus.Windows.EditControls.UIButton  editButton;
        private Janus.Windows.EditControls.UIButton  deleteButton;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.NumericEditBox sessionNumericEditBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceTypeCodeTextBox;
        private Janus.Windows.GridEX.EditControls.NumericEditBox nextRefrenceNumericEditBox;
        private Janus.Windows.GridEX.EditControls.NumericEditBox priceNumericEditBox;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private System.Windows.Forms.CheckBox isLaboratoryCheckBox;
    }
}