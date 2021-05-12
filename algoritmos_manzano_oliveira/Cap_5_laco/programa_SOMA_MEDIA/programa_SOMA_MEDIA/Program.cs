using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_SOMA_MEDIA
{
    // Exercício M - página 142

    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            string number;

            int c = 0;
            int s = 0;
            int m, n;

            // Processamento
            while (c <= 10)
            {
                Console.Write("Entre com valor: ");
                number = Console.ReadLine();
                // convertendo string em inteiro
                n = Int32.Parse(number);
                s = s + n;
                c = c + 1;
                   
            }
            m = s / 10;
            // Exibição
            Console.WriteLine("Soma = {0}. Média = {1}", s, m);
        }
    }
}
