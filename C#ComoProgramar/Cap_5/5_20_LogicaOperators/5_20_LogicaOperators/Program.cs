using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_20_LogicaOperators
{
    // Fig. 5.20: Logica1Operators.cs
    // Demonstrando os operadores lógicos

    class Program
    {
        static void Main(string[] args)
        {
            // testando o operador E condicional (&&)
            Console.WriteLine("Condicional AND (&&)" +
                "\nfalse && false: " + (false && false) +
                "\nfalse && false: " + (false && true) +
                "\nfalse && false: " + (true && false) +
                "\nfalse && false: " + (true && true));

            // testando o operador OU condicional (||)
            Console.WriteLine("\n\nCondicional OR (||)" +
                "\nfalse || false: " + (false || false) +
                "\nfalse || false: " + (false || true) +
                "\nfalse || false: " + (true || false) +
                "\nfalse || false: " + (true || true));

            // testando o operador E lógio (&)
            Console.WriteLine("\n\nLogical AND (&)" +
                "\nfalse & false: " + (false & false) +
                "\nfalse & false: " + (false & true) +
                "\nfalse & false: " + (true & false) +
                "\nfalse & false: " + (true & true));

            // testando o operador OU lógio (|)
            Console.WriteLine("\n\nLogical AND (&)" +
                "\nfalse | false: " + (false | false) +
                "\nfalse | false: " + (false | true) +
                "\nfalse | false: " + (true | false) +
                "\nfalse | false: " + (true | true));

            // testando o operador OU exclusivo lógio (^)
            Console.WriteLine("\n\nLogical AND (&)" +
                "\nfalse ^ false: " + (false ^ false) +
                "\nfalse ^ false: " + (false ^ true) +
                "\nfalse ^ false: " + (true ^ false) +
                "\nfalse ^ false: " + (true ^ true));

            // testando o operador NÃO lógico (!)
            Console.WriteLine("\n\nLogical NOT (!)" +
                "\n!false: " + (!false) +
                "\n!true: " + (!true));



        }
    }
}
