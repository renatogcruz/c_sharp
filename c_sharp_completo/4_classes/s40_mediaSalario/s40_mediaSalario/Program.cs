using System;

namespace s40_mediaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double Media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("A média salarial é de " + Media);
           
        }
    }
}
