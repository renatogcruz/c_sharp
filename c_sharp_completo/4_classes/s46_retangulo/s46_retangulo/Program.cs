using System;

namespace s46_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + ret.Area().ToString("F2"));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2"));
        }
    }
}
