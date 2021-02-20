using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_revisao_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio,         // número do raio do círculo
                   dim,          // número do diâmetro do círculo
                   circ,         // número da circunferência do círculo
                   area,         // número da área do círculo
                   pi = 3.14;    // valor de Pi                

            // lê o raio do usuário
            Console.Write("Entre com o número do raio da circunfêrencia: ");
            raio = double.Parse(Console.ReadLine());
            
            // diâmetro do círculo
            dim = 2 * raio;
            Console.WriteLine( "O diâmetro do círculo é " + dim + " !" );

            // circunferência do círculo
            circ = 2 * raio * pi;
            Console.WriteLine( "A circunferência do círculo é " + circ + " !" );

            // mostra a diferença dos dois números
            area = pi * (Math.Pow(raio, 2));
            Console.WriteLine( "A área do círculo é " + dim + " !" );                       
                        
        }  // fim do método Main
    }   // fim da classe Programa
}
