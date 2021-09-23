namespace UserInterface
{
    partial class EditLaboratoryStateUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLaboratoryStateUI));
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.laboratoryStateTitleTextBox = new System.Windows.Forms.TextBox();
            this.LaboratoryStateTitleLabel = new System.Windows.Forms.Label();
            this.LaboratoryStateIdLabel = new System.Windows.Forms.Label();
            this.laboratoryStateIdTextBox = new System.Windows.Forms.TextBox();
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
            this.descriptionTextBox.Location = new System.Drawing.Point(7, 78);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(312, 53);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // noticeLabel
            // 
            this.noticeLabel.Location = new System.Drawing.Point(267, 167);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(137, 23);
            this.noticeLabel.TabIndex = 3;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.descriptionTextBox);
            this.groupBox.Controls.Add(this.descriptionLabel);
            this.groupBox.Controls.Add(this.laboratoryStateTitleTextBox);
            this.groupBox.Controls.Add(this.LaboratoryStateTitleLabel);
            this.groupBox.Controls.Add(this.LaboratoryStateIdLabel);
            this.groupBox.Controls.Add(this.laboratoryStateIdTextBox);
            this.groupBox.Location = new System.Drawing.Point(10, 9);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(439, 148);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(379, 81);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "توضیحات :";
            // 
            // laboratoryStateTitleTextBox
            // 
            this.laboratoryStateTitleTextBox.Location = new System.Drawing.Point(9, 46);
            this.laboratoryStateTitleTextBox.MaxLength = 64;
            this.laboratoryStateTitleTextBox.Name = "laboratoryStateTitleTextBox";
            this.laboratoryStateTitleTextBox.Size = new System.Drawing.Size(310, 21);
            this.laboratoryStateTitleTextBox.TabIndex = 1;
            validationRule1.ErrorMessage = "داده اجباری";
            validationRule1.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.laboratoryStateTitleTextBox, validationRule1);
            this.laboratoryStateTitleTextBox.Enter += new System.EventHandler(this.setFarsiKeyboard_Enter);
            // 
            // LaboratoryStateTitleLabel
            // 
            this.LaboratoryStateTitleLabel.AutoSize = true;
            this.LaboratoryStateTitleLabel.Location = new System.Drawing.Point(333, 49);
            this.LaboratoryStateTitleLabel.Name = "LaboratoryStateTitleLabel";
            this.LaboratoryStateTitleLabel.Size = new System.Drawing.Size(100, 13);
            this.LaboratoryStateTitleLabel.TabIndex = 6;
            this.LaboratoryStateTitleLabel.Text = "نام وضعیت لابراتوار :";
            // 
            // LaboratoryStateIdLabel
            // 
            this.LaboratoryStateIdLabel.AutoSize = true;
            this.LaboratoryStateIdLabel.Location = new System.Drawing.Point(335, 17);
            this.LaboratoryStateIdLabel.Name = "LaboratoryStateIdLabel";
            this.LaboratoryStateIdLabel.Size = new System.Drawing.Size(98, 13);
            this.LaboratoryStateIdLabel.TabIndex = 5;
            this.LaboratoryStateIdLabel.Text = "کد وضعیت لابراتوار :";
            // 
            // laboratoryStateIdTextBox
            // 
            this.laboratoryStateIdTextBox.Enabled = false;
            this.laboratoryStateIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laboratoryStateIdTextBox.Location = new System.Drawing.Point(219, 14);
            this.laboratoryStateIdTextBox.Name = "laboratoryStateIdTextBox";
            this.laboratoryStateIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laboratoryStateIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.laboratoryStateIdTextBox.TabIndex = 0;
            this.laboratoryStateIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(11, 167);
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
            this.editButton.Location = new System.Drawing.Point(96, 167);
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
            // EditLaboratoryStateUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(461, 196);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditLaboratoryStateUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش وضعیت لابراتوار";
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
        private System.Windows.Forms.TextBox laboratoryStateTitleTextBox;
        private System.Windows.Forms.Label LaboratoryStateTitleLabel;
        private System.Windows.Forms.Label LaboratoryStateIdLabel;
        private System.Windows.Forms.TextBox laboratoryStateIdTextBox;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private Janus.Windows.EditControls.UIButton  editButton;
        private Janus.Windows.EditControls.UIButton  deleteButton;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
    }
}