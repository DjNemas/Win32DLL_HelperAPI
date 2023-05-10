using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Win32API.CustomArgs;
using Win32API.Numerics;
using Win32API.Win32Structs;

namespace Win32API.Inputs
{
    public class Win32Mouse
    {
        private Vector2Int mousePos;
        public event EventHandler<StatusCodeArgs>? ExternalMouseFunctionStatusCode;

        public Win32Mouse()
        {
            mousePos = Vector2Int.Zero();
        }

        public Win32Mouse SetMousePos(Vector2Int mousePos)
        {
            SetMousePos(mousePos.X, mousePos.Y);
            return this;
        }

        public Win32Mouse SetMousePos(int x, int y)
        {
            mousePos = new Vector2Int(x, y);
            return this;
        }

        public Win32Mouse MoveMouseMonitor()
        {
            int statusCode = Win32.SetCursorPos(mousePos.X, mousePos.Y);

            StatusCodeArgs args = new("MoveMouse()", "SetCursorPos(int x, int y)", statusCode.ToString());
            OnExternelMouseFunctionStatusCode(args);

            return this;
        }

        public Vector2Int GetMouseMonitorPos()
        {
            int statusCode = Win32.GetCursorPos(out POINT point);

            StatusCodeArgs args = new("GetMousePos()", "GetCursorPos(out POINT point)", statusCode.ToString());
            OnExternelMouseFunctionStatusCode(args);

            return new Vector2Int(point.x, point.y);
        }

        public CURSORINFO GetCursorInfo()
        {
            CURSORINFO cursorInfo = new CURSORINFO();
            cursorInfo.StrucSize = (uint)Marshal.SizeOf<CURSORINFO>();
            int statusCode = Win32.GetCursorInfo(ref cursorInfo);

            StatusCodeArgs args = new("GetCursorInfo()", "GetCursorInfo(ref cursorInfo)", statusCode.ToString());
            OnExternelMouseFunctionStatusCode(args);

            return cursorInfo;
        }

        public UIntPtr GetCourserHandler()
        {
            UIntPtr pointer = Win32.GetCursor();

            StatusCodeArgs args = new("GetCourserHandler()", "GetCursor()", "\"No Status Code Available\"");
            OnExternelMouseFunctionStatusCode(args);

            return pointer;
        }

        public Win32Mouse Wait(TimeSpan ts)
        {
            Task.Delay(ts).Wait();
            return this;
        }

        private void OnExternelMouseFunctionStatusCode(StatusCodeArgs args)
        {
            ExternalMouseFunctionStatusCode?.Invoke(this, args);
        }
    }
}