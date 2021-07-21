using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            // idade = 15.5; // instrução errado, casas decimais em atribuição inteiro

            char resposta = 'S'; // System.Char - ele armazena números

            byte nivelDeAzul = 0xFF; // = 255 em decimal (só números positivos)

            short passageirosVoo = 230; // System.Int16

            int população = 1500; // System.Int32
            
            long populacaoBrasil = 207_660_929; // System.Int64

            sbyte nivelDeBrilho = - 127; // System.Sbyte

            ushort passageirosNavio = 230; // System.UInt16 (não aceita negativo)

            uint estoque = 1500; // System.UInt32

            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64

            

           

        }
    }
}
