using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak się nazywasz: ");
            string imie = Console.ReadLine();

            Console.WriteLine(imie.ToUpper());

            Console.WriteLine("Podaj wiek");
            string wiek = Console.ReadLine();

            int wiekInt = Convert.ToInt32(wiek) + 1;
            Console.WriteLine("Za rok będziesz miał " + wiekInt);

            Console.ReadKey();
        }
    }
}
