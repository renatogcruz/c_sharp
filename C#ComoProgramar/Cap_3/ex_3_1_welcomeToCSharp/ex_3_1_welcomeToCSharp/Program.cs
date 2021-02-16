using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fig. 3.1: Welcome1.cs
// Um primeiro programa em C#

/* Também podemos comentar assim
 * de forma corrida.
 * Legal, não?! */

namespace ex_3_1_welcomeToCSharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to C# Programming!!");
            Console.WriteLine("Welcome\nto\nC#\nProggramming!!"); //Imprimindo múltiplas linhas 
        }
    }
}

/* As linhas 16 a 23 definem nossa primeira classe. Os programas C# consistem em partes chamadas
 * classes, que são grupamentos lógicos de membros (isto é, métodos) que simplificam a organização
 * do programa. Esses métodos realizam tarefas e retornam informações, quando as tarefas são concluídas.
 * 
 * A classe Console permite que os programas produzam informações na saída padrão do computador;
 * O método Console.WriteLine apresenta (imprime) uma linha de texto na janela do console.
 **/

