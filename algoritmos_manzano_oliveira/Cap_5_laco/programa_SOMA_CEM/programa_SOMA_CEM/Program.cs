using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_SOMA_CEM
{
    // exercício C - página 141

    class Program
    {
        static void Main(string[] args)
        {
            int cont, soma;

            // Processamento
            soma = 0;
            cont = 1;

            while (cont <= 100)
            {
                soma = soma + cont;
                cont = cont + 1;
            }

            Console.WriteLine("A soma dos 100 primeiros números é igual a {0}", soma);
        }
    }
}
