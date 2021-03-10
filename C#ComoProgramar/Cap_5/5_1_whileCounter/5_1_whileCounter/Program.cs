using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_whileCounter
{
    // Fig. 5.1: WhileCounter.cs
    // Repetição controlada por contador

    class Program
    {
        static void Main(string[] args)
        {
            // inicialização
            int counter = 1;

            // condição de repetição
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                // incrementa
                counter++;
            } // fim do while
        } // fim do método Main
    } // fim da classe Program
}
