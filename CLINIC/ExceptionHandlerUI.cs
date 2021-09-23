using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    using BusinessObjectLayer;

    public partial class ExceptionHandlerUI : Form
    {
        public ExceptionHandlerUI(ExceptionHandlerBOL _ExceptionHandlerBOL)
        {
            InitializeComponent();
            titleLabel.Text = _ExceptionHandlerBOL.Title;
            descriptionLabel.Text = _ExceptionHandlerBOL.Description;
            helpNoteLabel.Text = _ExceptionHandlerBOL.HelpNote;
            originalMessageTextBox.Text = _ExceptionHandlerBOL.OriginalMessage;
            originalMessageTextBox.ForeColor = Color.Red;
        }
        private void HandleMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }
    }
}