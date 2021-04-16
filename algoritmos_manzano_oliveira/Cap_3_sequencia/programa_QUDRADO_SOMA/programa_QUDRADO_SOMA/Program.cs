using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_QUDRADO_SOMA
{
    // Leia 3 valores e apresente o quadrado de suas somas (ex. 4.m - pág. 65)

    class Program
    {
        static void Main(string[] args)
        {
            string valor_a, valor_b, valor_c;
            double a, b, c, r;

            // Entrada
            Console.Write("Entre com valor de A: ");
            valor_a = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            valor_b = Console.ReadLine();

            Console.Write("Entre com valor de C: ");
            valor_c = Console.ReadLine();

            // convertendo string em integer
            a = Convert.ToDouble(valor_a);
            b = Convert.ToDouble(valor_b);
            c = Convert.ToDouble(valor_c);

            // Processamento
            r = Math.Pow((a + b + c), 2);

            // Exibição
            Console.WriteLine("O valor do quadrado é {0}.", r);


        }
    }
}
