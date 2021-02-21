using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_revisao_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1,
                number2,
                number3,
                number4,
                number5;

            // lê numbers
            Console.Write( "Entre com o valor do primeiro número: " );
            number1 = Int32.Parse( Console.ReadLine() );

            Console.Write("Entre com o valor do segundo número: ");
            number2 = Int32.Parse(Console.ReadLine());

            Console.Write("Entre com o valor do terceiro número: ");
            number3 = Int32.Parse(Console.ReadLine());

            Console.Write("Entre com o valor do quarto número: ");
            number4 = Int32.Parse(Console.ReadLine());

            Console.Write("Entre com o valor do quinto número: ");
            number5 = Int32.Parse(Console.ReadLine());

            // mostrar números separadamente
            Console.WriteLine( number1 + " " +
                number2 + " " +
                number3 + " " +
                number4 + " " +
                number5);
        }
    }
}
