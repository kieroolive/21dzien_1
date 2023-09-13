using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P09Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfrę");
            int cyfra = Convert.ToInt32(Console.ReadLine());

            switch (cyfra)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                default:
                    Console.WriteLine("inna");
                    break;
            }
        }
    }
}
