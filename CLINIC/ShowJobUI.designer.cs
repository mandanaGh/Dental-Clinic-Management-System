namespace UserInterface
{
    partial class ShowJobUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowJobUI));
            this.JobDataGridView = new System.Windows.Forms.DataGridView();
            this.jabId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newJobButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.JobDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // JobDataGridView
            // 
            this.JobDataGridView.AllowUserToAddRows = false;
            this.JobDataGridView.AllowUserToDeleteRows = false;
            this.JobDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JobDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.JobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.JobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jabId,
            this.jabTitle,
            this.description});
            this.JobDataGridView.Location = new System.Drawing.Point(6, 16);
            this.JobDataGridView.Name = "JobDataGridView";
            this.JobDataGridView.ReadOnly = true;
            this.JobDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.JobDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.JobDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JobDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JobDataGridView.Size = new System.Drawing.Size(445, 320);
            this.JobDataGridView.TabIndex = 3;
            this.JobDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobDataGridView_CellDoubleClick);
            this.JobDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JobdataGridView_KeyDown);
            // 
            // jabId
            // 
            this.jabId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jabId.DataPropertyName = "jabId";
            this.jabId.FillWeight = 150F;
            this.jabId.Frozen = true;
            this.jabId.HeaderText = "کد شغل";
            this.jabId.MinimumWidth = 150;
            this.jabId.Name = "jabId";
            this.jabId.ReadOnly = true;
            this.jabId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jabId.Width = 150;
            // 
            // jabTitle
            // 
            this.jabTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jabTitle.DataPropertyName = "jabTitle";
            this.jabTitle.FillWeight = 290F;
            this.jabTitle.Frozen = true;
            this.jabTitle.HeaderText = "نام شغل";
            this.jabTitle.MinimumWidth = 290;
            this.jabTitle.Name = "jabTitle";
            this.jabTitle.ReadOnly = true;
            this.jabTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jabTitle.Width = 290;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newJobButton
            // 
            this.newJobButton.Location = new System.Drawing.Point(7, 358);
            this.newJobButton.Name = "newJobButton";
            this.newJobButton.Size = new System.Drawing.Size(130, 23);
            this.newJobButton.TabIndex = 6;
            this.newJobButton.Text = "ثبت شغل جدید";
            this.newJobButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newJobButton.Click += new System.EventHandler(this.newJobButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.JobDataGridView);
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
            // ShowJobUI
            // 
            this.AcceptButton = this.newJobButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newJobButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowJobUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات شغل ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowJob_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.JobDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JobDataGridView;
        private Janus.Windows.EditControls.UIButton  newJobButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabId;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}