using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_14_increment
{
    // Fg. 4.14: Increment.cs
    // Pré-incremento e pós-incremento

    class Program
    {
        static void Main(string[] args)
        {
            int c;

            c = 5;
            Console.WriteLine( c );      // imprime 5
            Console.WriteLine( c++ );    // imprime 5 e depois pós-incrementa
            Console.WriteLine( c );      // imprime 6

            Console.WriteLine();         // pula uma linha

            c = 5;
            Console.WriteLine( c );      // imprime 5
            Console.WriteLine( ++c );    // pré-incremneta e depois imprime 6
            Console.WriteLine( c );      // imprime 6

        } // fim do método Main
    } // fim da classe Increment
}
