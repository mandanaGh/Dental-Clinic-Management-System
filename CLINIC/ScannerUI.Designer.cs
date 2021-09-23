namespace UserInterface
{
    partial class ScannerUI
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
            if (disposing)
            {
                _Twain.Finish();
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerUI));
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.scannerPictureBox = new System.Windows.Forms.PictureBox();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.acceptButton = new Janus.Windows.EditControls.UIButton();
            this.scanButton = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // scannerPictureBox
            // 
            this.scannerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scannerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.scannerPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scannerPictureBox.Name = "scannerPictureBox";
            this.scannerPictureBox.Size = new System.Drawing.Size(504, 450);
            this.scannerPictureBox.TabIndex = 0;
            this.scannerPictureBox.TabStop = false;
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 508);
            this.mainRibbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(528, 22);
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
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 472);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 22);
            this.cancelButton.TabIndex = 151;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(94, 472);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 22);
            this.acceptButton.TabIndex = 150;
            this.acceptButton.Text = "تایید";
            this.acceptButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // scanButton
            // 
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scanButton.Location = new System.Drawing.Point(175, 472);
            this.scanButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 22);
            this.scanButton.TabIndex = 152;
            this.scanButton.Text = "اسکن";
            this.scanButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // ScannerUI
            // 
            this.AcceptButton = this.scanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(528, 530);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.scannerPictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScannerUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اسکن تصویر";
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.PictureBox scannerPictureBox;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private Janus.Windows.EditControls.UIButton cancelButton;
        private Janus.Windows.EditControls.UIButton acceptButton;
        private Janus.Windows.EditControls.UIButton scanButton;
    }
}