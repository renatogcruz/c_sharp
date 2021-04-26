using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_MAIOR_MENOR
{
    // ex. 3.i - página 109

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC, numberD, numberE;
            int a, b, c, d, e, maior, menor;

            // Entrada
            Console.Write("Entre com valor de A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com valor de C: ");
            numberC = Console.ReadLine();

            Console.Write("Entre com valor de D: ");
            numberD = Console.ReadLine();

            Console.Write("Entre com valor de E: ");
            numberE = Console.ReadLine();

            // convertendo string em integer
            a = Int32.Parse(numberA);
            b = Int32.Parse(numberB);
            c = Int32.Parse(numberC);
            d = Int32.Parse(numberD);
            e = Int32.Parse(numberE);

            // Processamento
            maior = a;
            if (maior < b)
            {
                maior = b;
            }
            if (maior < c)
            {
                maior = c;
            }
            if (maior < d)
            {
                maior = d;
            }
            if (maior < e)
            {
                maior = e;
            }

            menor = a;
            if (menor > b)
            {
                menor = b;
            }
            if (menor > c)
            {
                menor = c;
            }
            if (menor > d)
            {
                menor = d;
            }
            if (menor > e)
            {
                menor = e;
            }

            // Exibição
            Console.WriteLine("Maior: {0}. Menor: {1}", maior, menor);

        }
    }
}
