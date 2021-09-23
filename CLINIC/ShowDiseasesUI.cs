using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace UserInterface
{
    using BusinessLogicLayer;
    using BusinessObjectLayer;

    public partial class ShowDiseasesUI : Form
    {
        DiseasesBLL _DiseasesBLL;
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        private AccessMode pageAccess;        
        public ShowDiseasesUI(AccessMode accessMode)
        {
            InitializeComponent();
            newDiseasesButton.Enabled = (accessMode != AccessMode.Read);
            pageAccess = accessMode;
            _DiseasesBLL = new DiseasesBLL();
            fillDataGridView();
        }
        private void fillDataGridView()
        {
            try
            {
                DiseasesBOL[] DiseasesRecords = _DiseasesBLL.Select();
                DiseasesDataGridView.Rows.Clear();
                if (DiseasesRecords != null)
                    for (int index = 0; index < DiseasesRecords.Length; index++)
                    {
                        DiseasesDataGridView.Rows.Add();
                        DataGridViewRow row = DiseasesDataGridView.Rows[index];
                        row.Cells["diseasesId"].Value = DiseasesRecords[index].DiseasesId;
                        row.Cells["diseasesTitle"].Value = DiseasesRecords[index].DiseasesTitle;
                        row.Cells["isDangerous"].Value = DiseasesRecords[index].IsDangerous;
                        row.Cells["description"].Value = DiseasesRecords[index].Description;
                    }
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void DiseasesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            messageTitleLabel.Text = string.Empty;
            if (e.RowIndex != -1 && pageAccess == AccessMode.Complete)
                ItemSelected(e.RowIndex);
            if (pageAccess != AccessMode.Complete)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(new Exception("NoAccess"));
                messageTitleLabel.ForeColor = Color.Red;
                messageTitleLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void ItemSelected(int selectedIndex)
        {
            short diseasesId = Convert.ToInt16(DiseasesDataGridView.Rows[selectedIndex].Cells["diseasesId"].Value);
            string diseasesTitle = (DiseasesDataGridView.Rows[selectedIndex].Cells["diseasesTitle"].Value == null ? null : DiseasesDataGridView.Rows[selectedIndex].Cells["diseasesTitle"].Value.ToString());
            string description = (DiseasesDataGridView.Rows[selectedIndex].Cells["description"].Value == null ? null : DiseasesDataGridView.Rows[selectedIndex].Cells["description"].Value.ToString());
            bool isDangerous = Convert.ToBoolean(DiseasesDataGridView.Rows[selectedIndex].Cells["isDangerous"].Value == null ? null : DiseasesDataGridView.Rows[selectedIndex].Cells["isDangerous"].Value);
            DiseasesBOL diseasesRecord = new DiseasesBOL(diseasesId, diseasesTitle,isDangerous, description);
            new EditDiseasesUI(diseasesRecord).ShowDialog();
            fillDataGridView();
        }
        private void DiseasesdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
                if (DiseasesDataGridView.Rows.Count != 0)
                    ItemSelected(DiseasesDataGridView.CurrentRow.Index);
        }
        private void closeForm()
        {
            this.Close();
        }
        private void newDiseasesButton_Click(object sender, EventArgs e)
        {
            new EditDiseasesUI().ShowDialog();
            fillDataGridView();
        }
        private void ShowDiseases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                closeForm();
        }
        private void messageTitleLabel_Click(object sender, EventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
        }
    }
}