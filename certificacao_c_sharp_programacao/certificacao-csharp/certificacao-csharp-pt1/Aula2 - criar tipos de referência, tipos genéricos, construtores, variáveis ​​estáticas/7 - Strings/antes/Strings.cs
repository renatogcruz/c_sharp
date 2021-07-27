using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = "b";

            // Adicionar ao conteúdo de "b"
            b = b + "om dia";
            Console.WriteLine($"a == b: {a == b}");
        }
    }
}
