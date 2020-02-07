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

            Console.WriteLine("Podaj rodzaj działania(+, -, /, *)");
            string c = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę do działania: ");
            int b = int.Parse(Console.ReadLine());


            if (c=="+")
            {
                Plus(a, b);
            }
            if (c=="-")
            {
                Minus(a, b);
            }
            if (c=="*")
            {
                Razy(a, b);
            }
            if (c=="/")
            {
                Przez(a, b);
            }
            else
            {
                Console.WriteLine("Wpisz jeden z czterech podanych znaków (+, -, /, *)");
            }


           

            Console.ReadKey();
        }



        static void Plus(int a, int b)
        {
            int dodawanie = a + b;
            Console.WriteLine("Wynik to: ");
            Console.WriteLine(dodawanie);
        }

        static void Minus(int a, int b)
        {
            int odejmowanie=(a-b);
            Console.WriteLine("Wynik to: ");
            Console.WriteLine(odejmowanie);
        }

        static void Razy(int a, int b)
        {
            int mnozenie = (a * b);
            Console.WriteLine("Wynik to: ");
            Console.WriteLine(mnozenie);
        }

        static void Przez(int a, int b)
        {
            int dzielenie = (a / b);
            Console.WriteLine("Wynik to: ");
            Console.WriteLine(dzielenie);
        }

    }
}

