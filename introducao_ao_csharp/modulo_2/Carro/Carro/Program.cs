using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Program // Sem modificador de acesso explicito -> internal por padrão
    {
        static void Main(string[] args) // void não retorna nada
        {
            Carros carro = new Carros(Cor.Verde, 4, "Variante"); // criando carro

            // Exibindo atributos do carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas");
                        
            Console.WriteLine(carro.Ligar()); // ligar o carro
            Console.WriteLine("O carro ligou? " + carro.Ligado); // verificando se o carro está realmente ligado
            Console.WriteLine(carro.Andar()); // andar com o carro
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("O carro ta ligado? " + carro.Ligado);

            carro.Cor = Cor.Branco; // Pintando o carro de branco
            Console.WriteLine("A nova cor do carro é " + carro.Cor);
            
        }
    }
}
