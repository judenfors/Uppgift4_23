using System;

namespace Uppgift4_23
{
    class Program
    {
        static void Main(string[]args)
        {
            bool o = true;

            int k = 0;

            for(int i = 0; o == true;)
            {
                Console.WriteLine("Skriv in ett heltal, ja/nej");

                string svar = Console.ReadLine();

                if (svar == "ja")
                {
                    k =int.Parse(Console.ReadLine());

                    if (k > 1)
                    {
                        i = k;
                    }
                }

                else
                {
                    Console.WriteLine("Det största talet du skrev var: " + i );

                    o= false;
                }
            }
        }
    }
}