using System.Runtime.InteropServices;

namespace Win32API.Win32Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CursorInfo
    {
        public uint StrucSize;
        public CursorStates Flags;
        public UIntPtr CursorHandler;
        public Point MouseMonitorPosition;
    }

    [Flags]
    public enum CursorStates : uint
    {
        Cursor_Hidden = 0,
        Cursor_Showing = 0x00000001,
        Cursor_Suppressed = 0x00000002
    }
}
