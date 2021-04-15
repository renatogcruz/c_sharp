using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_SUCESSOR_ANTECESSOR
{
    // ler um valor e apresentar seu antecessor e seu sucessor

    class Program
    {
        static void Main(string[] args)
        {
            string valor;

            int v, s, a;

            // Entrada
            Console.Write("Entre com um valor: ");
            valor = Console.ReadLine();

            // convertendo string para integer
            v = Int32.Parse(valor);

            // Processamento
            s = v + 1;
            a = v - 1;

            // Exibição
            Console.WriteLine("Antecessor = {0}. Sucessor = {1}.", a, s);
        }
    }
}
