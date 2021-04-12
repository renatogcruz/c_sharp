using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_4
{
    // programa que faça a entrada do nome de uma pessoa e seu sexo e apresente os dados

    class Program
    {
        static void Main(string[] args)
        {
            string nome,
                sexo;

            Console.WriteLine("Entre com seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Entre com seu sexo: ");
            sexo = Console.ReadLine();

            // Exibição
            Console.WriteLine("Nome: {0}. Sexo: {1}.", nome, sexo);
        }
    }
}
