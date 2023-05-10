using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Win32API.Win32Structs;

namespace Win32API
{
    public sealed class Win32
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetCursorPos(out Point point);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetCursorInfo(ref CursorInfo point);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern UIntPtr GetCursor();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint inputNumber, Input[] inputArray, int sizeOfInputStructInBytes);
    }
}
