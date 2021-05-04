using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_SOMA_500
{
    // Exercício D - página 141

    class Program
    {
        static void Main(string[] args)
        {
            int cont, soma, resultado;
            // processamento
            cont = 1;
            soma = 0;

            while (cont <= 500)
            {
                resultado = cont % 2;
                if (resultado == 0)
                {
                    soma = soma + cont;
                }
                cont = cont + 1;
            }
            // Exibição
            Console.WriteLine("A soma dos pares é igual a {0}", soma);
        }
    }
}
