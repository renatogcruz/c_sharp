using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_FATORIAL
{
    // Exercício O - página 142

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            int r;
            int fat;

            // Processamento
            while (i <= 10)
            {
                r = i % 2;
                if (r != 0)
                {
                    fat = 1;
                    j = 1;
                    while (j <= i)
                    {
                        fat = fat * j;
                        j = j + 1;
                    }
                    Console.WriteLine("{0}! = {1}", i, fat);
                }

                i = i + 1;
            }
            
        }
    }
}
