using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public abstract class Animal // Uma classe abstrada não pode ser instanciada (Animal a = new Animal())
    {
        public string Nome { get; }
        public int Idade { get; }
        public string SomEmitido { get;  }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
