namespace UserInterface
{
    partial class ShowServiceTypeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowServiceTypeUI));
            this.ServiceTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.newServiceTypeButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.serviceTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRefrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLaboratory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTypeDataGridView
            // 
            this.ServiceTypeDataGridView.AllowUserToAddRows = false;
            this.ServiceTypeDataGridView.AllowUserToDeleteRows = false;
            this.ServiceTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceTypeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ServiceTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ServiceTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTypeId,
            this.serviceTypeTitle,
            this.session,
            this.nextRefrence,
            this.price,
            this.serviceTypeCode,
            this.description,
            this.isLaboratory});
            this.ServiceTypeDataGridView.Location = new System.Drawing.Point(6, 16);
            this.ServiceTypeDataGridView.Name = "ServiceTypeDataGridView";
            this.ServiceTypeDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceTypeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ServiceTypeDataGridView.RowHeadersWidth = 5;
            this.ServiceTypeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.ServiceTypeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ServiceTypeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServiceTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceTypeDataGridView.Size = new System.Drawing.Size(445, 320);
            this.ServiceTypeDataGridView.TabIndex = 3;
            this.ServiceTypeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceTypeDataGridView_CellDoubleClick);
            this.ServiceTypeDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ServiceTypedataGridView_KeyDown);
            // 
            // newServiceTypeButton
            // 
            this.newServiceTypeButton.Location = new System.Drawing.Point(7, 358);
            this.newServiceTypeButton.Name = "newServiceTypeButton";
            this.newServiceTypeButton.Size = new System.Drawing.Size(130, 23);
            this.newServiceTypeButton.TabIndex = 6;
            this.newServiceTypeButton.Text = "ثبت نوع خدمات جدید";
            this.newServiceTypeButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newServiceTypeButton.Click += new System.EventHandler(this.newServiceTypeButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.ServiceTypeDataGridView);
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
            // serviceTypeId
            // 
            this.serviceTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serviceTypeId.DataPropertyName = "serviceTypeId";
            this.serviceTypeId.FillWeight = 70F;
            this.serviceTypeId.Frozen = true;
            this.serviceTypeId.HeaderText = "کد نوع خدمات";
            this.serviceTypeId.MinimumWidth = 70;
            this.serviceTypeId.Name = "serviceTypeId";
            this.serviceTypeId.ReadOnly = true;
            this.serviceTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceTypeId.Width = 70;
            // 
            // serviceTypeTitle
            // 
            this.serviceTypeTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serviceTypeTitle.DataPropertyName = "serviceTypeTitle";
            this.serviceTypeTitle.FillWeight = 200F;
            this.serviceTypeTitle.Frozen = true;
            this.serviceTypeTitle.HeaderText = "نام نوع خدمات";
            this.serviceTypeTitle.MinimumWidth = 200;
            this.serviceTypeTitle.Name = "serviceTypeTitle";
            this.serviceTypeTitle.ReadOnly = true;
            this.serviceTypeTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceTypeTitle.Width = 200;
            // 
            // session
            // 
            this.session.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.session.DataPropertyName = "session";
            this.session.FillWeight = 80F;
            this.session.Frozen = true;
            this.session.HeaderText = "تعداد جلسات";
            this.session.MinimumWidth = 80;
            this.session.Name = "session";
            this.session.ReadOnly = true;
            this.session.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.session.Width = 80;
            // 
            // nextRefrence
            // 
            this.nextRefrence.DataPropertyName = "nextRefrence";
            this.nextRefrence.HeaderText = "مهلت مراجعه";
            this.nextRefrence.Name = "nextRefrence";
            this.nextRefrence.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "هزينه";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            // 
            // serviceTypeCode
            // 
            this.serviceTypeCode.DataPropertyName = "serviceTypeCode";
            this.serviceTypeCode.HeaderText = "شناسه";
            this.serviceTypeCode.Name = "serviceTypeCode";
            this.serviceTypeCode.ReadOnly = true;
            this.serviceTypeCode.Visible = false;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // isLaboratory
            // 
            this.isLaboratory.HeaderText = "مربوط به لابراتوار";
            this.isLaboratory.Name = "isLaboratory";
            this.isLaboratory.ReadOnly = true;
            this.isLaboratory.Visible = false;
            // 
            // ShowServiceTypeUI
            // 
            this.AcceptButton = this.newServiceTypeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(476, 396);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newServiceTypeButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowServiceTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات نوع خدمات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowServiceType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiceTypeDataGridView;
        private Janus.Windows.EditControls.UIButton  newServiceTypeButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextRefrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn isLaboratory;
    }
}