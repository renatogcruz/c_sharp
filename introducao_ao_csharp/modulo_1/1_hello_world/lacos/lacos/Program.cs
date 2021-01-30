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

            // Do .. while
            // execução garantida pelo menos uma vez! (executa primeiro e depois testa)

            double j = 10;
            do
            {
                Console.WriteLine("Valor de j é " + j);
                j = j * 1.5;
            } while (j < 100);

            // 
        }
    }
}
