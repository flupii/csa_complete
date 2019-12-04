using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{


    public partial class NumericUpDownExt : NumericUpDown
    {
        /// <summary>
        /// The original parent of this control.
        /// </summary>
        Control prevParent = null;

        /// <summary>
        /// Occurs when the user clicks a TreeNode with the mouse.
        /// </summary>
        public event EventHandler<MouseEventArgs> MouseClick;


        public NumericUpDownExt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the control’s parent is changed. Here we hook into that
        /// parent’s WndProc and spy on the WM_NOTIFY message. When the parent
        /// changes, we unhook the old parent’s WndProc and hook into the new one.
        /// </summary>
        /// <param name=”e”>The arguments for this event</param>
        protected override void OnParentChanged(EventArgs e)
        {
            //// unhook the old parent
            //if (this.prevParent != null)
            //{
            //    WndProcHooker.UnhookWndProc(prevParent, Win32.WM_NOTIFY);
            //}
            //// update the previous parent
            //prevParent = this.Parent;

            //// hook up the new parent
            //if (this.Parent != null)
            //{
            //    WndProcHooker.HookWndProc(this.Parent,
            //        new WndProcHooker.WndProcCallback(this.WM_Notify_Handler),
            //        Win32.WM_NOTIFY);
            //}

            base.OnParentChanged(e);
        }


       
        /// <summary>
        /// Occurs when the mouse pointer is over the control and a mouse button is clicked.
        /// </summary>
        /// <param name=”e”>Provides data for the NodeMouseClick event.</param>
        protected void OnMouseClick(MouseEventArgs e)
        {
            if (MouseClick != null) MouseClick(this, e);
        }
        /*

        /// <summary>
        /// The method that gets called when a WM_NOTIFY message is received by the
        /// TreeView’s parent.
        /// </summary>
        /// <param name=”hwnd”>The handle of the window that received the message</param>
        /// <param name=”msg”>The message received</param>
        /// <param name=”wParam”>The wParam arguments for the message</param>
        /// <param name=”lParam”>The lParam arguments for the message</param>
        /// <param name=”handled”>Set to true to indicate that this message was handled</param>
        /// <returns>An appropriate returen code for the message handled (see MSDN)</returns>
        int WM_Notify_Handler(
            IntPtr hwnd, uint msg, uint wParam, int lParam,
            ref bool handled)
        {
            Win32.NMHDR nmHdr = new Win32.NMHDR();
            System.Runtime.InteropServices.Marshal.PtrToStructure((IntPtr)lParam, nmHdr);
            switch (nmHdr.code)
            {
                case Win32.NM_RCLICK:
                case Win32.NM_CLICK:
                    // get the cursor coordinates on the client
                    Point msgPos = Win32.LParamToPoint((int)Win32.GetMessagePos());
                    msgPos = this.PointToClient(msgPos);

                    // check to see if the click was on an item
                    Win32.TVHITTESTINFO hti = new Win32.TVHITTESTINFO();
                    hti.pt.X = msgPos.X;
                    hti.pt.Y = msgPos.Y;
                    int hitem = Win32.SendMessage(this.Handle, Win32.TVM_HITTEST, 0, ref hti);
                    uint htMask = (
                        Win32.TVHT_ONITEMICON |
                        Win32.TVHT_ONITEMLABEL |
                        Win32.TVHT_ONITEMINDENT |
                        Win32.TVHT_ONITEMBUTTON |
                        Win32.TVHT_ONITEMRIGHT |
                        Win32.TVHT_ONITEMSTATEICON);
                    if ((hti.flags & htMask) != 0)
                    {
                        bool leftButton = (nmHdr.code == Win32.NM_CLICK);

                        OnMouseClick(new MouseEventArgs(leftButton ? MouseButtons.Left : MouseButtons.Right, 1, msgPos.X, msgPos.Y, 0));
                        return 0;
                    }
                    break;

                default:
                    break;
            }
            return 0;
        }
        */
    }
}