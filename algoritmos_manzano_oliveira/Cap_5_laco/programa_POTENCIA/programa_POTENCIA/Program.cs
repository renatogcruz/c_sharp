using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_POTENCIA
{
    // Exercício F - página 141

    class Program
    {
        static void Main(string[] args)
        {
            double b = 3;
            double cont = 0;
            double resultado;

            // Processamento
            while (cont <= 15)
            {
                resultado = Math.Pow(b, cont);
                Console.WriteLine("{0} elevado a {1} = {2}", b, cont, resultado);
                cont += 1;
            }


        }
    }
}
