using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Proszę podać liczbę a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proszę podać liczbę b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int liczbaZnakow = Convert.ToString(c).Length;
            string raport1 = "wynik " + c + " złozony jest z: " + liczbaZnakow + " znaków";
            string raport2 = $"wynik {c} złozony jest z: {liczbaZnakow} znaków";
            string raport3 = string.Format("wynik {0} złożony jest z {1} znaków", c, liczbaZnakow);

            Console.WriteLine(raport1);

            Console.ReadKey();

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Proszę podać dwie liczby odzielone spacją");
            string liczby = Console.ReadLine();

            int pozycjaSpacji = liczby.IndexOf(" "); // = 3

            int nowaLiczba1 = Convert.ToInt32(liczby.Substring(0, pozycjaSpacji));
            int nowaLiczba2 = Convert.ToInt32(liczby.Substring(pozycjaSpacji));

            int suma = nowaLiczba1 + nowaLiczba2;
            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}
