using System;

namespace s40_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
