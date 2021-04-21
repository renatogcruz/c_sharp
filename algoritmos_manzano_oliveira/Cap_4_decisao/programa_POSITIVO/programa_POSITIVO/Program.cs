using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_POSITIVO
{
    // exercício 3.b - pág. 108
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n;

            // Entrada
            Console.Write("Entre com valor inteiro (positivo ou negativo): ");
            number = Console.ReadLine();

            // convertendo string para integer
            n = Int32.Parse(number);

            // Processamento
            if (n < 0)
                n = n * -1;

            // Exibição
            Console.WriteLine("O valor é {0}", n);
        }
    }
}
