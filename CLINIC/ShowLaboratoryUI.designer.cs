namespace UserInterface
{
    partial class ShowLaboratoryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLaboratoryUI));
            this.LaboratoryDataGridView = new System.Windows.Forms.DataGridView();
            this.newLaboratoryButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.laboratoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratoryTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // LaboratoryDataGridView
            // 
            this.LaboratoryDataGridView.AllowUserToAddRows = false;
            this.LaboratoryDataGridView.AllowUserToDeleteRows = false;
            this.LaboratoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LaboratoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LaboratoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LaboratoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laboratoryId,
            this.laboratoryTitle,
            this.tel,
            this.address});
            this.LaboratoryDataGridView.Location = new System.Drawing.Point(6, 16);
            this.LaboratoryDataGridView.Name = "LaboratoryDataGridView";
            this.LaboratoryDataGridView.ReadOnly = true;
            this.LaboratoryDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.LaboratoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LaboratoryDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LaboratoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LaboratoryDataGridView.Size = new System.Drawing.Size(445, 320);
            this.LaboratoryDataGridView.TabIndex = 3;
            this.LaboratoryDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaboratoryDataGridView_CellDoubleClick);
            this.LaboratoryDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaboratorydataGridView_KeyDown);
            // 
            // newLaboratoryButton
            // 
            this.newLaboratoryButton.Location = new System.Drawing.Point(7, 358);
            this.newLaboratoryButton.Name = "newLaboratoryButton";
            this.newLaboratoryButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newLaboratoryButton.Size = new System.Drawing.Size(130, 23);
            this.newLaboratoryButton.TabIndex = 6;
            this.newLaboratoryButton.Text = "ثبت لابراتوار جدید";
            this.newLaboratoryButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newLaboratoryButton.Click += new System.EventHandler(this.newLaboratoryButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.LaboratoryDataGridView);
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
            // laboratoryId
            // 
            this.laboratoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.laboratoryId.DataPropertyName = "laboratoryId";
            this.laboratoryId.FillWeight = 150F;
            this.laboratoryId.Frozen = true;
            this.laboratoryId.HeaderText = "کد لابراتوار";
            this.laboratoryId.MinimumWidth = 150;
            this.laboratoryId.Name = "laboratoryId";
            this.laboratoryId.ReadOnly = true;
            this.laboratoryId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laboratoryId.Width = 150;
            // 
            // laboratoryTitle
            // 
            this.laboratoryTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.laboratoryTitle.DataPropertyName = "laboratoryTitle";
            this.laboratoryTitle.FillWeight = 200F;
            this.laboratoryTitle.Frozen = true;
            this.laboratoryTitle.HeaderText = "نام لابراتوار";
            this.laboratoryTitle.MinimumWidth = 200;
            this.laboratoryTitle.Name = "laboratoryTitle";
            this.laboratoryTitle.ReadOnly = true;
            this.laboratoryTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laboratoryTitle.Width = 200;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.FillWeight = 90F;
            this.tel.HeaderText = "شماره تلفن";
            this.tel.MinimumWidth = 90;
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "آدرس";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // ShowLaboratoryUI
            // 
            this.AcceptButton = this.newLaboratoryButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newLaboratoryButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowLaboratoryUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات لابراتوار ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowLaboratory_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LaboratoryDataGridView;
        private Janus.Windows.EditControls.UIButton  newLaboratoryButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoryTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}