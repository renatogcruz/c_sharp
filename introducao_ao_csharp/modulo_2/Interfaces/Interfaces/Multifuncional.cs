using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Multifuncional : ICopiar, IImpressora, IEscaneadora
    {
        public string Copiar(string texto)
        {
            return $"Copiando texto: {texto}";
        }

        public string Escanear(string texto)
        {
            return $"Escaneando texto: {texto}";
        }

        public string Imprimir(string texto)
        {
            return $"Imprimindo texto: {texto}";
        }
    }
}
