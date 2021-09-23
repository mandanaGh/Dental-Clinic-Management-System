﻿namespace UserInterface
{
    partial class CallAlarmUI
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
            Janus.Windows.GridEX.GridEXLayout alarmGridEX_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallAlarmUI));
            this.alarmGridEX = new Janus.Windows.GridEX.GridEX();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            ((System.ComponentModel.ISupportInitialize)(this.alarmGridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // alarmGridEX
            // 
            this.alarmGridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.alarmGridEX.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            alarmGridEX_DesignTimeLayout.LayoutString = resources.GetString("alarmGridEX_DesignTimeLayout.LayoutString");
            this.alarmGridEX.DesignTimeLayout = alarmGridEX_DesignTimeLayout;
            this.alarmGridEX.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.alarmGridEX.GroupByBoxVisible = false;
            this.alarmGridEX.Location = new System.Drawing.Point(12, 37);
            this.alarmGridEX.Name = "alarmGridEX";
            this.alarmGridEX.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Black;
            this.alarmGridEX.Size = new System.Drawing.Size(424, 247);
            this.alarmGridEX.TabIndex = 0;
            this.alarmGridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.alarmGridEX.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.alarmGridEX_RowDoubleClick);
            this.alarmGridEX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alarmGridEX_KeyDown);
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
            this.label1.Location = new System.Drawing.Point(104, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "لیست بیمارانی که نوبت ویزیت ایشان رسیده است:";
            // 
            // mainRibbonStatusBar
            // 
            this.mainRibbonStatusBar.ImageSize = new System.Drawing.Size(16, 16);
            this.mainRibbonStatusBar.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.noticeLabel});
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 293);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(448, 23);
            // 
            // 
            // 
            this.mainRibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000;
            this.mainRibbonStatusBar.SuperTipComponent.ImageList = null;
            this.mainRibbonStatusBar.TabIndex = 159;
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
            // CallAlarmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(448, 316);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarmGridEX);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 348);
            this.MinimumSize = new System.Drawing.Size(456, 348);
            this.Name = "CallAlarmUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "هشدار تماس";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CallAlarmUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.alarmGridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEX alarmGridEX;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
    }
}