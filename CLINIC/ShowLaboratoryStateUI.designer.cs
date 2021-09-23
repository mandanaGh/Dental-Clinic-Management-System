namespace UserInterface
{
    partial class ShowLaboratoryStateUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLaboratoryStateUI));
            this.LaboratoryStateDataGridView = new System.Windows.Forms.DataGridView();
            this.laboratoryStateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratoryStateTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newLaboratoryStateButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryStateDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // LaboratoryStateDataGridView
            // 
            this.LaboratoryStateDataGridView.AllowUserToAddRows = false;
            this.LaboratoryStateDataGridView.AllowUserToDeleteRows = false;
            this.LaboratoryStateDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LaboratoryStateDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LaboratoryStateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LaboratoryStateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laboratoryStateId,
            this.laboratoryStateTitle,
            this.description});
            this.LaboratoryStateDataGridView.Location = new System.Drawing.Point(6, 16);
            this.LaboratoryStateDataGridView.Name = "LaboratoryStateDataGridView";
            this.LaboratoryStateDataGridView.ReadOnly = true;
            this.LaboratoryStateDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.LaboratoryStateDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LaboratoryStateDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LaboratoryStateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LaboratoryStateDataGridView.Size = new System.Drawing.Size(445, 320);
            this.LaboratoryStateDataGridView.TabIndex = 3;
            this.LaboratoryStateDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaboratoryStateDataGridView_CellDoubleClick);
            this.LaboratoryStateDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaboratoryStatedataGridView_KeyDown);
            // 
            // laboratoryStateId
            // 
            this.laboratoryStateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.laboratoryStateId.DataPropertyName = "laboratoryStateId";
            this.laboratoryStateId.FillWeight = 150F;
            this.laboratoryStateId.Frozen = true;
            this.laboratoryStateId.HeaderText = "کد وضعیت لابراتوار";
            this.laboratoryStateId.MinimumWidth = 150;
            this.laboratoryStateId.Name = "laboratoryStateId";
            this.laboratoryStateId.ReadOnly = true;
            this.laboratoryStateId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laboratoryStateId.Width = 150;
            // 
            // laboratoryStateTitle
            // 
            this.laboratoryStateTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.laboratoryStateTitle.DataPropertyName = "laboratoryStateTitle";
            this.laboratoryStateTitle.FillWeight = 290F;
            this.laboratoryStateTitle.Frozen = true;
            this.laboratoryStateTitle.HeaderText = "نام وضعیت لابراتوار";
            this.laboratoryStateTitle.MinimumWidth = 290;
            this.laboratoryStateTitle.Name = "laboratoryStateTitle";
            this.laboratoryStateTitle.ReadOnly = true;
            this.laboratoryStateTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laboratoryStateTitle.Width = 290;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newLaboratoryStateButton
            // 
            this.newLaboratoryStateButton.Location = new System.Drawing.Point(7, 358);
            this.newLaboratoryStateButton.Name = "newLaboratoryStateButton";
            this.newLaboratoryStateButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newLaboratoryStateButton.Size = new System.Drawing.Size(130, 23);
            this.newLaboratoryStateButton.TabIndex = 6;
            this.newLaboratoryStateButton.Text = "ثبت وضعیت لابراتوار جدید";
            this.newLaboratoryStateButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newLaboratoryStateButton.Click += new System.EventHandler(this.newLaboratoryStateButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.LaboratoryStateDataGridView);
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
            // ShowLaboratoryStateUI
            // 
            this.AcceptButton = this.newLaboratoryStateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newLaboratoryStateButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowLaboratoryStateUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات وضعیت لابراتوار ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowLaboratoryState_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryStateDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LaboratoryStateDataGridView;
        private Janus.Windows.EditControls.UIButton  newLaboratoryStateButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoryStateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoryStateTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}