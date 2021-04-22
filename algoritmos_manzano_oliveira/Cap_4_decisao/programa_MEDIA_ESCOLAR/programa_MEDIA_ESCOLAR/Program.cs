using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_MEDIA_ESCOLAR
{

    // ex. 3.c - pág. 108

    class Program
    {
        static void Main(string[] args)
        {
            string notaA, notaB, notaC, notaD;

            double a, b, c, d, media;

            // Entrada
            Console.Write("Entre com a nota A: ");
            notaA = Console.ReadLine();

            Console.Write("Entre com a nota B: ");
            notaB = Console.ReadLine();

            Console.Write("Entre com a nota C: ");
            notaC = Console.ReadLine();

            Console.Write("Entre com a nota D: ");
            notaD = Console.ReadLine();

            // converntendo string para double
            a = Convert.ToDouble(notaA);
            b = Convert.ToDouble(notaB);
            c = Convert.ToDouble(notaC);
            d = Convert.ToDouble(notaD);

            // Processamento
            media = (a + b + c + d) / 4;
            if (media >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
                
        }
    }
}
