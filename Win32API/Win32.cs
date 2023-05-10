using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32API
{
    public sealed class Win32
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetCursorPos(int x, int y);
    }
}
