namespace UserInterface
{
    partial class ChangePasswordUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUI));
            this.userNameShowLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.conFirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.changePasswordButton = new Janus.Windows.EditControls.UIButton();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameShowLabel
            // 
            this.userNameShowLabel.AutoSize = true;
            this.userNameShowLabel.Location = new System.Drawing.Point(14, 25);
            this.userNameShowLabel.Name = "userNameShowLabel";
            this.userNameShowLabel.Size = new System.Drawing.Size(0, 13);
            this.userNameShowLabel.TabIndex = 18;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(10, 70);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newPasswordTextBox.Size = new System.Drawing.Size(150, 21);
            this.newPasswordTextBox.TabIndex = 1;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // conFirmNewPasswordTextBox
            // 
            this.conFirmNewPasswordTextBox.Location = new System.Drawing.Point(10, 97);
            this.conFirmNewPasswordTextBox.Name = "conFirmNewPasswordTextBox";
            this.conFirmNewPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.conFirmNewPasswordTextBox.Size = new System.Drawing.Size(150, 21);
            this.conFirmNewPasswordTextBox.TabIndex = 2;
            this.conFirmNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmNewPasswordLabel
            // 
            this.confirmNewPasswordLabel.AutoSize = true;
            this.confirmNewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmNewPasswordLabel.Location = new System.Drawing.Point(198, 101);
            this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            this.confirmNewPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.confirmNewPasswordLabel.TabIndex = 15;
            this.confirmNewPasswordLabel.Text = "تایید کلمه عبور:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordLabel.Location = new System.Drawing.Point(195, 75);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.newPasswordLabel.TabIndex = 14;
            this.newPasswordLabel.Text = "کلمه عبور جدید:";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(10, 43);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oldPasswordTextBox.Size = new System.Drawing.Size(150, 21);
            this.oldPasswordTextBox.TabIndex = 0;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(193, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "کلمه عبور قبلی:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Location = new System.Drawing.Point(221, 23);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 13);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "کد کاربری:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(11, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(93, 168);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.changePasswordButton.Size = new System.Drawing.Size(75, 23);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "تایید";
            this.changePasswordButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // noticeLabel
            // 
            this.noticeLabel.BackColor = System.Drawing.Color.Transparent;
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Location = new System.Drawing.Point(13, 143);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(279, 22);
            this.noticeLabel.TabIndex = 3;
            this.noticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userNameShowLabel);
            this.groupBox2.Controls.Add(this.oldPasswordTextBox);
            this.groupBox2.Controls.Add(this.newPasswordTextBox);
            this.groupBox2.Controls.Add(this.userNameLabel);
            this.groupBox2.Controls.Add(this.conFirmNewPasswordTextBox);
            this.groupBox2.Controls.Add(this.passwordLabel);
            this.groupBox2.Controls.Add(this.confirmNewPasswordLabel);
            this.groupBox2.Controls.Add(this.newPasswordLabel);
            this.groupBox2.Location = new System.Drawing.Point(11, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 128);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تغییر کلمه عبور";
            // 
            // ChangePasswordUI
            // 
            this.AcceptButton = this.changePasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(303, 199);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر کلمه عبور ";
            this.Load += new System.EventHandler(this.ChangePasswordUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePasswordUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameShowLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox conFirmNewPasswordTextBox;
        private System.Windows.Forms.Label confirmNewPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private Janus.Windows.EditControls.UIButton cancelButton;
        private Janus.Windows.EditControls.UIButton changePasswordButton;
        private System.Windows.Forms.Label noticeLabel;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}