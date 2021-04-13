using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_TEMPERATURA
{
    class Program
    {
        
        // ler temperatura em ºC e converter para F

        static void Main(string[] args)
        {
            string celsius;
                
            double c, // temperatura em ºC
                f;    // temperatura em F

            // Entrada
            Console.Write("Entre com a temperatura em ºC: ");
            celsius = Console.ReadLine();

            // convertendo string para double
            c = Convert.ToDouble(celsius);

            // Processamento
            f = c * 9 / 5 + 32;

            // Exibição
            Console.WriteLine("A temperatura é {0} F.", f);

        }
    }
}
