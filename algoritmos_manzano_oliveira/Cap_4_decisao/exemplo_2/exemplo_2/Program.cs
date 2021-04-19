using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_2
{
    // Exmplo 2 página 102

    class Program
    {
        static void Main(string[] args)
        {
            string numberA, numberB, numberC;
            int a, b, c, x;

            // Entrada
            Console.Write("Entre com peso de A: ");
            numberA = Console.ReadLine();

            Console.Write("Entre com peso de B: ");
            numberB = Console.ReadLine();

            Console.Write("Entre com peso de C: ");
            numberC = Console.ReadLine();

            // converntendo string para integer
            a = Int32.Parse(numberA);
            b = Int32.Parse(numberB);
            c = Int32.Parse(numberC);

            // Processamento
            x = a;
            if (x < b)
                x = b;
            if (x < c)
                x = c;

            // Exibição
            Console.WriteLine("Maior peso = {0}", x);
        }
    }
}
