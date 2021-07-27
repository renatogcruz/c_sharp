using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
           int pontuacao = 10;
           Console.WriteLine($"pontuacao: {pontuacao}");

           Console.WriteLine("Object com valor primitivo");
           object meuObjeto;
           meuObjeto = pontuacao;
           Console.WriteLine($"meuObjeto: {meuObjeto}");

            
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
