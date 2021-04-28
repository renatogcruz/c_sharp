using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_MAIOR_30
{
    // ex. 3.o - página 110

    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n, resultado;

            // Entrada
            Console.Write("Entro com valor qualquer: ");
            number = Console.ReadLine();

            // convertendo string em integer
            n = Int32.Parse(number);

            // Processamento
            resultado = n * 2;
            if (resultado > 30)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}
