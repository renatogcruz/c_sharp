using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_SOMA_MEDIA_TOTAL
{
    // exercício N - página 142

    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            string number;
            int total = 0;
            int soma = 0;
            int n = 0;
            int media = 0;

            // Processamento
            while (n >= 0)
            {
                Console.Write("Entre com valor: ");
                number = Console.ReadLine();

                // converntendo string para inteiro
                n = Int32.Parse(number);

                if (n >= 0)
                {
                    soma = soma + n;
                    total = total + 1;
                }
                                
            }

            if (total > 0)
            {
                media = soma / total;
            }

            Console.WriteLine("Média = {0}. Total = {1}. Soma = {2}", media, total, soma);
                         
        }
    }
}
