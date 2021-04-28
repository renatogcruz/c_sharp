using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_MAIOR_IGUAL_100
{
    // ex. 3.n - página 110

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC;
            int a, b, c, soma;

            // Entrada
            Console.Write("Entre com valor de A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com valor de C: ");
            numberC = Console.ReadLine();

            // converter string em inteiro
            a = Int32.Parse(numberA);
            b = Int32.Parse(numberB);
            c = Int32.Parse(numberC);

            // Processamento
            soma = a + b + c;
            if (soma >= 100)
            {
                Console.WriteLine(soma);
            }

        }
    }
}
