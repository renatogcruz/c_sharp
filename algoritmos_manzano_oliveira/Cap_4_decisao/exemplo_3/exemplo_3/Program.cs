using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_3
{
    // Leia 3 valores e diga se é um triângulo (qual tipo) ou não
    // Exemplo 3 - página 103

    class Program
    {
        static void Main(string[] args)
        {
            string ladoA, ladoB, ladoC;
            double a, b, c;

            // Entrada
            Console.Write("Entre com o lado A: ");
            ladoA = Console.ReadLine();

            Console.Write("Entre com o lado B: ");
            ladoB = Console.ReadLine();

            Console.Write("Entre com o lado C: ");
            ladoC = Console.ReadLine();

            // converntendo string para double
            a = Convert.ToDouble(ladoA);
            b = Convert.ToDouble(ladoB);
            c = Convert.ToDouble(ladoC);

            // Processamento
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                    Console.WriteLine("Triângulo Equilátero");
                else
                {
                    if (a == b || a == c || c == b)
                        Console.WriteLine("Triângulo Isósceles");
                    else
                        Console.WriteLine("Triângulo Escaleno");
                }
            }                
            else
                Console.WriteLine("Não é um triângulo");                 
                                               
            


        }
    }
}
