using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laços iterativos -> estruturas que repetem um bloco de código, determinado número de vezes

            // Laço for

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i é " + i);
            }

            // laço while

            int contador = 3;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            
        }
    }
}
