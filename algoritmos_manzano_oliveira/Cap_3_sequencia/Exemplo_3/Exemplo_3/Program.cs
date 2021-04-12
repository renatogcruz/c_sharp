using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_3
{
    // programa que calcule o salário líquido de um professor. (pag. 61)

    class Program
    {
        static void Main(string[] args)
        {
            string horas, valor, percentual;

            int ht;

            double vh, pd, td, sb, sl;

            // Entradas
            Console.WriteLine("Entre com horas trabalhadas: ");
            horas = Console.ReadLine();

            Console.WriteLine("Entre com valor hora: ");
            valor = Console.ReadLine();

            Console.WriteLine("Entre com percentual desconto: ");
            percentual = Console.ReadLine();

            // convertendo strings em double
            ht = Int32.Parse(horas);
            vh = Convert.ToDouble(valor);
            pd = Convert.ToDouble(percentual);

            // Processamento
            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - td;

            // Exibição
            Console.WriteLine("{0} e {1}", sb, sl);

        }
    }
}
