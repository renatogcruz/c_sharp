using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ImpressoraCopiadora : IImpressora, ICopiar
    {
        public string Copiar(string texto)
        {
            Console.WriteLine();
            return $"Copiando texto: {texto}";
        }

        public string Imprimir(string texto)
        {
            Console.WriteLine();
            return $"Imprimindo texto: {texto}";
        }
    }
}
