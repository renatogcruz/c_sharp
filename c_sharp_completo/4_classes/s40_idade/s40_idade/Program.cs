using System;

namespace s40_idade
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Idade p1 = new Idade();
            Idade p2 = new Idade();
            
            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Anos = int.Parse(Console.ReadLine());

            if (p1.Anos > p2.Anos)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}
