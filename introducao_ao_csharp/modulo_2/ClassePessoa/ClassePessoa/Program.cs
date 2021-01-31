using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePessoa
{
    class Program // Sem modificador de acesso explícito -> internal por padrão (internal class Program)
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(); // criando pessoa

            // Exibindo atributos da pessoa
            Console.WriteLine("A pessoa tem " + pessoa.Idade + "!");

            // Acessando comportamento da pessoa
            Console.WriteLine(pessoa.Andar());
            Console.WriteLine(pessoa.Comer());
        }
    }
}
