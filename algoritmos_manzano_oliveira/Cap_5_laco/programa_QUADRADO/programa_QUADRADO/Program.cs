using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_QUADRADO
{
    // exercício A - página 141

    class Program
    {
        static void Main(string[] args)
        {
            double cont, qua;

            cont = 15;

            while (cont <= 200)
            {
                qua = Math.Pow(cont, 2);
                Console.WriteLine("{0}² = {1}", cont, qua);

                cont += 1;
            }
        }
    }
}
