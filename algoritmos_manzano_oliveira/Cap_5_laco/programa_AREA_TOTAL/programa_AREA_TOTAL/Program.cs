using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_AREA_TOTAL
{
    class Program
    {
        // Exercício Q - página 142

        static void Main(string[] args)
        {
            // Entrada
            double total = 0;
            double c, l, a;
            string continuar = "s";
            string nome, comprimento, largura;

            // Processamento
            while (continuar == "s")
            {
                Console.Write("Entre com o nome: ");
                nome = Console.ReadLine();

                Console.Write("Entre com a largura: ");
                largura = Console.ReadLine();

                Console.Write("Entre com o comprimento: ");
                comprimento = Console.ReadLine();

                // convertendo string para double
                l = Convert.ToDouble(largura);
                c = Convert.ToDouble(comprimento);

                a = l * c;
                total = total + a;
                Console.Write("Deseja continuar?" );
                continuar = Console.ReadLine();

            }

            // Exibição
            Console.WriteLine("Total de área = {0} m²", total);
        }
    }
}
