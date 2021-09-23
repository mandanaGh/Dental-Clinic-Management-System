namespace UserInterface
{
    partial class ShowDiseasesUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDiseasesUI));
            this.DiseasesDataGridView = new System.Windows.Forms.DataGridView();
            this.diseasesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseasesTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDangerous = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDiseasesButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiseasesDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // DiseasesDataGridView
            // 
            this.DiseasesDataGridView.AllowUserToAddRows = false;
            this.DiseasesDataGridView.AllowUserToDeleteRows = false;
            this.DiseasesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiseasesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DiseasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DiseasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseasesId,
            this.diseasesTitle,
            this.isDangerous,
            this.description});
            this.DiseasesDataGridView.Location = new System.Drawing.Point(6, 16);
            this.DiseasesDataGridView.Name = "DiseasesDataGridView";
            this.DiseasesDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiseasesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DiseasesDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.DiseasesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DiseasesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DiseasesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiseasesDataGridView.Size = new System.Drawing.Size(445, 320);
            this.DiseasesDataGridView.TabIndex = 0;
            this.DiseasesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiseasesDataGridView_CellDoubleClick);
            this.DiseasesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiseasesdataGridView_KeyDown);
            // 
            // diseasesId
            // 
            this.diseasesId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.diseasesId.DataPropertyName = "diseasesId";
            this.diseasesId.FillWeight = 150F;
            this.diseasesId.Frozen = true;
            this.diseasesId.HeaderText = "کد بیماری";
            this.diseasesId.MinimumWidth = 150;
            this.diseasesId.Name = "diseasesId";
            this.diseasesId.ReadOnly = true;
            this.diseasesId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diseasesId.Width = 150;
            // 
            // diseasesTitle
            // 
            this.diseasesTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.diseasesTitle.DataPropertyName = "diseasesTitle";
            this.diseasesTitle.FillWeight = 200F;
            this.diseasesTitle.Frozen = true;
            this.diseasesTitle.HeaderText = "نام بیماری";
            this.diseasesTitle.MinimumWidth = 200;
            this.diseasesTitle.Name = "diseasesTitle";
            this.diseasesTitle.ReadOnly = true;
            this.diseasesTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diseasesTitle.Width = 200;
            // 
            // isDangerous
            // 
            this.isDangerous.DataPropertyName = "isDangerous";
            this.isDangerous.FalseValue = "isDangerous";
            this.isDangerous.FillWeight = 90F;
            this.isDangerous.HeaderText = "خطرناک";
            this.isDangerous.Name = "isDangerous";
            this.isDangerous.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newDiseasesButton
            // 
            this.newDiseasesButton.Location = new System.Drawing.Point(7, 358);
            this.newDiseasesButton.Name = "newDiseasesButton";
            this.newDiseasesButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newDiseasesButton.Size = new System.Drawing.Size(130, 23);
            this.newDiseasesButton.TabIndex = 1;
            this.newDiseasesButton.Text = "ثبت بیماری جدید";
            this.newDiseasesButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newDiseasesButton.Click += new System.EventHandler(this.newDiseasesButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.DiseasesDataGridView);
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
            this.messageTitleLabel.TabIndex = 1;
            this.messageTitleLabel.Click += new System.EventHandler(this.messageTitleLabel_Click);
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // ShowDiseasesUI
            // 
            this.AcceptButton = this.newDiseasesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newDiseasesButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowDiseasesUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بیماری ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowDiseases_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DiseasesDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DiseasesDataGridView;
        private Janus.Windows.EditControls.UIButton  newDiseasesButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseasesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseasesTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDangerous;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}