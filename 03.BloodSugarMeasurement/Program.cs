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
                if (true)
                {

                }
            }

            else if (units == "mmol/l")
            {

            }

            else
            {
                Console.WriteLine("Unrecognized unit. Check if you have spelled correctly - 'mg/dl' or 'mmol/l'");
            }


        }
    }
}
