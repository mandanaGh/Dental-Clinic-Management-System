namespace UserInterface
{
    partial class ShowPhoneBookUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPhoneBookUI));
            Janus.Windows.GridEX.GridEXLayout phoneBookGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.newPhoneBookButton = new Janus.Windows.EditControls.UIButton();
            this.phoneBookGridEX = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridEX)).BeginInit();
            this.SuspendLayout();
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 392);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(861, 23);
            // 
            // 
            // 
            this.mainRibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000;
            this.mainRibbonStatusBar.SuperTipComponent.ImageList = null;
            this.mainRibbonStatusBar.TabIndex = 148;
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
            // newPhoneBookButton
            // 
            this.newPhoneBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newPhoneBookButton.Location = new System.Drawing.Point(12, 355);
            this.newPhoneBookButton.Name = "newPhoneBookButton";
            this.newPhoneBookButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newPhoneBookButton.Size = new System.Drawing.Size(96, 23);
            this.newPhoneBookButton.TabIndex = 1;
            this.newPhoneBookButton.Text = "ثبت تلفن جدید";
            this.newPhoneBookButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newPhoneBookButton.Click += new System.EventHandler(this.newPhoneBookButton_Click);
            // 
            // phoneBookGridEX
            // 
            this.phoneBookGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.phoneBookGridEX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBookGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.phoneBookGridEX.BuiltInTextsData = resources.GetString("phoneBookGridEX.BuiltInTextsData");
            phoneBookGridEX_DesignTimeLayout.LayoutString = resources.GetString("phoneBookGridEX_DesignTimeLayout.LayoutString");
            this.phoneBookGridEX.DesignTimeLayout = phoneBookGridEX_DesignTimeLayout;
            this.phoneBookGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.phoneBookGridEX.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.phoneBookGridEX.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.phoneBookGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.phoneBookGridEX.Location = new System.Drawing.Point(12, 12);
            this.phoneBookGridEX.Name = "phoneBookGridEX";
            this.phoneBookGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.phoneBookGridEX.Size = new System.Drawing.Size(837, 337);
            this.phoneBookGridEX.TabIndex = 149;
            this.phoneBookGridEX.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.phoneBookGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.phoneBookGridEX.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.phoneBookGridEX_RowDoubleClick);
            this.phoneBookGridEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneBookGridEX_KeyDown);
            // 
            // ShowPhoneBookUI
            // 
            this.AcceptButton = this.newPhoneBookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(861, 415);
            this.Controls.Add(this.newPhoneBookButton);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.phoneBookGridEX);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ShowPhoneBookUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه تلفن";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowPhoneBookUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridEX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private Janus.Windows.EditControls.UIButton newPhoneBookButton;
        private Janus.Windows.GridEX.GridEX phoneBookGridEX;

    }
}