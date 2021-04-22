using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_MEDIA_COM_EXAME
{

    // ex. 3.d - página 109

    class Program
    {
        static void Main(string[] args)
        {
            string notaA, notaB, notaC, notaD, notaE;
            double a, b, c, d, e, media, media_2;

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
            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.Write("Entre com a nota do exame especial: ");
                notaE = Console.ReadLine();

                e = Convert.ToDouble(notaE);

                if (media + e >= 5)
                {
                    Console.WriteLine("Aprovado no Exame Espcial");
                }
                else
                {
                    Console.WriteLine("Reprovado no Exame Especial.");
                }
            }
        }
    }
}
