using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_array
{
    class Program
    {
        // ponto de entrada principal do aplicativo
        static void Main(string[] args)
        {
            string output = "";

            int[] x;           // declara referência para um array
            x = new int[10];   // aloca o array dinamicamene e configura
                               // os valores padrão

            // a lista inicializadora especifica o número de elementos
            // e o valor de cada elemento
            int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            const int ARRAY_SIZE = 10; // constante nomeada
            int[] z;                   // referência para array int

            // aloca array d ARRAU_SIZE (isto é, 10) elementos
            z = new int[ARRAY_SIZE];

            // configura os valores no array
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = 2 + 2 * i;
            }

            output += "Subscript\tArray x\tArray y\tArray z\n";

            // mostra os valores de cada array na saída
            for(int i = 0; i < ARRAY_SIZE; i++)
            {
                output += i + "\t" + x[i] + "\t" + y[i] +
                    "\t" + z[i] + '\n';                
            }

            Console.WriteLine("Initializing an array of int values");
        } // fim de Main
    } // fim da classe InitArray
}
