using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_4
{
    // exemplo 4 página 105
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n, r2, r3;

            // Entrada
            Console.Write("Entre com valor: ");
            number = Console.ReadLine();

            // convertendo string para integer
            n = Int32.Parse(number);

            // Processamento
            r2 = n % 2;
            r3 = n % 3;

            if (r2 == 0 || r3 == 0)
                     Console.WriteLine(n);           
            

        }
    }
}
