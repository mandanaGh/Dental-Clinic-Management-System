namespace UserInterface
{
    partial class ShowSpecialistUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSpecialistUI));
            this.SpecialistDataGridView = new System.Windows.Forms.DataGridView();
            this.specialistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialistTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newSpecialistButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpecialistDataGridView
            // 
            this.SpecialistDataGridView.AllowUserToAddRows = false;
            this.SpecialistDataGridView.AllowUserToDeleteRows = false;
            this.SpecialistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SpecialistDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SpecialistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SpecialistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialistId,
            this.specialistTitle,
            this.description});
            this.SpecialistDataGridView.Location = new System.Drawing.Point(6, 16);
            this.SpecialistDataGridView.Name = "SpecialistDataGridView";
            this.SpecialistDataGridView.ReadOnly = true;
            this.SpecialistDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.SpecialistDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SpecialistDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SpecialistDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecialistDataGridView.Size = new System.Drawing.Size(445, 320);
            this.SpecialistDataGridView.TabIndex = 3;
            this.SpecialistDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecialistDataGridView_CellDoubleClick);
            this.SpecialistDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpecialistdataGridView_KeyDown);
            // 
            // specialistId
            // 
            this.specialistId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.specialistId.DataPropertyName = "specialistId";
            this.specialistId.FillWeight = 150F;
            this.specialistId.Frozen = true;
            this.specialistId.HeaderText = "کد تخصص";
            this.specialistId.MinimumWidth = 150;
            this.specialistId.Name = "specialistId";
            this.specialistId.ReadOnly = true;
            this.specialistId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialistId.Width = 150;
            // 
            // specialistTitle
            // 
            this.specialistTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.specialistTitle.DataPropertyName = "specialistTitle";
            this.specialistTitle.FillWeight = 290F;
            this.specialistTitle.Frozen = true;
            this.specialistTitle.HeaderText = "نام تخصص";
            this.specialistTitle.MinimumWidth = 290;
            this.specialistTitle.Name = "specialistTitle";
            this.specialistTitle.ReadOnly = true;
            this.specialistTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialistTitle.Width = 290;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newSpecialistButton
            // 
            this.newSpecialistButton.Location = new System.Drawing.Point(7, 358);
            this.newSpecialistButton.Name = "newSpecialistButton";
            this.newSpecialistButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newSpecialistButton.Size = new System.Drawing.Size(130, 23);
            this.newSpecialistButton.TabIndex = 6;
            this.newSpecialistButton.Text = "ثبت تخصص جدید";
            this.newSpecialistButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newSpecialistButton.Click += new System.EventHandler(this.newSpecialistButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.SpecialistDataGridView);
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
            // ShowSpecialistUI
            // 
            this.AcceptButton = this.newSpecialistButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newSpecialistButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowSpecialistUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات تخصص ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowSpecialist_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SpecialistDataGridView;
        private Janus.Windows.EditControls.UIButton  newSpecialistButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialistId;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialistTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}