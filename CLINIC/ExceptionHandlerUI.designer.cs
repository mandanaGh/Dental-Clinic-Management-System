namespace UserInterface
{
    partial class ExceptionHandlerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionHandlerUI));
            this.helpNoteLabel = new System.Windows.Forms.Label();
            this.HelpNoteGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.OriginalMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.originalMessageTextBox = new System.Windows.Forms.TextBox();
            this.TitleGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.officeFormAdorner1 = new Janus.Windows.Ribbon.OfficeFormAdorner(this.components);
            this.HelpNoteGroupBox.SuspendLayout();
            this.DescriptionGroupBox.SuspendLayout();
            this.OriginalMessageGroupBox.SuspendLayout();
            this.TitleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).BeginInit();
            this.SuspendLayout();
            // 
            // helpNoteLabel
            // 
            this.helpNoteLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.helpNoteLabel.Location = new System.Drawing.Point(12, 17);
            this.helpNoteLabel.Name = "helpNoteLabel";
            this.helpNoteLabel.Size = new System.Drawing.Size(440, 64);
            this.helpNoteLabel.TabIndex = 0;
            // 
            // HelpNoteGroupBox
            // 
            this.HelpNoteGroupBox.Controls.Add(this.helpNoteLabel);
            this.HelpNoteGroupBox.Location = new System.Drawing.Point(10, 157);
            this.HelpNoteGroupBox.Name = "HelpNoteGroupBox";
            this.HelpNoteGroupBox.Size = new System.Drawing.Size(455, 84);
            this.HelpNoteGroupBox.TabIndex = 6;
            this.HelpNoteGroupBox.TabStop = false;
            this.HelpNoteGroupBox.Text = "راهنمایی رفع اشکال";
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Controls.Add(this.descriptionLabel);
            this.DescriptionGroupBox.Location = new System.Drawing.Point(10, 73);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(455, 79);
            this.DescriptionGroupBox.TabIndex = 5;
            this.DescriptionGroupBox.TabStop = false;
            this.DescriptionGroupBox.Text = "شرح خطا";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 17);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(440, 59);
            this.descriptionLabel.TabIndex = 1;
            // 
            // OriginalMessageGroupBox
            // 
            this.OriginalMessageGroupBox.Controls.Add(this.originalMessageTextBox);
            this.OriginalMessageGroupBox.Location = new System.Drawing.Point(10, 244);
            this.OriginalMessageGroupBox.Name = "OriginalMessageGroupBox";
            this.OriginalMessageGroupBox.Size = new System.Drawing.Size(455, 87);
            this.OriginalMessageGroupBox.TabIndex = 7;
            this.OriginalMessageGroupBox.TabStop = false;
            this.OriginalMessageGroupBox.Text = "خطای اصلی";
            // 
            // originalMessageTextBox
            // 
            this.originalMessageTextBox.ForeColor = System.Drawing.Color.Red;
            this.originalMessageTextBox.Location = new System.Drawing.Point(6, 20);
            this.originalMessageTextBox.Multiline = true;
            this.originalMessageTextBox.Name = "originalMessageTextBox";
            this.originalMessageTextBox.ReadOnly = true;
            this.originalMessageTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.originalMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalMessageTextBox.Size = new System.Drawing.Size(443, 61);
            this.originalMessageTextBox.TabIndex = 0;
            this.originalMessageTextBox.TabStop = false;
            // 
            // TitleGroupBox
            // 
            this.TitleGroupBox.Controls.Add(this.titleLabel);
            this.TitleGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TitleGroupBox.Location = new System.Drawing.Point(9, 8);
            this.TitleGroupBox.Name = "TitleGroupBox";
            this.TitleGroupBox.Size = new System.Drawing.Size(456, 61);
            this.TitleGroupBox.TabIndex = 4;
            this.TitleGroupBox.TabStop = false;
            this.TitleGroupBox.Text = "عنوان خطا";
            // 
            // titleLabel
            // 
            this.titleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titleLabel.Location = new System.Drawing.Point(13, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(440, 41);
            this.titleLabel.TabIndex = 0;
            // 
            // officeFormAdorner1
            // 
            this.officeFormAdorner1.Form = this;
            this.officeFormAdorner1.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom;
            this.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // ExceptionHandlerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(477, 343);
            this.Controls.Add(this.HelpNoteGroupBox);
            this.Controls.Add(this.DescriptionGroupBox);
            this.Controls.Add(this.OriginalMessageGroupBox);
            this.Controls.Add(this.TitleGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ExceptionHandlerUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "خطا در انجام عملیات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleMessage_KeyDown);
            this.HelpNoteGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.ResumeLayout(false);
            this.OriginalMessageGroupBox.ResumeLayout(false);
            this.OriginalMessageGroupBox.PerformLayout();
            this.TitleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeFormAdorner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label helpNoteLabel;
        private System.Windows.Forms.GroupBox HelpNoteGroupBox;
        private System.Windows.Forms.GroupBox DescriptionGroupBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox OriginalMessageGroupBox;
        private System.Windows.Forms.GroupBox TitleGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private Janus.Windows.Ribbon.OfficeFormAdorner officeFormAdorner1;
        private System.Windows.Forms.TextBox originalMessageTextBox;

    }
}