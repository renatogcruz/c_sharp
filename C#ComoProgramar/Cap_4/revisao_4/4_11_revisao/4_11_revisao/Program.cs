using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_revisao
{
    // limite de crédito em uma conta
    class Program
    {
        static void Main(string[] args)
        {
            //
            int numero_conta,
                saldo_inicio,
                itens_cobrados,
                creditos_aplicados,
                limite_credito,
                novo_saldo;

            // entradas
            Console.WriteLine("Entre com o número da conta: ");
            numero_conta = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o saldo do início do mês: ");
            saldo_inicio = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os itens cobrados: ");
            itens_cobrados = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os créditos aplicados: ");
            creditos_aplicados = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o limite de crédito: ");
            limite_credito = Int32.Parse(Console.ReadLine());

            //novo saldo

            novo_saldo = saldo_inicio - creditos_aplicados + itens_cobrados;

            if (novo_saldo < limite_credito)
            {
                Console.WriteLine("Limite de crédito excedido");
            }


        }
    }
}
