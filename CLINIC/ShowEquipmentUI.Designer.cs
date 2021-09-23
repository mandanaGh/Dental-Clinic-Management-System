namespace UserInterface
{
    partial class ShowEquipmentUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEquipmentUI));
            this.EquipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newEquipmentButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentDataGridView
            // 
            this.EquipmentDataGridView.AllowUserToAddRows = false;
            this.EquipmentDataGridView.AllowUserToDeleteRows = false;
            this.EquipmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EquipmentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EquipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EquipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentId,
            this.equipmentTitle,
            this.count,
            this.expiredDate,
            this.persianExpiredDate,
            this.description});
            this.EquipmentDataGridView.Location = new System.Drawing.Point(6, 16);
            this.EquipmentDataGridView.Name = "EquipmentDataGridView";
            this.EquipmentDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            this.EquipmentDataGridView.Size = new System.Drawing.Size(445, 320);
            this.EquipmentDataGridView.TabIndex = 3;
            this.EquipmentDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentDataGridView_CellDoubleClick);
            this.EquipmentDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EquipmentdataGridView_KeyDown);
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
            // newEquipmentButton
            // 
            this.newEquipmentButton.Location = new System.Drawing.Point(7, 358);
            this.newEquipmentButton.Name = "newEquipmentButton";
            this.newEquipmentButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newEquipmentButton.Size = new System.Drawing.Size(130, 23);
            this.newEquipmentButton.TabIndex = 6;
            this.newEquipmentButton.Text = "ثبت تجهيزات جدید";
            this.newEquipmentButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newEquipmentButton.Click += new System.EventHandler(this.newEquipmentButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.EquipmentDataGridView);
            this.groupBox.Location = new System.Drawing.Point(7, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(457, 349);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            // 
            // messageTitleLabel
            // 
            this.messageTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.messageTitleLabel.Location = new System.Drawing.Point(143, 358);
            this.messageTitleLabel.Name = "messageTitleLabel";
            this.messageTitleLabel.Size = new System.Drawing.Size(321, 23);
            this.messageTitleLabel.TabIndex = 9;
            this.messageTitleLabel.Click += new System.EventHandler(this.messageTitleLabel_Click);
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // ShowEquipmentUI
            // 
            this.AcceptButton = this.newEquipmentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 387);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newEquipmentButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowEquipmentUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات تجهيزات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowEquipment_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EquipmentDataGridView;
        private Janus.Windows.EditControls.UIButton  newEquipmentButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}