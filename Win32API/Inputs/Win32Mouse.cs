using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Win32API.Numerics;

namespace Win32API.Inputs
{
    public class Win32Mouse
    {
        private Vector2Int mousePos;

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

        public Win32Mouse MoveMouse()
        {
            Console.WriteLine(Win32.SetCursorPos(mousePos.X, mousePos.Y));
            return this;
        }

        public Win32Mouse Wait(TimeSpan ts)
        {
            Task.Delay(ts).Wait();
            return this;
        }
    }
}