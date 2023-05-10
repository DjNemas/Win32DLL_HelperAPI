using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Win32API.Win32Structs
{
    public struct CURSORINFO
    {
        public uint StrucSize;
        public uint CursorState;
        public UIntPtr CursorHandler;
        public POINT MouseMonitorPosition;
    }

    public struct CursorStatesValues
    {
        public static readonly uint CURSOR_HIDDEN = 0;
        public static readonly uint CURSOR_SHOWING = 0x00000001;
        public static readonly uint CURSOR_SUPPRESSED = 0x00000002;
    }

    public enum CursorStates
    {
        CURSOR_HIDDEN,
        CURSOR_SHOWING,
        CURSOR_SUPPRESSED
    }
}
