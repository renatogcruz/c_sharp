using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laços condicionais => execução mediante determinada condição/situação satisfeita
            int hora = 18;
            if(hora <= 15) // se a hora for maior ou igual a 15 será impressa a mensagem
                Console.WriteLine("Já são 15 horas ou mais");
            
            else if(hora <= 17)
                Console.WriteLine("A hora é igual a 13!");
            else // o else garante a execução do bloco de código seguinte a ele
            {
                Console.WriteLine("Já passou das 17 horas!");
            }

            // switch.. case
            switch (hora)
            {
                case 15: // O teste condicional aqui é exato (só vai executar se a hora for exatametne igual a 15)
                    Console.WriteLine("São 15 horas");
                    break;
                case 18: // O teste condicional aqui é exato (só vai executar se a hora for exatametne igual a 18)
                    Console.WriteLine("São 18 horas");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch (mes)
            {
                case PrimeiroSemestre.Abril:
                    break;
                default: // Será executado se nenhum dos outros fou satisfeito!
                    Console.WriteLine("O mês atual não é Abril");
                    break;
            }
        }

    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
