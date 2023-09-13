using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieInstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj równanie matematyczne, które będzie oparte tylko o liczby jednocyfrowe");
            string rownanie = Console.ReadLine();

            string op = rownanie.Substring(1, 1);
            int liczba1 = Convert.ToInt32(rownanie.Substring(0, 1));
            int liczba2 = Convert.ToInt32(rownanie.Substring(2));

            double? wynik = null;

            if (op == "+")
                wynik = liczba1 + liczba2;
            else if (op == "-")
                wynik = liczba1 - liczba2;
            else if (op == "*")
                wynik = liczba1 * liczba2;
            else if (op == "/")
                wynik = Convert.ToDouble(liczba1) / liczba2; //Konwersję do doubla wystarczy zrobić tylko na jednej liczbie

            if (wynik != null)
                Console.WriteLine("wynik to: " + wynik);
            else
                Console.WriteLine("nieznany operator");
            Console.ReadKey();
        }
    }
}
