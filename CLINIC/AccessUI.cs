using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    using BusinessObjectLayer;
    using JntMsgBox;
    using ComplexDataType;
    using System.Resources;
    using System.Reflection;
    using BusinessLogicLayer;
    using DataConvertor;

    public partial class AccessUI : Form
    {
        ExceptionHandlerBOL _ExceptionHandlerBOL;
        JntMsgBoxFarsi _JntMsgBoxFarsi = new JntMsgBoxFarsi();
        RoleBOL _RoleBOL = new RoleBOL();
        RoleBLL _RoleBLL = new RoleBLL();
        SecurityBOL _SecurityBOL = new SecurityBOL();
        SecurityBLL _SecurityBLL = new SecurityBLL();
        bool cellValueChanged = false;
        public AccessUI()
        {
            InitializeComponent();
        }
        private void FillAccessDropDown()
        {
            try
            {
                DataTable _DataTable = AccessBLL.SelectComboBox();
                securityGridEX.DropDowns["Access"].SetDataBinding(_DataTable, "");
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void FillRoleGridEX()
        {
            try
            {
                roleGridEX.ClearItems();
                RoleBOL[] _RoleBOL = _RoleBLL.Select();
                if (_RoleBOL != null)
                    for (int index = 0; index < _RoleBOL.Length; index++)
                        roleGridEX.AddItem(_RoleBOL[index].RoleId, _RoleBOL[index].RoleTitle, _RoleBOL[index].Description);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void roleGridEX_SelectionChanged(object sender, EventArgs e)
        {
            _SecurityBOL.RoleId = (short)(roleGridEX.CurrentRow.Cells["ROLEID"].Value);
            FillSecurityGridEX();
        }
        private void FillSecurityGridEX()
        {
            securityGridEX.ClearItems();
            try
            {
                SecurityBOL[] _SecurityBOLs = _SecurityBLL.Select(_SecurityBOL);
                if (_SecurityBOL != null)
                    for (int index = 0; index < _SecurityBOLs.Length; index++)
                        securityGridEX.AddItem(_SecurityBOLs[index].PageId, _SecurityBOLs[index].PageTitle, _SecurityBOLs[index].AccessId, _SecurityBOLs[index].AccessTitle);
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        private void AccessUI_Load(object sender, EventArgs e)
        {
            FillRoleGridEX();
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
        private void securityGridEX_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
        {
            if (securityGridEX.DropDowns["Access"].DataSource == null)
                FillAccessDropDown();
        }
        private void securityGridEX_CellUpdated(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (cellValueChanged && (e.Column.Key == "AccessID" || e.Column.Key == "AccessTitle"))
            {
                securityGridEX.SetValue("AccessID", securityGridEX.GetValue(e.Column));
                securityGridEX.SetValue("AccessTitle", securityGridEX.GetValue(e.Column));
                _SecurityBOL.AccessId = Convert.ToInt16(securityGridEX.CurrentRow.Cells["AccessID"].Value);
                _SecurityBOL.PageId = Convert.ToInt16(securityGridEX.CurrentRow.Cells["PageID"].Value);
                _SecurityBLL.InsertUpdate(_SecurityBOL);
                cellValueChanged = false;
            }
        }
        private void securityGridEX_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            cellValueChanged = true;
        }
        private void AccessUI_KeyDown(object sender, KeyEventArgs e)
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
