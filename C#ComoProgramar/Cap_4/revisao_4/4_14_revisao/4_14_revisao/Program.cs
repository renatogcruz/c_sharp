using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_revisao
{
    // palíndromo
    class Program
    {
        static void Main(string[] args)
        {
            int valor,             // valor a ser digitado pelo usuário
                reverso = 0,       // valor escrito ao contrário
                rem;               // 

            // entrada
            Console.Write("Entre com valor: ");
            valor = Int32.Parse(Console.ReadLine());

            // invertendo valor
            while (valor != 0)
            {
                rem = valor % 10;
                reverso = reverso * 10 + rem;
                valor /= 10;                
            }

            Console.WriteLine("valor: " + valor);
            Console.WriteLine("Reverso: " + reverso);

            // comparação
            if (valor == reverso)
            {
                Console.WriteLine("É palíndromo");
            }
            
                

        }
    }
}
