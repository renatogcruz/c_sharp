using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_CONVERSÃO
{
    // programa converte dólar para real

    class Program
    {
        static void Main(string[] args)
        {
            string cotacao, dolar;

            double c, d, r;

            // Entrada
            Console.Write("Entre com valor em dólares: ");
            dolar = Console.ReadLine();

            Console.Write("Entre com a cotação do dólar: ");
            cotacao = Console.ReadLine();

            // convertendo string para double
            d = Convert.ToDouble(dolar);
            c = Convert.ToDouble(cotacao);

            // Processamento
            r = d * c;

            // Exibição
            Console.WriteLine("O valor em real é de R$ {0}", r);
        }
    }
}
