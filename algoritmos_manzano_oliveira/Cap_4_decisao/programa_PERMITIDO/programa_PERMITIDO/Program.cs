using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_PERMITIDO
{
    // Ex. 3.k - página 109

    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n;

            // Entrada
            Console.Write("Entre com valor (1 até 9): ");
            number = Console.ReadLine();

            // convertendo
            n = Int32.Parse(number);

            // Processamento
            if (n > 0 && n < 10)
            {
                Console.WriteLine("Valor dentro da faixa permitida!");
            }
            else
            {
                Console.WriteLine("Valor fora da faixa permitida!");
            }
        }
    }
}
