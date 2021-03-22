using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_15_ContinueTest
{
    // Fig. 5.15: ContinueTest.cs
    // Usando a instrução continue em uma estrutura for

    class ContinueTest
    {
        static void Main(string[] args)
        {
            string output = "";

            for (int count = 1; count <= 10; count++)
            {
                if (count == 5)
                    continue;                         // pula o código restane no laço
                                                      // apenas se count == 5
                output += count + " ";                                      
            }

            output += "\nUsed continue to skip printing 5";
            Console.WriteLine(output, "Using the continue statement");
        } // fim do método Main        

    } // fim da classe ContinueTest
}
