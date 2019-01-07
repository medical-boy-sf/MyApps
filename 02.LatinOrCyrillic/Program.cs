using System;

namespace _02.LatinOrCyrillic
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            if ((word[0] >= 'A' && word[0] <= 'Z') || (word[0] >= 'a' && word[0] <= 'z'))
            {
                Console.WriteLine("Latin");
                for (int i = 0; i < word.Length; i++)
                {
                    if ((word[i] >= 'а' && word[i] <= 'я') || (word[i] >= 'А' && word[i] <= 'Я'))
                    {
                        Console.WriteLine("There is Cyrillic letters also!");
                    }
                }
            }

            else if ((word[0] >= 'а' && word[0] <= 'я') || ((word[0] >= 'А' && word[0] <= 'Я')))
            {
                Console.WriteLine("Cyrillic");
                for (int i = 0; i < word.Length; i++)
                {
                    if ((word[i] >= 'A' && word[i] <= 'Z') || (word[i] >= 'a' && word[i] <= 'z'))
                    {
                        Console.WriteLine("There is Latin letters also!");
                    }
                }
            }
        }
    }
}
