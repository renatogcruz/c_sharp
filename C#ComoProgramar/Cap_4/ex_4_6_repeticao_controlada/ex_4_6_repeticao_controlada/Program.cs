using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_6_repeticao_controlada
{
    // fig. 4.7: Average1.cs
    // Média da turma com repetiçao controlada por contador
    class Program
    {
        static void Main(string[] args)
        {
            int total,            //
                gradeCounter,     //
                gradeValue,       //
                average;          //

            // fase de inicialização
            total = 0;
            gradeCounter = 1;

            // processamento
            while ( gradeCounter <= 10)
            {
                // solicita a entrada e lê a nota do usuário
                Console.WriteLine( "Enter integer grade: " );

                // lê a entrada e converte para inteiro
                gradeValue = Int32.Parse(Console.ReadLine());

                // soma gradeValue ao total
                total = total + gradeValue;

                // soma 1 a gradeCounter
                gradeCounter = gradeCounter + 1;
            }

            // fase de conclusão
            average = total / 10;

            // exibe a média das notas do exame
            Console.WriteLine( "\nClass average is {0}", average );

        }  // fim de Main
    }   // fim da classe Average1
}
