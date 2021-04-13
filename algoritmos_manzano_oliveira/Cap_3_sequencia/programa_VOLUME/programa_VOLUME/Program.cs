using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_VOLUME
{
    class Program
    {

        // calcular e apresentar volume de lata de óleo

        static void Main(string[] args)
        {

            string altura, raio;

            double v, r, h;

            // Entrada
            Console.Write("Entre com o raio da lata: ");
            raio = Console.ReadLine();

            Console.Write("Entre com a altura da lata: ");
            altura = Console.ReadLine();

            // convertendo string para double
            r = Convert.ToDouble(raio);
            h = Convert.ToDouble(altura);

            // Processamento
            v = 3.14 * Math.Pow(r, 2) * h;

            // Exibição
            Console.WriteLine("O volume da lata é de {0}.", v);

        }
    }
}
