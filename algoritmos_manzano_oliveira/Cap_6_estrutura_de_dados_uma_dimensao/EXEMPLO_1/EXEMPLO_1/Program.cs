using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXEMPLO_1
{
    // Exemplo 1 - página 152

    class Program
    {
        //Declaração da lista
        List<int> valores = new List<int>();

        static void Main(string[] args)
        {

            for (int cont = 1; cont < 2; cont++)
            {
                Console.Write("Entre com valor: ");
                string valor = Console.ReadLine();

                int a = Int32.Parse(valor);

                //Adiciona o item à lista
                valores.Add(a);


            }

        }
    }
}
