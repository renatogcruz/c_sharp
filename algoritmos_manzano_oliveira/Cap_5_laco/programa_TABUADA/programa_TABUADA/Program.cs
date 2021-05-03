using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_TABUADA
{
    // Exercício B - página 141

    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int n, cont, tab;

            // Entrada
            Console.Write("Entre com valor de N: ");
            number = Console.ReadLine();

            // convertendo String em Integer
            n = Int32.Parse(number);

            // Processamento
            cont = 0;

            while (cont <= 10)
            {
                tab = n * cont;
                Console.WriteLine("{0} x {1} = {2}", n, cont, tab);
                cont = cont + 1;
            }



        }
    }
}
