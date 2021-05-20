using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_DIVISAO
{
    // exercício S - página 143

    class Program
    {
        static void Main(string[] args)
        {
            string dividendo, divisor;
            int divid, divis;
            int quociente = 1;

            Console.Write("Entre com dividendo: ");
            dividendo = Console.ReadLine();

            Console.Write("Entre com divisor: ");
            divisor = Console.ReadLine();

            divid = Int32.Parse(dividendo);
            divis = Int32.Parse(divisor);

            while (divis < divid)
            {
                divid = divid - divis;
                quociente = quociente + 1;
            }
            Console.WriteLine("{0} / {1} = {2}", dividendo, divisor, quociente);
        }
    }
}
