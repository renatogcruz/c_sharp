using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_revisao_fatorial
{
    
    // calculando fatorial

    class Program
    {
        static void Main(string[] args)
        {
            int i, 
                number, 
                fact;

            // Entrada de dados pelo usuário
            Console.Write("Entre com valor: ");
            number = int.Parse(Console.ReadLine());


            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }


            Console.WriteLine("\nO Fatorial do número digitado é: " + fact);
            Console.ReadLine();
                       
        }
    }
}
