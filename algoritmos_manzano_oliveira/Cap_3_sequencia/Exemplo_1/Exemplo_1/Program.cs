using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /* Desenvolver programa que efetue a leitura de dois valores inteiros.
     * Processe a operação de adição dos valores e apresente a soma.  
     */

    class Program
    {
        static void Main(string[] args)
        {
            string first,
                second;
            int x,
                a,
                b;


            // Entradas
            Console.Write("Entre com primeiro número: ");
            first = Console.ReadLine();

            Console.Write("Entre com o segundo número: ");
            second = Console.ReadLine();

            // convertendo números string para int
            a = Int32.Parse(first);
            b = Int32.Parse(second);

            // Processamento
            x = a + b;

            // Exibição
            Console.WriteLine("A soma é {0}.", x);
        }
    }
}
