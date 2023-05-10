using System.Runtime.CompilerServices;
using Win32API.CustomArgs;
using Win32API.Inputs;
using Win32API.Numerics;
using Win32API.Win32Structs;

namespace Win32DLLTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Win32Mouse mouse = new();
            mouse.ExternalMouseFunctionStatusCode += Mouse_ExternalMouseFunctionStatusCode;
            MoveMouse(mouse);
            GetMousePos(mouse); // press m key
            GetMouseInfo(mouse);
            GetMouseHandler(mouse);
            ClickMouseButton(mouse);

            Console.ReadKey();
        }

        private static void ClickMouseButton(Win32Mouse mouse)
        {
            mouse.SetMousePos(1844, 1058).MoveMouseMonitor().ClickMouseButton(MouseButtons.Left);
        }

        private static void GetMouseHandler(Win32Mouse mouse)
        {
            Console.WriteLine(mouse.GetMouseHandler());
        }
        

        private static void GetMouseInfo(Win32Mouse mouse)
        {
            CursorInfo info = mouse.GetMouseInfo();
            Console.WriteLine("StructSize: " + info.StrucSize);
            Console.WriteLine("Flag: " + info.Flags + " Value uint: " + (uint)info.Flags);
            Console.WriteLine("CursorHandler: " + info.CursorHandler);
            Console.WriteLine($"MouseMonitorPosition: {info.MouseMonitorPosition.x}x {info.MouseMonitorPosition.y}y");
        }

        private static void GetMousePos(Win32Mouse mouse)
        {
            Console.WriteLine("Select Console and Press m to Show Coordinates. Press e to continue.");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.CursorLeft = 0;
                if (key.KeyChar == 'm')
                    Console.WriteLine(mouse.GetMouseMonitorPos());
                else if (key.KeyChar == 'e')
                    break;
            }
        }

        private static void MoveMouse(Win32Mouse mouse)
        {
            TimeSpan waitTime = TimeSpan.FromMilliseconds(500);
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