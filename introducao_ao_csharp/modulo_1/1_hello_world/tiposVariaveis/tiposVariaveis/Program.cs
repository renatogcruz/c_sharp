using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; // declara uma variável inteira e armazena o valor 10
            int numero2 = 20;
            var soma = numero1 + numero2; // o var definite dinamicamente o tipo da variável
            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1; // copia o valor da variável 'numero1'
            copiaDeNumero1 = 11;            // será que o valor de 'numero1' foi alterado?
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado(); //cria um quadrado
            quadrado1.lado = 10;            // quadrado 1 terá valor de lado = 10
            var quadrado2 = quadrado1;      // será que a cópia foi completa ou apenas referencial?

            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);

        }

        class Quadrado // define uma classe chamada Quadrado
        {
            public int lado; // define um atributo inteiro chamado lado, na classe Quadrado
        }
    }
}
