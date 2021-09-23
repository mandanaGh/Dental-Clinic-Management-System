namespace UserInterface
{
    partial class BackupUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupUI));
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backupPathTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.acceptButton = new Janus.Windows.EditControls.UIButton();
            this.requieredValidationProvider = new Noogen.Validation.ValidationProvider(this.components);
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.browserButton = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(357, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان فایل:";
            // 
            // backupPathTextBox
            // 
            this.backupPathTextBox.Enabled = false;
            this.backupPathTextBox.Location = new System.Drawing.Point(45, 11);
            this.backupPathTextBox.Name = "backupPathTextBox";
            this.backupPathTextBox.Size = new System.Drawing.Size(284, 21);
            this.backupPathTextBox.TabIndex = 0;
            validationRule3.ErrorMessage = "داده اجباری";
            validationRule3.IsRequired = true;
            this.requieredValidationProvider.SetValidationRule(this.backupPathTextBox, validationRule3);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(10, 39);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(92, 39);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;this.acceptButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 42;
            this.acceptButton.Text = "تایید";
            this.acceptButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // requieredValidationProvider
            // 
            this.requieredValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.requieredValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("requieredValidationProvider.Icon")));
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 70);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(422, 23);
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
            // browserButton
            // 
            this.browserButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.browserButton.Location = new System.Drawing.Point(10, 10);
            this.browserButton.Name = "browserButton";
            this.browserButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.browserButton.Size = new System.Drawing.Size(29, 23);
            this.browserButton.TabIndex = 150;
            this.browserButton.Text = "...";
            this.browserButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // BackupUI
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(422, 93);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.backupPathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 125);
            this.MinimumSize = new System.Drawing.Size(430, 125);
            this.Name = "BackupUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تهیه نسخه پشتیبان";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackupUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox backupPathTextBox;
        private Janus.Windows.EditControls.UIButton cancelButton;
        private Janus.Windows.EditControls.UIButton acceptButton;
        private Noogen.Validation.ValidationProvider requieredValidationProvider;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private Janus.Windows.EditControls.UIButton browserButton;
    }
}