using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_1
{
    // Exemplo 1 - página 101

    class Program
    {
        static void Main(string[] args)
        {
            string number;

            double n, r;

            // Entrada
            Console.Write("Entre com valor: ");
            number = Console.ReadLine();

            n = Convert.ToDouble(number);

            // Processamento
            if (n > 0)
                if (n != 5)
                    Console.Write("O valor é {0}", r = Math.Pow(n, (1 / 2)));
            
                else
                    Console.Write("O valor é {0}", r = Math.Pow(n, (1 / 3)));

                







        }
    }
}
