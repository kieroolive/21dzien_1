using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12InnePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 While
            while (true)
            {
                break;
            }

            // 2 Do While
            
            do
            {

            } while (true); //sprawdzenie czy powtarzamy działania powyższe
                            //do-while wykona się przynajmniej jeden raz

            // 3 For 
            // przy dużych pętlach for gdzie przetwarzane jest wiele elementów należy unikać pętli <= , >= ze względu na konieczność dokonania dwóch sprawdzeń zamiast jednego
            for (int i = 0; i < 10; i++)
            {

            }

            // 4 Foreach
            string zdanie = "Ala ma kota";

            foreach (var literka in zdanie) //var jest to typ zmiennej bliżej nie określonej. W sytuacji kiedy otrzyma pierwszy raz wartość to ustawi się na taką wartość jaką otrzyma
            {
                
            }

            foreach (char literka in zdanie)
            {
                continue; //przejdź do następnej iteracji. 
            }
        }
    }
}
