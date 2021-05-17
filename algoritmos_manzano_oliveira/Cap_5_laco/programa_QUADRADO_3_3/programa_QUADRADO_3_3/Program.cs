using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_QUADRADO_3_3
{
    // Programa T - página 143

    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            double cont = 15;

            //Processamento
            while (cont <= 200)
            {
                Console.WriteLine(Math.Pow(cont, 2));
                cont = cont + 3;
            }
        }
    }
}
