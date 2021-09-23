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
    using BusinessLogicLayer;
    using Device;
    using System.Collections;

    public partial class ScannerUI : Form//, IMessageFilter
    {
        private Twain _Twain;
        private bool msgfilter;
        ExceptionHandlerBOL _ExceptionHandlerBOL;

        public ScannerUI()
        {
            InitializeComponent();
        }        
        private void noticeLabel_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            if (_ExceptionHandlerBOL != null)
                new ExceptionHandlerUI(_ExceptionHandlerBOL).ShowDialog();
            _ExceptionHandlerBOL = null;
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            closeForm();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void scanButton_Click(object sender, EventArgs e)
        {
            try
            {
                _Twain = new Twain();
                _Twain.Init(this.Handle);
                _Twain.Select();
                //if (!msgfilter)
                //{
                //    this.Enabled = false;
                //    msgfilter = true;
                //    Application.AddMessageFilter(this);
                //}
                _Twain.Acquire();
                _Twain.Finish();
            }
            catch (Exception exception)
            {
                _ExceptionHandlerBOL = ExceptionHandlerBLL.HandleException(exception);
                noticeLabel.DescriptionForegroundStyle.ForeColor = Color.Red;
                noticeLabel.Text = _ExceptionHandlerBOL.Title;
            }
        }
        //bool IMessageFilter.PreFilterMessage(ref Message m)
        //{
        //    TwainCommand _TwainCommand = _Twain.PassMessage(ref m);
        //    if (_TwainCommand == TwainCommand.Not)
        //        return false;
        //    switch (_TwainCommand)
        //    {
        //        case TwainCommand.CloseRequest:
        //            {
        //                EndingScan();
        //                _Twain.CloseSrc();
        //                break;
        //            }
        //        case TwainCommand.CloseOk:
        //            {
        //                EndingScan();
        //                _Twain.CloseSrc();
        //                break;
        //            }
        //        case TwainCommand.DeviceEvent:
        //            {
        //                break;
        //            }
        //        case TwainCommand.TransferReady:
        //            {
        //                ArrayList pics = _Twain.TransferPictures();
        //                EndingScan();
        //                _Twain.CloseSrc();
        //                /* for (int i = 0; i < pics.Count; i++)
        //                 {
        //                     IntPtr img = (IntPtr)pics[i];
        //                     PicForm newpic = new PicForm(img);
        //                     newpic.MdiParent = this;
        //                     int picnum = i + 1;
        //                     newpic.Text = "ScanPass" + picnumber.ToString() + "_Pic" + picnum.ToString();
        //                     newpic.Show();
        //                 }*/
        //                break;
        //            }
        //    }
        //    return true;
        //}
        //private void EndingScan()
        //{
        //    if (msgfilter)
        //    {
        //        Application.RemoveMessageFilter(this);
        //        msgfilter = false;
        //        this.Enabled = true;
        //        this.Activate();
        //    }
        //}
    }
}