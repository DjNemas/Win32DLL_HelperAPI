using System.Runtime.CompilerServices;
using Win32API.CustomArgs;
using Win32API.Inputs;
using Win32API.Numerics;
using Win32API.Win32Structs;

namespace Win32DLLTest
{
    internal class Program
    {
        // Coords X:387 Y:1059 (start button)
        static void Main(string[] args)
        {
            Win32Mouse mouse = new();
            mouse.ExternalMouseFunctionStatusCode += Mouse_ExternalMouseFunctionStatusCode;
            //MoveMouse(mouse);
            //GetMousePos(mouse);
            //CURSORINFO info = mouse.GetCursorInfo();
            //Console.WriteLine(mouse.GetCourserHandler());

            Console.ReadKey();
        }

        private static void GetMousePos(Win32Mouse mouse)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.CursorLeft = 0;
                if (key.KeyChar == 'c')
                    Console.WriteLine(mouse.GetMouseMonitorPos());
                else if (key.KeyChar == 'e')
                    break;
            }
        }

        private static void MoveMouse(Win32Mouse mouse)
        {
            TimeSpan waitTime = TimeSpan.FromMilliseconds(10);
            Vector2Int cord1 = new(100, 100);
            Vector2Int cord2 = new(200, 100);
            Vector2Int cord3 = new(200, 200);
            Vector2Int cord4 = new(100, 200);
            
            mouse.SetMousePos(cord1).MoveMouseMonitor().Wait(waitTime);
            mouse.SetMousePos(cord2).MoveMouseMonitor().Wait(waitTime);
            mouse.SetMousePos(cord3).MoveMouseMonitor().Wait(waitTime);
            mouse.SetMousePos(cord4).MoveMouseMonitor().Wait(waitTime);
        }

        private static void Mouse_ExternalMouseFunctionStatusCode(object? sender, StatusCodeArgs e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}