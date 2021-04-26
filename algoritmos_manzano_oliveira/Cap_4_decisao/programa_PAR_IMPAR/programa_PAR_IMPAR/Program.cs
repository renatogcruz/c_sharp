using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_PAR_IMPAR
{
    // ex. 3.j - página 109

    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n, resto2;

            // Entrada
            Console.Write("Entre com valor de N: ");
            number = Console.ReadLine();

            // convertendo string em integer
            n = Int32.Parse(number);

            // Processamento
            resto2 = n % 2;
            if (resto2 == 0)
            {
                Console.WriteLine("{0} é par!", n);
            }
            else
            {
                Console.WriteLine("{0} é ímpar!", n);
            }
            

        }
    }
}
