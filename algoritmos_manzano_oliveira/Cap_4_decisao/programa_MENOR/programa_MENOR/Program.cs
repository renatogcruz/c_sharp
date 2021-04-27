using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_MENOR
{
    // Ex. 3.l - página 109

    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n;

            // Entrada
            Console.Write("Entre com valor qualquer: ");
            number = Console.ReadLine();

            // convertendo string em inteiro
            n = Int32.Parse(number);

            // Processamento
            if (! (n > 3))
            {
                Console.WriteLine(n);
            }

       
        }
    }
}
