namespace UserInterface
{
    partial class ShowToothColorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowToothColorUI));
            this.ToothColorDataGridView = new System.Windows.Forms.DataGridView();
            this.toothColorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toothColorTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newToothColorButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ToothColorDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToothColorDataGridView
            // 
            this.ToothColorDataGridView.AllowUserToAddRows = false;
            this.ToothColorDataGridView.AllowUserToDeleteRows = false;
            this.ToothColorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToothColorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ToothColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ToothColorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toothColorId,
            this.toothColorTitle,
            this.description});
            this.ToothColorDataGridView.Location = new System.Drawing.Point(6, 16);
            this.ToothColorDataGridView.Name = "ToothColorDataGridView";
            this.ToothColorDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ToothColorDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ToothColorDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.ToothColorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ToothColorDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ToothColorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ToothColorDataGridView.Size = new System.Drawing.Size(445, 320);
            this.ToothColorDataGridView.TabIndex = 3;
            this.ToothColorDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToothColorDataGridView_CellDoubleClick);
            this.ToothColorDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToothColordataGridView_KeyDown);
            // 
            // toothColorId
            // 
            this.toothColorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.toothColorId.DataPropertyName = "toothColorId";
            this.toothColorId.FillWeight = 150F;
            this.toothColorId.Frozen = true;
            this.toothColorId.HeaderText = "کد رنگ دندان";
            this.toothColorId.MinimumWidth = 150;
            this.toothColorId.Name = "toothColorId";
            this.toothColorId.ReadOnly = true;
            this.toothColorId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toothColorId.Width = 150;
            // 
            // toothColorTitle
            // 
            this.toothColorTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.toothColorTitle.DataPropertyName = "toothColorTitle";
            this.toothColorTitle.FillWeight = 290F;
            this.toothColorTitle.Frozen = true;
            this.toothColorTitle.HeaderText = "نام رنگ دندان";
            this.toothColorTitle.MinimumWidth = 290;
            this.toothColorTitle.Name = "toothColorTitle";
            this.toothColorTitle.ReadOnly = true;
            this.toothColorTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toothColorTitle.Width = 290;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newToothColorButton
            // 
            this.newToothColorButton.Location = new System.Drawing.Point(7, 358);
            this.newToothColorButton.Name = "newToothColorButton";
            this.newToothColorButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newToothColorButton.Size = new System.Drawing.Size(130, 23);
            this.newToothColorButton.TabIndex = 6;
            this.newToothColorButton.Text = "ثبت رنگ دندان جدید";
            this.newToothColorButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newToothColorButton.Click += new System.EventHandler(this.newToothColorButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.ToothColorDataGridView);
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
            // ShowToothColorUI
            // 
            this.AcceptButton = this.newToothColorButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 391);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newToothColorButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowToothColorUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات رنگ دندان ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowToothColor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ToothColorDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ToothColorDataGridView;
        private Janus.Windows.EditControls.UIButton  newToothColorButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn toothColorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn toothColorTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}