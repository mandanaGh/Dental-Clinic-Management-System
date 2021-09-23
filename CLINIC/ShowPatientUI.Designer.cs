namespace UserInterface
{
    partial class ShowPatientUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPatientUI));
            Janus.Windows.GridEX.GridEXLayout patientGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.newPatientButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patientGridEX = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridEX)).BeginInit();
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
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 419);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(892, 23);
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
            // newPatientButton
            // 
            this.newPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newPatientButton.Location = new System.Drawing.Point(6, 384);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newPatientButton.Size = new System.Drawing.Size(130, 23);
            this.newPatientButton.TabIndex = 1;
            this.newPatientButton.Text = "ثبت بیمار جدید";
            this.newPatientButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.patientGridEX);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(880, 371);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            // 
            // patientGridEX
            // 
            this.patientGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.patientGridEX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.patientGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.patientGridEX.BuiltInTextsData = resources.GetString("patientGridEX.BuiltInTextsData");
            patientGridEX_DesignTimeLayout.LayoutString = resources.GetString("patientGridEX_DesignTimeLayout.LayoutString");
            this.patientGridEX.DesignTimeLayout = patientGridEX_DesignTimeLayout;
            this.patientGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.patientGridEX.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.patientGridEX.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.patientGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.patientGridEX.Location = new System.Drawing.Point(10, 24);
            this.patientGridEX.Name = "patientGridEX";
            this.patientGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.patientGridEX.Size = new System.Drawing.Size(860, 337);
            this.patientGridEX.TabIndex = 0;
            this.patientGridEX.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.patientGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.patientGridEX.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.patientGridEX_RowDoubleClick);
            this.patientGridEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patientGridEX_KeyDown);
            // 
            // ShowPatientUI
            // 
            this.AcceptButton = this.newPatientButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(892, 442);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "ShowPatientUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بیماران";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowPatientUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientGridEX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private Janus.Windows.EditControls.UIButton newPatientButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private Janus.Windows.GridEX.GridEX patientGridEX;

    }
}