using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_POTENCIA_2
{
    // Exercício H - página 141

    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            string numberB, numberE;
            int b, e, c, p;

            Console.Write("Entre com valor da base: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com valor do expoente: ");
            numberE = Console.ReadLine();

            // convertendo string em inteiro
            b = Int32.Parse(numberB);
            e = Int32.Parse(numberE);

            // Processamento
            p = 1;
            c = 1;
            while (c <= e)
            {
                p = p * b;
                c = c + 1;
            }

            // Exibição
            Console.WriteLine("{0} elevado a {1} = {2}", b, e, p);
        }
    }
}
