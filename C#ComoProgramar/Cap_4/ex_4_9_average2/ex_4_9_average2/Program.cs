using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_9_average2
{
    // fig. 4.9: Average2.cs
    // Média da turma com repetição controlada por sentinela
    class Program
    {
        static void Main(string[] args)
        {
            int total,        // soma das notas
                gradeCounter, // número de notas fornecidas
                gradeValue;   // valor da nota

            double average;   // média de todas as notas

            // fase de inicialização
            total = 0;        // limpa total
            gradeCounter = 0; // prepara para o laço

            // fase de processamento
            // solicita entrada e converte para inteiro
            Console.Write( "Enter Integer Grade, -1 to Quit: " );
            gradeValue = Int32.Parse(Console.ReadLine());

            // repete o laço até que -1 seja fornecido pelo usuário
            while ( gradeValue != -1)
            {
                // soma gradeValue ao total
                total = total + gradeValue;

                // soma 1 a gradeCount
                gradeCounter = gradeCounter + 1;

                // solicita entrada e lê a nota do usuário
                // converte a nota de string para inteiro
                Console.Write( "Enter Integer grade, -1 to Quit: " );
                gradeValue = Int32.Parse(Console.ReadLine());

            } // fim do while

            // fase de conclusão
            if ( gradeCounter != 0)
            {
                average = (double)total / gradeCounter;

                // exibe a média das notas do teste
                Console.WriteLine( "\nClass average is {0}", average );
                    
            }
            else
            {
                Console.WriteLine( "No grades were entered." );
            }


        } // fim do método Main
    } // fim da classe Average2
}
