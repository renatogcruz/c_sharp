using System;

namespace s3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F'; // caracter em c# deve ser declaro com aspas simples
            char letra = '\u0041'; // pode inserir o código do unicode table (imprime a letra A)
            sbyte x = 100;
            byte n1 = 126; //byte não aceita números negativos
            int n2 = 1000;
            int min = int.MinValue; //declara o menor valor da classe int
            long n3 = 215415254L;
            string obj1 = "Renato";
            object obj2 = 4.5f; // object aceita tudo (genericos)

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(min);
            Console.WriteLine(n3);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
