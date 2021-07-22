using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            bool possuiSaldo = true;
            Console.WriteLine(possuiSaldo);

            int dias = DateTime.Now.Day;
            Console.WriteLine(dias);

            bool diasPar = (dias % 2 == 0);
            Console.WriteLine(diasPar);
            
        }
    }
}
