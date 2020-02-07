using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę do działania: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę do działania: ");
            int b = int.Parse(Console.ReadLine());

            Plus(a , b);
            

            Console.ReadKey();
        }

        static void Plus(int a, int b)
        {
            int dodawanie = a + b;
            Console.WriteLine("Wynik to: ");
            Console.WriteLine(dodawanie);
        }




    }
}

