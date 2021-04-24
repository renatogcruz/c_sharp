using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_CRESCENTE
{
    // Ex. 3.f - pág. 109

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC;
            int a, b, c, x;

            // Entrada
            Console.Write("Entre com primeiro valor: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com segundo valor: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com terceiro valor: ");
            numberC = Console.ReadLine();

            // convertendo string -> integer
            a = Int32.Parse(numberA);
            b = Int32.Parse(numberB);
            c = Int32.Parse(numberC);

            // Processamento
            if (a > b)
            {
                x = a;
                a = b;
                b = x;
            }
            if (a > c)
            {
                x = a;
                a = c;
                c = x;
            }
            if (b > c)
            {
                x = b;
                b = c;
                c = x;
            }

            // Exibição
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
