using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite velicinu niza");
            int n = int.Parse(Console.ReadLine());
            int[] niz = new int[n];
            niz[0] = 0;      Console.Write($"{niz[0]} ");
            niz[1] = 1;      Console.Write($"{niz[1]} ");

            for (int i = 2; i < n  ; i++)
            {   
                niz[i] = niz[i-1] + niz[i - 2];
                Console.Write($"{niz[i]} ");
            }
            Console.ReadLine();
        }
    }
}
