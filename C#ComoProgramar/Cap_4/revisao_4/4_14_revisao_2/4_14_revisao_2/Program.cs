using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_revisao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor,             // valor a ser digitado pelo usuário
                v_referencia,
                reverso = 0,       // valor escrito ao contrário
                rem;               // 

            // entrada
            Console.Write("Entre com valor: ");
            valor = Int32.Parse(Console.ReadLine());

            v_referencia = valor;

            // invertendo valor
            while (v_referencia != 0)
            {
                rem = v_referencia % 10;
                reverso = reverso * 10 + rem;
                v_referencia /= 10;
            }

            Console.WriteLine("valor: " + valor);
            Console.WriteLine("Reverso: " + reverso);

            // comparação
            if (valor == reverso)
            {
                Console.WriteLine("É palíndromo");
            }
            else
            {
                Console.WriteLine("Não é palíndromo");
            }
        }
    }
}
