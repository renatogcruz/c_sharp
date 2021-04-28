using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_NOME_SEXO
{
    // ex. 3.m - página 109

    class Program
    {
        static void Main(string[] args)
        {
            char nome, sexo;

            // Entrada
            Console.Write("Entre com seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Entre com o sexo (M/F): ");
            sexo = Console.ReadLine();

            // Converter

            // Processamento
            if (sexo == 'M' || sexo == 'M')
            {
                if(sexo == 'M')
                {
                    Console.WriteLine("Ilmo Sr. {0}", nome);
                }
                else
                {
                    Console.WriteLine("Ilma Sra. {0}", nome);
                }
            }

        }
    }
}
