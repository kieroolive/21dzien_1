using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadaniePetla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać dowolne zdanie");
            string tekst = Console.ReadLine();

            Console.WriteLine("Czego szukamy?");
            string szukane = Console.ReadLine();
            
            int wystapienieSzukanego = 0;
            int i = 0;
            
            while(i <= tekst.Length - szukane.Length)
            {
                if(tekst.Substring(i, szukane.Length) == szukane)
                {
                    wystapienieSzukanego++;
                }
                i++;
            }

            Console.WriteLine($"Słowo/znak '{szukane}' występuje w podanym zdaniu {wystapienieSzukanego} razy");
            Console.ReadKey();
        }
    }
}
