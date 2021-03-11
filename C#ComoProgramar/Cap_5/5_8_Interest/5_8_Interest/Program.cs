using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_Interest
{
    // Fig. 5.8: Interesest.cs
    // Calculando juros compostos

    class Program
    {
        static void Main(string[] args)
        {
            decimal amount, principal = (decimal)1000.00;
            double rate = 0.50;
            string output;

            output = "Year\tAmount on deposit\n";

            for (int year = 1; year <= 10; year++)
            {
                amount = principal *
                    (decimal)Math.Pow(1.0 + rate, year);

                output += year + "\t" +
                    String.Format("{0:C}", amount) + "\n";
            }

            Console.WriteLine(output, "Compound Interest");
        }
    }
}
