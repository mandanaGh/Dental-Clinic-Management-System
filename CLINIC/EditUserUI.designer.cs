namespace UserInterface
{
    partial class EditUserUI
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
            Noogen.Validation.ValidationRule validationRule2 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule3 = new Noogen.Validation.ValidationRule();
            Noogen.Validation.ValidationRule validationRule4 = new Noogen.Validation.ValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserUI));
            this.noticeLabel = new System.Windows.Forms.Label();
            this.deleteButton = new Janus.Windows.EditControls.UIButton();
            this.editButton = new Janus.Windows.EditControls.UIButton();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.userInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isLockedCheckBox = new System.Windows.Forms.CheckBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.userInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // noticeLabel
            // 
            this.noticeLabel.Location = new System.Drawing.Point(300, 189);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(137, 23);
            this.noticeLabel.TabIndex = 7;
            this.noticeLabel.Click += new System.EventHandler(this.noticeLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(179, 189);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(94, 189);
            this.editButton.Name = "editButton";
            this.editButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "ویرایش";
            this.editButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(9, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // userInformationGroupBox
            // 
            this.userInformationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.userInformationGroupBox.Controls.Add(this.label2);
            this.userInformationGroupBox.Controls.Add(this.isLockedCheckBox);
            this.userInformationGroupBox.Controls.Add(this.userNameTextBox);
            this.userInformationGroupBox.Controls.Add(this.userNameLabel);
            this.userInformationGroupBox.Controls.Add(this.userIdLabel);
            this.userInformationGroupBox.Controls.Add(this.userIdTextBox);
            this.userInformationGroupBox.Controls.Add(this.newPasswordTextBox);
            this.userInformationGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.userInformationGroupBox.Controls.Add(this.label1);
            this.userInformationGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.userInformationGroupBox.Controls.Add(this.roleComboBox);
            this.userInformationGroupBox.Controls.Add(this.roleLabel);
            this.userInformationGroupBox.Controls.Add(this.descriptionTextBox);
            this.userInformationGroupBox.Controls.Add(this.descriptionLabel);
            this.userInformationGroupBox.Location = new System.Drawing.Point(10, 9);
            this.userInformationGroupBox.Name = "userInformationGroupBox";
            this.userInformationGroupBox.Size = new System.Drawing.Size(424, 164);
            this.userInformationGroupBox.TabIndex = 1;
            this.userInformationGroupBox.TabStop = false;
            this.userInformationGroupBox.Text = "اطلاعات کاربر";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(114, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "وضعیت دسترسی:";
            // 
            // isLockedCheckBox
            // 
            this.isLockedCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.isLockedCheckBox.Location = new System.Drawing.Point(54, 44);
            this.isLockedCheckBox.Name = "isLockedCheckBox";
            this.isLockedCheckBox.Size = new System.Drawing.Size(60, 17);
            this.isLockedCheckBox.TabIndex = 3;
            this.isLockedCheckBox.Text = "مسدود";
            this.isLockedCheckBox.UseVisualStyleBackColor = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(14, 15);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.userNameTextBox.TabIndex = 1;
            validationRule1.ErrorMessage = "داده اجباری";
            validationRule1.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.userNameTextBox, validationRule1);
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Location = new System.Drawing.Point(153, 18);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 47;
            this.userNameLabel.Text = "نام کاربری :";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.userIdLabel.Location = new System.Drawing.Point(372, 19);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(48, 13);
            this.userIdLabel.TabIndex = 46;
            this.userIdLabel.Text = "کد کاربر :";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Enabled = false;
            this.userIdTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userIdTextBox.Location = new System.Drawing.Point(215, 15);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.userIdTextBox.TabIndex = 0;
            this.userIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newPasswordTextBox.Location = new System.Drawing.Point(215, 69);
            this.newPasswordTextBox.MaxLength = 64;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newPasswordTextBox.Size = new System.Drawing.Size(100, 21);
            this.newPasswordTextBox.TabIndex = 4;
            this.newPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            validationRule2.ErrorMessage = "داده اجباری";
            validationRule2.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.newPasswordTextBox, validationRule2);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(132, 72);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.confirmPasswordLabel.TabIndex = 43;
            this.confirmPasswordLabel.Text = "تایید کلمه عبور :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(336, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "کلمه عبور جدید :";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(14, 69);
            this.confirmPasswordTextBox.MaxLength = 64;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(100, 21);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            validationRule3.ErrorMessage = "داده اجباری";
            validationRule3.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.confirmPasswordTextBox, validationRule3);
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(215, 42);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(100, 21);
            this.roleComboBox.TabIndex = 2;
            validationRule4.ErrorMessage = "داده اجباری";
            validationRule4.InitialValue = "[انتخاب کنید]";
            validationRule4.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.roleComboBox, validationRule4);
            // 
            // roleLabel
            // 
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Location = new System.Drawing.Point(360, 45);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(60, 13);
            this.roleLabel.TabIndex = 22;
            this.roleLabel.Text = "نقش کاربر :";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 96);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(301, 53);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(366, 97);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 13);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "توضیحات :";
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // EditUserUI
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(443, 219);
            this.Controls.Add(this.userInformationGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EditUserUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش کاربر";
            this.userInformationGroupBox.ResumeLayout(false);
            this.userInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label noticeLabel;
        private Janus.Windows.EditControls.UIButton  deleteButton;
        private Janus.Windows.EditControls.UIButton  editButton;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private System.Windows.Forms.GroupBox userInformationGroupBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.CheckBox isLockedCheckBox;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}