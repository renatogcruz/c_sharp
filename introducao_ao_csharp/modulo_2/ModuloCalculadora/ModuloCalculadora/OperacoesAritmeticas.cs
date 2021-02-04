using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{

    /// <summary>
    /// Classe com as operações matemáticas básicas de adição, subtração, multiplicação e divisão.
    /// </summary>
    public static class OperacoesAritmeticas // Uma classe estática: não pode ser instanciada, não pode herdar e nem ser herdada. Só pode conter membros estáticos
    {
        /// <summary>
        /// Operação básica de adição
        /// </summary>
        /// <param name="parcela1">
        /// A primeira parcela.
        /// </param>
        /// <param name="parcela2">
        /// A segunda parcela
        /// </param>
        /// <returns>
        /// A soma dos números informados
        /// </returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        /// <summary>
        /// Operação básica de subtração.
        /// </summary>
        /// <param name="minuando">
        /// O valor de minuando.
        /// </param>
        /// <param name="subtraendo">
        /// O valor do subtraendo.
        /// </param>
        /// <returns>
        /// Retorna o valor da subtração entre o minuando e o subtraendo
        /// </returns>
        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }

        /// <summary>
        /// Operação básica de multiplicação.
        /// </summary>
        /// <param name="multiplicando">
        /// O valor do multiplicando.
        /// </param>
        /// <param name="multiplicador">
        /// O valor do multiplicador.
        /// </param>
        /// <returns>
        /// Retorna o valor da multiplicação entre o multiplicando e o multiplicador.
        /// </returns>
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        /// <summary>
        /// Operação básica de divisão.
        /// </summary>
        /// <param name="dividendo">
        /// O valor do dividendo.
        /// </param>
        /// <param name="divisor">
        /// O valor do divisor.
        /// </param>
        /// <returns>
        /// Retorna o valor da divisão entre o dividendo e o divisor.
        /// </returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
