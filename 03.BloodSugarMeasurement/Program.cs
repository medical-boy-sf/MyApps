using System;

namespace _03.BloodSugarMeasurement
{
    class Program
    {
        static void Main()
        {
            double bloodSugarLevel = double.Parse(Console.ReadLine());
            string units = Console.ReadLine();

            if (units == "mg/dl")
            {
                if (bloodSugarLevel > 90)
                {
                    Console.WriteLine("Hyperglycemia");
                } 
                
                else if (bloodSugarLevel < 50)
                {
                    Console.WriteLine("Hypoglycemia");
                }

                else
                {
                    Console.WriteLine("Normoglycemia");
                }
            }

            else if (units == "mmol/l")
            {
                if (bloodSugarLevel > 5)
                {
                    Console.WriteLine("Hyperglycemia");
                } 
                
                else if (bloodSugarLevel < 2.8)
                {
                    Console.WriteLine("Hypoglycemia");
                }

                else
                {
                    Console.WriteLine("Normoglycemia");
                }                
            }

            else
            {
                Console.WriteLine("Unrecognized unit. Check if you have spelled correctly - 'mg/dl' or 'mmol/l'");
            }
        }
    }
}
