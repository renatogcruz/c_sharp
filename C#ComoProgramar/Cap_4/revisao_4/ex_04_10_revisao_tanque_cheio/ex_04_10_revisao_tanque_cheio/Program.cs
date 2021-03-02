using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04_10_revisao_tanque_cheio
{
    // 4.10 - receba como entrada os km rodados e o combustível gasto e imprima quilometragem/tanque
    class Program
    {
        static void Main(string[] args)
        {
            double km,            // quilômetros rodados
                   tanque,        // combustível gasto
                   quilometragem; // relação km/tanque


            //
            Console.Write( "Entre com a quilometragem rodada: " );
            km = double.Parse(Console.ReadLine());

            Console.Write("Entre com o combustível gasto: ");
            tanque = double.Parse(Console.ReadLine());

            // relação quilometragem para cada tanque cheio
            quilometragem = km / tanque;
            Console.WriteLine("A relação de quilometragem para o tanque é de " 
                + quilometragem 
                + " Km por litros");


        }
    }
}
