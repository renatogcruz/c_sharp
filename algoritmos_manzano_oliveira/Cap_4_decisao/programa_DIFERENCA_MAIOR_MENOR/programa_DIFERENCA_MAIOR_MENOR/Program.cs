using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_DIFERENCA_MAIOR_MENOR
{
    // exercicio 3.a - página 108

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB;
            int a, b, r;

            // Entrada
            Console.Write("Entre com valor de A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            numberB = Console.ReadLine();

            // converter string para integer
            a = Int32.Parse(numberA);
            b = Int32.Parse(numberB);

            // Processamento
            if (a > b)
                r = a - b;
            else
                r = b - a;

            // Exibição
            Console.WriteLine("A diferença é de {0}", r);
        }
    }
}
