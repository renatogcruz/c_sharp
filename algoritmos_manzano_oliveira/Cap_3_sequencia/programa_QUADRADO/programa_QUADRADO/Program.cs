using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_QUADRADO
{
    // leia 2 valores (A, B) e apresente o quadrado do resultado da divisão de A por B

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB;

            double a, b, d, r;

            // Entrada
            Console.Write("Entre com valor de A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            numberB = Console.ReadLine();

            // convertendo string para integer
            a = Convert.ToDouble(numberA);
            b = Convert.ToDouble(numberB);

            // Processamento
            d = a / b;
            r = Math.Pow(d, 2);

            // Exibição
            Console.WriteLine("O quadrado da divisão é igual a {0}", r);

        }
    }
}
