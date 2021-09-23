using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BusinessObjectLayer;
using BusinessLogicLayer;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    public partial class BackupUI : Form
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;        
        public BackupUI()
        {
            InitializeComponent();
        }
        private void browserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string DatabasePath = GetDatabasePath();
                if (!Directory.Exists(DatabasePath))
                    Directory.CreateDirectory(DatabasePath);
                SaveFileDialog _SaveFileDialog = new SaveFileDialog();
                _SaveFileDialog.DefaultExt = "mdf";
                _SaveFileDialog.InitialDirectory = DatabasePath;
                _SaveFileDialog.Filter = "Backup (*.bak)|*.bak;";
                DialogResult _DialogResult = _SaveFileDialog.ShowDialog();
                if (_DialogResult == DialogResult.No)
                    return;
                backupPathTextBox.Text = _SaveFileDialog.FileName;
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        string GetDatabasePath()
        {
            return string.Format("{0}{1}\\{2}", ServerBLL.GetServerPath(), ServerBLL.GetStringValue("DatabasePath"), DataConvertor.DataConvertor.ConvertToPersianDate(DateTime.Now).Replace('/', '-'));
        }
        private bool ValidatePath()
        {
            requieredValidationProvider.ValidationMessages(!requieredValidationProvider.Validate());
            return requieredValidationProvider.Validate();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                if (ValidatePath())
                {
                    string filePath = backupPathTextBox.Text.ToString();
                    string Path = filePath.Substring(0, filePath.LastIndexOf("\\"));
                    string Name = filePath.Substring(filePath.LastIndexOf("\\") + 1).Replace(".bak", string.Empty);
                    if (ServerBLL.BackUp(Path, Name))
                    {
                        ResourceManager _ResourceManager = new ResourceManager("UserInterface.Properties.Resources", Assembly.GetExecutingAssembly());
                        DialogResult _DialogResult = MessageBox.Show(_ResourceManager.GetString("SuccessFullBackup"));
                        if (_DialogResult == DialogResult.OK)
                            this.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
            finally
            {
                this.Enabled = true;
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void noticeLabel_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
            {
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
                noticeLabel.Text = string.Empty;
            }
            _ExceptionHandlerBOL = null;
        }
        private void BackupUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
    }
}
