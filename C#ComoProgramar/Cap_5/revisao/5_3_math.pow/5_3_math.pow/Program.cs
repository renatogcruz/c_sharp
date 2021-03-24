using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_math.pow
{
    // 5.3 b calcule valor de 2, 5 elevado à potencia de 3 usando o método Math.Pow
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Potencia de 2 elevado a 3 = " + Math.Pow(2, 3));
            Console.WriteLine("Potencia de 5 elevado a 3 = " + Math.Pow(5, 3));

            int x = 1;

            while (x <= 20)
            {
                Console.Write(x);
                if (x % 5 == 0)
                    Console.WriteLine();
                else
                    Console.Write('\n');
                ++x;
            }

            for (x = 1; x <= 20; x++)
            {
                Console.Write(x);
                if(x % 5 == 0)
                    Console.WriteLine();
                else
                    Console.Write('\t');
            }
        }
    }
}
