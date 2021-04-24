using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_BHASKARA
{
    // ex. 3.e - pág. 109

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC;
            double a, b, c, d, x1, x2;

            // Entrada
            Console.Write("Entre com primeiro valor: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com segundo valor: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com terceiro valor: ");
            numberC = Console.ReadLine();

            // convertendo string para double
            a = Convert.ToDouble(numberA);
            b = Convert.ToDouble(numberB);
            c = Convert.ToDouble(numberC);

            // Processamento
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Não há solução!");
            }

            d = Math.Pow(b, 2) - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine(x1);
            }
            else
            {
                if (d > 0)
                {
                    x1 = -b / (2 * a);
                    x2 = b / (2 * a);
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
                else
                {
                    Console.WriteLine("Não existe raizes reais!");
                }
            }


        }
    }
}
