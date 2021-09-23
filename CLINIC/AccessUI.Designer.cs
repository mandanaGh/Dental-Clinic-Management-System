namespace UserInterface
{
    partial class AccessUI
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
            Janus.Windows.GridEX.GridEXLayout roleGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessUI));
            Janus.Windows.GridEX.GridEXLayout securityGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            this.roleGridEX = new Janus.Windows.GridEX.GridEX();
            this.label1 = new System.Windows.Forms.Label();
            this.pageGroupBox = new Janus.Windows.EditControls.UIGroupBox();
            this.securityGridEX = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupBox)).BeginInit();
            this.pageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityGridEX)).BeginInit();
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
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 361);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(500, 23);
            // 
            // 
            // 
            this.mainRibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000;
            this.mainRibbonStatusBar.SuperTipComponent.ImageList = null;
            this.mainRibbonStatusBar.TabIndex = 150;
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
            // roleGridEX
            // 
            this.roleGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.roleGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            roleGridEX_DesignTimeLayout.LayoutString = resources.GetString("roleGridEX_DesignTimeLayout.LayoutString");
            this.roleGridEX.DesignTimeLayout = roleGridEX_DesignTimeLayout;
            this.roleGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.roleGridEX.GroupByBoxVisible = false;
            this.roleGridEX.Location = new System.Drawing.Point(16, 25);
            this.roleGridEX.Name = "roleGridEX";
            this.roleGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.roleGridEX.Size = new System.Drawing.Size(468, 101);
            this.roleGridEX.TabIndex = 1;
            this.roleGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.roleGridEX.SelectionChanged += new System.EventHandler(this.roleGridEX_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "نقش های موجود در سیستم:";
            // 
            // pageGroupBox
            // 
            this.pageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pageGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.pageGroupBox.Controls.Add(this.securityGridEX);
            this.pageGroupBox.Location = new System.Drawing.Point(16, 132);
            this.pageGroupBox.Name = "pageGroupBox";
            this.pageGroupBox.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.pageGroupBox.Size = new System.Drawing.Size(468, 215);
            this.pageGroupBox.TabIndex = 160;
            this.pageGroupBox.Text = "نوع دسترسی به صفحات";
            this.pageGroupBox.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // securityGridEX
            // 
            this.securityGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.securityGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            securityGridEX_DesignTimeLayout.LayoutString = resources.GetString("securityGridEX_DesignTimeLayout.LayoutString");
            this.securityGridEX.DesignTimeLayout = securityGridEX_DesignTimeLayout;
            this.securityGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.securityGridEX.GroupByBoxVisible = false;
            this.securityGridEX.Location = new System.Drawing.Point(12, 25);
            this.securityGridEX.Name = "securityGridEX";
            this.securityGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.securityGridEX.Size = new System.Drawing.Size(442, 171);
            this.securityGridEX.TabIndex = 2;
            this.securityGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.securityGridEX.EditingCell += new Janus.Windows.GridEX.EditingCellEventHandler(this.securityGridEX_EditingCell);
            this.securityGridEX.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.securityGridEX_CellValueChanged);
            this.securityGridEX.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.securityGridEX_CellUpdated);
            // 
            // AccessUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(500, 384);
            this.Controls.Add(this.pageGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleGridEX);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 416);
            this.MinimumSize = new System.Drawing.Size(508, 416);
            this.Name = "AccessUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دسترسی";
            this.Load += new System.EventHandler(this.AccessUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccessUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroupBox)).EndInit();
            this.pageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.securityGridEX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.GridEX roleGridEX;
        private Janus.Windows.EditControls.UIGroupBox pageGroupBox;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
        private Janus.Windows.GridEX.GridEX securityGridEX;
    }
}