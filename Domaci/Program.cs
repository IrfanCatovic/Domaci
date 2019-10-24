using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite zavrsnu vrednost koja je veca od 1");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            if (n <= 1)
            {
                Console.WriteLine("Greska !");
                Console.ReadKey();
                return;
                    }
            while (i <= n)
            {   
                Console.Write($"\n {i}");
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write($" -- FizzBuzz");
                    i++;
                    continue;

                }
                    if (i % 3 == 0)
                {
                    Console.Write($" -- Fizz\t");
                    i++;
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.Write($" -- Buzz\t");
                    i++;
                    continue;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
