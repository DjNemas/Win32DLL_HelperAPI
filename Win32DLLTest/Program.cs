using System.Runtime.CompilerServices;
using Win32API.Inputs;
using Win32API.Numerics;

namespace Win32DLLTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MoveMouse();
            
            
            Console.ReadKey();
        }

        private static void MoveMouse()
        {
            TimeSpan waitTime = TimeSpan.FromMilliseconds(1000);
            Vector2Int cord1 = new(100, 100);
            Vector2Int cord2 = new(200, 100);
            Vector2Int cord3 = new(200, 200);
            Vector2Int cord4 = new(100, 200);

            Win32Mouse mouse = new();
            mouse.SetMousePos(cord1).MoveMouse().Wait(waitTime)
                .SetMousePos(cord2).MoveMouse().Wait(waitTime)
                .SetMousePos(cord3).MoveMouse().Wait(waitTime)
                .SetMousePos(cord4).MoveMouse().Wait(waitTime);

        }
    }
}