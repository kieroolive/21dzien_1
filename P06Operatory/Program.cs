using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; //operator przypisania
            bool czy = a == 1; //operator porównania
            a = a++; //incrementacja po
            a += 5; //incrementacja o 5
            a *= 2; //iloczyn przez 2 (skrócone a = a *2)
            a -= 6; //zmniejsz o 6
            a /= 2;  //iloraz przez 2

            bool czyMniejsze = a < 5;
            bool czyWieksze = a > 5;

            bool lub = a < 5 || a > 10; // operatory porównania z dodatkowym OR
            bool i = a < 5 && a > 10;   //operatory porównania z dodatkowym AND

            bool rozne = a != 5; //operator różności 

            bool b4 = !(a == 5); //zaprzeczenie porównania w nawiasie
        }
    }
}
