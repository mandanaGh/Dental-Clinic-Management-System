namespace UserInterface
{
    partial class ShowUserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserUI));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newUserButton = new Janus.Windows.EditControls.UIButton();
            this.messageTitleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.usersDataGridView);
            this.groupBox.Location = new System.Drawing.Point(10, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(346, 349);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.roleId,
            this.roleTitle,
            this.password,
            this.isLocked,
            this.description});
            this.usersDataGridView.Location = new System.Drawing.Point(6, 16);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.usersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(333, 322);
            this.usersDataGridView.TabIndex = 3;
            this.usersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellDoubleClick);
            this.usersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usersDataGridView_KeyDown);
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "شماره کاربر";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.FillWeight = 194.9239F;
            this.userName.HeaderText = "نام کاربری";
            this.userName.MinimumWidth = 120;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // roleId
            // 
            this.roleId.DataPropertyName = "roleId";
            this.roleId.HeaderText = "کد نقش";
            this.roleId.Name = "roleId";
            this.roleId.ReadOnly = true;
            this.roleId.Visible = false;
            // 
            // roleTitle
            // 
            this.roleTitle.DataPropertyName = "roleTitle";
            this.roleTitle.FillWeight = 125F;
            this.roleTitle.HeaderText = "عنوان نقش";
            this.roleTitle.MinimumWidth = 125;
            this.roleTitle.Name = "roleTitle";
            this.roleTitle.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "کلمه عبور";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // isLocked
            // 
            this.isLocked.DataPropertyName = "isLocked";
            this.isLocked.HeaderText = "مسدود";
            this.isLocked.Name = "isLocked";
            this.isLocked.ReadOnly = true;
            this.isLocked.Visible = false;
            // 
            // description
            // 
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(10, 357);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(130, 23);
            this.newUserButton.TabIndex = 8;
            this.newUserButton.Text = "ثبت کاربر جدید";
            this.newUserButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // messageTitleLabel
            // 
            this.messageTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.messageTitleLabel.Location = new System.Drawing.Point(146, 357);
            this.messageTitleLabel.Name = "messageTitleLabel";
            this.messageTitleLabel.Size = new System.Drawing.Size(210, 23);
            this.messageTitleLabel.TabIndex = 10;
            this.messageTitleLabel.Click += new System.EventHandler(this.messageTitleLabel_Click);
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // ShowUserUI
            // 
            this.AcceptButton = this.newUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(363, 384);
            this.Controls.Add(this.messageTitleLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.newUserButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ShowUserUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات کاربران";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowUsers_KeyDown);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private Janus.Windows.EditControls.UIButton  newUserButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Label messageTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn isLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
    }
}