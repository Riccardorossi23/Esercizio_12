using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_12
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Costo spesa:");
            double spesa = double.Parse(Console.ReadLine());
            Console.WriteLine(" Costo spesa2:");
            double spesa2 = double.Parse(Console.ReadLine());
            if(spesa<2456)
            {
                double sconto = spesa * 95 / 100;
                double totaleM = spesa - sconto;
                Console.WriteLine($"il totale è {totaleM}");
            }
            else if(spesa >2456)
            {
               Console.WriteLine($"lo scontonon puo essere effettuato");
            }
            if (spesa > 1600)
                {
                    double sconto = spesa * 95 / 100;
                    double totale = spesa - sconto;
                    Console.WriteLine($"il totale è {totale}");
                }
                else if (spesa <= 1600)
                {
                    double sconto = spesa * 45 / 100;
                    double totaleMaggiore = spesa - sconto;
                    Console.WriteLine($"lo sconto è {totaleMaggiore}");
                }
            
            Console.ReadLine();
        }
    }
}
