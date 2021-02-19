using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercícios de revisão capítulo 3 - página 124

namespace ex_3_revisao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a - exiba a mensagem "Enter two numbers"
            Console.WriteLine("Enter two numbers");

            // b - 
            int b, 
                c, 
                soma, 
                a;

            b = 10;
            c = 15;

            soma = b + c;
            a = soma;

            Console.WriteLine( "\nA soma de " + b + " + " + c + " é igual a "  + a + ".");

            // c - informe ao programa que este é um exemplo de folha de pagamento. (é apenas para escrever como comentário).

            // 3.4

            int x,
                y;

            x = 2;
            y = 3;

            Console.WriteLine( "x = " + x );
            Console.WriteLine( "The value of x + x is " + (x + x) );
            Console.WriteLine( "x = " );
            Console.WriteLine( ( x + y ) + " = " + (y + x ));

            // 3.5 dado y = a.x³ + 7, qual instrução corresponde a essa equação?
            // a resposta é y = a * ( x *x * x ) + 7 -> primeiro parenteses, depois multiplicação e por fim, a soma




        }
    }
}
