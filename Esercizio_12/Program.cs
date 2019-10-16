using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Totale spesa:");
            double spesa = double.Parse(Console.ReadLine());
            if (spesa < 300)
            {
                double sconto = spesa * 10 / 100;
                double totale = spesa - sconto;
                Console.WriteLine($"il totale è {totale}");
            }
            else if (spesa > 300)
            {
                double sconto = spesa * 20 / 100;
                double totaleMaggiore = spesa - sconto;
                Console.WriteLine($"lo sconto è {totaleMaggiore}");
            }
            Console.ReadLine();
        }
    }
}
