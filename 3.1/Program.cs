using System;

namespace Övning_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 50)
            {
                Console.WriteLine("Är du en man?");
                string kön = (Console.ReadLine().ToLower());
                if (kön == "ja")
                {
                    Console.WriteLine("Grattis! du får delta :)");
                }
                if (kön == "nej")
                {
                    Console.WriteLine("Synd för dig");
                    Console.ReadKey();
                    Console.WriteLine("Bara skoja, vill du verkligen vara med ändå?");

                    string svar = Console.ReadLine().ToLower();

                    if (svar == "ja")
                    {
                        Console.WriteLine("Okej då, du får delta ändå");
                    }
                    if (svar == "nej")
                    {
                        Console.WriteLine("Nähe, synd för dig");
                    }
                }
            }
            if (ålder < 50)
            {
                Console.WriteLine("Synd för dig");
            }
            Console.ReadKey();
        }
    }
}