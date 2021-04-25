using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_DIVISIVEIS_OR
{
    // ex. 3.h - página 109

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC, numberD;
            int a, b, c, d, resto2, resto3;

            // Entrada
            Console.Write("Entre com valor de A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com valor de C: ");
            numberC = Console.ReadLine();

            Console.Write("Entre com valor de D: ");
            numberD = Console.ReadLine();

            // converter string em Integer
            a = Int32.Parse(numberA);
            b = Int32.Parse(numberB);
            c = Int32.Parse(numberC);
            d = Int32.Parse(numberD);

            // Processamento
            resto2 = a % 2;
            resto3 = a % 3;
            if (resto2 == 0 || resto3 == 0)
            {
                Console.WriteLine(a);
            }

            resto2 = b % 2;
            resto3 = b % 3;
            if (resto2 == 0 || resto3 == 0)
            {
                Console.WriteLine(b);
            }

            resto2 = c % 2;
            resto3 = c % 3;
            if (resto2 == 0 || resto3 == 0)
            {
                Console.WriteLine(c);
            }

            resto2 = d % 2;
            resto3 = d % 3;
            if (resto2 == 0 || resto3 == 0)
            {
                Console.WriteLine(d);
            }
        }
    }
}
