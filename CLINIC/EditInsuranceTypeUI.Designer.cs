namespace UserInterface
{
    partial class EditInsuranceTypeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInsuranceTypeUI));
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.percentNumericEditBox = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.insuranceTypeTitleTextBox = new System.Windows.Forms.TextBox();
            this.InsuranceTypeTitleLabel = new System.Windows.Forms.Label();
            this.InsuranceTypeIdLabel = new System.Windows.Forms.Label();
            this.insuranceTypeIdTextBox = new System.Windows.Forms.TextBox();
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
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 86);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(312, 53);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Location = new System.Drawing.Point(267, 167);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(137, 23);
            this.noticeLabel.TabIndex = 4;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.percentNumericEditBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.descriptionTextBox);
            this.groupBox.Controls.Add(this.descriptionLabel);
            this.groupBox.Controls.Add(this.insuranceTypeTitleTextBox);
            this.groupBox.Controls.Add(this.InsuranceTypeTitleLabel);
            this.groupBox.Controls.Add(this.InsuranceTypeIdLabel);
            this.groupBox.Controls.Add(this.insuranceTypeIdTextBox);
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 148);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // percentNumericEditBox
            // 
            this.percentNumericEditBox.Location = new System.Drawing.Point(218, 62);
            this.percentNumericEditBox.MaxLength = 6;
            this.percentNumericEditBox.Name = "percentNumericEditBox";
            this.percentNumericEditBox.Size = new System.Drawing.Size(100, 21);
            this.percentNumericEditBox.TabIndex = 2;
            this.percentNumericEditBox.Text = "0.00";
            this.percentNumericEditBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(332, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "سهم بيمه:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(337, 89);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "توضیحات :";
            // 
            // insuranceTypeTitleTextBox
            // 
            this.insuranceTypeTitleTextBox.Location = new System.Drawing.Point(8, 38);
            this.insuranceTypeTitleTextBox.MaxLength = 64;
            this.insuranceTypeTitleTextBox.Name = "insuranceTypeTitleTextBox";
            this.insuranceTypeTitleTextBox.Size = new System.Drawing.Size(310, 21);
            this.insuranceTypeTitleTextBox.TabIndex = 1;
            validationRule2.ErrorMessage = "داده اجباری";
            validationRule2.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.insuranceTypeTitleTextBox, validationRule2);
            this.insuranceTypeTitleTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // InsuranceTypeTitleLabel
            // 
            this.InsuranceTypeTitleLabel.AutoSize = true;
            this.InsuranceTypeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsuranceTypeTitleLabel.Location = new System.Drawing.Point(341, 41);
            this.InsuranceTypeTitleLabel.Name = "InsuranceTypeTitleLabel";
            this.InsuranceTypeTitleLabel.Size = new System.Drawing.Size(50, 13);
            this.InsuranceTypeTitleLabel.TabIndex = 6;
            this.InsuranceTypeTitleLabel.Text = "نام بيمه :";
            // 
            // InsuranceTypeIdLabel
            // 
            this.InsuranceTypeIdLabel.AutoSize = true;
            this.InsuranceTypeIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsuranceTypeIdLabel.Location = new System.Drawing.Point(343, 17);
            this.InsuranceTypeIdLabel.Name = "InsuranceTypeIdLabel";
            this.InsuranceTypeIdLabel.Size = new System.Drawing.Size(48, 13);
            this.InsuranceTypeIdLabel.TabIndex = 5;
            this.InsuranceTypeIdLabel.Text = "کد بيمه :";
            // 
            // insuranceTypeIdTextBox
            // 
            this.insuranceTypeIdTextBox.Enabled = false;
            this.insuranceTypeIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insuranceTypeIdTextBox.Location = new System.Drawing.Point(218, 14);
            this.insuranceTypeIdTextBox.Name = "insuranceTypeIdTextBox";
            this.insuranceTypeIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.insuranceTypeIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.insuranceTypeIdTextBox.TabIndex = 0;
            this.insuranceTypeIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(11, 167);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(96, 167);
            this.editButton.Name = "editButton";
            this.editButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "ویرایش";
            this.editButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(181, 167);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
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
            // EditInsuranceTypeUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(413, 196);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditInsuranceTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش بيمه";
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
        private System.Windows.Forms.TextBox insuranceTypeTitleTextBox;
        private System.Windows.Forms.Label InsuranceTypeTitleLabel;
        private System.Windows.Forms.Label InsuranceTypeIdLabel;
        private System.Windows.Forms.TextBox insuranceTypeIdTextBox;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private Janus.Windows.EditControls.UIButton  editButton;
        private Janus.Windows.EditControls.UIButton  deleteButton;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.NumericEditBox percentNumericEditBox;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
    }
}