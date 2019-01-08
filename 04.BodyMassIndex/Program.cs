using System;

namespace _04.BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
					Console.Write("Your height in meters: ");
					double height = double.Parse(Console.ReadLine());
					Console.Write("Your weight in kilograms: ");
					double weight = double.Parse(Console.ReadLine());
					double bmi = weight / (height * height);
					
					if (bmi > 25) 
					{
						Console.WriteLine($"Your BMI is {bmi:F2}"); 
						Console.WriteLine("Overweight!");
					}

					else if (bmi < 18)
					{
            Console.WriteLine($"Your BMI is {bmi:F2}");
						Console.WriteLine("Underweight!");
					}

					else 
					{
						Console.WriteLine($"Your BMI is {bmi:F2}");
						Console.WriteLine("You have normal weight");
					}

        }
    }
}
