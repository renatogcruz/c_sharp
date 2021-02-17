using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fig. 3.19: Comparison.cs
// Usando instruções if, operadores relacionais e operadores de igualdade

namespace ex_3_3_comparacao
{
    class Comparison
    {
        static void Main(string[] args)
        {
            int number1, // primeiro número a comparar
                number2; // segundo número a comparar

            // lê o primeiro número do usuário
            Console.WriteLine("Please enter first integer: ");
            number1 = Int32.Parse(Console.ReadLine());

            // lê o segundo número do usuário
            Console.WriteLine("Please enter first integer: ");
            number2 = Int32.Parse(Console.ReadLine());

            if ( number1 == number2 )
                Console.WriteLine(number1 + " == " + number2);

            if ( number1 != number2 )
                Console.WriteLine(number1 + " != " + number2);

            if ( number1 < number2 )
                Console.WriteLine(number1 + " < " + number2);

            if ( number1 > number2 )
                Console.WriteLine(number1 + " > " + number2);

            if ( number1 <= number2 )
                Console.WriteLine(number1 + " <= " + number2);

            if ( number1 >= number2 )
                Console.WriteLine(number1 + " >= " + number2);
                        
        } // fim do método Main
    } // fim da classe Comparison
}
