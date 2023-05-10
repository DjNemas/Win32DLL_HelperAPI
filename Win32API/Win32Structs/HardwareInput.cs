using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32API.Win32Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        public int Msg;
        public short ParamL;
        public short ParamH;
    }
}
