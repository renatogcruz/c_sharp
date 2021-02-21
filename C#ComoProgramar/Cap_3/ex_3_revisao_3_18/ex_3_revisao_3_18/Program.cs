using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_revisao_3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenome,
                sobrenome;

            // lê o prenome
            Console.Write( "Entre com seu prenome: " );
            prenome = Console.ReadLine();

            // lê o sobrenome
            Console.Write("Entre com seu sobrenome: ");
            sobrenome = Console.ReadLine();

            // concatene prenome + nome e imprima resultado
            Console.WriteLine( prenome + " " + sobrenome );
            
        }  // fim do método Main
    }   // fim da classe Programa
}
