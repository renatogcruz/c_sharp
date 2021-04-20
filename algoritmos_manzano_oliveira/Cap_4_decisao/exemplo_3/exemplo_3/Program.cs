using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_3
{
    // Exemplo 3 - página 103

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC;
            double a, b, c;

            // Entrada
            Console.Write("Entre com lado A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com lado B: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com lado C: ");
            numberC = Console.ReadLine();

            // convertendo string para double
            a = Convert.ToDouble(numberA);
            b = Convert.ToDouble(numberB);
            c = Convert.ToDouble(numberC);

            // Processamento
            if (a < b) & (a > c);
            {
                if (b == a) & (b > c);
                    Console.WriteLine("Texto");
            }
                    

        }
    }
}
