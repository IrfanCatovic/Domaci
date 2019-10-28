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
            Console.WriteLine("Unesite tekst: "); string unos = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Za koliko mesta se pomera"); int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string unos2 = null;


            Console.WriteLine("Sifriran tekst: ");
            foreach (char slovo in unos)
            {
                if (slovo >= 97 && slovo <= 122 || (slovo >= 65 && slovo <= 90))//Ispitivanje da li je uneti char slovo 
                {
                    if ((slovo + n <= 122 && slovo + n >= 97) || slovo + n <= 90 && slovo + n >= 65)//ako je slovo + n u tom opsegu ispisuje ga
                    {
                        Console.Write($"{(char)(slovo + n)}");
                        unos2 += ($"{(char)(slovo + n)}");
                    }
                    else if (slovo + n > 90 || slovo + n > 122) //ako je van opsega, racuna ga pa ispisuje
                    {
                        Console.Write($"{(char)((slovo + n) - 26)}");
                        unos2 += ($"{(char)((slovo + n) - 26)}");
                    }


                }

                else
                {
                    Console.Write($"{slovo}"); //slucaj kada nisu u pitanju unesena slova
                    unos2 += (slovo);
                }


            }

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Desifrovan tekst:");


            foreach (char slovo in unos2)
            {
                if (slovo >= 97 && slovo <= 122 || (slovo >= 65 && slovo <= 90))
                {
                    if ((slovo - n <= 122 && slovo - n >= 97) || slovo - n <= 90 && slovo - n >= 65)
                    {
                        Console.Write($"{(char)(slovo - n)}");
                    }
                    else if (slovo - n < 65 || slovo - n < 97)
                    {
                        Console.Write($"{(char)((slovo - n) + 26)}");
                    }
                }
                else
                {
                    Console.Write($"{slovo}");
                }
            }




            Console.ReadKey();
        }
    }
}
