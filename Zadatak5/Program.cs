using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int n = int.Parse(Console.ReadLine());
            while (n != 1) //ako hocemo beskonacnu petlju, da nam vrti vrednost 4, 2 ,1 samo uslov postavimo (true)
            {
                
                if (n % 2 == 0)
                {
                    n = n / 2;
                    Console.Write($"{n} ");
                }
                else
                {
                    n = n * 3 + 1;
                    Console.Write($"{n} ");
                }
            }
            Console.ReadKey();
        }
    }
}
