namespace UserInterface
{
    partial class ShowAppointmentTypeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAppointmentTypeUI));
            this.AppointmentTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newAppointmentTypeButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypeDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentTypeDataGridView
            // 
            this.AppointmentTypeDataGridView.AllowUserToAddRows = false;
            this.AppointmentTypeDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentTypeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AppointmentTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentTypeId,
            this.appointmentTypeTitle,
            this.description});
            this.AppointmentTypeDataGridView.Location = new System.Drawing.Point(6, 16);
            this.AppointmentTypeDataGridView.Name = "AppointmentTypeDataGridView";
            this.AppointmentTypeDataGridView.ReadOnly = true;
            this.AppointmentTypeDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.AppointmentTypeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentTypeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AppointmentTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentTypeDataGridView.Size = new System.Drawing.Size(445, 320);
            this.AppointmentTypeDataGridView.TabIndex = 0;
            this.AppointmentTypeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentTypeDataGridView_CellDoubleClick);
            this.AppointmentTypeDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AppointmentTypedataGridView_KeyDown);
            // 
            // appointmentTypeId
            // 
            this.appointmentTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.appointmentTypeId.DataPropertyName = "appointmentTypeId";
            this.appointmentTypeId.FillWeight = 150F;
            this.appointmentTypeId.Frozen = true;
            this.appointmentTypeId.HeaderText = "کد جلسه";
            this.appointmentTypeId.MinimumWidth = 150;
            this.appointmentTypeId.Name = "appointmentTypeId";
            this.appointmentTypeId.ReadOnly = true;
            this.appointmentTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentTypeId.Width = 150;
            // 
            // appointmentTypeTitle
            // 
            this.appointmentTypeTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.appointmentTypeTitle.DataPropertyName = "appointmentTypeTitle";
            this.appointmentTypeTitle.FillWeight = 290F;
            this.appointmentTypeTitle.Frozen = true;
            this.appointmentTypeTitle.HeaderText = "نام جلسه";
            this.appointmentTypeTitle.MinimumWidth = 290;
            this.appointmentTypeTitle.Name = "appointmentTypeTitle";
            this.appointmentTypeTitle.ReadOnly = true;
            this.appointmentTypeTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentTypeTitle.Width = 290;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newAppointmentTypeButton
            // 
            this.newAppointmentTypeButton.Location = new System.Drawing.Point(7, 358);
            this.newAppointmentTypeButton.Name = "newAppointmentTypeButton";
            this.newAppointmentTypeButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newAppointmentTypeButton.Size = new System.Drawing.Size(130, 23);
            this.newAppointmentTypeButton.TabIndex = 1;
            this.newAppointmentTypeButton.Text = "ثبت نوع جلسه جدید";
            this.newAppointmentTypeButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newAppointmentTypeButton.Click += new System.EventHandler(this.newAppointmentTypeButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.AppointmentTypeDataGridView);
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
            // ShowAppointmentTypeUI
            // 
            this.AcceptButton = this.newAppointmentTypeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newAppointmentTypeButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowAppointmentTypeUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات جلسات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowAppointmentType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypeDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentTypeDataGridView;
        private Janus.Windows.EditControls.UIButton  newAppointmentTypeButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}