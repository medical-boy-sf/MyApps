using System;

namespace _08.AreAllLettersThere
{
    class Program
    {
        static void Main(string[] args)
        {
					
					string text = Console.ReadLine().ToLower();
					bool l1 = false; // 'а'
					bool l2 = false; // 'б'
					bool l3 = false; // 'в'
					bool l4 = false; // 'г'
          bool l5 = false; // 'д'
          bool l6 = false; // 'е'
 					bool l7 = false; // 'ж'
          bool l8 = false; // 'з'
          bool l9 = false; // 'и'
					bool l10 = false; // 'й'
          bool l11 = false; // 'к'
          bool l12 = false; // 'л'
				  bool l13 = false; // 'м'
          bool l14 = false; // 'н'
          bool l15 = false; // 'о'
				  bool l16 = false; // 'п'
          bool l17 = false; // 'р'
          bool l18 = false; // 'с'
					bool l19 = false; // 'т'
					bool l20 = false; // 'у'
					bool l21 = false; // 'ф'
					bool l22 = false; // 'х'
					bool l23 = false; // 'ц'
					bool l24 = false; // 'ч'
					bool l25 = false; // 'ш'
					bool l26 = false; // 'щ'
					bool l27 = false; // 'ъ'
					bool l28 = false; // 'ь'
					bool l29 = false; // 'ю'
					bool l30 = false; // 'я'

					for (int i = 0; i < text.Length; i++) 
					{
						switch(text[i]) 
						{
							case 'а':
							l1 = true; break;
							case 'б':
							l2 = true; break;
							case 'в':
							l3 = true; break;
							case 'г':
							l4 = true; break;
							case 'д':
							l5 = true; break;
							case 'е':
							l6 = true; break;
							case 'ж':
              l7 = true; break;
							case 'з':
              l8 = true; break;
							case 'и':
              l9 = true; break;
							case 'й':
              l10 = true; break;
							case 'к':
              l11 = true; break;
							case 'л':
              l12 = true; break;
							case 'м':
              l13 = true; break;
							case 'н':
              l14 = true; break;
							case 'о':
              l15 = true; break;
							case 'п':
              l16 = true; break;
							case 'р':
              l17 = true; break;
							case 'с':
              l18 = true; break;
							case 'т':
              l19 = true; break;
							case 'у':
              l20 = true; break;
							case 'ф':
              l21 = true; break;
							case 'х':
              l22 = true; break;
							case 'ц':
              l23 = true; break;
							case 'ч':
              l24 = true; break;
							case 'ш':
              l25 = true; break;
							case 'щ':
              l26 = true; break;
							case 'ъ':
              l27 = true; break;
							case 'ь':
              l28 = true; break;
							case 'ю':
              l29 = true; break;
							case 'я':
              l30 = true; break;
							case ' ':
							case '.':
							case ',':
							break;
							default: 
							Console.WriteLine("Wrong character in the world!"); break;
						}
					}

						if (l1 && l2 && l3 && l4 && l5 && l6 && l7 && l8 && l9 && l10 && l11 && l12 && l13 && l14 && l15 && l16 && l17 && l18 && l19 && l20 && l21 && l22 && l23 && l24 && l25 && l26 && l27 && l28 && l29 && l30)
						{
							Console.WriteLine("The text contains all Cyrillic letters");
						}

						else 
						{
							Console.WriteLine("The text does not contain all Cyrillic letters");
						}
							
        	}
    }
 }
