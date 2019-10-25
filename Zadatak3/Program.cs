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
                if (slovo >= 97 || (slovo >= 65 && slovo <= 91))
                {
                    if (slovo + n <= 122 || (slovo >= 65 && slovo <= 91))
                    {
                        Console.Write($"{(char)(slovo + n)}");

                    }
                    else if (slovo + n > 91 && slovo + n < 97  )
                    {
                        Console.Write($"{ (char)((slovo + n) - 91) + 64}");
                    }
                else
                {
                    Console.Write($"{ (char)(((slovo + n)-122)+96)}");
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
