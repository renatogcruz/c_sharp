using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_DIVISIVEL_4
{
    // Exercício f - página 141

    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int resto;

            // Processamento
            while (cont <= 199)
            {
                resto = cont % 4;
                if (resto == 0)
                {
                    Console.WriteLine(cont);
                }
                cont += 1;
            }
        }
    }
}
