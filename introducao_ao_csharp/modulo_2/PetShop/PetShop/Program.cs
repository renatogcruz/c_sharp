using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5); // var -> 
            var g = new Gato("Ana", 4);

            Animal a = new Gato("Felix", 3); // Polimorfismo -> o gato também é um animal

            ExibeAnimal(c); // recebe argumento do tipo cachorro
            ExibeAnimal(g); // recebe argumento do tipo gato
            ExibeAnimal(a); // recebe argumento do tipo animal
            
        }

        public static void ExibeAnimal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Nome: {animal.Idade}");
        }
    }
}
