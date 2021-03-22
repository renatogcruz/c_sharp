using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_DoWhileLoop
{
    // Fig. 5.12: DoWhileLoop.cd
    // A estrutura de repetição do/while

    class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 5);

        } // fim do método Main
    } // fim da classe DoWhileLoop
}
