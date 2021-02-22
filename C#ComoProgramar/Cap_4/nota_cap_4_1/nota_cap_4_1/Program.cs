using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nota_cap_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaAluno;

            notaAluno = 40;

            // estrutura de seleção if
            if ( notaAluno >= 60)            
                Console.WriteLine("Aprovado.");
            
            // estrutura de seleção if/else
            if (notaAluno >= 60)            
                Console.WriteLine("Aprovado.");            
            else           
                Console.WriteLine("Reprovado");
            

            // if/else com expressão condicional (?)
            Console.WriteLine(  notaAluno >= 60 ? "Aprovado.": "Reprovado." );

            // multiplos elses
            if (notaAluno >= 90)            
                Console.WriteLine( "A" );
                      
            //
            if ( notaAluno >= 60 )
                Console.WriteLine( "Passou" );
            else
            {
                Console.WriteLine( "Reprovou" );
                Console.WriteLine( "Você terá de fazer esta matéria novamente." );
            }

            // 
            if ( notaAluno >= 90 )
                Console.WriteLine( "A" );
            else if ( notaAluno >= 80)
                Console.WriteLine( "B" );
            else if ( notaAluno >= 70 )
                Console.WriteLine( "C" );
            else if ( notaAluno >= 60 )
                Console.WriteLine( "D" );
            else
                Console.WriteLine( "E" );


        }   //
    }   //
}
