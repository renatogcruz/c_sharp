using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_ForCounter
{
    // Fig. 5.2: ForCounter.cs
    // Repetição controlada por contador com a estrutura for.

    class Program
    {
        static void Main(string[] args)
        {
            // inicialização, condição de repetição e incremento
            // todos estãi incluídos na estrutura for
            for (int counter = 1; counter <= 5; counter++)
                Console.WriteLine(  counter);
                       
        } // fim Main
    } // fim classe Program
}
