namespace UserInterface
{
    partial class EquipmentLOV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentLOV));
            this.EquipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new Janus.Windows.EditControls.UIButton();
            this.acceptButton = new Janus.Windows.EditControls.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.mainRibbonStatusBar = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.noticeLabel = new Janus.Windows.Ribbon.LabelCommand();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentDataGridView
            // 
            this.EquipmentDataGridView.AllowUserToAddRows = false;
            this.EquipmentDataGridView.AllowUserToDeleteRows = false;
            this.EquipmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EquipmentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EquipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentId,
            this.equipmentTitle,
            this.count,
            this.expiredDate,
            this.persianExpiredDate,
            this.description});
            this.EquipmentDataGridView.Location = new System.Drawing.Point(10, 10);
            this.EquipmentDataGridView.Name = "EquipmentDataGridView";
            this.EquipmentDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EquipmentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EquipmentDataGridView.RowHeadersWidth = 5;
            this.EquipmentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.EquipmentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.EquipmentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EquipmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EquipmentDataGridView.Size = new System.Drawing.Size(462, 297);
            this.EquipmentDataGridView.TabIndex = 4;
            this.EquipmentDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentDataGridView_CellDoubleClick);
            // 
            // equipmentId
            // 
            this.equipmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.equipmentId.DataPropertyName = "equipmentId";
            this.equipmentId.FillWeight = 70F;
            this.equipmentId.Frozen = true;
            this.equipmentId.HeaderText = "کد تجهيزات";
            this.equipmentId.MinimumWidth = 70;
            this.equipmentId.Name = "equipmentId";
            this.equipmentId.ReadOnly = true;
            this.equipmentId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.equipmentId.Width = 70;
            // 
            // equipmentTitle
            // 
            this.equipmentTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.equipmentTitle.DataPropertyName = "equipmentTitle";
            this.equipmentTitle.FillWeight = 200F;
            this.equipmentTitle.Frozen = true;
            this.equipmentTitle.HeaderText = "نام تجهيزات";
            this.equipmentTitle.MinimumWidth = 200;
            this.equipmentTitle.Name = "equipmentTitle";
            this.equipmentTitle.ReadOnly = true;
            this.equipmentTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.equipmentTitle.Width = 200;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.count.DataPropertyName = "count";
            this.count.FillWeight = 80F;
            this.count.Frozen = true;
            this.count.HeaderText = "تعداد";
            this.count.MinimumWidth = 80;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count.Width = 80;
            // 
            // expiredDate
            // 
            this.expiredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.expiredDate.DataPropertyName = "expiredDate";
            this.expiredDate.Frozen = true;
            this.expiredDate.HeaderText = "تاريخ انقضاء ميلادي";
            this.expiredDate.Name = "expiredDate";
            this.expiredDate.ReadOnly = true;
            this.expiredDate.Visible = false;
            // 
            // persianExpiredDate
            // 
            this.persianExpiredDate.DataPropertyName = "persianExpiredDate";
            this.persianExpiredDate.HeaderText = "تاريخ انقضاء";
            this.persianExpiredDate.Name = "persianExpiredDate";
            this.persianExpiredDate.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.cancelButton.Location = new System.Drawing.Point(10, 342);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 57;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.acceptButton.Location = new System.Drawing.Point(91, 342);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 58;
            this.acceptButton.Text = "تاييد";
            this.acceptButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(438, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "عنوان:";
            // 
            // equipmentTitleTextBox
            // 
            this.equipmentTitleTextBox.Location = new System.Drawing.Point(10, 313);
            this.equipmentTitleTextBox.Name = "equipmentTitleTextBox";
            this.equipmentTitleTextBox.ReadOnly = true;
            this.equipmentTitleTextBox.Size = new System.Drawing.Size(405, 21);
            this.equipmentTitleTextBox.TabIndex = 61;
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
            this.mainRibbonStatusBar.Location = new System.Drawing.Point(0, 373);
            this.mainRibbonStatusBar.Name = "mainRibbonStatusBar";
            this.mainRibbonStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver;
            this.mainRibbonStatusBar.Office2007CustomColor = System.Drawing.Color.Empty;
            this.mainRibbonStatusBar.ShowToolTips = false;
            this.mainRibbonStatusBar.Size = new System.Drawing.Size(484, 23);
            // 
            // 
            // 
            this.mainRibbonStatusBar.SuperTipComponent.AutoPopDelay = 2000;
            this.mainRibbonStatusBar.SuperTipComponent.ImageList = null;
            this.mainRibbonStatusBar.TabIndex = 151;
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
            // EquipmentLOV
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(484, 396);
            this.Controls.Add(this.mainRibbonStatusBar);
            this.Controls.Add(this.equipmentTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.EquipmentDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EquipmentLOV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ليست تجهيزات";
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EquipmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.EditControls.UIButton  cancelButton;
        private Janus.Windows.EditControls.UIButton acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equipmentTitleTextBox;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private Janus.Windows.Ribbon.RibbonStatusBar mainRibbonStatusBar;
        private Janus.Windows.Ribbon.LabelCommand noticeLabel;
    }
}