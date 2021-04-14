using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_VALORES_TROCADOS
{
    class Program
    {
        // leia dois valores e troque para que um possua o valor do outro

        static void Main(string[] args)
        {
            string valor_a, valor_b;

            int a, b, x;

            // Entrada
            Console.Write("Entre com valor de A: ");
            valor_a = Console.ReadLine();

            Console.Write("Entre com valor de B: ");
            valor_b = Console.ReadLine();

            // convertendo string para integer
            a = Int32.Parse(valor_a);
            b = Int32.Parse(valor_b);

            // Processamento
            x = a;
            a = b;
            b = x;

            // Exibição
            Console.WriteLine("A = {0}. B = {1}.", a, b);
        }
    }
}
