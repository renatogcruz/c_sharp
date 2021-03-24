using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_exercicio_revisao
{
    // Exercicios de revisão capítulo 5 - página 195

    class Program
    {
        static void Main(string[] args)
        {
            // some inteiros ímpares entre 1 e 99 usando a estrutura for
            int sum,
                count;

            sum = 0;            

            for (count = 1; count <= 99; count += 2)
            {
                sum += count;
            }

            Console.WriteLine("Soma = " + sum);
        }
    }
}
