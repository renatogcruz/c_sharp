using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            var c = new ImpressoraCopiadora();
           

            Console.WriteLine(i.Imprimir("Estou estudando c#"));
            Console.WriteLine(i2.Copiar("Estou estudando C# e gostando"));

            CopiarDocumento(new Xerox(), "Hello, world");

            EscanearDocumento(new Multifuncional(), "Escanenado");
        }

        public static void CopiarDocumento(ICopiar c, string texto)
        {
            Console.WriteLine("Estou copiando o texto: " + c.Copiar(texto));
        }

        public static void EscanearDocumento(IEscaneadora i, string texto)
        {
            Console.WriteLine("Estou copiando o texto: " + i.Escanear(texto));
        }
    }
}
