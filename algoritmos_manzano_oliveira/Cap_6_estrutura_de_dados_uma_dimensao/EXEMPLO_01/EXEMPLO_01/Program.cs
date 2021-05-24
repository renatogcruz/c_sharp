using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEMPLO_01
{
    // Exemplo 1 - página 152

    class Program
    {
        static void Main(string[] args)
        {
            
            for (int contador = 1; contador < 10; contador++)
            {
                Console.Write("Entre com valor: ");
                string a = Console.ReadLine();
            }

            Console.WriteLine(a);

        }
    }
}
