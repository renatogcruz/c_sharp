using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_ELEICAO_SINDICAL
{
    
    // Programa eleição sindical (ex. 4.r - página 66)

    class Program
    {
        static void Main(string[] args)
        {
            string va, vb, vc, nl, bra;
            double a, b, c, n, br, t, pv, pa, pb, pc, pn, pbr;

            // Entrada
            Console.Write("Entre total de votos em A: ");
            va = Console.ReadLine();

            Console.Write("Entre total de votos em B: ");
            vb = Console.ReadLine();

            Console.Write("Entre total de votos em C: ");
            vc = Console.ReadLine();

            Console.Write("Entre total de votos em Nulos: ");
            nl = Console.ReadLine();

            Console.Write("Entre total de votos em Brancos: ");
            bra = Console.ReadLine();

            // converntendo strings em integer
            a = Convert.ToDouble(va);
            b = Convert.ToDouble(vb);
            c = Convert.ToDouble(vc);
            n = Convert.ToDouble(nl);
            br = Convert.ToDouble(bra);

            // Processamento
            t = a + b + c + n + br;
            pv = (a + b + c) * 100 / t;
            pa = a * 100 / t;
            pb = b * 100 / t;
            pc = c * 100 / t;
            pn = n * 100 / t;
            pbr = br * 100 / t;

            // Exibição
            Console.WriteLine("Total de votos = {0}", t);
            Console.WriteLine("Porcentagem votos válidos = {0}", pv);
            Console.WriteLine("Porcentagem votos A = {0}", pa);
            Console.WriteLine("Porcentagem votos B = {0}", pb);
            Console.WriteLine("Porcentagem votos C = {0}", pc);
            Console.WriteLine("Porcentagem votos Nulos = {0}", pn);
            Console.WriteLine("Porcentagem votos Brancos = {0}", br);
        }
    }
}
