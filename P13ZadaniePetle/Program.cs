using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadaniePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać dowolne zdanie");
            string tekst = Console.ReadLine();

            string szukane;
            Console.WriteLine("Czego szukamy?");
            szukane = Console.ReadLine();
            do
            {
                int wystapienieSzukanego = 0;
                int i = 0;

                while (i <= tekst.Length - szukane.Length)
                {
                    if (tekst.Substring(i, szukane.Length) == szukane)
                    {
                        wystapienieSzukanego++;
                    }
                    i++;
                }

                Console.WriteLine($"Słowo/znak '{szukane}' występuje w podanym zdaniu {wystapienieSzukanego} razy");
                Console.ReadKey();
                Console.WriteLine("Czego jeszcze szukamy?");
                szukane = Console.ReadLine();
            } while (szukane.ToLower() != "koniec");


            //string.IsNullOrWhiteSpace(szukane) -> porównuje do "" lub null lub dowolnej liczby spacji
            //string.IsNullOrEmpty(szukane) -> porównuje do "" lub null
            
        }
    }
}
