using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_BreakTest
{
    //  Fig. 5.14: BreakTest.cs
    // Usando a instrução break em uma estrutura for

    class BreakTest
    {
        static void Main(string[] args)
        {

            string output = " ";
            int count;

            for (count = 1; count <= 10; count++)
            {
                if (count == 5)
                    break;         // pula o código restante no laço
                                   // se count == 5

                output += count + " ";

            } // fim do laço

            output += "\nBroke out of loop at count = " + count;

            Console.WriteLine(output, "Demonstrating the break statement");

        } // fim do método Main
    } // fim da classe BreakTest
}
