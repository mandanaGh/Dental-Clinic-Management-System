namespace UserInterface
{
    partial class ShowRoleUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRoleUI));
            this.RoleDataGridView = new System.Windows.Forms.DataGridView();
            this.roleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newRoleButton = new Janus.Windows.EditControls.UIButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleDataGridView
            // 
            this.RoleDataGridView.AllowUserToAddRows = false;
            this.RoleDataGridView.AllowUserToDeleteRows = false;
            this.RoleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleId,
            this.roleTitle,
            this.description});
            this.RoleDataGridView.Location = new System.Drawing.Point(6, 16);
            this.RoleDataGridView.Name = "RoleDataGridView";
            this.RoleDataGridView.ReadOnly = true;
            this.RoleDataGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.RoleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RoleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleDataGridView.Size = new System.Drawing.Size(445, 320);
            this.RoleDataGridView.TabIndex = 3;
            this.RoleDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleDataGridView_CellDoubleClick);
            this.RoleDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RoledataGridView_KeyDown);
            // 
            // roleId
            // 
            this.roleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.roleId.DataPropertyName = "roleId";
            this.roleId.FillWeight = 150F;
            this.roleId.Frozen = true;
            this.roleId.HeaderText = "کد نقش";
            this.roleId.MinimumWidth = 150;
            this.roleId.Name = "roleId";
            this.roleId.ReadOnly = true;
            this.roleId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roleId.Width = 150;
            // 
            // roleTitle
            // 
            this.roleTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.roleTitle.DataPropertyName = "roleTitle";
            this.roleTitle.FillWeight = 290F;
            this.roleTitle.Frozen = true;
            this.roleTitle.HeaderText = "نام نقش";
            this.roleTitle.MinimumWidth = 290;
            this.roleTitle.Name = "roleTitle";
            this.roleTitle.ReadOnly = true;
            this.roleTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roleTitle.Width = 290;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newRoleButton
            // 
            this.newRoleButton.Location = new System.Drawing.Point(7, 358);
            this.newRoleButton.Name = "newRoleButton";
            this.newRoleButton.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Black;
            this.newRoleButton.Size = new System.Drawing.Size(130, 23);
            this.newRoleButton.TabIndex = 6;
            this.newRoleButton.Text = "ثبت نقش جدید";
            this.newRoleButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newRoleButton.Click += new System.EventHandler(this.newRoleButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.RoleDataGridView);
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
            // ShowRoleUI
            // 
            this.AcceptButton = this.newRoleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(468, 390);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.newRoleButton);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowRoleUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات نقش ها";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowRole_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoleDataGridView;
        private Janus.Windows.EditControls.UIButton  newRoleButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}