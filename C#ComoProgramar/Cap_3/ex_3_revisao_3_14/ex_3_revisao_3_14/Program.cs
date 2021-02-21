using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_revisao_3_14
{
    class Multiplo
    {
        static void Main(string[] args)
        {
            int number1,
                number2;
                

            // lê o primeiro número
            Console.Write( "Entre com o primeiro número: " );
            number1 = Int32.Parse( Console.ReadLine() );

            // lê o segundo número
            Console.Write("Entre com o segundo número: ");
            number2 = Int32.Parse(Console.ReadLine());

            // verifique se o primeiro é multiplo o segundo
            if ( number1 % number2 == 0)
            {
                Console.WriteLine( "O número {0} é multiplo do número {1}",  number1, number2 );
            }
            else
            {
                Console.WriteLine( "O número {0} não é multiplo do número {1}", number1, number2 );
            }

        }   // fim do método Main
    }   // fim da classe Multiplo
}
