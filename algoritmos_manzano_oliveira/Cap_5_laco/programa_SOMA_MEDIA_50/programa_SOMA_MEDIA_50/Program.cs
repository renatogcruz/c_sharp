using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_SOMA_MEDIA_50
{
    // Exercício P - página 142
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            int soma = 0;
            int quantidade = 0;
            int contador = 50;
            int media;

            // Processamento
            while (contador <= 70)
            {
                soma = soma + contador;
                contador = contador + 1;
                quantidade = quantidade + 1;
            }
            media = soma / quantidade;

            // Exibição
            Console.WriteLine("Soma = {0}. Média = {1}", soma, media);
        }
    }
}
