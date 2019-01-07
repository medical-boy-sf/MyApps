using System;
using System.Threading;

namespace _01.DrawingTimeBar
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            int counter = 1;
            while (true)
            {
                if (counter > 10)
                {
                    counter = 1;
                    Console.Clear();
                }
                Console.Write(counter + " ");
                Thread.Sleep(1500);
                counter += 1;
            }
        }
    }
}
