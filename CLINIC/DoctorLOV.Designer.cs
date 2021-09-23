namespace UserInterface
{
    partial class DoctorLOV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorLOV));
            Janus.Windows.GridEX.GridEXLayout doctorGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.doctorGridEX = new Janus.Windows.GridEX.GridEX();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptButton = new Janus.Windows.EditControls.UIButton();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridEX)).BeginInit();
            this.SuspendLayout();
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // doctorGridEX
            // 
            this.doctorGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.doctorGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.doctorGridEX.BuiltInTextsData = resources.GetString("doctorGridEX.BuiltInTextsData");
            doctorGridEX_DesignTimeLayout.LayoutString = resources.GetString("doctorGridEX_DesignTimeLayout.LayoutString");
            this.doctorGridEX.DesignTimeLayout = doctorGridEX_DesignTimeLayout;
            this.doctorGridEX.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorGridEX.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.doctorGridEX.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.doctorGridEX.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.doctorGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.doctorGridEX.GroupByBoxVisible = false;
            this.doctorGridEX.Location = new System.Drawing.Point(0, 0);
            this.doctorGridEX.Name = "doctorGridEX";
            this.doctorGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver;
            this.doctorGridEX.Size = new System.Drawing.Size(513, 209);
            this.doctorGridEX.TabIndex = 1;
            this.doctorGridEX.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.doctorGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.doctorGridEX.SelectionChanged += new System.EventHandler(this.doctorGridEX_SelectionChanged);
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(8, 215);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.ReadOnly = true;
            this.doctorNameTextBox.Size = new System.Drawing.Size(375, 21);
            this.doctorNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(416, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "خانم / آقای دکتر:";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.acceptButton.Location = new System.Drawing.Point(89, 242);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
            this.acceptButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "تاييد";
            this.acceptButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.cancelButton.Location = new System.Drawing.Point(8, 242);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 271);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(513, 23);
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
            // 
            // DoctorLOV
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(513, 294);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.doctorGridEX);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 326);
            this.MinimumSize = new System.Drawing.Size(521, 326);
            this.Name = "DoctorLOV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پزشک";
            this.Load += new System.EventHandler(this.DoctorLOV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoctorLOV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGridEX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.GridEX.GridEX doctorGridEX;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIButton acceptButton;
        private Janus.Windows.EditControls.UIButton cancelButton;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;

    }
}