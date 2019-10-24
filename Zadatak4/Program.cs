using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite duzinu stranice");       int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite duzinu stranice");       int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= m -1 ; i++)
            {
               
                Console.WriteLine();
               
                for (int j = 0; j <= n - 1; j++)
                {
                    Console.Write(" ");  //ispis praznina izmedju zvezdica
                    if (j== 0 || j==n - 1 )
                    {
                        Console.Write("*"); //ispis visina
                    }                   
                    if (i == 0 && j>0 && j<n - 1) //ispis gornje stranice
                    {
                        Console.Write("*");
                    }
                    if( i!=0 && i!=m-1 && j>0 && j < n - 1)//ispis praznih polja
                    {
                        Console.Write(" ");
                    }
                    if (i == m-1 && j > 0 && j < n - 1) //ispis donje stranice
                    {
                        Console.Write("*");
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
