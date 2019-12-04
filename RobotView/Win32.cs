using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
/*
namespace RobotView
{
    /// <summary>
    /// Contains managed wrappers or implementations of Win32 structs, delegates,
    /// constants and PInvokes that are useful for this sample.
    ///
    /// See the documentation on MSDN for more information on the elements provided
    /// in this file.
    /// </summary>
    public sealed class Win32
    {
        /// <summary>
        /// A callback to a Win32 window procedure (wndproc)
        /// </summary>
        /// <param name=”hwnd”>The handle of the window receiving a message</param>
        /// <param name=”msg”>The message</param>
        /// <param name=”wParam”>The message’s parameters (part 1)</param>
        /// <param name=”lParam”>The message’s parameters (part 2)</param>
        /// <returns>A integer as described for the given message in MSDN</returns>
        public delegate int WndProc(IntPtr hwnd, uint msg, uint wParam, int lParam);

        public const uint WM_NOTIFY = 0x4E;

        public const uint NM_CLICK = 0xFFFFFFFE;
        public const uint NM_RCLICK = 0xFFFFFFFB;

        public const uint TV_FIRST = 0x1100;
        public const uint TVM_HITTEST = TV_FIRST + 17;

        public const uint TVHT_NOWHERE = 0x0001;
        public const uint TVHT_ONITEMICON = 0x0002;
        public const uint TVHT_ONITEMLABEL = 0x0004;
        public const uint TVHT_ONITEM = (TVHT_ONITEMICON | TVHT_ONITEMLABEL | TVHT_ONITEMSTATEICON);
        public const uint TVHT_ONITEMINDENT = 0x0008;
        public const uint TVHT_ONITEMBUTTON = 0x0010;
        public const uint TVHT_ONITEMRIGHT = 0x0020;
        public const uint TVHT_ONITEMSTATEICON = 0x0040;
        public const uint TVHT_ABOVE = 0x0100;
        public const uint TVHT_BELOW = 0x0200;
        public const uint TVHT_TORIGHT = 0x0400;
        public const uint TVHT_TOLEFT = 0x0800;

        [System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
        public class NMHDR
        {
            public IntPtr hwndFrom;
            public uint idFrom;
            public uint code;
        }

        public struct TVHITTESTINFO
        {
            public Point pt;
            public uint flags;
            public IntPtr hItem;
        }

        /// <summary>
        /// Helper function to convert a Windows lParam into a Point
        /// </summary>
        /// <param name=”lParam”>The parameter to convert</param>
        /// <returns>A Point where X is the low 16 bits and Y is the
        /// high 16 bits of the value passed in</returns>
        public static Point LParamToPoint(int lParam)
        {
            uint ulParam = (uint)lParam;
            return new Point(
                (int)(ulParam & 0x0000ffff),
                (int)((ulParam & 0xffff0000) >> 16));
        }

#if DESKTOP
    [DllImport(“user32.dll”)]
#else
        [DllImport("coredll.dll")]
#endif
        public extern static uint GetMessagePos();

#if DESKTOP
    [DllImport(“user32.dll”)]
#else
        [DllImport("coredll.dll")]
#endif
        public extern static int SendMessage(
            IntPtr hwnd, uint msg, uint wParam, ref TVHITTESTINFO lParam);



#if DESKTOP
    [DllImport(“user32.dll”)]
#else
        [DllImport("coredll.dll")]
#endif
        public extern static int DefWindowProc(
            IntPtr hwnd, uint msg, uint wParam, int lParam);

#if DESKTOP
    [DllImport(“user32.dll”)]
#else
        [DllImport("coredll.dll")]
#endif
        public extern static IntPtr SetWindowLong(
            IntPtr hwnd, int nIndex, IntPtr dwNewLong);

        public const int GWL_WNDPROC = -4;

#if DESKTOP
    [DllImport(“user32.dll”)]
#else
        [DllImport("coredll.dll")]
#endif
        public extern static int CallWindowProc(
            IntPtr lpPrevWndFunc, IntPtr hwnd, uint msg, uint wParam, int lParam);
    }
}
*/