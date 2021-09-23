namespace UserInterface
{
    partial class ShowInsuranceTypeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInsuranceTypeUI));
            this.InsuranceTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.insuranceTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newInsuranceTypeButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceTypeDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsuranceTypeDataGridView
            // 
            this.InsuranceTypeDataGridView.AllowUserToAddRows = false;
            this.InsuranceTypeDataGridView.AllowUserToDeleteRows = false;
            this.InsuranceTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InsuranceTypeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.InsuranceTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InsuranceTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insuranceTypeId,
            this.insuranceTypeTitle,
            this.description,
            this.percent});
            this.InsuranceTypeDataGridView.Location = new System.Drawing.Point(6, 16);
            this.InsuranceTypeDataGridView.Name = "InsuranceTypeDataGridView";
            this.InsuranceTypeDataGridView.ReadOnly = true;
            this.InsuranceTypeDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.InsuranceTypeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InsuranceTypeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InsuranceTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InsuranceTypeDataGridView.Size = new System.Drawing.Size(445, 320);
            this.InsuranceTypeDataGridView.TabIndex = 3;
            this.InsuranceTypeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsuranceTypeDataGridView_CellDoubleClick);
            this.InsuranceTypeDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsuranceTypedataGridView_KeyDown);
            // 
            // insuranceTypeId
            // 
            this.insuranceTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.insuranceTypeId.DataPropertyName = "insuranceTypeId";
            this.insuranceTypeId.Frozen = true;
            this.insuranceTypeId.HeaderText = "كد بيمه";
            this.insuranceTypeId.Name = "insuranceTypeId";
            this.insuranceTypeId.ReadOnly = true;
            this.insuranceTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // insuranceTypeTitle
            // 
            this.insuranceTypeTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.insuranceTypeTitle.DataPropertyName = "insuranceTypeTitle";
            this.insuranceTypeTitle.FillWeight = 250F;
            this.insuranceTypeTitle.Frozen = true;
            this.insuranceTypeTitle.HeaderText = "عنوان بيمه";
            this.insuranceTypeTitle.Name = "insuranceTypeTitle";
            this.insuranceTypeTitle.ReadOnly = true;
            this.insuranceTypeTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.insuranceTypeTitle.Width = 250;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضيحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.description.Visible = false;
            // 
            // percent
            // 
            this.percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.percent.FillWeight = 90F;
            this.percent.Frozen = true;
            this.percent.HeaderText = "سهم بيمه";
            this.percent.Name = "percent";
            this.percent.ReadOnly = true;
            this.percent.Width = 90;
            // 
            // newInsuranceTypeButton
            // 
            this.newInsuranceTypeButton.Location = new System.Drawing.Point(7, 358);
            this.newInsuranceTypeButton.Name = "newInsuranceTypeButton";
            this.newInsuranceTypeButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newInsuranceTypeButton.Size = new System.Drawing.Size(130, 23);
            this.newInsuranceTypeButton.TabIndex = 6;
            this.newInsuranceTypeButton.Text = "ثبت بيمه جدید";
            this.newInsuranceTypeButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newInsuranceTypeButton.Click += new System.EventHandler(this.newInsuranceTypeButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.InsuranceTypeDataGridView);
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
            // ShowInsuranceTypeUI
            // 
            this.AcceptButton = this.newInsuranceTypeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 389);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newInsuranceTypeButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowInsuranceTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بيمه ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowInsuranceType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceTypeDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InsuranceTypeDataGridView;
        private Janus.Windows.EditControls.UIButton  newInsuranceTypeButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}