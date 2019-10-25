using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());


            foreach (char slovo in unos)
            {
                if (slovo >= 97)
                {
                if (slovo + n <= 122)
                    {
                        Console.Write($"{(char)(slovo + n)}");
                    }
                    else
                    {
                        Console.Write(((slovo + n) - 122) + 97);
                    }
                } else
                {
                    Console.Write(slovo);
                }
        }

            Console.ReadKey();
        }
    }
}
