using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_revisao_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, // primeiro número 
                number2; // segundo número

            // lê o primeiro número do usuário
            Console.Write( "Entre com o primero número: " );
            number1 = Int32.Parse(Console.ReadLine());

            // lê o segundo número do usuário
            Console.Write("Entre com o segundo número: ");
            number2 = Int32.Parse(Console.ReadLine());

            // soma e mostra os dois números
            Console.WriteLine("A soma de " + number1 + 
                " mais " + 
                number2 + 
                " é " + 
                (number1 + number2) + 
                "!");

            // mostra o produto dos dois números
            Console.WriteLine("O produto de " + number1 +
               " x " +
               number2 +
               " é " +
               (number1 * number2) +
               "!");

            // mostra a diferença dos dois números
            Console.WriteLine("A diferença de " + number1 +
               " menos " +
               number2 +
               " é " +
               (number1 - number2) +
               "!");

            // mostra o quociente dos dois números
            Console.WriteLine("O quociente entre " + number1 +
               " e " +
               number2 +
               " é " +
               (number1 % number2) +
               "!");
        }   // fim do método Main
    }   // fim da classe Programa   
}
