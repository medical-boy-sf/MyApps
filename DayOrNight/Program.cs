using System;

namespace DayOrNight
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            int hour = date.Hour;
            Console.WriteLine(hour);

            if ((hour >= 0 && hour < 5) || (hour >= 18 && hour < 24))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Night");
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Day");
            }
        }
    }
}