using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_Sum
{
    // Fig.: Sum.cs
    // Soma com a estrutura for.
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int number = 2; number <= 100; number += 2)
                sum += number;

            Console.WriteLine("The sum is " + sum);

        } // fim do metodo Main
    } // fim da classe Sum
}
