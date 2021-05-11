using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_CELSIUS
{
    // Exercício J - página 142

    class Program
    {
        static void Main(string[] args)
        {
            int c = 10;

            // processamento
            while (c <= 100)
            {
                int f = (c * 9 / 5) + 32;
                Console.WriteLine("{0} ºC. {1} ºF", c, f);
                c += 10;
            }
        }
    }
}
