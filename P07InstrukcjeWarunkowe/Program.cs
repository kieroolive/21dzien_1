using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            // wypisz "wsyoki" gdy wzrost jest większy od 180 lub nikski gdy jest mniejszy

            if(wzrost > 180)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else
            {
                Console.WriteLine("Jesteś niski");
            }

            //Starać się unikać zagnieżdżeń instrukcji warunkowych skonstruowanych w sposób if else..if else

            if (wzrost > 180)
                Console.WriteLine("Wysoki");
            else if (wzrost >160)
                Console.WriteLine("Średni");
            else if (wzrost > 150)
                Console.WriteLine("Niski");
            else
                Console.WriteLine("Bardzo niski");

            //żeby zapobiec powtarzającym się kawałkom kodu wyciągamy dodatkową zmienną na zewnątrz
            string raport;
            if (wzrost > 180
                raport = "wysoki";
            else if (wzrost > 160)
                raport = "średni";
            else if (wzrost > 150)
                raport = "niski";
            else
                raport = "bardzo niski";

            raport = $"twój wzrost to {wzrost} i jest {raport}";


            //prosty if
            string wyn;
            if (wzrost > 180)
                wyn = "wysoki";
            else
                wyn = "niski";

            string wyn1 = wzrost > 180 ? "wysoki" : "niski";

            Console.ReadKey();
        }
    }
}
