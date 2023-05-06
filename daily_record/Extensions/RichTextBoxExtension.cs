using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daily_record.Extensions.RichTextBoxExtension
{
    public static class RichTextBoxExtension
    {
        private const int WM_SETREDRAW = 0x0b;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, IntPtr lParam);

        public static void BeginUpdate(this RichTextBox richTextBox) 
        {
            SendMessage(richTextBox.Handle, WM_SETREDRAW, 0, IntPtr.Zero);
        }

        public static void EndUpdate(this RichTextBox richTextBox) 
        {
            SendMessage(richTextBox.Handle, WM_SETREDRAW, 1, IntPtr.Zero);
            richTextBox.Invalidate();
        }
    }
}
