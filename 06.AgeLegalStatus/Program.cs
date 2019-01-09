using System;

namespace AgeLegalStatus
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }

            else if (age >= 14)
            {
                Console.WriteLine("Underaged");
            }

            else if (age >= 0)
            {
                Console.WriteLine("Minor");
            }
        }
    }
}
