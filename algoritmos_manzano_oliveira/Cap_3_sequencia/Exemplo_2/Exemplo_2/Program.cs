using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_2
{
    /* Elabore um programa que calcule a área de uma circunferencia e apresente
     * a sua medida da área calculado
     */

    class Program
    {
        static void Main(string[] args)
        {
            string raio;

            double a,
                r,
                pi = 3.14159265;

            // Entrada
            Console.Write("Entre com valor do raio: ");
            raio = Console.ReadLine();

            // converntendo string para double
            r = Convert.ToDouble(raio);

            // Processamento
            a = pi * Math.Pow(r, 5);

            // Exibição

            Console.WriteLine("Valor da área igual a {0}", a);


        }
    }
}
