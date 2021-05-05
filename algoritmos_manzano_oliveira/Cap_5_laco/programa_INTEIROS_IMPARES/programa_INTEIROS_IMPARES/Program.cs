using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_INTEIROS_IMPARES
{
    //Exercício E - página 141

    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int resto;


            while (cont <= 20)
            {
                resto = cont % 2;
                if (resto != 0)
                {
                    Console.WriteLine(cont);
                }
                cont += 1;
            }
        }
    }
}
