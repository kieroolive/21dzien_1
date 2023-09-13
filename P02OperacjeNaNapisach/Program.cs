using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";

            Console.WriteLine(napis.Length); //wypisanie ile znaków zawiera zmienna tekstowa
            

            Console.WriteLine(napis.Substring(4)); //odciecie tekstu od którego znaku do końca zawartości
            Console.WriteLine(napis.Substring(4,2)); //odcięcie tekstu od którego znku ile znaków

            Console.WriteLine(napis.Contains("ma")); //sprawdzenie czy wartość jest w wartości w zmiennej

            Console.WriteLine(napis.ToLower()); //zamiana na małe litery
            Console.WriteLine(napis.ToUpper()); //zamiana na duże litery

            Console.WriteLine("ala" + "ma" + "kota"); //łączenie tekstu za pomocą concatenacji

            string s1 = "abecadło";
            Console.WriteLine(s1);
                                    //podmiana zawartości zmiennej tekstowej przez podstawienie jej wartości z wykorzystaniem metody ToUpper
            s1 = s1.ToUpper();
            Console.WriteLine(s1);

            Console.WriteLine(napis.Replace("ma" , "będzie miała")); //pomiana części wartości wyszukiwanej na podaną

            Console.WriteLine(napis.IndexOf("ma")); //wyśiwetlenie indeksu w zmiennej




            Console.ReadKey();
        }
    }
}
