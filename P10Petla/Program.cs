using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Petla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            while (k < 10)
            {
                //pętla while jest najbardziej optymalną pętlą
                k++;
                Console.WriteLine(k);
            }
            Console.ReadKey();

            string rownanie = "10 200";
            int pozycjaSpacji = -1;
            int i = 0;

            while(i < rownanie.Length)
            {
                if(rownanie.Substring(i,1) == " ")
                {
                    pozycjaSpacji = i;
                }
                i++;
            }

            //powyższa funkcja działa jako last occurance. aby działała identycznie jak indexOf należy dołożyć do if break który przerwie pętle
        }
    }
}
