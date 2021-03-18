using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_switchTeste
{
    // Fig. 5.10: SwitchTest.cs
    // COntando notas

    class Program
    {
        static void Main(string[] args)
        {
            char grade;       // uma nota
            int aCount = 0,   // número de notas A
                bCount = 0,   // número de notas B
                cCount = 0,   // número de notas C
                dCount = 0,   // número de notas D
                fCount = 0;   // número de notas F

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter a letter grade: ");
                grade = Char.Parse(Console.ReadLine());

                switch (grade)
                {
                    case 'A': // a nota é A maiúsculo
                    case 'a': // ou a minúsculo
                        ++aCount;
                        break;                   // não incliur a instrução break no final de cada case é um erro

                    case 'B': // a nota é B maiúsculo
                    case 'b': // ou b minúsculo
                        ++bCount;
                        break;

                    case 'C': // a nota é C maiúsculo
                    case 'c': // ou c minúsculo
                        ++cCount;
                        break;

                    case 'D': // a nota é D maiúsculo
                    case 'd': // ou d minúsculo
                        ++dCount;
                        break;

                    case 'F': // a nota é F maiúsculo
                    case 'f': // ou f minúsculo
                        ++fCount;
                        break;

                    default:  // processa todos os outros caracteres (fora dos case, gera mensagem de erro)
                    Console.WriteLine(
                        "Incorrect letter grade entered." +
                        "\nGrade not added to totals.");
                    break;

                                                
                } // fim de switch
            } // fim do for

            Console.WriteLine(
                "\nTotals for each letter grade are: \nA: {0}" +
                "\nB: {1} \nC: {2} \nD: {3} \nF: {4}", aCount, bCount, cCount, dCount, fCount);

        } // fim do método Main
    } // fim da classe 
}
