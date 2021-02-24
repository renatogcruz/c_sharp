using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_analysis
{
    // Fig. 4.11 Analysis.cs
    // Análise dos resultados do exame

    class Program
    {
        static void Main(string[] args)
        {
            int passes = 0,    // número de aprovados
                failures = 0,  // número de reprovados
                student = 1,   // contador de alunos
                result;        // resultado de um exame

            // processa 10 alunos; laço controlado por contador
            while ( student <= 10)
            {
                Console.Write( "Enter result (1=pass, 2=fail): " );
                result = Int32.Parse(Console.ReadLine());

                if (result == 1)
                    passes = passes + 1;

                else
                    failures = failures + 1;

                student = student + 1;
            }

            // fase de conclusão
            Console.WriteLine();
            Console.WriteLine( "Passed: " + passes );
            Console.WriteLine( "Failed: " + failures );

            if ( passes > 8 )
                Console.WriteLine( "Raise Tuition\n" );


        } // fim do método Main
    } // fim da classe Analysis
}
