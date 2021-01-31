using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePessoa  // Pasta virtual Classe Pessoa
{
    public class Pessoa // Classe carro
    {
        // Atributos da pessoa
        public int Idade;
        public string Nome;

        // Comportamento da pessoa
        public string Andar()
        {
            return "A pessoa esta andando";
        }
        public string Comer()
        {
            return "A pessoa esta comendo";
        }
    }
}
