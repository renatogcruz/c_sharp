using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_2_soma
{
    class Addition
    {
        static void Main(string[] args)
        {
            string firstNumber,  // primeira string fornecida pelo usuário
                   secondNumber; // segunda string fornecida pelo usuário

            int number1, number2, sum; // primeiro num a somar; segundo a somar e soma.

            // Solicita e lê o primeiro número de usuário como string
            Console.WriteLine( "Please enter the first integer: " );
            firstNumber = Console.ReadLine();

            // Solicita e lê o segundo número do usuário como string
            Console.WriteLine( "\nPlease enter the second integer: " );
            secondNumber = Console.ReadLine();

            // Converte números de tipo string para tipo int
            number1 = Int32.Parse(firstNumber);
            number2 = Int32.Parse(secondNumber);

            // Soma os números
            sum = number1 + number2;

            // Exibe o resultado
            Console.WriteLine("\nThe sum is {0}.", sum);
            Console.WriteLine("\nThe sum of {0} and {1} is {2}.", number1, number2, sum);

        } // fim do método Main
    } // fim da classe Addition
}
