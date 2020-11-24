using System;
using System.Collections.Generic;
using System.Text;

namespace s40_produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
