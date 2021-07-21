using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;            
            Console.WriteLine(idade);
            
            int copiaIdade = idade;
            // mouse sobre 'int' e veremos sua documentação
            // int == System.Int32

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"Cópia idade: {copiaIdade}");

            int? idade2 = null; // tipo int? é um tipo anulável
            System.Nullable<int> Idade3 = null; // mesma declaração de cima

        }
    }
}
