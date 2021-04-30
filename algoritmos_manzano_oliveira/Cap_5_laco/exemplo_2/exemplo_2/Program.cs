using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat, cont;

            // processamento
            fat = 1;
            cont = 1;

            while (! (cont > 5))
            {
                fat = fat * cont;
                cont = cont + 1;
            }

            // exibição
            Console.WriteLine("5! = {0}", fat);
        }
    }
}
