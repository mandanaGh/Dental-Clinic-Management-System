namespace UserInterface
{
    partial class EditLaboratoryUI
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
            Noogen.Validation.ValidationRule validationRule1 = new Noogen.Validation.ValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLaboratoryUI));
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.telMaskedTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.laboratoryTitleTextBox = new System.Windows.Forms.TextBox();
            this.LaboratoryTitleLabel = new System.Windows.Forms.Label();
            this.LaboratoryIdLabel = new System.Windows.Forms.Label();
            this.laboratoryIdTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.editButton = new Janus.Windows.EditControls.UIButton();
            this.deleteButton = new Janus.Windows.EditControls.UIButton();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telMaskedTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(9, 101);
            this.addressTextBox.MaxLength = 256;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressTextBox.Size = new System.Drawing.Size(309, 53);
            this.addressTextBox.TabIndex = 3;
            this.addressTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Location = new System.Drawing.Point(265, 177);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(159, 23);
            this.noticeLabel.TabIndex = 3;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.telMaskedTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.addressTextBox);
            this.groupBox.Controls.Add(this.addressLabel);
            this.groupBox.Controls.Add(this.laboratoryTitleTextBox);
            this.groupBox.Controls.Add(this.LaboratoryTitleLabel);
            this.groupBox.Controls.Add(this.LaboratoryIdLabel);
            this.groupBox.Controls.Add(this.laboratoryIdTextBox);
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(414, 162);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // telMaskedTextBox
            // 
            this.telMaskedTextBox.Location = new System.Drawing.Point(219, 72);
            this.telMaskedTextBox.Name = "telMaskedTextBox";
            this.telMaskedTextBox.Properties.Mask.BeepOnError = true;
            this.telMaskedTextBox.Properties.Mask.EditMask = "\\d{7,11}";
            this.telMaskedTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.telMaskedTextBox.Properties.Mask.SaveLiteral = false;
            this.telMaskedTextBox.Properties.Mask.ShowPlaceHolders = false;
            this.telMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telMaskedTextBox.TabIndex = 12;
            this.telMaskedTextBox.ToolTip = "عدد وارد شده باید 11-7 رقمی باشد";
            this.telMaskedTextBox.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Error;
            this.telMaskedTextBox.ToolTipTitle = "عدد 11-7 رقمی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "شماره تلفن :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(369, 104);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(39, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "آدرس :";
            // 
            // laboratoryTitleTextBox
            // 
            this.laboratoryTitleTextBox.Location = new System.Drawing.Point(9, 43);
            this.laboratoryTitleTextBox.MaxLength = 64;
            this.laboratoryTitleTextBox.Name = "laboratoryTitleTextBox";
            this.laboratoryTitleTextBox.Size = new System.Drawing.Size(310, 21);
            this.laboratoryTitleTextBox.TabIndex = 1;
            validationRule1.ErrorMessage = "داده اجباری";
            validationRule1.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.laboratoryTitleTextBox, validationRule1);
            this.laboratoryTitleTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // LaboratoryTitleLabel
            // 
            this.LaboratoryTitleLabel.AutoSize = true;
            this.LaboratoryTitleLabel.Location = new System.Drawing.Point(345, 46);
            this.LaboratoryTitleLabel.Name = "LaboratoryTitleLabel";
            this.LaboratoryTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.LaboratoryTitleLabel.TabIndex = 6;
            this.LaboratoryTitleLabel.Text = "نام لابراتوار :";
            // 
            // LaboratoryIdLabel
            // 
            this.LaboratoryIdLabel.AutoSize = true;
            this.LaboratoryIdLabel.Location = new System.Drawing.Point(347, 17);
            this.LaboratoryIdLabel.Name = "LaboratoryIdLabel";
            this.LaboratoryIdLabel.Size = new System.Drawing.Size(61, 13);
            this.LaboratoryIdLabel.TabIndex = 5;
            this.LaboratoryIdLabel.Text = "کد لابراتوار :";
            // 
            // laboratoryIdTextBox
            // 
            this.laboratoryIdTextBox.Enabled = false;
            this.laboratoryIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laboratoryIdTextBox.Location = new System.Drawing.Point(219, 14);
            this.laboratoryIdTextBox.Name = "laboratoryIdTextBox";
            this.laboratoryIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laboratoryIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.laboratoryIdTextBox.TabIndex = 0;
            this.laboratoryIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(9, 177);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(94, 177);
            this.editButton.Name = "editButton";
            this.editButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "ویرایش";
            this.editButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(179, 177);
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
            // EditLaboratoryUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(436, 209);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditLaboratoryUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش لابراتوار";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telMaskedTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox laboratoryTitleTextBox;
        private System.Windows.Forms.Label LaboratoryTitleLabel;
        private System.Windows.Forms.Label LaboratoryIdLabel;
        private System.Windows.Forms.TextBox laboratoryIdTextBox;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private Janus.Windows.EditControls.UIButton  editButton;
        private Janus.Windows.EditControls.UIButton  deleteButton;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit telMaskedTextBox;
    }
}