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
                Console.WriteLine("Night");
            }

            else
            {
                Console.WriteLine("Day");
            }
        }
    }
}