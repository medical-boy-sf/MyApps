using System;

namespace SumNNumbers_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1; i <= 7; i++)
            {
                string month = "";
                switch (i)
                {
                    case 1:
                        month = "January";
                        break;
                    case 2:
                        month = "February";
                        break;
                    case 3:
                        month = "March";
                        break;
                    case 4:
                        month = "April";
                        break;
                    case 5:
                        month = "May";
                        break;
                    case 6:
                        month = "June";
                        break;
                    case 7:
                        month = "July";
                        break;
                }

                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                Console.WriteLine($"{month} - {grade}");
            }

            Console.WriteLine($"The average is {sum / 7.0}!");
        }
    }
}